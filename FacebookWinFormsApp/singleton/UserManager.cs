using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.singleton
{
    public sealed class UserManager
    {
        private static UserManager s_Instance;
        private static readonly object sr_CreationLock = new object();
        private LoginResult m_LoginResult;
        public User LoggedInUser { get; private set; }
        private const string k_UserAppID = "1572779573353065";
        private readonly string[] r_UserPermissions = new string[]
            {
            "email",
            "public_profile",
            "user_gender",
            "user_birthday",
            "user_photos",
            "user_likes",
            "user_posts",
            "user_friends"
            };

        private UserManager()
        {
        }

        public static UserManager Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_CreationLock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new UserManager();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public void UserLogin()
        {
            m_LoginResult = FacebookService.Connect("EAAWWb0fHmmkBO24HyontHQrjmQ3WZCeAgpJorze4BG27QSYJqZArN4AH4yxnrJo9P8CweQTnjQIMobMZCHjaAIGWIoypfFwzLCG5Dv19sZAWmQA2o1LOgG3g5sCnFHXiLFRkiucDNq3hbLJWLeZBVySj8pXEEbgVFlzf3utbn8be8HkrVOb3Rl8fTSZALEZAJtgINNHMjgWkaRReNIAvi8ZD");
            //m_LoginResult = FacebookService.Login(k_UserAppID, r_UserPermissions);
            if (m_LoginResult == null || string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                throw new Exception(m_LoginResult.ErrorMessage);
            }

            LoggedInUser = m_LoginResult.LoggedInUser;
        }

        public void UserLogout()
        {
            FacebookService.LogoutWithUI();
            m_LoginResult = null;
            LoggedInUser = null;
        }
    }
}
