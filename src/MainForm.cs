using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestForm {
    public partial class MainForm : Form {
        private readonly CregitInfoWS.CreditOrgInfo _serviceClient = new CregitInfoWS.CreditOrgInfo(); //ссылка на сервис

        public MainForm() {
            _serviceClient.UseDefaultCredentials = true;
            _serviceClient.CookieContainer = new System.Net.CookieContainer();
            _serviceClient.Url = "http://www.cbr.ru/CreditInfoWebServ/CreditOrgInfo.asmx?WSDL";
            InitializeComponent();
        }

        private void BankRegnum_TextChanged(object sender, EventArgs e) {
            try {
                DateTime[] dtArray;
                int regnum = System.Convert.ToInt32(BankRegnum.Text);
                BankName.Text = GetBankNameByRegnum(regnum);

                if (BankName.Text == "") {
                    BankName.Text = "Банк  с рег кодом" + regnum.ToString() + " не найден";

                    dataGridView1.DataSource = null;
                    return;
                }

                switch (FormsList.Items[FormsList.SelectedIndex].ToString()) {
                    case "123":
                        dtArray = _serviceClient.GetDatesForF123(regnum);
                        break;
                    case "134":
                        dtArray = _serviceClient.GetDatesForF134(regnum);
                        break;
                    case "135":
                        dtArray = _serviceClient.GetDatesForF135(regnum);
                        break;
                    default: return;

                }

                DatesListBox.Items.Clear();
                foreach (var dt in dtArray) {
                    DatesListBox.Items.Add(dt.ToString("dd.MM.yyyy"));
                }

                if (DatesListBox.Items.Count != 0) {
                    DatesListBox.SelectedIndex = 0;
                }

            }
            finally { }
        }

        private void FormsList_SelectedIndexChanged(object sender, EventArgs e) {
            BankRegnum_TextChanged(null, null);
            DatesListBox_SelectedIndexChanged(null, null);
        }

        private void MainWindow_Load(object sender, EventArgs e) {
            GetMaxDatesFor();
            FormsList.SelectedIndex = 0;
        }

        void GetMaxDatesFor() {
            DateTime lu = _serviceClient.LastUpdate();
            DateTime form_101_date = _serviceClient.GetFormsMaxDate(101);
            DateTime form_102_date = _serviceClient.GetFormsMaxDate(102);
            DateTime form_123_date = _serviceClient.GetFormsMaxDate(123);
            DateTime form_134_date = _serviceClient.GetFormsMaxDate(134);
            DateTime form_135_date = _serviceClient.GetFormsMaxDate(135);

            label4.Text = string.Format("Последние данные по формама: 101 - {0:dd.MM.yyyy}, 102 - {1:dd.MM.yyyy}, 123b - {2:dd.MM.yyyy},\r\n124b - {3:dd.MM.yyyy}, 135b - {4:dd.MM.yyyy} ", form_101_date, form_102_date, form_123_date, form_134_date, form_135_date);
            label4.Refresh();
            this.Text += " DB Update:" + lu.ToString();
        }


        public static void MapGridViewTitle(DataGridView dgv) {
            var dt = (DataTable)dgv.DataSource;
            for (int i = 0; i < dt.Columns.Count; i++) {
                dgv.Columns[i].HeaderText = dt.Columns[i].Caption;
            }
        }

        private void DatesListBox_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                int regnum = System.Convert.ToInt32(BankRegnum.Text);
                DateTime dt = System.Convert.ToDateTime(DatesListBox.Items[DatesListBox.SelectedIndex].ToString());
                DataSet ds;
                string filename = "";
                switch (FormsList.Items[FormsList.SelectedIndex].ToString()) {
                    case "123":
                        filename = "Data123FormFull";
                        ds = _serviceClient.Data123FormFull(regnum, dt);
                        break;
                    case "134":
                        filename = "Data134FormFull";
                        ds = _serviceClient.Data134FormFull(regnum, dt);
                        break;
                    case "135":
                        filename = "Data135FormFull";
                        ds = _serviceClient.Data135FormFull(regnum, dt);
                        break;
                    default: return;

                }

                dataGridView1.DataSource = ds.Tables[0];
                MapGridViewTitle(dataGridView1);
                string shema = ds.GetXmlSchema();
                shema = shema.Replace("encoding=\"utf-16\"", "encoding=\"utf-8\"");
                System.IO.File.WriteAllText(filename + ".xsd", shema, Encoding.UTF8);
            }
            catch {
                dataGridView1.DataSource = null;
            }
            finally { }
        }

        private string GetBankNameByRegnum(int regnum) {
            double internal_code = _serviceClient.RegNumToIntCode(regnum);
            if (internal_code == -1) {
                return "";
            }

            DataSet info_ds = _serviceClient.CreditInfoByIntCode(internal_code);

            string shema = info_ds.GetXmlSchema();
            shema = shema.Replace("encoding=\"utf-16\"", "encoding=\"utf-8\"");
            System.IO.File.WriteAllText("CreditInfoByIntCode.xsd", shema);

            if (info_ds == null) {
                return "";
            }

            return info_ds.Tables[0].Rows[0]["OrgName"].ToString();
        }

        private void button1_Click(object sender, EventArgs e) {
            Form102ex fe = new Form102ex();
            fe.ws = this._serviceClient;
            fe.ShowDialog();
        }

        private void BanksEnumerator_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            OrganisationInfoForm fe = new OrganisationInfoForm();
            fe.ws = this._serviceClient;
            fe.ShowDialog();
        }

        private void btnShowBanks_Click(object sender, EventArgs e) {
            BankList bn = new BankList();
            bn.ws = this._serviceClient;
            if (bn.ShowDialog() == DialogResult.OK) {
                BankRegnum.Text = bn.regnumber.ToString();
            }
        }

    }
}
