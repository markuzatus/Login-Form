namespace Login_Form
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(100, 100);
            this.lbl_Name.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.lbl_Name.MinimumSize = new System.Drawing.Size(300, 70);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(300, 70);
            this.lbl_Name.TabIndex = 0;
            // 
            // lbl_Time
            // 
            this.lbl_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(150, 250);
            this.lbl_Time.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.lbl_Time.MinimumSize = new System.Drawing.Size(200, 70);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(200, 70);
            this.lbl_Time.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.lbl_Name);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Time;
    }
}