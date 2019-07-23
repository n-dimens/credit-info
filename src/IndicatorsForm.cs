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
    public partial class IndicatorsForm : Form
    {

        public bool Is102Form {set; private get;}
        public CregitInfoWS.CreditOrgInfo ws { get; set; }
        public double selected_code { get; set; }
        public IndicatorsForm()
        {
            InitializeComponent();
            selected_code=-1;
            Is102Form = false;
        }

        private void Ind1_101_102_Enums_Load(object sender, EventArgs e)
        {
            DataSet ds=null;
            if (Is102Form)
            {
                this.Text = "Индикаторы для формы 102 (DoubleClick to select indicator)";
                 ds= ws.Form102IndicatorsEnum();
                 string shema = ds.GetXmlSchema();
                shema=shema.Replace("encoding=\"utf-16\"","encoding=\"utf-8\"");
                 System.IO.File.WriteAllText("Form102IndicatorsEnum.xsd", shema, Encoding.UTF8);

            }
            else
            {
                this.Text = "Индикаторы для формы 101 (DoubleClick to select indicator)";
                 ds = ws.Form101IndicatorsEnum();
                 string shema = ds.GetXmlSchema();
                 shema = shema.Replace("encoding=\"utf-16\"", "encoding=\"utf-8\"");
                 System.IO.File.WriteAllText("Form101IndicatorsEnum.xsd", shema, Encoding.UTF8);
            }  

            dataGridView1.DataSource = ds.Tables[0];
            MainForm.MapGridViewTitle(dataGridView1);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            if (Is102Form){
                if (dataGridView1.SelectedRows[0].Cells["symbol"].Value.ToString().Trim() == "") return;
              selected_code =  System.Convert.ToDouble(dataGridView1.SelectedRows[0].Cells["symbol"].Value);
              
            }else{
                if (dataGridView1.SelectedRows[0].Cells["IndCode"].Value.ToString().Trim() == "") return;
                selected_code = System.Convert.ToDouble(dataGridView1.SelectedRows[0].Cells["IndCode"].Value);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
