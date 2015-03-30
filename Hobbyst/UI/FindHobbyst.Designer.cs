namespace Hobbyst.UI
{
    partial class FindHobbyst
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgsearch = new System.Windows.Forms.DataGridView();
            this.btnHire = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDistance = new System.Windows.Forms.ComboBox();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbZip = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgsearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // dgsearch
            // 
            this.dgsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgsearch.Location = new System.Drawing.Point(12, 182);
            this.dgsearch.Name = "dgsearch";
            this.dgsearch.RowTemplate.Height = 24;
            this.dgsearch.Size = new System.Drawing.Size(437, 237);
            this.dgsearch.TabIndex = 3;
            this.dgsearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnHire
            // 
            this.btnHire.Location = new System.Drawing.Point(155, 442);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(148, 52);
            this.btnHire.TabIndex = 4;
            this.btnHire.Text = "Hire!";
            this.btnHire.UseVisualStyleBackColor = true;
            this.btnHire.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price range:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Distance:";
            // 
            // cbDistance
            // 
            this.cbDistance.FormattingEnabled = true;
            this.cbDistance.Location = new System.Drawing.Point(207, 136);
            this.cbDistance.Name = "cbDistance";
            this.cbDistance.Size = new System.Drawing.Size(175, 24);
            this.cbDistance.TabIndex = 3;
            this.cbDistance.SelectedIndexChanged += new System.EventHandler(this.cbDistance_SelectedIndexChanged);
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(207, 31);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(175, 22);
            this.tbsearch.TabIndex = 0;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(207, 64);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(175, 22);
            this.tbPrice.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Zip Code";
            // 
            // tbZip
            // 
            this.tbZip.Location = new System.Drawing.Point(207, 100);
            this.tbZip.Name = "tbZip";
            this.tbZip.Size = new System.Drawing.Size(175, 22);
            this.tbZip.TabIndex = 2;
            // 
            // FindHobbyst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 513);
            this.Controls.Add(this.tbZip);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.cbDistance);
            this.Controls.Add(this.btnHire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgsearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FindHobbyst";
            this.Text = "FindHobbyst";
            this.Load += new System.EventHandler(this.FindHobbyst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgsearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgsearch;
        private System.Windows.Forms.Button btnHire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbDistance;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbZip;
    }


}