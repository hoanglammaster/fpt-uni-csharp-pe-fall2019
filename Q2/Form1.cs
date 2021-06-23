using Q2.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductBLL.GetListAllProduct();
            //a b c

            //o
            DataGridViewTextBoxColumn textBoxColumn = new DataGridViewTextBoxColumn();
            textBoxColumn.HeaderText = dataGridView1.Columns["Discontinued"].HeaderText;
            textBoxColumn.ValueType = typeof(bool);
            textBoxColumn.DataPropertyName = "Discontinued";
            textBoxColumn.Name = "Discontinued";


            //xoa c di; a b
            dataGridView1.Columns.Remove("Discontinued");

            // add them o vao; a b o
            dataGridView1.Columns.Add(textBoxColumn);
            

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                checkedListBox1.Items.Add(dataGridView1.Columns[i].HeaderText, true);
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            { 
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<string> listColumnWillDisplay = new List<string>();
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                listColumnWillDisplay.Add(checkedListBox1.CheckedItems[i].ToString());

            }
            changeColumnVisible(listColumnWillDisplay);
        }

        private void changeColumnVisible(List<string> listColumnWillDisplay)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Visible = false;
            }
            foreach (string columnName in listColumnWillDisplay)
            {
                dataGridView1.Columns[columnName].Visible = true;
            }

        }
    }
}
