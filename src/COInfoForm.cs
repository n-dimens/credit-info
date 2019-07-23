using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace TestForm
{
        public partial class COInfoForm : Form
    {
        public CregitInfoWS.CreditOrgInfo ws { get; set; }
        public COInfoForm()
        {
            InitializeComponent();
        }

        private void COInfoForm_Load(object sender, EventArgs e)
        {
            var ds = ws.EnumBIC();

            string shema = ds.GetXmlSchema();
            System.IO.File.WriteAllText("EnumBIC.xsd", shema);

            var rows = ds.Tables[0].Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                double ic = System.Convert.ToDouble(rows[i]["IntCode"]);
                string nm = rows[i]["NM"].ToString();
                ItemDDL idl = new ItemDDL() { Code=ic, Name=nm };
                BanksEnumerator.Items.Add(idl);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (BanksEnumerator.SelectedItem != null)
            {
                listBox1.Items.Add(((ItemDDL)BanksEnumerator.SelectedItem).Code);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<double> codes=new List<double>();
            foreach (var itm in listBox1.Items)
            {
                if (itm != null)
                {
                    codes.Add(System.Convert.ToDouble(itm));
                }
            }
            DataSet ret=ws.CreditInfoByIntCodeEx(codes.ToArray());
            if (ret != null)
            {
                string shema=ret.GetXmlSchema();
                System.IO.File.WriteAllText("CreditInfoByIntCodeEx.xsd", shema , Encoding.UTF8);;
                dataGridView1.DataSource = ret.Tables[0];
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<double> codes = new List<double>();
            foreach (var itm in listBox1.Items)
            {
                if (itm != null)
                {
                    codes.Add(System.Convert.ToDouble(itm));
                }
            }
            var ret = ws.CreditInfoByIntCodeExXML(codes.ToArray());
            if (ret != null)
            {
                MessageBox.Show(ret.InnerXml);

            }
        }
    }

        public class ItemDDL
        {
            public double Code { get; set; }
            public string Name { get; set; }
            public override string ToString()
            {
                return Name +" :"+ Code.ToString() ;
            }
        }

}
