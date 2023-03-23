using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cinema.Forms
{
    public partial class editor : Form
    {
        public editor()
        {
            InitializeComponent();
        }

        private void cinestarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cinestarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_project);

        }

        private void cinestarBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cinestarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_project);

        }

        private void editor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_project.Cinestar' table. You can move, or remove it, as needed.
            this.cinestarTableAdapter.Fill(this.dataSet_project.Cinestar);

            this.add_btn.Enabled = true;
            this.edit_btn.Enabled = true;
            this.del_btn.Enabled = true;
            //-------------------------
            this.save_btn.Enabled = false;
            this.cancel_btn.Enabled = false;
            this.button1.Enabled = false;
            this.groupBox2.Enabled =false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog(this);
            string si;
            si = this.openFileDialog1.FileName;

            if (si=="openFileDialog1")
            {
                return;
            }
            
            this.pictureBox1.Image = Image.FromFile(si);

        }

        
        private void add_btn_Click(object sender, EventArgs e)
        {
            add_edit_del();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            add_edit_del();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            add_edit_del();
        }

        void add_edit_del()
        {
            this.add_btn.Enabled = false;
            this.edit_btn.Enabled = false;
            this.del_btn.Enabled = false;
            this.button2.Enabled = false;
            //--------------------------
            this.save_btn.Enabled = true;
            this.cancel_btn.Enabled = true;
            this.button1.Enabled = true;
            this.groupBox2.Enabled = true;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            save_del_controller();
            this.cinestarBindingSource.EndEdit();
            this.cinestarTableAdapter.Update(this.dataSet_project.Cinestar);
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            save_del_controller();
        }
        void save_del_controller()
        {
            this.add_btn.Enabled = true;
            this.edit_btn.Enabled = true;
            this.del_btn.Enabled = true;
            this.button2.Enabled = true;
            //--------------------------
            this.save_btn.Enabled = false;
            this.cancel_btn.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            discount_box f1 = new discount_box();
            f1.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
