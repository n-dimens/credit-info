namespace TestForm
{
    partial class Form102ex
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
            this.button1 = new System.Windows.Forms.Button();
            this.RegCodesEDT = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.symbolEdt = new System.Windows.Forms.TextBox();
            this.dformEDT = new System.Windows.Forms.TextBox();
            this.dtoEDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FormsList = new System.Windows.Forms.ComboBox();
            this.BanksEnumerator = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GetXMLButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.FormIndicatorsEnumbutton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "получить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegCodesEDT
            // 
            this.RegCodesEDT.FormattingEnabled = true;
            this.RegCodesEDT.Items.AddRange(new object[] {
            "1",
            "1000",
            "23",
            "101"});
            this.RegCodesEDT.Location = new System.Drawing.Point(31, 18);
            this.RegCodesEDT.Name = "RegCodesEDT";
            this.RegCodesEDT.Size = new System.Drawing.Size(120, 95);
            this.RegCodesEDT.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(154, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Символ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "С:";
            // 
            // symbolEdt
            // 
            this.symbolEdt.Location = new System.Drawing.Point(106, 126);
            this.symbolEdt.Name = "symbolEdt";
            this.symbolEdt.Size = new System.Drawing.Size(100, 20);
            this.symbolEdt.TabIndex = 14;
            this.symbolEdt.Text = "10000";
            // 
            // dformEDT
            // 
            this.dformEDT.Location = new System.Drawing.Point(486, 90);
            this.dformEDT.Name = "dformEDT";
            this.dformEDT.Size = new System.Drawing.Size(100, 20);
            this.dformEDT.TabIndex = 15;
            this.dformEDT.Text = "01.01.2015";
            // 
            // dtoEDT
            // 
            this.dtoEDT.Location = new System.Drawing.Point(636, 87);
            this.dtoEDT.Name = "dtoEDT";
            this.dtoEDT.Size = new System.Drawing.Size(100, 20);
            this.dtoEDT.TabIndex = 16;
            this.dtoEDT.Text = "01.04.2015";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "по:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Форма";
            // 
            // FormsList
            // 
            this.FormsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormsList.FormattingEnabled = true;
            this.FormsList.Items.AddRange(new object[] {
            "101",
            "102"});
            this.FormsList.Location = new System.Drawing.Point(649, 18);
            this.FormsList.Name = "FormsList";
            this.FormsList.Size = new System.Drawing.Size(87, 21);
            this.FormsList.TabIndex = 18;
            this.FormsList.SelectedIndexChanged += new System.EventHandler(this.FormsList_SelectedIndexChanged);
            // 
            // BanksEnumerator
            // 
            this.BanksEnumerator.FormattingEnabled = true;
            this.BanksEnumerator.Location = new System.Drawing.Point(256, 21);
            this.BanksEnumerator.Name = "BanksEnumerator";
            this.BanksEnumerator.Size = new System.Drawing.Size(258, 21);
            this.BanksEnumerator.TabIndex = 20;
            this.BanksEnumerator.SelectedIndexChanged += new System.EventHandler(this.BanksEnumerator_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(971, 725);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FormIndicatorsEnumbutton);
            this.panel1.Controls.Add(this.GetXMLButton);
            this.panel1.Controls.Add(this.BanksEnumerator);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.RegCodesEDT);
            this.panel1.Controls.Add(this.FormsList);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.dtoEDT);
            this.panel1.Controls.Add(this.dformEDT);
            this.panel1.Controls.Add(this.symbolEdt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 159);
            this.panel1.TabIndex = 8;
            // 
            // GetXMLButton
            // 
            this.GetXMLButton.Enabled = false;
            this.GetXMLButton.Location = new System.Drawing.Point(649, 122);
            this.GetXMLButton.Name = "GetXMLButton";
            this.GetXMLButton.Size = new System.Drawing.Size(75, 23);
            this.GetXMLButton.TabIndex = 21;
            this.GetXMLButton.Text = "XML";
            this.GetXMLButton.UseVisualStyleBackColor = true;
            this.GetXMLButton.Click += new System.EventHandler(this.GetXMLButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(23, 173);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(925, 529);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(917, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Форма N101";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(911, 497);
            this.dataGridView1.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(917, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Код формы по ОКУД 0409101 ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(911, 497);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // FormIndicatorsEnumbutton
            // 
            this.FormIndicatorsEnumbutton.Location = new System.Drawing.Point(212, 126);
            this.FormIndicatorsEnumbutton.Name = "FormIndicatorsEnumbutton";
            this.FormIndicatorsEnumbutton.Size = new System.Drawing.Size(45, 23);
            this.FormIndicatorsEnumbutton.TabIndex = 22;
            this.FormIndicatorsEnumbutton.Text = "<";
            this.FormIndicatorsEnumbutton.UseVisualStyleBackColor = true;
            this.FormIndicatorsEnumbutton.Click += new System.EventHandler(this.FormIndicatorsEnumbutton_Click);
            // 
            // Form102ex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 725);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form102ex";
            this.Text = "Form102ex";
            this.Load += new System.EventHandler(this.Form102ex_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox RegCodesEDT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox symbolEdt;
        private System.Windows.Forms.TextBox dformEDT;
        private System.Windows.Forms.TextBox dtoEDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox FormsList;
        private System.Windows.Forms.ComboBox BanksEnumerator;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button GetXMLButton;
        private System.Windows.Forms.Button FormIndicatorsEnumbutton;
    }
}