using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestForm.CregitInfoWS;

namespace TestForm {
    public partial class IndicatorsForm : Form {
        private readonly CreditOrgInfo serviceClient;

        private readonly Forms form;

        public double SelectedCode { get; private set; }

        public IndicatorsForm(Forms form, CreditOrgInfo serviceClient) {
            this.serviceClient = serviceClient;
            InitializeComponent();
            SelectedCode = -1;
            this.form = form;
        }

        private void IndicatorsForm_Load(object sender, EventArgs e) {
            DataTable indicatorsTable = null;
            if (this.form == Forms.F102) {
                Text = "Индикаторы для формы 102 (DoubleClick to select indicator)";
                indicatorsTable = Load102FormIndicators();
            }
            else {
                Text = "Индикаторы для формы 101 (DoubleClick to select indicator)";
                indicatorsTable = Load101FormIndicators();
            }

            dgvIndicators.DataSource = indicatorsTable;
            SetColumnsHeader(indicatorsTable);
        }

        private void dgvIndicators_DoubleClick(object sender, EventArgs e) {
            if (dgvIndicators.SelectedRows.Count == 0) {
                return;
            }

            var columnName = "IndCode";
            if (this.form == Forms.F102) {
                columnName = "symbol";
            }

            if (dgvIndicators.SelectedRows[0].Cells[columnName].Value.ToString().Trim() == "") {
                return;
            }

            SelectedCode = Convert.ToDouble(dgvIndicators.SelectedRows[0].Cells[columnName].Value);
            DialogResult = DialogResult.OK;
            Close();
        }

        private DataTable Load101FormIndicators() {
            var ds = this.serviceClient.Form101IndicatorsEnum();
            string shema = ds.GetXmlSchema();
            shema = shema.Replace("encoding=\"utf-16\"", "encoding=\"utf-8\"");
            System.IO.File.WriteAllText("Form101IndicatorsEnum.xsd", shema, Encoding.UTF8);
            return ds.Tables[0];
        }

        private DataTable Load102FormIndicators() {
            var ds = this.serviceClient.Form102IndicatorsEnum();
            string shema = ds.GetXmlSchema();
            shema = shema.Replace("encoding=\"utf-16\"", "encoding=\"utf-8\"");
            System.IO.File.WriteAllText("Form102IndicatorsEnum.xsd", shema, Encoding.UTF8);
            return ds.Tables[0];
        }

        private void SetColumnsHeader(DataTable indicatorsTable) {
            for (int i = 0; i < indicatorsTable.Columns.Count; i++) {
                this.dgvIndicators.Columns[i].HeaderText = indicatorsTable.Columns[i].Caption;
            }
        }
    }
}
