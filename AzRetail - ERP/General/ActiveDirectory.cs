using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ERP.General
{
    public class ActiveDirectory
    {

        #region n1

        #region Variables

        private string _sDomain = "retail.local";
        private string _sDefaultOu = "OU=Test Users,OU=Test,DC=test,DC=com";
        private string _sDefaultRootOu = "DC=test,DC=com";
        private string _sServiceUser = @"ServiceUser";
        private string _sServicePassword = "ServicePassword";

        #endregion

        #region Validate Methods

        public bool ValidateCredentials(string sUserName, string sPassword)
        {
            PrincipalContext oPrincipalContext = GetPrincipalContext();
            return oPrincipalContext.ValidateCredentials(sUserName, sPassword);

        }

        public bool IsUserExpired(string sUserName)
        {
            UserPrincipal oUserPrincipal = GetUser(sUserName);
            if (oUserPrincipal.AccountExpirationDate != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsUserExisiting(string sUserName)
        {
            if (GetUser(sUserName) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsAccountLocked(string sUserName)
        {
            UserPrincipal oUserPrincipal = GetUser(sUserName);
            return oUserPrincipal.IsAccountLockedOut();
        }

        #endregion

        #region Search Methods

        public UserPrincipal GetUser(string sUserName)
        {
            PrincipalContext oPrincipalContext = GetPrincipalContext();

            UserPrincipal oUserPrincipal = UserPrincipal.FindByIdentity(oPrincipalContext, sUserName);
            return oUserPrincipal;
        }

        public GroupPrincipal GetGroup(string sGroupName)
        {
            PrincipalContext oPrincipalContext = GetPrincipalContext();

            GroupPrincipal oGroupPrincipal = GroupPrincipal.FindByIdentity(oPrincipalContext, sGroupName);
            return oGroupPrincipal;
        }

        #endregion

        #region User Account Methods

        public void SetUserPassword(string sUserName, string sNewPassword, out string sMessage)
        {
            try
            {
                UserPrincipal oUserPrincipal = GetUser(sUserName);
                oUserPrincipal.SetPassword(sNewPassword);
                sMessage = "";
            }
            catch (Exception ex)
            {
                sMessage = ex.Message;
            }

        }

        public void EnableUserAccount(string sUserName)
        {
            UserPrincipal oUserPrincipal = GetUser(sUserName);
            oUserPrincipal.Enabled = true;
            oUserPrincipal.Save();
        }

        public void DisableUserAccount(string sUserName)
        {
            UserPrincipal oUserPrincipal = GetUser(sUserName);
            oUserPrincipal.Enabled = false;
            oUserPrincipal.Save();
        }

        public void ExpireUserPassword(string sUserName)
        {
            UserPrincipal oUserPrincipal = GetUser(sUserName);
            oUserPrincipal.ExpirePasswordNow();
            oUserPrincipal.Save();

        }

        public void UnlockUserAccount(string sUserName)
        {
            UserPrincipal oUserPrincipal = GetUser(sUserName);
            oUserPrincipal.UnlockAccount();
            oUserPrincipal.Save();
        }

        public UserPrincipal CreateNewUser(string sOu, string sUserName, string sPassword, string sGivenName,
            string sSurname)
        {
            if (!IsUserExisiting(sUserName))
            {
                PrincipalContext oPrincipalContext = GetPrincipalContext(sOu);

                UserPrincipal oUserPrincipal = new UserPrincipal(oPrincipalContext, sUserName, sPassword, true
                    /*Enabled or not*/);

                //User Log on Name
                oUserPrincipal.UserPrincipalName = sUserName;
                oUserPrincipal.GivenName = sGivenName;
                oUserPrincipal.Surname = sSurname;
                oUserPrincipal.Save();

                return oUserPrincipal;
            }
            else
            {
                return GetUser(sUserName);
            }
        }

        public bool DeleteUser(string sUserName)
        {
            try
            {
                UserPrincipal oUserPrincipal = GetUser(sUserName);

                oUserPrincipal.Delete();
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Group Methods

        public GroupPrincipal CreateNewGroup(string sOu, string sGroupName, string sDescription, GroupScope oGroupScope,
            bool bSecurityGroup)
        {
            PrincipalContext oPrincipalContext = GetPrincipalContext(sOu);

            GroupPrincipal oGroupPrincipal = new GroupPrincipal(oPrincipalContext, sGroupName);
            oGroupPrincipal.Description = sDescription;
            oGroupPrincipal.GroupScope = oGroupScope;
            oGroupPrincipal.IsSecurityGroup = bSecurityGroup;
            oGroupPrincipal.Save();

            return oGroupPrincipal;
        }

        public bool AddUserToGroup(string sUserName, string sGroupName)
        {
            try
            {
                UserPrincipal oUserPrincipal = GetUser(sUserName);
                GroupPrincipal oGroupPrincipal = GetGroup(sGroupName);
                if (oUserPrincipal != null && oGroupPrincipal != null)
                {
                    if (!IsUserGroupMember(sUserName, sGroupName))
                    {
                        oGroupPrincipal.Members.Add(oUserPrincipal);
                        oGroupPrincipal.Save();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveUserFromGroup(string sUserName, string sGroupName)
        {
            try
            {
                UserPrincipal oUserPrincipal = GetUser(sUserName);
                GroupPrincipal oGroupPrincipal = GetGroup(sGroupName);
                if (oUserPrincipal != null && oGroupPrincipal != null)
                {
                    if (IsUserGroupMember(sUserName, sGroupName))
                    {
                        oGroupPrincipal.Members.Remove(oUserPrincipal);
                        oGroupPrincipal.Save();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool IsUserGroupMember(string sUserName, string sGroupName)
        {
            UserPrincipal oUserPrincipal = GetUser(sUserName);
            GroupPrincipal oGroupPrincipal = GetGroup(sGroupName);

            if (oUserPrincipal != null && oGroupPrincipal != null)
            {
                return oGroupPrincipal.Members.Contains(oUserPrincipal);
            }
            else
            {
                return false;
            }
        }

        public ArrayList GetUserGroups(string sUserName)
        {
            ArrayList myItems = new ArrayList();
            UserPrincipal oUserPrincipal = GetUser(sUserName);

            PrincipalSearchResult<Principal> oPrincipalSearchResult = oUserPrincipal.GetGroups();

            foreach (Principal oResult in oPrincipalSearchResult)
            {
                myItems.Add(oResult.Name);
            }
            return myItems;
        }

        public ArrayList GetUserAuthorizationGroups(string sUserName)
        {
            ArrayList myItems = new ArrayList();
            UserPrincipal oUserPrincipal = GetUser(sUserName);

            PrincipalSearchResult<Principal> oPrincipalSearchResult = oUserPrincipal.GetAuthorizationGroups();

            foreach (Principal oResult in oPrincipalSearchResult)
            {
                myItems.Add(oResult.Name);
            }
            return myItems;
        }

        #endregion

        #region Helper Methods

        public PrincipalContext GetPrincipalContext()
        {
            PrincipalContext oPrincipalContext = new PrincipalContext(ContextType.Domain, _sDomain, _sDefaultOu,
                ContextOptions.SimpleBind, _sServiceUser, _sServicePassword);
            return oPrincipalContext;
        }

        public PrincipalContext GetPrincipalContext(string sOu)
        {
            PrincipalContext oPrincipalContext = new PrincipalContext(ContextType.Domain, _sDomain, sOu,
                ContextOptions.SimpleBind, _sServiceUser, _sServicePassword);
            return oPrincipalContext;
        }

        #endregion

        #endregion

        #region n2
        public static bool IsAuthenticated(string srvr, string usr, string pwd)
        {
          bool authenticated = false;
            srvr = "LDAP://retail.local/DC=retail,DC=local";
            try
            {
                DirectoryEntry entry = new DirectoryEntry(srvr, usr, pwd);
                object nativeObject = entry.NativeObject;
                authenticated = true;
            }
            catch (DirectoryServicesCOMException cex)
            {
                //not authenticated; reason why is in cex
            }
            catch (Exception ex)
            {
                //not authenticated due to some other exception [this is optional]
            }

            return authenticated;
        }
        public class Users
        {
            public string UserName { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string DisplayName { get; set; }
            public string Email { get; set; }
            public bool AccountController { get; set; }
        }

        public static List<Users> GetAdUsers()
        {
            List<Users> lstAdUsers = new List<Users>();
            try
            {

                string DomainPath = "LDAP://retail.local/DC=retail,DC=local";
                DirectoryEntry searchRoot = new DirectoryEntry(DomainPath);
                DirectorySearcher search = new DirectorySearcher(searchRoot);
                search.Filter = "(&(objectClass=user)(objectCategory=person))";
                search.PropertiesToLoad.Add("samaccountname");
                search.PropertiesToLoad.Add("mail");
                search.PropertiesToLoad.Add("usergroup");
                search.PropertiesToLoad.Add("displayname");
                search.PropertiesToLoad.Add("description");
                search.PropertiesToLoad.Add("givenName");
                search.PropertiesToLoad.Add("sn");
                search.PropertiesToLoad.Add("userAccountControl");
                SearchResult result;
                SearchResultCollection resultCol = search.FindAll();
               
                for (int counter = 0; counter < resultCol.Count; counter++)
                {
                    string userNameEmailString = string.Empty;
                    result = resultCol[counter];
                    Users objSurveyUsers = new Users();
                    if (result.Properties.Contains("samaccountname")) //&&
                        //Result.Properties.Contains("mail") &&
                       // Result.Properties.Contains("displayname")&&
                       // Result.Properties.Contains("givenName") &&
                     //   Result.Properties.Contains("sn"))
                        {
                       // objSurveyUsers.Email = Result.Properties["mail"] !=null ? (string)Result.Properties["mail"][0] : null;
                        objSurveyUsers.UserName = result.Properties["samaccountname"] !=null ? (String) result.Properties["samaccountname"][0]:null;
                       // objSurveyUsers.DisplayName = Result.Properties["displayname"] !=null ? (String) Result.Properties["displayname"][0] : null;
                       // objSurveyUsers.FirstName = Result.Properties["givenName"] !=null ? (String)Result.Properties["givenName"][0] : null;
                        //objSurveyUsers.LastName = Result.Properties["sn"] !=null ? (String)Result.Properties["sn"][0] :null;
                        objSurveyUsers.AccountController = !((int)result.Properties["userAccountControl"][0]==514 ||(int)result.Properties["userAccountControl"][0]==66050) ;
                        lstAdUsers.Add(objSurveyUsers);

                        //objSurveyUsers.Email = Result.Properties["mail"][0] != null ? (string)Result.Properties["mail"][0] : null;
                        //objSurveyUsers.UserName = Result.Properties["samaccountname"][0] != null ? (String)Result.Properties["samaccountname"][0] : null;
                        //objSurveyUsers.DisplayName = (String)Result.Properties["displayname"][0];
                        //objSurveyUsers.FirstName = (String)Result.Properties["givenName"][0];
                        //objSurveyUsers.LastName = (String)Result.Properties["sn"][0];
                        //objSurveyUsers.AccountController = !((int)Result.Properties["userAccountControl"][0] == 514 || (int)Result.Properties["userAccountControl"][0] == 66050);
                        //lstAdUsers.Add(objSurveyUsers);

                    }
                }
               return lstAdUsers;
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Xəta!",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }




        public static List<object> GetAdUser()
        {
            List<object> lstAdUsers = new List<object>();
            try
            {

                string DomainPath = "LDAP://retail.local/DC=retail,DC=local";
                DirectoryEntry searchRoot = new DirectoryEntry(DomainPath);
                DirectorySearcher search = new DirectorySearcher(searchRoot);
                search.Filter = "(&(objectClass=user)(objectCategory=person))";
                search.PropertiesToLoad.Add("samaccountname");
                search.PropertiesToLoad.Add("mail");
                search.PropertiesToLoad.Add("usergroup");
                search.PropertiesToLoad.Add("displayname"); //first name
                SearchResult result;
                SearchResultCollection resultCol = search.FindAll();

                for (int counter = 0; counter < resultCol.Count; counter++)
                {
                    lstAdUsers.Add(resultCol);
                    string userNameEmailString = string.Empty;
                    result = resultCol[counter];
                    if (result.Properties.Contains("samaccountname") &&
                        result.Properties.Contains("mail") &&
                        result.Properties.Contains("displayname"))
                    {
                        Users objSurveyUsers = new Users();
                        objSurveyUsers.Email = (String)result.Properties["mail"][0] +
                                               "^" + (String)result.Properties["displayname"][0];
                        objSurveyUsers.UserName = (String)result.Properties["samaccountname"][0];
                        objSurveyUsers.DisplayName = (String)result.Properties["displayname"][0];
                        lstAdUsers.Add(objSurveyUsers);
                    }
                }
                return lstAdUsers;



            }
            catch (Exception ex)
            {

            }
            return null;
        }

        #endregion

     
  
    }

}