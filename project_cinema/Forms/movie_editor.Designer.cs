namespace project_cinema.Forms
{
    partial class movie_editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(movie_editor));
            System.Windows.Forms.Label user_IDLabel;
            System.Windows.Forms.Label user_NameLabel;
            System.Windows.Forms.Label user_PassLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataSet_project = new project_cinema.Data.Dataset.DataSet_project();
            this.cinestarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinestarTableAdapter = new project_cinema.Data.Dataset.DataSet_projectTableAdapters.CinestarTableAdapter();
            this.tableAdapterManager = new project_cinema.Data.Dataset.DataSet_projectTableAdapters.TableAdapterManager();
            this.cinestarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cinestarBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cinestarDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user_IDTextBox = new System.Windows.Forms.TextBox();
            this.user_NameTextBox = new System.Windows.Forms.TextBox();
            this.user_PassTextBox = new System.Windows.Forms.TextBox();
            user_IDLabel = new System.Windows.Forms.Label();
            user_NameLabel = new System.Windows.Forms.Label();
            user_PassLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_project)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinestarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinestarBindingNavigator)).BeginInit();
            this.cinestarBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cinestarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(user_IDLabel);
            this.groupBox1.Controls.Add(this.user_IDTextBox);
            this.groupBox1.Controls.Add(user_NameLabel);
            this.groupBox1.Controls.Add(this.user_NameTextBox);
            this.groupBox1.Controls.Add(user_PassLabel);
            this.groupBox1.Controls.Add(this.user_PassTextBox);
            this.groupBox1.Controls.Add(this.cinestarDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 648);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movie Editor";
            // 
            // dataSet_project
            // 
            this.dataSet_project.DataSetName = "DataSet_project";
            this.dataSet_project.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cinestarBindingSource
            // 
            this.cinestarBindingSource.DataMember = "Cinestar";
            this.cinestarBindingSource.DataSource = this.dataSet_project;
            // 
            // cinestarTableAdapter
            // 
            this.cinestarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CinestarTableAdapter = this.cinestarTableAdapter;
            this.tableAdapterManager.UpdateOrder = project_cinema.Data.Dataset.DataSet_projectTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cinestarBindingNavigator
            // 
            this.cinestarBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cinestarBindingNavigator.BindingSource = this.cinestarBindingSource;
            this.cinestarBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cinestarBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cinestarBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cinestarBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cinestarBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cinestarBindingNavigatorSaveItem});
            this.cinestarBindingNavigator.Location = new System.Drawing.Point(0, 701);
            this.cinestarBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cinestarBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cinestarBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cinestarBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cinestarBindingNavigator.Name = "cinestarBindingNavigator";
            this.cinestarBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cinestarBindingNavigator.Size = new System.Drawing.Size(992, 27);
            this.cinestarBindingNavigator.TabIndex = 1;
            this.cinestarBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // cinestarBindingNavigatorSaveItem
            // 
            this.cinestarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cinestarBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cinestarBindingNavigatorSaveItem.Image")));
            this.cinestarBindingNavigatorSaveItem.Name = "cinestarBindingNavigatorSaveItem";
            this.cinestarBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cinestarBindingNavigatorSaveItem.Text = "Save Data";
            this.cinestarBindingNavigatorSaveItem.Click += new System.EventHandler(this.cinestarBindingNavigatorSaveItem_Click_1);
            // 
            // cinestarDataGridView
            // 
            this.cinestarDataGridView.AutoGenerateColumns = false;
            this.cinestarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cinestarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn8});
            this.cinestarDataGridView.DataSource = this.cinestarBindingSource;
            this.cinestarDataGridView.Location = new System.Drawing.Point(12, 197);
            this.cinestarDataGridView.Name = "cinestarDataGridView";
            this.cinestarDataGridView.RowHeadersWidth = 51;
            this.cinestarDataGridView.RowTemplate.Height = 24;
            this.cinestarDataGridView.Size = new System.Drawing.Size(821, 323);
            this.cinestarDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Movie_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Movie_name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Day";
            this.dataGridViewTextBoxColumn3.HeaderText = "Day";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date_show";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date_show";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn5.HeaderText = "Time";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Arena";
            this.dataGridViewTextBoxColumn6.HeaderText = "Arena";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn7.HeaderText = "Price";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Image";
            this.dataGridViewImageColumn1.HeaderText = "Image";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn8.HeaderText = "Description";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 27);
            this.button2.TabIndex = 18;
            this.button2.Text = "Save Image Manually";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 27);
            this.button1.TabIndex = 17;
            this.button1.Text = "Select Image";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(238, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // user_IDLabel
            // 
            user_IDLabel.AutoSize = true;
            user_IDLabel.Location = new System.Drawing.Point(15, 56);
            user_IDLabel.Name = "user_IDLabel";
            user_IDLabel.Size = new System.Drawing.Size(55, 16);
            user_IDLabel.TabIndex = 10;
            user_IDLabel.Text = "User ID:";
            // 
            // user_IDTextBox
            // 
            this.user_IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_IDTextBox.Location = new System.Drawing.Point(109, 53);
            this.user_IDTextBox.Name = "user_IDTextBox";
            this.user_IDTextBox.ReadOnly = true;
            this.user_IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.user_IDTextBox.TabIndex = 11;
            // 
            // user_NameLabel
            // 
            user_NameLabel.AutoSize = true;
            user_NameLabel.Location = new System.Drawing.Point(15, 86);
            user_NameLabel.Name = "user_NameLabel";
            user_NameLabel.Size = new System.Drawing.Size(79, 16);
            user_NameLabel.TabIndex = 12;
            user_NameLabel.Text = "User Name:";
            // 
            // user_NameTextBox
            // 
            this.user_NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_NameTextBox.Location = new System.Drawing.Point(109, 83);
            this.user_NameTextBox.Name = "user_NameTextBox";
            this.user_NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.user_NameTextBox.TabIndex = 13;
            // 
            // user_PassLabel
            // 
            user_PassLabel.AutoSize = true;
            user_PassLabel.Location = new System.Drawing.Point(15, 116);
            user_PassLabel.Name = "user_PassLabel";
            user_PassLabel.Size = new System.Drawing.Size(73, 16);
            user_PassLabel.TabIndex = 14;
            user_PassLabel.Text = "User Pass:";
            // 
            // user_PassTextBox
            // 
            this.user_PassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_PassTextBox.Location = new System.Drawing.Point(109, 113);
            this.user_PassTextBox.Name = "user_PassTextBox";
            this.user_PassTextBox.Size = new System.Drawing.Size(100, 22);
            this.user_PassTextBox.TabIndex = 15;
            // 
            // movie_editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 728);
            this.Controls.Add(this.cinestarBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "movie_editor";
            this.Text = "movie_editor";
            this.Load += new System.EventHandler(this.movie_editor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_project)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinestarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinestarBindingNavigator)).EndInit();
            this.cinestarBindingNavigator.ResumeLayout(false);
            this.cinestarBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cinestarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Data.Dataset.DataSet_project dataSet_project;
        private System.Windows.Forms.BindingSource cinestarBindingSource;
        private Data.Dataset.DataSet_projectTableAdapters.CinestarTableAdapter cinestarTableAdapter;
        private Data.Dataset.DataSet_projectTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cinestarBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cinestarBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox user_IDTextBox;
        private System.Windows.Forms.TextBox user_NameTextBox;
        private System.Windows.Forms.TextBox user_PassTextBox;
        private System.Windows.Forms.DataGridView cinestarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}