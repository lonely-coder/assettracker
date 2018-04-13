using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FAS
{
    public partial class frm_scrap : MetroFramework.Forms.MetroForm
    {
        public frm_scrap()
        {
            InitializeComponent();
        }

        private void frm_scrap_Load(object sender, EventArgs e)
        {
            Asset asset = new Asset();
            DataTable dt = asset.SelectScrappedAssets();
            dt.Columns.Add(new DataColumn("Selected",typeof(bool)));

            //dataGridView1.ColumnCount = 7;
            //dataGridView1.Columns[0].Name = "asset_id";
            //dataGridView1.Columns[1].Name = "Property Tag";
            //dataGridView1.Columns[2].Name = "item_id";
            //dataGridView1.Columns[3].Name = "Brand";
            //dataGridView1.Columns[4].Name = "Model";
            //dataGridView1.Columns[5].Name = "receipt_id";
            //dataGridView1.Columns[6].Name = "serial_id";
            //foreach (DataRow rows in dt.Rows) {
            //    int n = dataGridView1.Rows.Add();
            //    dataGridView1.Rows[n].Cells["asset_id"].ToString();
            //}
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            //dataGridView1.Columns[0].Visible = false;
            //DataGridViewCheckBoxColumn CheckboxColumn = new DataGridViewCheckBoxColumn();
            //CheckboxColumn.HeaderText = "Delete";
            //CheckboxColumn.TrueValue = 0;//true
            //CheckboxColumn.FalseValue = 1;//false
            //CheckboxColumn.Width = 100;
            //dataGridView1.Columns.Add(CheckboxColumn);
            dataGridView1.ClearSelection();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = new List<int>();
            int n = dataGridView1.Rows.Count;
            foreach (DataGridViewRow rows in dataGridView1.Rows) {
                if (rows.Cells[8].Value.Equals(true)){
                    list.Add(int.Parse(rows.Cells[0].Value.ToString()));
                }
            }
            //MessageBoxOptions 
            DialogResult result = MessageBox.Show("Delete Items?","Delete",MessageBoxButtons.YesNo);
            switch (result) {
                case DialogResult.Yes:
                    Asset asset = new Asset();
                    asset.DeleteScrappedAssets(list);
                    break;
                case DialogResult.No:
                    this.Close();
                    break;
                default:
                    //laziness strikes
                    MessageBox.Show("Unknown error.");
                    break;
            }
            
            //for (int i = 0; i < list.Count; i++) {
            //    MessageBox.Show(list[i].ToString());
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if()
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
