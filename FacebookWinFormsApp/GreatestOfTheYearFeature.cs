using BasicFacebookFeatures.Factory;
using CefSharp.ModelBinding;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace BasicFacebookFeatures
{
    public class GreatestOfTheYearFeature : IFacebookFeature
    {
        private int m_Year;
        private readonly int r_MinYear = 2004;
        private readonly int r_MaxYear = 2024;

        public GreatestOfTheYearFeature()
        {
            m_Year = r_MinYear;
        }

        public int Year
        {
            get
            {
                return m_Year;
            }
            set
            {
                if (value >= r_MinYear && value <= r_MaxYear)
                {
                    m_Year = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid Year!");
                }
            }
        }
        
        public void Execute(params object[] parameters)
        {
            Post greatestPost;
            Photo greatestPhoto;
            var greatestPicture = parameters[0] as PictureBox;
            var photosList = parameters[1] as List<Photo>;
            var greatestPostTextBox = parameters[2] as TextBox;
            var postsList = parameters[3] as List<Post>;

            greatestPostTextBox.Text = "";
            greatestPicture.Image = null;
            greatestPhoto = findTheGreatestPictureOfTheYear(photosList);
            greatestPost = findTheGreatestPostOfTheYear(postsList);
            if (greatestPhoto == null)
            {
                greatestPicture.Image = null;
                MessageBox.Show("There is no picture in this year");
            }
            else
            {
                greatestPicture.ImageLocation = greatestPhoto.PictureNormalURL;
            }

            if (greatestPost == null)
            {
                greatestPostTextBox.Text = "";
                MessageBox.Show("There is no post in this year");
            }
            else
            {
                if(greatestPost.Message != null)
                {
                    greatestPostTextBox.Text += greatestPost.Message;  
                }
            }
        }

        private Photo findTheGreatestPictureOfTheYear(List<Photo> i_PhotosList)
        {
            int maxCountComments = -1, countComments ;
            Photo result = null;

            if (i_PhotosList.Count > 0)
            {
                var photosInYear = i_PhotosList.Where(photo => DateTime.Parse(photo.CreatedTime.ToString()).Year == m_Year);

                foreach (Photo photo in photosInYear)
                {
                    countComments = photo.Comments.Count();
                    if (countComments > maxCountComments)
                    {
                        result = photo;
                        maxCountComments = countComments;
                    }
                }
            }

            return result;
        }

        private Post findTheGreatestPostOfTheYear(List<Post> i_PostsList)
        {
            int maxCountComments = -1, countComments;
            Post result = null;

            if (i_PostsList.Count > 0)
            {
                var postsInYear = i_PostsList.Where(Post => DateTime.Parse(Post.CreatedTime.ToString()).Year == m_Year);

                foreach (Post post in postsInYear)
                {
                    countComments = post.Comments.Count();
                    if (countComments > maxCountComments)
                    {
                        result = post;
                        maxCountComments = countComments;
                    }
                }
            }

            return result;
        }
    }
}
