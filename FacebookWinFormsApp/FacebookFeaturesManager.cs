using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using static FacebookWrapper.ObjectModel.User;
using BasicFacebookFeatures.singleton;
using BasicFacebookFeatures.Factory;
using System.ComponentModel;


namespace BasicFacebookFeatures
{
    public class FacebookFeaturesManager
    {
        private PictureBox m_PictureBox;
        private List<Photo> m_UserPhotos;
        private int m_CurrentPhotoIndex;
        private ListBox m_FriendsListBox;
        private ListBox m_LikedPagesListBox;
        private MatchFeature m_MatchFeature;
        private GreatestOfTheYearFeature m_GreatestOfTheYearFeature;
        private User m_UserLoggedIn;
        private BindingSource m_FriendsBidingSource;
        private BindingSource m_PagesBidingSource;
        private BindingSource m_PostsBidingSource;

        public FacebookFeaturesManager(ListBox i_FriendsListBox, ListBox i_LikedPagesListBox, PictureBox i_PictureBox, BindingSource i_FriendsBidingSource, BindingSource i_PagesBidingSource, BindingSource i_PostsBidingSource)
        {
            m_FriendsListBox = i_FriendsListBox;
            m_LikedPagesListBox = i_LikedPagesListBox;
            m_PictureBox = i_PictureBox;
            m_UserPhotos = new List<Photo>();
            m_CurrentPhotoIndex = 0;
            m_UserLoggedIn = UserManager.Instance.LoggedInUser;
            m_FriendsBidingSource = i_FriendsBidingSource;
            m_PagesBidingSource = i_PagesBidingSource;
            m_PostsBidingSource = i_PostsBidingSource;
        }

        public List<Photo> UserPhoto
        {
            set
            {
                m_UserPhotos = value;
            }
        }
        
        public void DisplayLikedPages()
        {
            try
            {
                FacebookObjectCollection<Page> pages = m_UserLoggedIn.LikedPages;
                m_LikedPagesListBox.Invoke(new Action(() => m_PagesBidingSource.DataSource = pages));
                if (pages.Count == 0)
                {
                    MessageBox.Show("There are no facebook pages to show.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't fetch your facebook pages.");
            }
        }

        public void DisplayFriends()
        {
            try
            {
                FacebookObjectCollection<User> friends = m_UserLoggedIn.Friends;
                m_FriendsListBox.Invoke(new Action(() => m_FriendsBidingSource.DataSource = friends));
                if (friends.Count == 0)
                {
                    MessageBox.Show("There are no facebook friends to show.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't fetch your facebook friends.");
            }      
        }
        
        public void LoadUserPhotos()
        {
            m_UserPhotos.Clear();
            m_CurrentPhotoIndex = 0;
            if (m_UserLoggedIn != null)
            {
                try
                {
                    foreach (Album album in m_UserLoggedIn.Albums)
                    {
                        m_UserPhotos.AddRange(album.Photos);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading photos.");
                }

                if (m_UserPhotos.Count > 0)
                {
                    DisplayPhoto(m_CurrentPhotoIndex);
                }
            }
        }

        public void DisplayPhoto(int i_Index)
        {
            if (m_UserPhotos.Count > 0 && i_Index < m_UserPhotos.Count)
            {
                m_PictureBox.Invoke(new Action(() => m_PictureBox.ImageLocation = m_UserPhotos[i_Index].PictureNormalURL));
            }
            else 
            {
                MessageBox.Show("Error displaying image");
            }
        }

        public void ChangePicture(int i_AddToIndex)
        {
            if (m_UserPhotos.Count > 0)
            {
                m_CurrentPhotoIndex = (m_CurrentPhotoIndex + m_UserPhotos.Count + i_AddToIndex) % m_UserPhotos.Count;
                m_PictureBox.Invoke(new Action(() => DisplayPhoto(m_CurrentPhotoIndex)));
            }
        }

        public void DisplayAllPosts()
        {
            try
            {
                FacebookObjectCollection<Post> posts = m_UserLoggedIn.Posts;
                m_FriendsListBox.Invoke(new Action(() => m_PostsBidingSource.DataSource = posts));
                if (posts.Count == 0)
                {
                    MessageBox.Show("There are no facebook posts to show.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't fetch your facebook posts.");
            }
        }

        public void CreateGreatestOfTheYear()
        {
            m_GreatestOfTheYearFeature = (GreatestOfTheYearFeature)FeaturesFactory.CreateFeature(eFeatureType.GreatestOfTheYear);
        }

        public void FindGreatestOfTheYearByData(NumericUpDown i_TheGreatestyearNumeric, TextBox i_GreatestPostTextBox, PictureBox i_GreatestPictureBox)
        {
            try
            {
                if (m_UserLoggedIn == null)
                {
                    throw new ArgumentException("no user is login");
                }
                m_GreatestOfTheYearFeature.Year = (int)i_TheGreatestyearNumeric.Value;
                m_GreatestOfTheYearFeature.Execute(i_GreatestPictureBox, m_UserPhotos, i_GreatestPostTextBox, getPostsList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<Post> getPostsList()
        {
            List<Post> posts = new List<Post>();

            foreach (Post post in m_UserLoggedIn.Posts)
            {
                posts.Add(post);
            }
            
            return posts;
        }

        public void CreateMatcher()
        {
            m_MatchFeature = (MatchFeature)FeaturesFactory.CreateFeature(eFeatureType.MatchMaker);
        }

        public void FindMatchByData(RadioButton i_FemaleRadioButton, RadioButton i_MaleRadioButton, NumericUpDown i_MinPreference, NumericUpDown i_MaxPreference, ListBox i_MatchesListBox)
        {
            try
            {
                i_MatchesListBox.Items.Clear();
                if (m_UserLoggedIn == null)
                {
                    throw new ArgumentException("No user is login");
                }

                m_MatchFeature.SetGenderFromForm(i_FemaleRadioButton, i_MaleRadioButton);
                m_MatchFeature.MaxAgePreference = (int)i_MaxPreference.Value;
                m_MatchFeature.MinAgePreference = (int)i_MinPreference.Value;
                m_MatchFeature.Execute(i_MatchesListBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ResetUser()
        {
            m_UserLoggedIn = null;
            m_UserPhotos.Clear();
        }
    }
}
