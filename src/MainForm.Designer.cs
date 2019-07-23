namespace TestForm
{
    partial class MainForm
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
            this.BankRegnum = new System.Windows.Forms.TextBox();
            this.DatesListBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FormsList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BankName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnShowBanks = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистроционный номер банка";
            // 
            // BankRegnum
            // 
            this.BankRegnum.Location = new System.Drawing.Point(211, 38);
            this.BankRegnum.Name = "BankRegnum";
            this.BankRegnum.Size = new System.Drawing.Size(100, 20);
            this.BankRegnum.TabIndex = 1;
            this.BankRegnum.Text = "2048";
            this.BankRegnum.TextChanged += new System.EventHandler(this.BankRegnum_TextChanged);
            // 
            // DatesListBox
            // 
            this.DatesListBox.FormattingEnabled = true;
            this.DatesListBox.Location = new System.Drawing.Point(211, 64);
            this.DatesListBox.Name = "DatesListBox";
            this.DatesListBox.Size = new System.Drawing.Size(121, 21);
            this.DatesListBox.TabIndex = 2;
            this.DatesListBox.SelectedIndexChanged += new System.EventHandler(this.DatesListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Список дат";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(487, 313);
            this.dataGridView1.TabIndex = 6;
            // 
            // FormsList
            // 
            this.FormsList.FormattingEnabled = true;
            this.FormsList.Items.AddRange(new object[] {
            "123",
            "134",
            "135"});
            this.FormsList.Location = new System.Drawing.Point(211, 13);
            this.FormsList.Name = "FormsList";
            this.FormsList.Size = new System.Drawing.Size(121, 21);
            this.FormsList.TabIndex = 7;
            this.FormsList.SelectedIndexChanged += new System.EventHandler(this.FormsList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Форма";
            // 
            // BankName
            // 
            this.BankName.AutoSize = true;
            this.BankName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BankName.Location = new System.Drawing.Point(19, 94);
            this.BankName.Name = "BankName";
            this.BankName.Size = new System.Drawing.Size(35, 13);
            this.BankName.TabIndex = 9;
            this.BankName.Text = "label4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "F102EX";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnShowBanks
            // 
            this.btnShowBanks.Location = new System.Drawing.Point(421, 68);
            this.btnShowBanks.Name = "btnShowBanks";
            this.btnShowBanks.Size = new System.Drawing.Size(75, 23);
            this.btnShowBanks.TabIndex = 13;
            this.btnShowBanks.Text = "BankEnums";
            this.btnShowBanks.UseVisualStyleBackColor = true;
            this.btnShowBanks.Click += new System.EventHandler(this.btnShowBanks_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 469);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnShowBanks);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BankName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FormsList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DatesListBox);
            this.Controls.Add(this.BankRegnum);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Информация по F 123, 134, 135 (пример)";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BankRegnum;
        private System.Windows.Forms.ComboBox DatesListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox FormsList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BankName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnShowBanks;
        private System.Windows.Forms.Label label4;
    }
}

