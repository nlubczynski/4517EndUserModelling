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
            this.controlBox = new System.Windows.Forms.GroupBox();
            this.spinnerImage = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // controlBox
            // 
            this.controlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
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
            // spinnerImage
            // 
            this.spinnerImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.spinnerImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(60)))));
            this.spinnerImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spinnerImage.Location = new System.Drawing.Point(753, 419);
            this.spinnerImage.Name = "spinnerImage";
            this.spinnerImage.Size = new System.Drawing.Size(250, 250);
            this.spinnerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spinnerImage.TabIndex = 2;
            this.spinnerImage.TabStop = false;
            this.spinnerImage.Click += new System.EventHandler(this.spinnerImage_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.spinnerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox controlBox;
        private System.Windows.Forms.PictureBox spinnerImage;
        private System.Windows.Forms.PictureBox background;
    }
}