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
    public partial class movie_editor : Form
    {
        public movie_editor()
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

        private void movie_editor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_project.Cinestar' table. You can move, or remove it, as needed.
            this.cinestarTableAdapter.Fill(this.dataSet_project.Cinestar);

        }
    }
}
