using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabMatchMaking = new System.Windows.Forms.TabControl();
            this.HomePageTab = new System.Windows.Forms.TabPage();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labalBirthday = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelUserDetails = new System.Windows.Forms.Label();
            this.listBoxPost = new System.Windows.Forms.ListBox();
            this.labelPosts = new System.Windows.Forms.Label();
            this.buttonPost = new System.Windows.Forms.Button();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.labelPostStatus = new System.Windows.Forms.Label();
            this.buttonLeftPhoto = new System.Windows.Forms.Button();
            this.buttonRightPhoto = new System.Windows.Forms.Button();
            this.pictureBoxPhotos = new System.Windows.Forms.PictureBox();
            this.labelPhotos = new System.Windows.Forms.Label();
            this.pictureBoxLikedPages = new System.Windows.Forms.PictureBox();
            this.bindingSourcePages = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxFriends = new System.Windows.Forms.PictureBox();
            this.bindingSourcefriends = new System.Windows.Forms.BindingSource(this.components);
            this.labelLikedPages = new System.Windows.Forms.Label();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.labelFriends = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.pageTabMatchMaker = new System.Windows.Forms.TabPage();
            this.labelMatchLocation = new System.Windows.Forms.Label();
            this.labelMatchBirthday = new System.Windows.Forms.Label();
            this.labelMatchFullName = new System.Windows.Forms.Label();
            this.pictureBoxMatch = new System.Windows.Forms.PictureBox();
            this.listBoxMatches = new System.Windows.Forms.ListBox();
            this.labelMatchesListInfo = new System.Windows.Forms.Label();
            this.labelMatchesList = new System.Windows.Forms.Label();
            this.buttonMatch = new System.Windows.Forms.Button();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.labelMaxAge = new System.Windows.Forms.Label();
            this.labelMinAge = new System.Windows.Forms.Label();
            this.labelAgePreference = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.labelGenderPreference = new System.Windows.Forms.Label();
            this.labelMatchMakerInfo = new System.Windows.Forms.Label();
            this.pictureBoxMatchMakerRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxMatchMakerLeft = new System.Windows.Forms.PictureBox();
            this.labelMatchMaker = new System.Windows.Forms.Label();
            this.tabPageGreatestOfTheYear = new System.Windows.Forms.TabPage();
            this.labelGretestPost = new System.Windows.Forms.Label();
            this.labelGreatestPicture = new System.Windows.Forms.Label();
            this.buttonFindGreatest = new System.Windows.Forms.Button();
            this.textBoxGreatestPost = new System.Windows.Forms.TextBox();
            this.pictureBoxGreatest = new System.Windows.Forms.PictureBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.numericUpDowmGreatetYear = new System.Windows.Forms.NumericUpDown();
            this.labelGreatestOfTheYearInfo = new System.Windows.Forms.Label();
            this.pictureBoxGreatestOfTheYearRight = new System.Windows.Forms.PictureBox();
            this.labelGreatestOfTheYear = new System.Windows.Forms.Label();
            this.pictureBoxGreatestOfTheYearLeft = new System.Windows.Forms.PictureBox();
            this.bindingSourcePost = new System.Windows.Forms.BindingSource(this.components);
            this.tabMatchMaking.SuspendLayout();
            this.HomePageTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcefriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.pageTabMatchMaker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatchMakerRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatchMakerLeft)).BeginInit();
            this.tabPageGreatestOfTheYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreatest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowmGreatetYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreatestOfTheYearRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreatestOfTheYearLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePost)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(18, 29);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 48);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(18, 85);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 50);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabMatchMaking
            // 
            this.tabMatchMaking.Controls.Add(this.HomePageTab);
            this.tabMatchMaking.Controls.Add(this.pageTabMatchMaker);
            this.tabMatchMaking.Controls.Add(this.tabPageGreatestOfTheYear);
            this.tabMatchMaking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMatchMaking.Location = new System.Drawing.Point(0, 0);
            this.tabMatchMaking.Name = "tabMatchMaking";
            this.tabMatchMaking.SelectedIndex = 0;
            this.tabMatchMaking.Size = new System.Drawing.Size(1582, 900);
            this.tabMatchMaking.TabIndex = 54;
            // 
            // HomePageTab
            // 
            this.HomePageTab.BackColor = System.Drawing.Color.LightBlue;
            this.HomePageTab.Controls.Add(this.labelEmail);
            this.HomePageTab.Controls.Add(this.labalBirthday);
            this.HomePageTab.Controls.Add(this.labelGender);
            this.HomePageTab.Controls.Add(this.labelFullName);
            this.HomePageTab.Controls.Add(this.labelUserDetails);
            this.HomePageTab.Controls.Add(this.listBoxPost);
            this.HomePageTab.Controls.Add(this.labelPosts);
            this.HomePageTab.Controls.Add(this.buttonPost);
            this.HomePageTab.Controls.Add(this.textBoxPost);
            this.HomePageTab.Controls.Add(this.labelPostStatus);
            this.HomePageTab.Controls.Add(this.buttonLeftPhoto);
            this.HomePageTab.Controls.Add(this.buttonRightPhoto);
            this.HomePageTab.Controls.Add(this.pictureBoxPhotos);
            this.HomePageTab.Controls.Add(this.labelPhotos);
            this.HomePageTab.Controls.Add(this.pictureBoxLikedPages);
            this.HomePageTab.Controls.Add(this.pictureBoxFriends);
            this.HomePageTab.Controls.Add(this.labelLikedPages);
            this.HomePageTab.Controls.Add(this.listBoxLikedPages);
            this.HomePageTab.Controls.Add(this.labelFriends);
            this.HomePageTab.Controls.Add(this.listBoxFriends);
            this.HomePageTab.Controls.Add(this.pictureBoxProfile);
            this.HomePageTab.Controls.Add(this.buttonLogout);
            this.HomePageTab.Controls.Add(this.buttonLogin);
            this.HomePageTab.Location = new System.Drawing.Point(8, 47);
            this.HomePageTab.Name = "HomePageTab";
            this.HomePageTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomePageTab.Size = new System.Drawing.Size(1566, 845);
            this.HomePageTab.TabIndex = 0;
            this.HomePageTab.Text = "Home";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(339, 323);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(102, 36);
            this.labelEmail.TabIndex = 88;
            this.labelEmail.Text = "Email:";
            // 
            // labalBirthday
            // 
            this.labalBirthday.AutoSize = true;
            this.labalBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labalBirthday.Location = new System.Drawing.Point(335, 270);
            this.labalBirthday.Name = "labalBirthday";
            this.labalBirthday.Size = new System.Drawing.Size(142, 36);
            this.labalBirthday.TabIndex = 87;
            this.labalBirthday.Text = "Birthday:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(335, 212);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(138, 36);
            this.labelGender.TabIndex = 86;
            this.labelGender.Text = "Gender: ";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.Location = new System.Drawing.Point(335, 155);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(162, 36);
            this.labelFullName.TabIndex = 85;
            this.labelFullName.Text = "Full name:";
            // 
            // labelUserDetails
            // 
            this.labelUserDetails.AutoSize = true;
            this.labelUserDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserDetails.Location = new System.Drawing.Point(461, 85);
            this.labelUserDetails.Name = "labelUserDetails";
            this.labelUserDetails.Size = new System.Drawing.Size(193, 36);
            this.labelUserDetails.TabIndex = 84;
            this.labelUserDetails.Text = "User details:";
            // 
            // bindingSourcePost
            // 
            this.bindingSourcePost.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // listBoxPost
            // 
            this.listBoxPost.DataSource = this.bindingSourcePost;
            this.listBoxPost.DisplayMember = "Message";
            this.listBoxPost.FormattingEnabled = true;
            this.listBoxPost.ItemHeight = 33;
            this.listBoxPost.Location = new System.Drawing.Point(931, 114);
            this.listBoxPost.Name = "listBoxPost";
            this.listBoxPost.Size = new System.Drawing.Size(573, 268);
            this.listBoxPost.TabIndex = 82;
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Location = new System.Drawing.Point(802, 114);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(90, 36);
            this.labelPosts.TabIndex = 81;
            this.labelPosts.Text = "Posts";
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(1392, 33);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(145, 40);
            this.buttonPost.TabIndex = 80;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.postButton_Click);
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(931, 36);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(434, 41);
            this.textBoxPost.TabIndex = 79;
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.Location = new System.Drawing.Point(747, 29);
            this.labelPostStatus.Name = "labelPostStatus";
            this.labelPostStatus.Size = new System.Drawing.Size(162, 36);
            this.labelPostStatus.TabIndex = 76;
            this.labelPostStatus.Text = "Post status";
            // 
            // buttonLeftPhoto
            // 
            this.buttonLeftPhoto.Location = new System.Drawing.Point(1051, 733);
            this.buttonLeftPhoto.Name = "buttonLeftPhoto";
            this.buttonLeftPhoto.Size = new System.Drawing.Size(118, 54);
            this.buttonLeftPhoto.TabIndex = 68;
            this.buttonLeftPhoto.Text = "<--";
            this.buttonLeftPhoto.UseVisualStyleBackColor = true;
            this.buttonLeftPhoto.Click += new System.EventHandler(this.leftPhotoButton_Click);
            // 
            // buttonRightPhoto
            // 
            this.buttonRightPhoto.Location = new System.Drawing.Point(1209, 733);
            this.buttonRightPhoto.Name = "buttonRightPhoto";
            this.buttonRightPhoto.Size = new System.Drawing.Size(118, 54);
            this.buttonRightPhoto.TabIndex = 67;
            this.buttonRightPhoto.Text = "-->";
            this.buttonRightPhoto.UseVisualStyleBackColor = true;
            this.buttonRightPhoto.Click += new System.EventHandler(this.rightPhotoButton_Click);
            // 
            // pictureBoxPhotos
            // 
            this.pictureBoxPhotos.Location = new System.Drawing.Point(1001, 464);
            this.pictureBoxPhotos.Name = "pictureBoxPhotos";
            this.pictureBoxPhotos.Size = new System.Drawing.Size(354, 254);
            this.pictureBoxPhotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhotos.TabIndex = 66;
            this.pictureBoxPhotos.TabStop = false;
            // 
            // labelPhotos
            // 
            this.labelPhotos.AutoSize = true;
            this.labelPhotos.Location = new System.Drawing.Point(1114, 405);
            this.labelPhotos.Name = "labelPhotos";
            this.labelPhotos.Size = new System.Drawing.Size(109, 36);
            this.labelPhotos.TabIndex = 65;
            this.labelPhotos.Text = "Photos";
            // 
            // pictureBoxLikedPages
            // 
            this.pictureBoxLikedPages.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.bindingSourcePages, "PictureNormalURL", true));
            this.pictureBoxLikedPages.Location = new System.Drawing.Point(796, 655);
            this.pictureBoxLikedPages.Name = "pictureBoxLikedPages";
            this.pictureBoxLikedPages.Size = new System.Drawing.Size(138, 102);
            this.pictureBoxLikedPages.TabIndex = 61;
            this.pictureBoxLikedPages.TabStop = false;
            // 
            // bindingSourcePages
            // 
            this.bindingSourcePages.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // pictureBoxFriends
            // 
            this.pictureBoxFriends.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.bindingSourcefriends, "PictureNormalURL", true));
            this.pictureBoxFriends.Location = new System.Drawing.Point(387, 653);
            this.pictureBoxFriends.Name = "pictureBoxFriends";
            this.pictureBoxFriends.Size = new System.Drawing.Size(138, 102);
            this.pictureBoxFriends.TabIndex = 60;
            this.pictureBoxFriends.TabStop = false;
            // 
            // bindingSourcefriends
            // 
            this.bindingSourcefriends.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // labelLikedPages
            // 
            this.labelLikedPages.AutoSize = true;
            this.labelLikedPages.Location = new System.Drawing.Point(669, 411);
            this.labelLikedPages.Name = "labelLikedPages";
            this.labelLikedPages.Size = new System.Drawing.Size(179, 36);
            this.labelLikedPages.TabIndex = 59;
            this.labelLikedPages.Text = "Liked Pages";
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.DataSource = this.bindingSourcePages;
            this.listBoxLikedPages.DisplayMember = "Name";
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 33;
            this.listBoxLikedPages.Location = new System.Drawing.Point(581, 464);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(356, 301);
            this.listBoxLikedPages.TabIndex = 58;
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Location = new System.Drawing.Point(326, 411);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(115, 36);
            this.labelFriends.TabIndex = 57;
            this.labelFriends.Text = "Friends";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.DataSource = this.bindingSourcefriends;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 33;
            this.listBoxFriends.Location = new System.Drawing.Point(187, 464);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(341, 301);
            this.listBoxFriends.TabIndex = 56;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(18, 155);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(287, 227);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // pageTabMatchMaker
            // 
            this.pageTabMatchMaker.BackColor = System.Drawing.Color.LightBlue;
            this.pageTabMatchMaker.Controls.Add(this.labelMatchLocation);
            this.pageTabMatchMaker.Controls.Add(this.labelMatchBirthday);
            this.pageTabMatchMaker.Controls.Add(this.labelMatchFullName);
            this.pageTabMatchMaker.Controls.Add(this.pictureBoxMatch);
            this.pageTabMatchMaker.Controls.Add(this.listBoxMatches);
            this.pageTabMatchMaker.Controls.Add(this.labelMatchesListInfo);
            this.pageTabMatchMaker.Controls.Add(this.labelMatchesList);
            this.pageTabMatchMaker.Controls.Add(this.buttonMatch);
            this.pageTabMatchMaker.Controls.Add(this.numericUpDownMax);
            this.pageTabMatchMaker.Controls.Add(this.numericUpDownMin);
            this.pageTabMatchMaker.Controls.Add(this.labelMaxAge);
            this.pageTabMatchMaker.Controls.Add(this.labelMinAge);
            this.pageTabMatchMaker.Controls.Add(this.labelAgePreference);
            this.pageTabMatchMaker.Controls.Add(this.radioButtonMale);
            this.pageTabMatchMaker.Controls.Add(this.radioButtonFemale);
            this.pageTabMatchMaker.Controls.Add(this.labelGenderPreference);
            this.pageTabMatchMaker.Controls.Add(this.labelMatchMakerInfo);
            this.pageTabMatchMaker.Controls.Add(this.pictureBoxMatchMakerRight);
            this.pageTabMatchMaker.Controls.Add(this.pictureBoxMatchMakerLeft);
            this.pageTabMatchMaker.Controls.Add(this.labelMatchMaker);
            this.pageTabMatchMaker.Location = new System.Drawing.Point(8, 47);
            this.pageTabMatchMaker.Name = "pageTabMatchMaker";
            this.pageTabMatchMaker.Padding = new System.Windows.Forms.Padding(3);
            this.pageTabMatchMaker.Size = new System.Drawing.Size(1566, 845);
            this.pageTabMatchMaker.TabIndex = 1;
            this.pageTabMatchMaker.Text = "Match Making";
            // 
            // labelMatchLocation
            // 
            this.labelMatchLocation.AutoSize = true;
            this.labelMatchLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchLocation.Location = new System.Drawing.Point(925, 760);
            this.labelMatchLocation.Name = "labelMatchLocation";
            this.labelMatchLocation.Size = new System.Drawing.Size(146, 36);
            this.labelMatchLocation.TabIndex = 91;
            this.labelMatchLocation.Text = "Location:";
            // 
            // labelMatchBirthday
            // 
            this.labelMatchBirthday.AutoSize = true;
            this.labelMatchBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchBirthday.Location = new System.Drawing.Point(925, 704);
            this.labelMatchBirthday.Name = "labelMatchBirthday";
            this.labelMatchBirthday.Size = new System.Drawing.Size(142, 36);
            this.labelMatchBirthday.TabIndex = 90;
            this.labelMatchBirthday.Text = "Birthday:";
            // 
            // labelMatchFullName
            // 
            this.labelMatchFullName.AutoSize = true;
            this.labelMatchFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchFullName.Location = new System.Drawing.Point(925, 650);
            this.labelMatchFullName.Name = "labelMatchFullName";
            this.labelMatchFullName.Size = new System.Drawing.Size(162, 36);
            this.labelMatchFullName.TabIndex = 88;
            this.labelMatchFullName.Text = "Full name:";
            // 
            // pictureBoxMatch
            // 
            this.pictureBoxMatch.Location = new System.Drawing.Point(712, 655);
            this.pictureBoxMatch.Name = "pictureBoxMatch";
            this.pictureBoxMatch.Size = new System.Drawing.Size(174, 169);
            this.pictureBoxMatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMatch.TabIndex = 17;
            this.pictureBoxMatch.TabStop = false;
            // 
            // listBoxMatches
            // 
            this.listBoxMatches.FormattingEnabled = true;
            this.listBoxMatches.ItemHeight = 33;
            this.listBoxMatches.Location = new System.Drawing.Point(74, 655);
            this.listBoxMatches.Name = "listBoxMatches";
            this.listBoxMatches.Size = new System.Drawing.Size(618, 169);
            this.listBoxMatches.TabIndex = 16;
            this.listBoxMatches.SelectedIndexChanged += new System.EventHandler(this.listBoxMatches_SelectedIndexChanged);
            // 
            // labelMatchesListInfo
            // 
            this.labelMatchesListInfo.AutoSize = true;
            this.labelMatchesListInfo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchesListInfo.Location = new System.Drawing.Point(83, 602);
            this.labelMatchesListInfo.Name = "labelMatchesListInfo";
            this.labelMatchesListInfo.Size = new System.Drawing.Size(705, 30);
            this.labelMatchesListInfo.TabIndex = 15;
            this.labelMatchesListInfo.Text = "(Sorted by the number of shared like pages in descending order)";
            // 
            // labelMatchesList
            // 
            this.labelMatchesList.AutoSize = true;
            this.labelMatchesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchesList.Location = new System.Drawing.Point(81, 550);
            this.labelMatchesList.Name = "labelMatchesList";
            this.labelMatchesList.Size = new System.Drawing.Size(236, 39);
            this.labelMatchesList.TabIndex = 14;
            this.labelMatchesList.Text = "Matches List:";
            // 
            // buttonMatch
            // 
            this.buttonMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMatch.ForeColor = System.Drawing.Color.Crimson;
            this.buttonMatch.Location = new System.Drawing.Point(587, 451);
            this.buttonMatch.Name = "buttonMatch";
            this.buttonMatch.Size = new System.Drawing.Size(394, 77);
            this.buttonMatch.TabIndex = 12;
            this.buttonMatch.Text = "Find me a match !";
            this.buttonMatch.UseVisualStyleBackColor = true;
            this.buttonMatch.Click += new System.EventHandler(this.matchButton_Click);
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Location = new System.Drawing.Point(1406, 379);
            this.numericUpDownMax.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDownMax.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(120, 41);
            this.numericUpDownMax.TabIndex = 11;
            this.numericUpDownMax.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Location = new System.Drawing.Point(1189, 379);
            this.numericUpDownMin.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDownMin.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(120, 41);
            this.numericUpDownMin.TabIndex = 10;
            this.numericUpDownMin.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // labelMaxAge
            // 
            this.labelMaxAge.AutoSize = true;
            this.labelMaxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxAge.Location = new System.Drawing.Point(1315, 383);
            this.labelMaxAge.Name = "labelMaxAge";
            this.labelMaxAge.Size = new System.Drawing.Size(85, 37);
            this.labelMaxAge.TabIndex = 9;
            this.labelMaxAge.Text = "Max:";
            // 
            // labelMinAge
            // 
            this.labelMinAge.AutoSize = true;
            this.labelMinAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinAge.Location = new System.Drawing.Point(1106, 383);
            this.labelMinAge.Name = "labelMinAge";
            this.labelMinAge.Size = new System.Drawing.Size(77, 37);
            this.labelMinAge.TabIndex = 8;
            this.labelMinAge.Text = "Min:";
            // 
            // labelAgePreference
            // 
            this.labelAgePreference.AutoSize = true;
            this.labelAgePreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgePreference.Location = new System.Drawing.Point(814, 383);
            this.labelAgePreference.Name = "labelAgePreference";
            this.labelAgePreference.Size = new System.Drawing.Size(282, 39);
            this.labelAgePreference.TabIndex = 7;
            this.labelAgePreference.Text = "Age Preference:";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(561, 384);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(110, 40);
            this.radioButtonMale.TabIndex = 6;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Checked = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(403, 384);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(142, 40);
            this.radioButtonFemale.TabIndex = 5;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // labelGenderPreference
            // 
            this.labelGenderPreference.AutoSize = true;
            this.labelGenderPreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenderPreference.Location = new System.Drawing.Point(49, 385);
            this.labelGenderPreference.Name = "labelGenderPreference";
            this.labelGenderPreference.Size = new System.Drawing.Size(359, 39);
            this.labelGenderPreference.TabIndex = 4;
            this.labelGenderPreference.Text = "Gender Preference : ";
            // 
            // labelMatchMakerInfo
            // 
            this.labelMatchMakerInfo.AutoSize = true;
            this.labelMatchMakerInfo.Location = new System.Drawing.Point(82, 302);
            this.labelMatchMakerInfo.Name = "labelMatchMakerInfo";
            this.labelMatchMakerInfo.Size = new System.Drawing.Size(1350, 36);
            this.labelMatchMakerInfo.TabIndex = 3;
            this.labelMatchMakerInfo.Text = "Lets try find out your best next dates from your friend list,based on preferences" +
    " and common hobbies!";
            // 
            // pictureBoxMatchMakerRight
            // 
            this.pictureBoxMatchMakerRight.Image = global::BasicFacebookFeatures.Properties.Resources.MatchMaker;
            this.pictureBoxMatchMakerRight.Location = new System.Drawing.Point(1113, 46);
            this.pictureBoxMatchMakerRight.Name = "pictureBoxMatchMakerRight";
            this.pictureBoxMatchMakerRight.Size = new System.Drawing.Size(265, 214);
            this.pictureBoxMatchMakerRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMatchMakerRight.TabIndex = 2;
            this.pictureBoxMatchMakerRight.TabStop = false;
            // 
            // pictureBoxMatchMakerLeft
            // 
            this.pictureBoxMatchMakerLeft.Image = global::BasicFacebookFeatures.Properties.Resources.MatchMaker;
            this.pictureBoxMatchMakerLeft.Location = new System.Drawing.Point(135, 46);
            this.pictureBoxMatchMakerLeft.Name = "pictureBoxMatchMakerLeft";
            this.pictureBoxMatchMakerLeft.Size = new System.Drawing.Size(265, 214);
            this.pictureBoxMatchMakerLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMatchMakerLeft.TabIndex = 1;
            this.pictureBoxMatchMakerLeft.TabStop = false;
            // 
            // labelMatchMaker
            // 
            this.labelMatchMaker.AutoSize = true;
            this.labelMatchMaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchMaker.ForeColor = System.Drawing.Color.Crimson;
            this.labelMatchMaker.Location = new System.Drawing.Point(598, 57);
            this.labelMatchMaker.Name = "labelMatchMaker";
            this.labelMatchMaker.Size = new System.Drawing.Size(349, 63);
            this.labelMatchMaker.TabIndex = 0;
            this.labelMatchMaker.Text = "Match Maker";
            // 
            // tabPageGreatestOfTheYear
            // 
            this.tabPageGreatestOfTheYear.BackColor = System.Drawing.Color.LightBlue;
            this.tabPageGreatestOfTheYear.Controls.Add(this.labelGretestPost);
            this.tabPageGreatestOfTheYear.Controls.Add(this.labelGreatestPicture);
            this.tabPageGreatestOfTheYear.Controls.Add(this.buttonFindGreatest);
            this.tabPageGreatestOfTheYear.Controls.Add(this.textBoxGreatestPost);
            this.tabPageGreatestOfTheYear.Controls.Add(this.pictureBoxGreatest);
            this.tabPageGreatestOfTheYear.Controls.Add(this.labelYear);
            this.tabPageGreatestOfTheYear.Controls.Add(this.numericUpDowmGreatetYear);
            this.tabPageGreatestOfTheYear.Controls.Add(this.labelGreatestOfTheYearInfo);
            this.tabPageGreatestOfTheYear.Controls.Add(this.pictureBoxGreatestOfTheYearRight);
            this.tabPageGreatestOfTheYear.Controls.Add(this.labelGreatestOfTheYear);
            this.tabPageGreatestOfTheYear.Controls.Add(this.pictureBoxGreatestOfTheYearLeft);
            this.tabPageGreatestOfTheYear.Location = new System.Drawing.Point(8, 47);
            this.tabPageGreatestOfTheYear.Name = "tabPageGreatestOfTheYear";
            this.tabPageGreatestOfTheYear.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGreatestOfTheYear.Size = new System.Drawing.Size(1566, 845);
            this.tabPageGreatestOfTheYear.TabIndex = 2;
            this.tabPageGreatestOfTheYear.Text = "Greatest Of The Year";
            // 
            // labelGretestPost
            // 
            this.labelGretestPost.AutoSize = true;
            this.labelGretestPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGretestPost.Location = new System.Drawing.Point(1160, 488);
            this.labelGretestPost.Name = "labelGretestPost";
            this.labelGretestPost.Size = new System.Drawing.Size(217, 36);
            this.labelGretestPost.TabIndex = 10;
            this.labelGretestPost.Text = "Greatest Post:";
            // 
            // labelGreatestPicture
            // 
            this.labelGreatestPicture.AutoSize = true;
            this.labelGreatestPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreatestPicture.Location = new System.Drawing.Point(144, 468);
            this.labelGreatestPicture.Name = "labelGreatestPicture";
            this.labelGreatestPicture.Size = new System.Drawing.Size(253, 36);
            this.labelGreatestPicture.TabIndex = 9;
            this.labelGreatestPicture.Text = "Greatest Picture:";
            // 
            // buttonFindGreatest
            // 
            this.buttonFindGreatest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindGreatest.ForeColor = System.Drawing.Color.Coral;
            this.buttonFindGreatest.Location = new System.Drawing.Point(625, 438);
            this.buttonFindGreatest.Name = "buttonFindGreatest";
            this.buttonFindGreatest.Size = new System.Drawing.Size(294, 66);
            this.buttonFindGreatest.TabIndex = 8;
            this.buttonFindGreatest.Text = "Find Greatest";
            this.buttonFindGreatest.UseVisualStyleBackColor = true;
            this.buttonFindGreatest.Click += new System.EventHandler(this.greatestOfTheYearButton_Click);
            // 
            // textBoxGreatestPost
            // 
            this.textBoxGreatestPost.Location = new System.Drawing.Point(1094, 578);
            this.textBoxGreatestPost.Name = "textBoxGreatestPost";
            this.textBoxGreatestPost.ReadOnly = true;
            this.textBoxGreatestPost.Size = new System.Drawing.Size(440, 41);
            this.textBoxGreatestPost.TabIndex = 7;
            // 
            // pictureBoxGreatest
            // 
            this.pictureBoxGreatest.Location = new System.Drawing.Point(92, 524);
            this.pictureBoxGreatest.Name = "pictureBoxGreatest";
            this.pictureBoxGreatest.Size = new System.Drawing.Size(351, 287);
            this.pictureBoxGreatest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGreatest.TabIndex = 6;
            this.pictureBoxGreatest.TabStop = false;
            // 
            // labelYear
            // 
            this.labelYear.AutoEllipsis = true;
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.ForeColor = System.Drawing.Color.Coral;
            this.labelYear.Location = new System.Drawing.Point(492, 369);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(265, 39);
            this.labelYear.TabIndex = 5;
            this.labelYear.Text = "Choose a year:";
            // 
            // numericUpDowmGreatetYear
            // 
            this.numericUpDowmGreatetYear.Location = new System.Drawing.Point(765, 372);
            this.numericUpDowmGreatetYear.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.numericUpDowmGreatetYear.Minimum = new decimal(new int[] {
            2004,
            0,
            0,
            0});
            this.numericUpDowmGreatetYear.Name = "numericUpDowmGreatetYear";
            this.numericUpDowmGreatetYear.Size = new System.Drawing.Size(154, 41);
            this.numericUpDowmGreatetYear.TabIndex = 4;
            this.numericUpDowmGreatetYear.Value = new decimal(new int[] {
            2004,
            0,
            0,
            0});
            // 
            // labelGreatestOfTheYearInfo
            // 
            this.labelGreatestOfTheYearInfo.AutoSize = true;
            this.labelGreatestOfTheYearInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreatestOfTheYearInfo.Location = new System.Drawing.Point(370, 286);
            this.labelGreatestOfTheYearInfo.Name = "labelGreatestOfTheYearInfo";
            this.labelGreatestOfTheYearInfo.Size = new System.Drawing.Size(882, 37);
            this.labelGreatestOfTheYearInfo.TabIndex = 3;
            this.labelGreatestOfTheYearInfo.Text = "Choose a year to see witch photo and post got the most likes";
            // 
            // pictureBoxGreatestOfTheYearRight
            // 
            this.pictureBoxGreatestOfTheYearRight.Image = global::BasicFacebookFeatures.Properties.Resources.GreastOfTheYear;
            this.pictureBoxGreatestOfTheYearRight.Location = new System.Drawing.Point(1117, 54);
            this.pictureBoxGreatestOfTheYearRight.Name = "pictureBoxGreatestOfTheYearRight";
            this.pictureBoxGreatestOfTheYearRight.Size = new System.Drawing.Size(280, 212);
            this.pictureBoxGreatestOfTheYearRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGreatestOfTheYearRight.TabIndex = 2;
            this.pictureBoxGreatestOfTheYearRight.TabStop = false;
            // 
            // labelGreatestOfTheYear
            // 
            this.labelGreatestOfTheYear.AutoSize = true;
            this.labelGreatestOfTheYear.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreatestOfTheYear.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelGreatestOfTheYear.Location = new System.Drawing.Point(461, 126);
            this.labelGreatestOfTheYear.Name = "labelGreatestOfTheYear";
            this.labelGreatestOfTheYear.Size = new System.Drawing.Size(592, 72);
            this.labelGreatestOfTheYear.TabIndex = 1;
            this.labelGreatestOfTheYear.Text = "Greatest Of The Year";
            // 
            // pictureBoxGreatestOfTheYearLeft
            // 
            this.pictureBoxGreatestOfTheYearLeft.Image = global::BasicFacebookFeatures.Properties.Resources.GreastOfTheYear;
            this.pictureBoxGreatestOfTheYearLeft.Location = new System.Drawing.Point(117, 54);
            this.pictureBoxGreatestOfTheYearLeft.Name = "pictureBoxGreatestOfTheYearLeft";
            this.pictureBoxGreatestOfTheYearLeft.Size = new System.Drawing.Size(280, 212);
            this.pictureBoxGreatestOfTheYearLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGreatestOfTheYearLeft.TabIndex = 0;
            this.pictureBoxGreatestOfTheYearLeft.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 900);
            this.Controls.Add(this.tabMatchMaking);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            this.tabMatchMaking.ResumeLayout(false);
            this.HomePageTab.ResumeLayout(false);
            this.HomePageTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcefriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.pageTabMatchMaker.ResumeLayout(false);
            this.pageTabMatchMaker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatchMakerRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatchMakerLeft)).EndInit();
            this.tabPageGreatestOfTheYear.ResumeLayout(false);
            this.tabPageGreatestOfTheYear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreatest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowmGreatetYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreatestOfTheYearRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreatestOfTheYearLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.TabControl tabMatchMaking;
        private System.Windows.Forms.TabPage HomePageTab;
        private System.Windows.Forms.TabPage pageTabMatchMaker;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Label labelLikedPages;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.PictureBox pictureBoxLikedPages;
        private System.Windows.Forms.PictureBox pictureBoxFriends;
        private System.Windows.Forms.Label labelPhotos;
        private System.Windows.Forms.Button buttonLeftPhoto;
        private System.Windows.Forms.Button buttonRightPhoto;
        private System.Windows.Forms.PictureBox pictureBoxPhotos;
        private System.Windows.Forms.Label labelPostStatus;
        private System.Windows.Forms.ListBox listBoxPost;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Label labelUserDetails;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labalBirthday;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelMatchMaker;
        private System.Windows.Forms.PictureBox pictureBoxMatchMakerLeft;
        private PictureBox pictureBoxMatchMakerRight;
        private Label labelMatchMakerInfo;
        private Label labelGenderPreference;
        private Label labelAgePreference;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private NumericUpDown numericUpDownMax;
        private NumericUpDown numericUpDownMin;
        private Label labelMaxAge;
        private Label labelMinAge;
        private Label labelMatchesList;
        private Button buttonMatch;
        private Label labelMatchesListInfo;
        private ListBox listBoxMatches;
        private Label labelMatchLocation;
        private Label labelMatchBirthday;
        private Label labelMatchFullName;
        private PictureBox pictureBoxMatch;
        private TabPage tabPageGreatestOfTheYear;
        private PictureBox pictureBoxGreatestOfTheYearLeft;
        private PictureBox pictureBoxGreatestOfTheYearRight;
        private Label labelGreatestOfTheYear;
        private Label labelGreatestOfTheYearInfo;
        private Label labelYear;
        private NumericUpDown numericUpDowmGreatetYear;
        private PictureBox pictureBoxGreatest;
        private TextBox textBoxGreatestPost;
        private Button buttonFindGreatest;
        private Label labelGretestPost;
        private Label labelGreatestPicture;
        private ListBox listBoxFriends;
        private BindingSource bindingSourcefriends;
        private BindingSource bindingSourcePages;
        private BindingSource bindingSourcePost;
    }
}

