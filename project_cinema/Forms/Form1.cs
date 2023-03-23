using project_cinema.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cinema
{
    public partial class discount_box : Form
    {
        private readonly int NumericUpDown1;

        public discount_box()
        {
            InitializeComponent();
        }

        private void cinestarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cinestarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_project);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_project.Cinestar' table. You can move, or remove it, as needed.
            //this.cinestarTableAdapter.Fill(this.dataSet_project.Cinestar);
            this.comboBox1.SelectedIndex = 0;
            this.cash_box.Enabled = false;

            
        }

              private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // komentar: koristi switch
            
            if (this.comboBox1.SelectedIndex == 0)
            {
                this.cinestarTableAdapter.FillBy_week(this.dataSet_project.Cinestar);
            }
            if (this.comboBox1.SelectedIndex == 1)
            {
                this.cinestarTableAdapter.FillBy_wed(this.dataSet_project.Cinestar);
            }
            else if (this.comboBox1.SelectedIndex == 2)
            {
                this.cinestarTableAdapter.FillBy_Thur(this.dataSet_project.Cinestar);
            }
            else if (this.comboBox1.SelectedIndex == 3)
            {
                this.cinestarTableAdapter.FillBy_Fri(this.dataSet_project.Cinestar);
            }
            else if (this.comboBox1.SelectedIndex == 4)
            {
                this.cinestarTableAdapter.FillBy_sat(this.dataSet_project.Cinestar);
            }
            else if (this.comboBox1.SelectedIndex == 5)
            {
                this.cinestarTableAdapter.FillBy_sun(this.dataSet_project.Cinestar);
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void movieEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor em = new editor();
            em.ShowDialog();
            this.Close();

        }

       
        private void pro_btn_Click(object sender, EventArgs e)
        {
            this.cash_box.Enabled = true;
            this.groupBox1.Enabled = false;

        }
           
               
        private void cash_box_Enter(object sender, EventArgs e)
        {
            //int r,a,b;
            //a = Convert.ToInt32(price_Box.Text);
            //b = Convert.ToInt32(numericUpDown1.Value);
            //r = a * b;
            //string res;
            //res = r.ToString();
            //this.total_box.Text = res;
            int r, a, b;
            a = Convert.ToInt32(domainUpDown1.Text);
            b = Convert.ToInt32(price_Box.Text);
            r = a * b;
            total_box.Text=r.ToString();

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.cash_box.Enabled=false;
            this.groupBox1.Enabled = true;

        }

        private void buy_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You buy a ticket for Movie{movie_nameTextBox} Arena:{arenaTextBox} Time:{timeTextBox} Price:{price_Box}");
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void domainUpDown1_TextChanged(object sender, EventArgs e)
        {
            var totalPrice = Convert.ToInt32(price_Box.Text) * Convert.ToInt32(domainUpDown1.Text);
            total_box.Text = totalPrice.ToString();
        }
    }
}

