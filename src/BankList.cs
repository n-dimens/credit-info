using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestForm.CregitInfoWS;

namespace TestForm {
    public partial class BankList : Form {
        private readonly CreditOrgInfo serviceClient;

        public int RegistraionNumber { get; private set; }

        public BankList(CreditOrgInfo serviceClient) {
            this.serviceClient = serviceClient;
            InitializeComponent();
            RegistraionNumber = -1;
        }

        private void BankName_Load(object sender, EventArgs e) {
            var banksTable = LoadBanks();
            dgvBanks.DataSource = banksTable;
            SetColumnsHeader(banksTable);
        }

        private void dgvBanks_DoubleClick(object sender, EventArgs e) {
            if (dgvBanks.SelectedRows.Count == 0) {
                return;
            }

            RegistraionNumber = Convert.ToInt32(dgvBanks.SelectedRows[0].Cells["RN"].Value);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void SetColumnsHeader(DataTable banksTable) {
            for (int i = 0; i < banksTable.Columns.Count; i++) {
                this.dgvBanks.Columns[i].HeaderText = banksTable.Columns[i].Caption;
            }
        }

        private DataTable LoadBanks() {
            var ds = this.serviceClient.EnumBIC();
            var shema = ds.GetXmlSchema();
            shema = shema.Replace("encoding=\"utf-16\"", "encoding=\"utf-8\"");
            File.WriteAllText("EnumBIC.xsd", shema);
            return ds.Tables[0];
        }
    }
}
