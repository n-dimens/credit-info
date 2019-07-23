using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using TestForm.CregitInfoWS;

namespace TestForm {
    public partial class OrganisationInfoForm : Form {
        private readonly CreditOrgInfo serviceClient;

        public OrganisationInfoForm(CreditOrgInfo serviceClient) {
            this.serviceClient = serviceClient;
            InitializeComponent();
        }

        private void OrganisationForm_Load(object sender, EventArgs e) {
            var banks = GetBanks();
            foreach (var bank in banks) {
                this.cbBanks.Items.Add(bank);
            }
        }

        private void btnAddInternalCode_Click(object sender, EventArgs e) {
            if (cbBanks.SelectedItem != null) {
                lbInternalCodes.Items.Add(((ItemDDL)cbBanks.SelectedItem).Code);
            }
        }

        private void btnLoadInfo_Click(object sender, EventArgs e) {
            var selectedCodes = GetSelectedInternalCodes();
            var info = GetBanksInfo(selectedCodes);
            if (info != null) {
                dataGridView1.DataSource = info;
                SetColumnsHeader(info);
            }
        }

        private void btnLoadXmlInfo_Click(object sender, EventArgs e) {
            var selectedCodes = GetSelectedInternalCodes().ToArray();
            var xmlInfo = this.serviceClient.CreditInfoByIntCodeExXML(selectedCodes);
            if (xmlInfo != null) {
                // todo: Открывать notepad
                MessageBox.Show(xmlInfo.InnerXml);
            }
        }

        private IReadOnlyCollection<double> GetSelectedInternalCodes() {
            var codes = new List<double>();
            foreach (var codeItem in lbInternalCodes.Items) {
                if (codeItem != null) {
                    codes.Add(Convert.ToDouble(codeItem));
                }
            }

            return codes.AsReadOnly();
        }

        private void SetColumnsHeader(DataTable table) {
            for (int i = 0; i < table.Columns.Count; i++) {
                this.dataGridView1.Columns[i].HeaderText = table.Columns[i].Caption;
            }
        }

        private IReadOnlyCollection<ItemDDL> GetBanks() {
            var result = new List<ItemDDL>();
            var ds = this.serviceClient.EnumBIC();
            var shema = ds.GetXmlSchema();
            File.WriteAllText("EnumBIC.xsd", shema);
            var rows = ds.Tables[0].Rows;
            for (int i = 0; i < rows.Count; i++) {
                var internalCode = Convert.ToDouble(rows[i]["IntCode"]);
                var name = rows[i]["NM"].ToString();
                result.Add(new ItemDDL(name, internalCode));
            }

            return result.AsReadOnly();
        }

        private DataTable GetBanksInfo(IEnumerable<double> internalCodes) {
            var info = this.serviceClient.CreditInfoByIntCodeEx(internalCodes.ToArray());
            if (info != null) {
                var shema = info.GetXmlSchema();
                File.WriteAllText("CreditInfoByIntCodeEx.xsd", shema, Encoding.UTF8);
                return info.Tables[0];
            }

            return null;
        }
    }
}
