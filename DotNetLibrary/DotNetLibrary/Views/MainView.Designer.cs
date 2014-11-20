namespace DotNetLibrary
{
    partial class MainView
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
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.removePlayerButton = new System.Windows.Forms.Button();
            this.playerList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.alienRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.spinnerImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addPlayerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.addPlayerButton.Enabled = false;
            this.addPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlayerButton.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addPlayerButton.Location = new System.Drawing.Point(1129, 217);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(302, 99);
            this.addPlayerButton.TabIndex = 4;
            this.addPlayerButton.Text = "Join";
            this.addPlayerButton.UseVisualStyleBackColor = false;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButtonClick);
            // 
            // removePlayerButton
            // 
            this.removePlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removePlayerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.removePlayerButton.Enabled = false;
            this.removePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePlayerButton.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removePlayerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removePlayerButton.Location = new System.Drawing.Point(1129, 322);
            this.removePlayerButton.Name = "removePlayerButton";
            this.removePlayerButton.Size = new System.Drawing.Size(302, 99);
            this.removePlayerButton.TabIndex = 5;
            this.removePlayerButton.Text = "Remove Player";
            this.removePlayerButton.UseVisualStyleBackColor = false;
            this.removePlayerButton.Click += new System.EventHandler(this.removePlayerButton_Click);
            // 
            // playerList
            // 
            this.playerList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.playerList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(206)))), ((int)(((byte)(56)))));
            this.playerList.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerList.FormattingEnabled = true;
            this.playerList.ItemHeight = 31;
            this.playerList.Location = new System.Drawing.Point(12, 217);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(412, 562);
            this.playerList.TabIndex = 4;
            this.playerList.SelectedIndexChanged += new System.EventHandler(this.playerList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1129, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 99);
            this.button1.TabIndex = 6;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Gadugi", 20.25F);
            this.nameLabel.Location = new System.Drawing.Point(489, 251);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(91, 31);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Gadugi", 20.25F);
            this.genderLabel.Location = new System.Drawing.Point(473, 313);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(107, 31);
            this.genderLabel.TabIndex = 8;
            this.genderLabel.Text = "Gender:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Gadugi", 20.25F);
            this.nameTextBox.Location = new System.Drawing.Point(586, 248);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(360, 43);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.addUserControlChanged);
            this.nameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTextBox_KeyDown);
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(8)))), ((int)(((byte)(136)))));
            this.startButton.Enabled = false;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startButton.Location = new System.Drawing.Point(1129, 687);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(302, 99);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // profilePicture
            // 
            this.profilePicture.Image = global::DotNetLibrary.Properties.Resources.defaultMale;
            this.profilePicture.Location = new System.Drawing.Point(586, 369);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(360, 360);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 10;
            this.profilePicture.TabStop = false;
            this.profilePicture.Click += new System.EventHandler(this.profilePicture_Click);
            // 
            // alienRadioButton
            // 
            this.alienRadioButton.Font = new System.Drawing.Font("Gadugi", 20.25F);
            this.alienRadioButton.Image = global::DotNetLibrary.Properties.Resources.alien;
            this.alienRadioButton.Location = new System.Drawing.Point(826, 293);
            this.alienRadioButton.Name = "alienRadioButton";
            this.alienRadioButton.Size = new System.Drawing.Size(120, 70);
            this.alienRadioButton.TabIndex = 9;
            this.alienRadioButton.UseVisualStyleBackColor = true;
            this.alienRadioButton.CheckedChanged += new System.EventHandler(this.addUserControlChanged);
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.Font = new System.Drawing.Font("Gadugi", 20.25F);
            this.femaleRadioButton.Image = global::DotNetLibrary.Properties.Resources.Female;
            this.femaleRadioButton.Location = new System.Drawing.Point(703, 293);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(120, 70);
            this.femaleRadioButton.TabIndex = 3;
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            this.femaleRadioButton.CheckedChanged += new System.EventHandler(this.addUserControlChanged);
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.Checked = true;
            this.maleRadioButton.Font = new System.Drawing.Font("Gadugi", 20.25F);
            this.maleRadioButton.Image = global::DotNetLibrary.Properties.Resources.Male;
            this.maleRadioButton.Location = new System.Drawing.Point(586, 293);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(120, 70);
            this.maleRadioButton.TabIndex = 2;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.UseVisualStyleBackColor = true;
            this.maleRadioButton.CheckedChanged += new System.EventHandler(this.addUserControlChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::DotNetLibrary.Properties.Resources.GameOfLife;
            this.pictureBox1.InitialImage = global::DotNetLibrary.Properties.Resources.GameOfLife;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1443, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // spinnerImage
            // 
            this.spinnerImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.spinnerImage.Location = new System.Drawing.Point(10, -295);
            this.spinnerImage.Name = "spinnerImage";
            this.spinnerImage.Size = new System.Drawing.Size(1800, 1886);
            this.spinnerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.spinnerImage.TabIndex = 5;
            this.spinnerImage.TabStop = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1443, 798);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.alienRadioButton);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.removePlayerButton);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.spinnerImage);
            this.Name = "MainView";
            this.Text = "Game of Life";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button removePlayerButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ListBox playerList;
        private System.Windows.Forms.PictureBox spinnerImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton alienRadioButton;
        private System.Windows.Forms.PictureBox profilePicture;
    }
}