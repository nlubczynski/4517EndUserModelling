namespace DotNetLibrary.Views
{
    partial class Choose
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
            this.op1 = new System.Windows.Forms.Button();
            this.op2 = new System.Windows.Forms.Button();
            this.op3 = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.thingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // op1
            // 
            this.op1.Location = new System.Drawing.Point(12, 104);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(337, 87);
            this.op1.TabIndex = 0;
            this.op1.Text = "button1";
            this.op1.UseVisualStyleBackColor = true;
            this.op1.Click += new System.EventHandler(this.jb1_Click);
            // 
            // op2
            // 
            this.op2.Location = new System.Drawing.Point(12, 197);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(337, 87);
            this.op2.TabIndex = 1;
            this.op2.Text = "button2";
            this.op2.UseVisualStyleBackColor = true;
            this.op2.Click += new System.EventHandler(this.jb2_Click);
            // 
            // op3
            // 
            this.op3.Location = new System.Drawing.Point(12, 290);
            this.op3.Name = "op3";
            this.op3.Size = new System.Drawing.Size(337, 87);
            this.op3.TabIndex = 2;
            this.op3.Text = "button3";
            this.op3.UseVisualStyleBackColor = true;
            this.op3.Click += new System.EventHandler(this.jb3_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Gadugi", 20.25F);
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(116, 31);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "<name>";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Gadugi", 20.25F);
            this.textLabel.Location = new System.Drawing.Point(12, 50);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(131, 31);
            this.textLabel.TabIndex = 4;
            this.textLabel.Text = "Choose a ";
            // 
            // thingLabel
            // 
            this.thingLabel.AutoSize = true;
            this.thingLabel.Font = new System.Drawing.Font("Gadugi", 20.25F);
            this.thingLabel.Location = new System.Drawing.Point(140, 50);
            this.thingLabel.Name = "thingLabel";
            this.thingLabel.Size = new System.Drawing.Size(112, 31);
            this.thingLabel.TabIndex = 5;
            this.thingLabel.Text = "<thing>";
            // 
            // Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 389);
            this.Controls.Add(this.thingLabel);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.op3);
            this.Controls.Add(this.op2);
            this.Controls.Add(this.op1);
            this.Name = "Choose";
            this.Text = "Choose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button op1;
        private System.Windows.Forms.Button op2;
        private System.Windows.Forms.Button op3;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label thingLabel;
    }
}