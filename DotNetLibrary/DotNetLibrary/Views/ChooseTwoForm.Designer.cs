namespace DotNetLibrary.Views
{
    partial class ChooseTwoForm
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
            this.btnFirstOption = new System.Windows.Forms.Button();
            this.btnSecondOption = new System.Windows.Forms.Button();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFirstOption
            // 
            this.btnFirstOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.btnFirstOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstOption.Location = new System.Drawing.Point(12, 115);
            this.btnFirstOption.Name = "btnFirstOption";
            this.btnFirstOption.Size = new System.Drawing.Size(200, 63);
            this.btnFirstOption.TabIndex = 0;
            this.btnFirstOption.Text = "<button text>";
            this.btnFirstOption.UseVisualStyleBackColor = false;
            this.btnFirstOption.Click += new System.EventHandler(this.btnFirstOption_Click);
            // 
            // btnSecondOption
            // 
            this.btnSecondOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.btnSecondOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecondOption.Location = new System.Drawing.Point(224, 115);
            this.btnSecondOption.Name = "btnSecondOption";
            this.btnSecondOption.Size = new System.Drawing.Size(200, 63);
            this.btnSecondOption.TabIndex = 1;
            this.btnSecondOption.Text = "<button text>";
            this.btnSecondOption.UseVisualStyleBackColor = false;
            this.btnSecondOption.Click += new System.EventHandler(this.btnSecondOption_Click);
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(27, 22);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(194, 31);
            this.lblPrompt.TabIndex = 2;
            this.lblPrompt.Text = "<label prompt>";
            // 
            // ChooseTwoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(436, 190);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.btnSecondOption);
            this.Controls.Add(this.btnFirstOption);
            this.Name = "ChooseTwoForm";
            this.Text = "<title>";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirstOption;
        private System.Windows.Forms.Button btnSecondOption;
        private System.Windows.Forms.Label lblPrompt;
    }
}