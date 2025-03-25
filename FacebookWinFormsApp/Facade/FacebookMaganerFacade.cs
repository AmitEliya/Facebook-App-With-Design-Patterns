using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Facade
{
    public class FacebookMaganerFacade
    {
        private FacebookFeaturesManager m_FBFeaturesManager;

        public FacebookMaganerFacade(ListBox i_FriendsListBox, ListBox i_LikedPagesListBox, PictureBox i_PictureBox, BindingSource i_FriendsBidingSource, BindingSource i_PagesBidingSource, BindingSource i_PostsBidingSource)
        {
            m_FBFeaturesManager = new FacebookFeaturesManager(i_FriendsListBox, i_LikedPagesListBox, i_PictureBox, i_FriendsBidingSource, i_PagesBidingSource, i_PostsBidingSource);
        }

        public void DisplayFriends() => m_FBFeaturesManager.DisplayFriends();

        public void DisplayLikedPages() => m_FBFeaturesManager.DisplayLikedPages();

        public void LoadUserPhotos() => m_FBFeaturesManager.LoadUserPhotos();

        public void DisplayAllPosts() => m_FBFeaturesManager.DisplayAllPosts();

        public void ChangePicture(int i_AddToIndex) => m_FBFeaturesManager.ChangePicture(i_AddToIndex);

        public void CreateGreatestOfTheYear() => m_FBFeaturesManager.CreateGreatestOfTheYear();

        public void FindGreatestOfTheYearByData(NumericUpDown i_TheGreatestyearNumeric, TextBox i_GreatestPostTextBox, PictureBox i_GreatestPictureBox) =>
            m_FBFeaturesManager.FindGreatestOfTheYearByData(i_TheGreatestyearNumeric, i_GreatestPostTextBox, i_GreatestPictureBox);

        public void CreateMatcher() => m_FBFeaturesManager.CreateMatcher();

        public void FindMatchByData(RadioButton i_FemaleRadioButton, RadioButton i_MaleRadioButton, NumericUpDown i_MinPreference, NumericUpDown i_MaxPreference, ListBox i_MatchesListBox) =>
            m_FBFeaturesManager.FindMatchByData(i_FemaleRadioButton, i_MaleRadioButton, i_MinPreference, i_MaxPreference, i_MatchesListBox);

        public void ResetUser() => m_FBFeaturesManager.ResetUser();
    }
}
