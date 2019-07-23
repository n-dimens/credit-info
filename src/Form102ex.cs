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
    public partial class Form102ex : Form
    {
        public CregitInfoWS.CreditOrgInfo ws { get; set; }
        public Form102ex()
        {
            InitializeComponent();
        }

        private void Form102ex_Load(object sender, EventArgs e)
        {
            dtoEDT.Text = DateTime.Now.ToShortDateString();
            var ds = ws.EnumBIC();

            string shema = ds.GetXmlSchema();
            shema = shema.Replace("encoding=\"utf-16\"", "encoding=\"utf-8\"");
            System.IO.File.WriteAllText("EnumBIC.xsd", shema);

            var rows = ds.Tables[0].Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                if (rows[i]["RB"] == DBNull.Value) continue;

                double ic = System.Convert.ToDouble(rows[i]["IntCode"]);
                string nm = rows[i]["NM"].ToString();
                ItemDDL idl = new ItemDDL() { Code = ic, Name = nm };
                BanksEnumerator.Items.Add(idl);
            }
            FormsList.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList regs = new System.Collections.ArrayList();
            regs.AddRange(RegCodesEDT.Items);

            if (FormsList.SelectedIndex == 0)
            {
                //DataSet ds = ws.Data101FormEx(regs.ToArray(), System.Convert.ToInt32(symbolEdt.Text), System.Convert.ToDateTime(dformEDT.Text), System.Convert.ToDateTime(dtoEDT.Text));
                //if (ds != null)
                //{
                //    dataGridView1.DataSource = ds.Tables[0];
                //          string shema = ds.GetXmlSchema();
                //          System.IO.File.WriteAllText("Data101FormEx.xsd", shema,  Encoding.UTF8);
                //}

                DataSet ds = ws.Data101FullEx(regs.ToArray(), System.Convert.ToInt32(symbolEdt.Text), System.Convert.ToDateTime(dformEDT.Text), System.Convert.ToDateTime(dtoEDT.Text));
                if (ds != null)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                    MainForm.MapGridViewTitle(dataGridView1);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        tabControl1.SelectedIndex = 0;
                       

                    }
                    dataGridView2.DataSource = ds.Tables[1];
                    MainForm.MapGridViewTitle(dataGridView2);
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        tabControl1.SelectedIndex = 1;
                       
                    }

                    string shema = ds.GetXmlSchema();
                    shema = shema.Replace("encoding=\"utf-16\"", "encoding=\"utf-8\"");
                    System.IO.File.WriteAllText("Data101FullEx.xsd", shema, Encoding.UTF8);
                    GetXMLButton.Enabled = true;
                }

            }
            if (FormsList.SelectedIndex == 1)
            {

                DataSet ds = ws.Data102FormEx(regs.ToArray(), System.Convert.ToInt32(symbolEdt.Text), System.Convert.ToDateTime(dformEDT.Text), System.Convert.ToDateTime(dtoEDT.Text));
                if (ds != null)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                    string shema = ds.GetXmlSchema();
                    System.IO.File.WriteAllText("Data102FormEx.xsd", shema, Encoding.UTF8);
                    GetXMLButton.Enabled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Добавляем банк
            if (BanksEnumerator.SelectedItem != null)
            {
                double code= ws.IntCodeToRegNum(((ItemDDL)BanksEnumerator.SelectedItem).Code);
                RegCodesEDT.Items.Add(code.ToString());
              
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (RegCodesEDT.SelectedIndex != -1) {
                RegCodesEDT.Items.RemoveAt(RegCodesEDT.SelectedIndex);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BanksEnumerator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetXMLButton_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList regs = new System.Collections.ArrayList();
            regs.AddRange(RegCodesEDT.Items);

            if (FormsList.SelectedIndex == 0)
            {
                //DataSet ds = ws.Data101FormEx(regs.ToArray(), System.Convert.ToInt32(symbolEdt.Text), System.Convert.ToDateTime(dformEDT.Text), System.Convert.ToDateTime(dtoEDT.Text));
                //if (ds != null)
                //{
                //    dataGridView1.DataSource = ds.Tables[0];
                //          string shema = ds.GetXmlSchema();
                //          System.IO.File.WriteAllText("Data101FormEx.xsd", shema,  Encoding.UTF8);
                //}

                var ds = ws.Data101FullExXML(regs.ToArray(), System.Convert.ToInt32(symbolEdt.Text), System.Convert.ToDateTime(dformEDT.Text), System.Convert.ToDateTime(dtoEDT.Text));
                MessageBox.Show(ds.OuterXml);

            }
            if (FormsList.SelectedIndex == 1)
            {

                var ds = ws.Data102FormExXML(regs.ToArray(), System.Convert.ToInt32(symbolEdt.Text), System.Convert.ToDateTime(dformEDT.Text), System.Convert.ToDateTime(dtoEDT.Text));
                MessageBox.Show(ds.OuterXml);
            }
        }

        private void btnLoadIndicators_Click(object sender, EventArgs e)
        {
            IndicatorsForm indenum = new IndicatorsForm();
            indenum.ws = this.ws;
            if (FormsList.SelectedIndex == 1)
            {
                indenum.Is102Form = true;
            }
            if (indenum.ShowDialog() == DialogResult.OK)
            {
                symbolEdt.Text = indenum.selected_code.ToString();
            }
        }


        TabPage tp;
        private void FormsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormsList.SelectedIndex == 1)
            {
                tabControl1.SelectedIndex = 0;
                tabControl1.TabPages[0].Text = "Форма N102";
                tp = tabControl1.TabPages[1];
                tabControl1.TabPages.Remove(tp);
            }
            else
            {
               if (tp!=null) tabControl1.TabPages.Add(tp);
                tabControl1.TabPages[0].Text = "Форма N101";
                tabControl1.TabPages[1].Show();
            }

        }
    }
}
