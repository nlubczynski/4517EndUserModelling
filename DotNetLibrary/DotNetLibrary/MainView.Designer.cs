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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.removePlayerButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.playerList = new System.Windows.Forms.ListBox();
            this.addPlayerTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::DotNetLibrary.Properties.Resources.GameOfLife;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(872, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addPlayerButton.Location = new System.Drawing.Point(436, 234);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(186, 36);
            this.addPlayerButton.TabIndex = 3;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButtonClick);
            // 
            // removePlayerButton
            // 
            this.removePlayerButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.removePlayerButton.Location = new System.Drawing.Point(436, 276);
            this.removePlayerButton.Name = "removePlayerButton";
            this.removePlayerButton.Size = new System.Drawing.Size(186, 36);
            this.removePlayerButton.TabIndex = 4;
            this.removePlayerButton.Text = "Remove Player";
            this.removePlayerButton.UseVisualStyleBackColor = true;
            this.removePlayerButton.Click += new System.EventHandler(this.removePlayerButton_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(663, 341);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(197, 66);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // playerList
            // 
            this.playerList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playerList.FormattingEnabled = true;
            this.playerList.Location = new System.Drawing.Point(216, 208);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(214, 199);
            this.playerList.TabIndex = 4;
            // 
            // addPlayerTextBox
            // 
            this.addPlayerTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addPlayerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayerTextBox.Location = new System.Drawing.Point(436, 208);
            this.addPlayerTextBox.Name = "addPlayerTextBox";
            this.addPlayerTextBox.Size = new System.Drawing.Size(186, 20);
            this.addPlayerTextBox.TabIndex = 2;
            this.addPlayerTextBox.Text = "Enter Name";
            this.addPlayerTextBox.Enter += new System.EventHandler(this.addPlayerTextBox_Enter);
            this.addPlayerTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addPlayerTextBox_KeyDown);
            this.addPlayerTextBox.Leave += new System.EventHandler(this.addPlayerTextBox_Leave);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(872, 419);
            this.Controls.Add(this.addPlayerTextBox);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.removePlayerButton);
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainView";
            this.Text = "Game of Life";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button removePlayerButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ListBox playerList;
        private System.Windows.Forms.TextBox addPlayerTextBox;
    }
}