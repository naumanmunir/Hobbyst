namespace Hobbyst.UI
{
    partial class HUB
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
            this.btnBrowseHobbys = new System.Windows.Forms.Button();
            this.btnCreateHobby = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowseHobbys
            // 
            this.btnBrowseHobbys.Location = new System.Drawing.Point(146, 486);
            this.btnBrowseHobbys.Name = "btnBrowseHobbys";
            this.btnBrowseHobbys.Size = new System.Drawing.Size(146, 55);
            this.btnBrowseHobbys.TabIndex = 0;
            this.btnBrowseHobbys.Text = "Search Hobbyst";
            this.btnBrowseHobbys.UseVisualStyleBackColor = true;
            this.btnBrowseHobbys.Click += new System.EventHandler(this.btnBrowseHobbys_Click);
            // 
            // btnCreateHobby
            // 
            this.btnCreateHobby.Location = new System.Drawing.Point(146, 315);
            this.btnCreateHobby.Name = "btnCreateHobby";
            this.btnCreateHobby.Size = new System.Drawing.Size(146, 55);
            this.btnCreateHobby.TabIndex = 0;
            this.btnCreateHobby.Text = "Create your hobby!";
            this.btnCreateHobby.UseVisualStyleBackColor = true;
            this.btnCreateHobby.Click += new System.EventHandler(this.btnCreateHobby_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 115);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(173, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 115);
            this.panel1.TabIndex = 2;
            // 
            // HUB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreateHobby);
            this.Controls.Add(this.btnBrowseHobbys);
            this.Name = "HUB";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseHobbys;
        private System.Windows.Forms.Button btnCreateHobby;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}