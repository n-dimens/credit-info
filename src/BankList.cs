using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestForm
{
    public partial class BankList : Form
    {
        public CregitInfoWS.CreditOrgInfo ws { get; set; }
        public int regnumber { get; set; }
        public BankList()
        {
            InitializeComponent();
            regnumber = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BankName_Load(object sender, EventArgs e)
        {
            var ds = ws.EnumBIC();
            string shema = ds.GetXmlSchema();
            shema = shema.Replace("encoding=\"utf-16\"", "encoding=\"utf-8\"");
            System.IO.File.WriteAllText("EnumBIC.xsd", shema);
            dataGridView1.DataSource = ds.Tables[0];
            MainForm.MapGridViewTitle(dataGridView1);

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            regnumber = System.Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["RN"].Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
