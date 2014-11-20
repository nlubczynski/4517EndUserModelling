namespace DotNetLibrary.Views
{
    partial class GameBoard
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
            this.background = new System.Windows.Forms.PictureBox();
            this.spinnerImage = new System.Windows.Forms.PictureBox();
            this.spinLabel = new System.Windows.Forms.Label();
            this.controlBox = new System.Windows.Forms.GroupBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.spinOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerImage)).BeginInit();
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(60)))));
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Margin = new System.Windows.Forms.Padding(1);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1013, 681);
            this.background.TabIndex = 1;
            this.background.TabStop = false;
            // 
            // spinnerImage
            // 
            this.spinnerImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.spinnerImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(60)))));
            this.spinnerImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spinnerImage.Location = new System.Drawing.Point(753, 396);
            this.spinnerImage.Name = "spinnerImage";
            this.spinnerImage.Size = new System.Drawing.Size(250, 285);
            this.spinnerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spinnerImage.TabIndex = 2;
            this.spinnerImage.TabStop = false;
            this.spinnerImage.Click += new System.EventHandler(this.spinnerImage_Click);
            // 
            // spinLabel
            // 
            this.spinLabel.AutoSize = true;
            this.spinLabel.Location = new System.Drawing.Point(6, 396);
            this.spinLabel.Name = "spinLabel";
            this.spinLabel.Size = new System.Drawing.Size(79, 31);
            this.spinLabel.TabIndex = 0;
            this.spinLabel.Text = "Spin: ";
            // 
            // controlBox
            // 
            this.controlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.controlBox.Controls.Add(this.profilePicture);
            this.controlBox.Controls.Add(this.spinOutput);
            this.controlBox.Controls.Add(this.spinLabel);
            this.controlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlBox.Font = new System.Drawing.Font("Gadugi", 20.25F);
            this.controlBox.ForeColor = System.Drawing.Color.White;
            this.controlBox.Location = new System.Drawing.Point(1009, 0);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(255, 681);
            this.controlBox.TabIndex = 0;
            this.controlBox.TabStop = false;
            this.controlBox.Text = "<UserName>";
            // 
            // profilePicture
            // 
            this.profilePicture.Location = new System.Drawing.Point(8, 42);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(240, 240);
            this.profilePicture.TabIndex = 2;
            this.profilePicture.TabStop = false;
            // 
            // spinOutput
            // 
            this.spinOutput.AutoSize = true;
            this.spinOutput.Location = new System.Drawing.Point(78, 396);
            this.spinOutput.Name = "spinOutput";
            this.spinOutput.Size = new System.Drawing.Size(0, 31);
            this.spinOutput.TabIndex = 1;
            // 
            // GameBoard
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.spinnerImage);
            this.Controls.Add(this.controlBox);
            this.Controls.Add(this.background);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "GameBoard";
            this.Text = "Game of Life";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerImage)).EndInit();
            this.controlBox.ResumeLayout(false);
            this.controlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox spinnerImage;
        private System.Windows.Forms.Label spinLabel;
        private System.Windows.Forms.GroupBox controlBox;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Label spinOutput;

    }
}