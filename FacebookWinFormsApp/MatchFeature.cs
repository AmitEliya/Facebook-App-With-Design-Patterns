using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FacebookWrapper.ObjectModel.User;
using System.Windows.Forms;
using BasicFacebookFeatures.Factory;
using System.Text.RegularExpressions;
using BasicFacebookFeatures.singleton;


namespace BasicFacebookFeatures
{
    public class MatchFeature : IFacebookFeature
    {
        private User m_UserLogin;
        public User.eGender GenderPrefrence { get; set; }
        private int m_MinAgePrefrence;
        private int m_MaxAgePrefrence;
        private readonly int r_MinAgeLimit = 18;
        private readonly int r_MaxAgeLimit = 120;

        public int MinAgePreference
        {
            get
            {
                return m_MinAgePrefrence;
            }
            set
            {
                if (value >= r_MinAgeLimit && value <= r_MaxAgeLimit)
                {
                    m_MinAgePrefrence = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("AgePreferenceMin", "Age Preference Min need to be between 18 to 100");
                }
            }
        }

        public int MaxAgePreference
        {
            get
            {
                return m_MaxAgePrefrence;
            }
            set
            {
                if (value >= r_MinAgeLimit && value <= r_MaxAgeLimit)
                {
                    m_MaxAgePrefrence = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("AgePrefernceMax", "Age Preference Max need to be between 18 to 100");
                }
            }
        }

        public MatchFeature()
        {
            m_UserLogin = UserManager.Instance.LoggedInUser;
            m_MaxAgePrefrence = r_MaxAgeLimit;
            m_MinAgePrefrence = r_MinAgeLimit;
        }

        public void Execute(params object[] parameters)
        {
            FacebookObjectCollection<User> friends = m_UserLogin.Friends;
            List<User> potentialMatches = new List<User>(), sortedlist;
            var matchesListBox = parameters[0] as ListBox;

            foreach (User friend in friends)
            {
                if (checkAgePreference(friend) && checkGenderPreference(friend))
                {
                    potentialMatches.Add(friend);
                }
            }

            sortedlist = sortBySharedLikedPages(potentialMatches);
            if (sortedlist.Count > 0)
            {
                foreach (User userMatch in sortedlist)
                {
                    matchesListBox.Items.Add(userMatch);
                }
            }
            else
            {
                MessageBox.Show("Find Match didn't found any matches for you, maybe try diffrent preferences!",
                    "Find Match - no matches found", MessageBoxButtons.OK);
            }
        }

        private bool checkGenderPreference(User i_Friend)
        {
            bool inGenderPrefernce = false;

            if (i_Friend.Gender != null)
            {
                inGenderPrefernce = i_Friend.Gender.Equals(this.GenderPrefrence);
            }

            return inGenderPrefernce;
        }

        private bool checkAgePreference(User i_Friend)
        {
            bool inAgePreference = false;
            string friendBirthDateStr = i_Friend.Birthday;

            if (friendBirthDateStr != null)
            {
                DateTime friendBirthDate = DateTime.ParseExact(friendBirthDateStr, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                int friendAge = DateTime.Today.Year - friendBirthDate.Year;
                if (DateTime.Today < friendBirthDate.AddYears(friendAge))
                {
                    friendAge--;
                }

                inAgePreference = friendAge >= m_MinAgePrefrence && friendAge <= m_MaxAgePrefrence;
            }

            return inAgePreference;
        }

        private List<User> sortBySharedLikedPages(List<User> i_PotentialMatches)
        {
            List<User> sortedPotentialMatches = i_PotentialMatches.OrderByDescending(match => sharedLikedPagesCount(match)).ToList();

            return sortedPotentialMatches;
        }

        private int sharedLikedPagesCount(User i_Match)
        {
            int countSharePages = 0;

            foreach (Page matchLikePage in i_Match.LikedPages)
            {
                foreach (Page userLikePage in m_UserLogin.LikedPages)
                {
                    if (matchLikePage.Id == userLikePage.Id)
                    {
                        countSharePages++;
                        break;
                    }
                }
            }

            return countSharePages;
        }

        public void SetGenderFromForm(RadioButton i_FemaleRadioButton, RadioButton i_MaleRadioButton)
        {
            if (i_MaleRadioButton.Checked)
            {
                this.GenderPrefrence = eGender.male;
            }
            else
            {
                this.GenderPrefrence = eGender.female;
            }
        }
    }
}
