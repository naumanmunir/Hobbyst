namespace Hobbyst.UI
{
    partial class Hobbys
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
            this.btnCreateHobby = new System.Windows.Forms.Button();
            this.btnFindHobbyst = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateHobby
            // 
            this.btnCreateHobby.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateHobby.Location = new System.Drawing.Point(104, 93);
            this.btnCreateHobby.Name = "btnCreateHobby";
            this.btnCreateHobby.Size = new System.Drawing.Size(244, 93);
            this.btnCreateHobby.TabIndex = 0;
            this.btnCreateHobby.Text = "Create Hobby!";
            this.btnCreateHobby.UseVisualStyleBackColor = true;
            this.btnCreateHobby.Click += new System.EventHandler(this.btnCreateHobby_Click);
            // 
            // btnFindHobbyst
            // 
            this.btnFindHobbyst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFindHobbyst.Location = new System.Drawing.Point(104, 337);
            this.btnFindHobbyst.Name = "btnFindHobbyst";
            this.btnFindHobbyst.Size = new System.Drawing.Size(244, 93);
            this.btnFindHobbyst.TabIndex = 0;
            this.btnFindHobbyst.Text = "Find a Hobbyst";
            this.btnFindHobbyst.UseVisualStyleBackColor = true;
            this.btnFindHobbyst.Click += new System.EventHandler(this.btnFindHobbyst_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "List what your good at and create a hobby!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Looking to hire a Hobbyst? Find one below!";
            // 
            // Hobbys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 513);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindHobbyst);
            this.Controls.Add(this.btnCreateHobby);
            this.Name = "Hobbys";
            this.Text = "Hobbys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateHobby;
        private System.Windows.Forms.Button btnFindHobbyst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}