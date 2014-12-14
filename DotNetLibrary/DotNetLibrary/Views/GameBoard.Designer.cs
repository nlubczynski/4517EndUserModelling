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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this.spinLabel = new System.Windows.Forms.Label();
            this.controlBox = new System.Windows.Forms.GroupBox();
            this.moneyOutput = new System.Windows.Forms.Label();
            this.careerOutput = new System.Windows.Forms.Label();
            this.stockButton = new System.Windows.Forms.Button();
            this.houseButton = new System.Windows.Forms.Button();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.spinOutput = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCurrentTileType = new System.Windows.Forms.Label();
            this.lblCurrentTileName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNextTileOneType = new System.Windows.Forms.Label();
            this.lblNextTileOneName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNextTileTwoType = new System.Windows.Forms.Label();
            this.lblNextTileTwoName = new System.Windows.Forms.Label();
            this.drivingGif = new System.Windows.Forms.PictureBox();
            this.spinnerImage = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drivingGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // spinLabel
            // 
            this.spinLabel.AutoSize = true;
            this.spinLabel.Location = new System.Drawing.Point(8, 396);
            this.spinLabel.Name = "spinLabel";
            this.spinLabel.Size = new System.Drawing.Size(79, 31);
            this.spinLabel.TabIndex = 0;
            this.spinLabel.Text = "Spin: ";
            // 
            // controlBox
            // 
            this.controlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.controlBox.Controls.Add(this.spinLabel);
            this.controlBox.Controls.Add(this.moneyOutput);
            this.controlBox.Controls.Add(this.careerOutput);
            this.controlBox.Controls.Add(this.stockButton);
            this.controlBox.Controls.Add(this.houseButton);
            this.controlBox.Controls.Add(this.profilePicture);
            this.controlBox.Controls.Add(this.spinOutput);
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
            // moneyOutput
            // 
            this.moneyOutput.AutoSize = true;
            this.moneyOutput.Location = new System.Drawing.Point(8, 353);
            this.moneyOutput.Name = "moneyOutput";
            this.moneyOutput.Size = new System.Drawing.Size(131, 31);
            this.moneyOutput.TabIndex = 8;
            this.moneyOutput.Text = "<money>";
            // 
            // careerOutput
            // 
            this.careerOutput.AutoSize = true;
            this.careerOutput.Location = new System.Drawing.Point(8, 440);
            this.careerOutput.Name = "careerOutput";
            this.careerOutput.Size = new System.Drawing.Size(122, 31);
            this.careerOutput.TabIndex = 7;
            this.careerOutput.Text = "<career>";
            // 
            // stockButton
            // 
            this.stockButton.BackColor = System.Drawing.Color.Transparent;
            this.stockButton.Enabled = false;
            this.stockButton.FlatAppearance.BorderSize = 0;
            this.stockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(8)))), ((int)(((byte)(136)))));
            this.stockButton.Image = ((System.Drawing.Image)(resources.GetObject("stockButton.Image")));
            this.stockButton.Location = new System.Drawing.Point(128, 288);
            this.stockButton.Name = "stockButton";
            this.stockButton.Size = new System.Drawing.Size(120, 50);
            this.stockButton.TabIndex = 4;
            this.stockButton.UseVisualStyleBackColor = false;
            this.stockButton.Click += new System.EventHandler(this.stockButton_Click);
            // 
            // houseButton
            // 
            this.houseButton.BackColor = System.Drawing.Color.Transparent;
            this.houseButton.Enabled = false;
            this.houseButton.FlatAppearance.BorderSize = 0;
            this.houseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.houseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(8)))), ((int)(((byte)(136)))));
            this.houseButton.Image = ((System.Drawing.Image)(resources.GetObject("houseButton.Image")));
            this.houseButton.Location = new System.Drawing.Point(8, 288);
            this.houseButton.Name = "houseButton";
            this.houseButton.Size = new System.Drawing.Size(120, 50);
            this.houseButton.TabIndex = 3;
            this.houseButton.UseVisualStyleBackColor = false;
            // 
            // profilePicture
            // 
            this.profilePicture.Location = new System.Drawing.Point(8, 42);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(240, 240);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 2;
            this.profilePicture.TabStop = false;
            // 
            // spinOutput
            // 
            this.spinOutput.AutoSize = true;
            this.spinOutput.Location = new System.Drawing.Point(93, 396);
            this.spinOutput.Name = "spinOutput";
            this.spinOutput.Size = new System.Drawing.Size(99, 31);
            this.spinOutput.TabIndex = 1;
            this.spinOutput.Text = "<spin>";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.lblCurrentTileType);
            this.panel3.Controls.Add(this.lblCurrentTileName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel3.Location = new System.Drawing.Point(52, 396);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 237);
            this.panel3.TabIndex = 3;
            // 
            // lblCurrentTileType
            // 
            this.lblCurrentTileType.AutoSize = true;
            this.lblCurrentTileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTileType.Location = new System.Drawing.Point(14, 141);
            this.lblCurrentTileType.MaximumSize = new System.Drawing.Size(164, 200);
            this.lblCurrentTileType.Name = "lblCurrentTileType";
            this.lblCurrentTileType.Size = new System.Drawing.Size(89, 24);
            this.lblCurrentTileType.TabIndex = 2;
            this.lblCurrentTileType.Text = "Tile Type";
            // 
            // lblCurrentTileName
            // 
            this.lblCurrentTileName.AutoSize = true;
            this.lblCurrentTileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTileName.Location = new System.Drawing.Point(14, 77);
            this.lblCurrentTileName.MaximumSize = new System.Drawing.Size(164, 200);
            this.lblCurrentTileName.Name = "lblCurrentTileName";
            this.lblCurrentTileName.Size = new System.Drawing.Size(97, 24);
            this.lblCurrentTileName.TabIndex = 1;
            this.lblCurrentTileName.Text = "Tile Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Tile";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.lblNextTileOneType);
            this.panel4.Controls.Add(this.lblNextTileOneName);
            this.panel4.Location = new System.Drawing.Point(273, 416);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(166, 200);
            this.panel4.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 29);
            this.label8.TabIndex = 5;
            this.label8.Text = "Next Tile";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNextTileOneType
            // 
            this.lblNextTileOneType.AutoSize = true;
            this.lblNextTileOneType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextTileOneType.Location = new System.Drawing.Point(13, 111);
            this.lblNextTileOneType.MaximumSize = new System.Drawing.Size(140, 50);
            this.lblNextTileOneType.Name = "lblNextTileOneType";
            this.lblNextTileOneType.Size = new System.Drawing.Size(67, 18);
            this.lblNextTileOneType.TabIndex = 4;
            this.lblNextTileOneType.Text = "Tile Type";
            // 
            // lblNextTileOneName
            // 
            this.lblNextTileOneName.AutoSize = true;
            this.lblNextTileOneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextTileOneName.Location = new System.Drawing.Point(13, 63);
            this.lblNextTileOneName.MaximumSize = new System.Drawing.Size(140, 50);
            this.lblNextTileOneName.Name = "lblNextTileOneName";
            this.lblNextTileOneName.Size = new System.Drawing.Size(75, 18);
            this.lblNextTileOneName.TabIndex = 3;
            this.lblNextTileOneName.Text = "Tile Name";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.lblNextTileTwoType);
            this.panel5.Controls.Add(this.lblNextTileTwoName);
            this.panel5.Location = new System.Drawing.Point(470, 416);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(166, 200);
            this.panel5.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Next Tile";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNextTileTwoType
            // 
            this.lblNextTileTwoType.AutoSize = true;
            this.lblNextTileTwoType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextTileTwoType.Location = new System.Drawing.Point(13, 111);
            this.lblNextTileTwoType.MaximumSize = new System.Drawing.Size(140, 50);
            this.lblNextTileTwoType.Name = "lblNextTileTwoType";
            this.lblNextTileTwoType.Size = new System.Drawing.Size(67, 18);
            this.lblNextTileTwoType.TabIndex = 7;
            this.lblNextTileTwoType.Text = "Tile Type";
            // 
            // lblNextTileTwoName
            // 
            this.lblNextTileTwoName.AutoSize = true;
            this.lblNextTileTwoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextTileTwoName.Location = new System.Drawing.Point(13, 63);
            this.lblNextTileTwoName.MaximumSize = new System.Drawing.Size(140, 50);
            this.lblNextTileTwoName.Name = "lblNextTileTwoName";
            this.lblNextTileTwoName.Size = new System.Drawing.Size(75, 18);
            this.lblNextTileTwoName.TabIndex = 6;
            this.lblNextTileTwoName.Text = "Tile Name";
            // 
            // drivingGif
            // 
            this.drivingGif.Image = global::DotNetLibrary.Properties.Resources.alienGiphy;
            this.drivingGif.Location = new System.Drawing.Point(52, 26);
            this.drivingGif.Name = "drivingGif";
            this.drivingGif.Size = new System.Drawing.Size(732, 312);
            this.drivingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.drivingGif.TabIndex = 6;
            this.drivingGif.TabStop = false;
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
            this.Controls.Add(this.drivingGif);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.spinnerImage);
            this.Controls.Add(this.controlBox);
            this.Controls.Add(this.background);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "GameBoard";
            this.Text = "Game of Life";
            this.controlBox.ResumeLayout(false);
            this.controlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drivingGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox spinnerImage;
        private System.Windows.Forms.Label spinLabel;
        private System.Windows.Forms.GroupBox controlBox;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Label spinOutput;
        private System.Windows.Forms.Button houseButton;
        private System.Windows.Forms.Button stockButton;
        private System.Windows.Forms.Label careerOutput;
        private System.Windows.Forms.Label moneyOutput;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCurrentTileType;
        private System.Windows.Forms.Label lblCurrentTileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNextTileOneType;
        private System.Windows.Forms.Label lblNextTileOneName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNextTileTwoType;
        private System.Windows.Forms.Label lblNextTileTwoName;
        private System.Windows.Forms.PictureBox drivingGif;

    }
}