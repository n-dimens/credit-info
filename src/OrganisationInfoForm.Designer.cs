namespace TestForm
{
    partial class OrganisationInfoForm
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
            this.lbInternalCodes = new System.Windows.Forms.ListBox();
            this.cbBanks = new System.Windows.Forms.ComboBox();
            this.btnAddInternalCode = new System.Windows.Forms.Button();
            this.btnLoadInfo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoadXmlInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInternalCodes
            // 
            this.lbInternalCodes.FormattingEnabled = true;
            this.lbInternalCodes.Location = new System.Drawing.Point(12, 25);
            this.lbInternalCodes.Name = "lbInternalCodes";
            this.lbInternalCodes.Size = new System.Drawing.Size(181, 95);
            this.lbInternalCodes.TabIndex = 0;
            // 
            // cbBanks
            // 
            this.cbBanks.FormattingEnabled = true;
            this.cbBanks.Location = new System.Drawing.Point(199, 61);
            this.cbBanks.Name = "cbBanks";
            this.cbBanks.Size = new System.Drawing.Size(258, 21);
            this.cbBanks.TabIndex = 1;
            // 
            // btnAddInternalCode
            // 
            this.btnAddInternalCode.Location = new System.Drawing.Point(199, 32);
            this.btnAddInternalCode.Name = "btnAddInternalCode";
            this.btnAddInternalCode.Size = new System.Drawing.Size(45, 23);
            this.btnAddInternalCode.TabIndex = 2;
            this.btnAddInternalCode.Text = "<<";
            this.btnAddInternalCode.UseVisualStyleBackColor = true;
            this.btnAddInternalCode.Click += new System.EventHandler(this.btnAddInternalCode_Click);
            // 
            // btnLoadInfo
            // 
            this.btnLoadInfo.Location = new System.Drawing.Point(13, 127);
            this.btnLoadInfo.Name = "btnLoadInfo";
            this.btnLoadInfo.Size = new System.Drawing.Size(75, 23);
            this.btnLoadInfo.TabIndex = 3;
            this.btnLoadInfo.Text = "Executed";
            this.btnLoadInfo.UseVisualStyleBackColor = true;
            this.btnLoadInfo.Click += new System.EventHandler(this.btnLoadInfo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 289);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnLoadXmlInfo
            // 
            this.btnLoadXmlInfo.Location = new System.Drawing.Point(118, 127);
            this.btnLoadXmlInfo.Name = "btnLoadXmlInfo";
            this.btnLoadXmlInfo.Size = new System.Drawing.Size(75, 23);
            this.btnLoadXmlInfo.TabIndex = 5;
            this.btnLoadXmlInfo.Text = "As XML";
            this.btnLoadXmlInfo.UseVisualStyleBackColor = true;
            this.btnLoadXmlInfo.Click += new System.EventHandler(this.btnLoadXmlInfo_Click);
            // 
            // OrganisationInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 474);
            this.Controls.Add(this.btnLoadXmlInfo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLoadInfo);
            this.Controls.Add(this.btnAddInternalCode);
            this.Controls.Add(this.cbBanks);
            this.Controls.Add(this.lbInternalCodes);
            this.Name = "OrganisationInfoForm";
            this.Text = "COInfoForm";
            this.Load += new System.EventHandler(this.OrganisationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbInternalCodes;
        private System.Windows.Forms.ComboBox cbBanks;
        private System.Windows.Forms.Button btnAddInternalCode;
        private System.Windows.Forms.Button btnLoadInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoadXmlInfo;
    }
}