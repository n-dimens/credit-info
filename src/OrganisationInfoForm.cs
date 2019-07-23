using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace TestForm {
    public partial class OrganisationInfoForm : Form {
        public CregitInfoWS.CreditOrgInfo ws { get; set; }

        public OrganisationInfoForm() {
            InitializeComponent();
        }

        private void OrganisationForm_Load(object sender, EventArgs e) {
            var ds = ws.EnumBIC();

            string shema = ds.GetXmlSchema();
            System.IO.File.WriteAllText("EnumBIC.xsd", shema);

            var rows = ds.Tables[0].Rows;
            for (int i = 0; i < rows.Count; i++) {
                double ic = System.Convert.ToDouble(rows[i]["IntCode"]);
                string nm = rows[i]["NM"].ToString();
                ItemDDL idl = new ItemDDL() { Code = ic, Name = nm };
                cbBanks.Items.Add(idl);
            }
        }

        private void btnAddInternalCode_Click(object sender, EventArgs e) {
            if (cbBanks.SelectedItem != null) {
                lbInternalCodes.Items.Add(((ItemDDL)cbBanks.SelectedItem).Code);
            }
        }

        private void btnLoadInfo_Click(object sender, EventArgs e) {
            List<double> codes = new List<double>();
            foreach (var itm in lbInternalCodes.Items) {
                if (itm != null) {
                    codes.Add(System.Convert.ToDouble(itm));
                }
            }

            DataSet ret = ws.CreditInfoByIntCodeEx(codes.ToArray());
            if (ret != null) {
                string shema = ret.GetXmlSchema();
                System.IO.File.WriteAllText("CreditInfoByIntCodeEx.xsd", shema, Encoding.UTF8); ;
                dataGridView1.DataSource = ret.Tables[0];
            }

        }

        private void btnLoadXmlInfo_Click(object sender, EventArgs e) {
            List<double> codes = new List<double>();
            foreach (var itm in lbInternalCodes.Items) {
                if (itm != null) {
                    codes.Add(System.Convert.ToDouble(itm));
                }
            }

            var ret = ws.CreditInfoByIntCodeExXML(codes.ToArray());
            if (ret != null) {
                MessageBox.Show(ret.InnerXml);

            }
        }
    }
}
