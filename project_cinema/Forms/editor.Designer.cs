namespace project_cinema.Forms
{
    partial class editor
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label movie_nameLabel;
            System.Windows.Forms.Label dayLabel;
            System.Windows.Forms.Label date_showLabel;
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label arenaLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.cinestarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_project = new project_cinema.Data.Dataset.DataSet_project();
            this.movie_nameTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.date_showDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.arenaTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cinestarTableAdapter = new project_cinema.Data.Dataset.DataSet_projectTableAdapters.CinestarTableAdapter();
            this.tableAdapterManager = new project_cinema.Data.Dataset.DataSet_projectTableAdapters.TableAdapterManager();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.add_btn = new System.Windows.Forms.ToolStripButton();
            this.edit_btn = new System.Windows.Forms.ToolStripButton();
            this.del_btn = new System.Windows.Forms.ToolStripButton();
            this.cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.save_btn = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            movie_nameLabel = new System.Windows.Forms.Label();
            dayLabel = new System.Windows.Forms.Label();
            date_showLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            arenaLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cinestarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_project)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinestarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(7, 13);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(23, 16);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // movie_nameLabel
            // 
            movie_nameLabel.AutoSize = true;
            movie_nameLabel.Location = new System.Drawing.Point(7, 41);
            movie_nameLabel.Name = "movie_nameLabel";
            movie_nameLabel.Size = new System.Drawing.Size(84, 16);
            movie_nameLabel.TabIndex = 2;
            movie_nameLabel.Text = "Movie name:";
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Location = new System.Drawing.Point(7, 69);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new System.Drawing.Size(35, 16);
            dayLabel.TabIndex = 4;
            dayLabel.Text = "Day:";
            // 
            // date_showLabel
            // 
            date_showLabel.AutoSize = true;
            date_showLabel.Location = new System.Drawing.Point(7, 98);
            date_showLabel.Name = "date_showLabel";
            date_showLabel.Size = new System.Drawing.Size(73, 16);
            date_showLabel.TabIndex = 6;
            date_showLabel.Text = "Date show:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(7, 125);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(41, 16);
            timeLabel.TabIndex = 8;
            timeLabel.Text = "Time:";
            // 
            // arenaLabel
            // 
            arenaLabel.AutoSize = true;
            arenaLabel.Location = new System.Drawing.Point(7, 153);
            arenaLabel.Name = "arenaLabel";
            arenaLabel.Size = new System.Drawing.Size(46, 16);
            arenaLabel.TabIndex = 10;
            arenaLabel.Text = "Arena:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(7, 181);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(41, 16);
            priceLabel.TabIndex = 12;
            priceLabel.Text = "Price:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(7, 209);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(78, 16);
            descriptionLabel.TabIndex = 14;
            descriptionLabel.Text = "Description:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cinestarDataGridView);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1462, 644);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(iDLabel);
            this.groupBox2.Controls.Add(this.iDTextBox);
            this.groupBox2.Controls.Add(movie_nameLabel);
            this.groupBox2.Controls.Add(this.movie_nameTextBox);
            this.groupBox2.Controls.Add(dayLabel);
            this.groupBox2.Controls.Add(this.dayTextBox);
            this.groupBox2.Controls.Add(date_showLabel);
            this.groupBox2.Controls.Add(this.date_showDateTimePicker);
            this.groupBox2.Controls.Add(timeLabel);
            this.groupBox2.Controls.Add(this.timeTextBox);
            this.groupBox2.Controls.Add(arenaLabel);
            this.groupBox2.Controls.Add(this.arenaTextBox);
            this.groupBox2.Controls.Add(priceLabel);
            this.groupBox2.Controls.Add(this.priceTextBox);
            this.groupBox2.Controls.Add(descriptionLabel);
            this.groupBox2.Controls.Add(this.descriptionTextBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 238);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // iDTextBox
            // 
            this.iDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cinestarBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(97, 10);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 22);
            this.iDTextBox.TabIndex = 1;
            // 
            // cinestarBindingSource
            // 
            this.cinestarBindingSource.DataMember = "Cinestar";
            this.cinestarBindingSource.DataSource = this.dataSet_project;
            // 
            // dataSet_project
            // 
            this.dataSet_project.DataSetName = "DataSet_project";
            this.dataSet_project.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movie_nameTextBox
            // 
            this.movie_nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movie_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cinestarBindingSource, "Movie_name", true));
            this.movie_nameTextBox.Location = new System.Drawing.Point(97, 38);
            this.movie_nameTextBox.Name = "movie_nameTextBox";
            this.movie_nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.movie_nameTextBox.TabIndex = 3;
            // 
            // dayTextBox
            // 
            this.dayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cinestarBindingSource, "Day", true));
            this.dayTextBox.Location = new System.Drawing.Point(97, 66);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(200, 22);
            this.dayTextBox.TabIndex = 5;
            // 
            // date_showDateTimePicker
            // 
            this.date_showDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cinestarBindingSource, "Date_show", true));
            this.date_showDateTimePicker.Location = new System.Drawing.Point(97, 94);
            this.date_showDateTimePicker.Name = "date_showDateTimePicker";
            this.date_showDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.date_showDateTimePicker.TabIndex = 7;
            // 
            // timeTextBox
            // 
            this.timeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cinestarBindingSource, "Time", true));
            this.timeTextBox.Location = new System.Drawing.Point(97, 122);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(200, 22);
            this.timeTextBox.TabIndex = 9;
            // 
            // arenaTextBox
            // 
            this.arenaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cinestarBindingSource, "Arena", true));
            this.arenaTextBox.Location = new System.Drawing.Point(97, 150);
            this.arenaTextBox.Name = "arenaTextBox";
            this.arenaTextBox.Size = new System.Drawing.Size(200, 22);
            this.arenaTextBox.TabIndex = 11;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cinestarBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(97, 178);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 22);
            this.priceTextBox.TabIndex = 13;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cinestarBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(97, 206);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 22);
            this.descriptionTextBox.TabIndex = 15;
            // 
            // cinestarDataGridView
            // 
            this.cinestarDataGridView.AllowUserToAddRows = false;
            this.cinestarDataGridView.AllowUserToDeleteRows = false;
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
            this.cinestarDataGridView.Location = new System.Drawing.Point(6, 269);
            this.cinestarDataGridView.Name = "cinestarDataGridView";
            this.cinestarDataGridView.ReadOnly = true;
            this.cinestarDataGridView.RowHeadersWidth = 51;
            this.cinestarDataGridView.RowTemplate.Height = 24;
            this.cinestarDataGridView.Size = new System.Drawing.Size(1430, 355);
            this.cinestarDataGridView.TabIndex = 18;
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
            this.dataGridViewTextBoxColumn2.HeaderText = "Movie Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Day";
            this.dataGridViewTextBoxColumn3.HeaderText = "Day";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date_show";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn5.HeaderText = "Time";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Arena";
            this.dataGridViewTextBoxColumn6.HeaderText = "Arena";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn7.HeaderText = "Price";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Image";
            this.dataGridViewImageColumn1.HeaderText = "Image";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn8.HeaderText = "Description";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "Select Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.cinestarBindingSource, "Image", true));
            this.pictureBox1.Location = new System.Drawing.Point(402, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "All Images|*JPG;*.BMP;*.PNG|JPG Files|*.JPG";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_btn,
            this.edit_btn,
            this.del_btn,
            this.cancel_btn,
            this.save_btn});
            this.toolStrip1.Location = new System.Drawing.Point(28, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(351, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // add_btn
            // 
            this.add_btn.Image = global::project_cinema.Properties.Resources.add48;
            this.add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(61, 24);
            this.add_btn.Text = "Add";
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Image = global::project_cinema.Properties.Resources.edit48;
            this.edit_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(59, 24);
            this.edit_btn.Text = "Edit";
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Image = global::project_cinema.Properties.Resources.delete48;
            this.del_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(77, 24);
            this.del_btn.Text = "Delete";
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Image = global::project_cinema.Properties.Resources.undo48;
            this.cancel_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(77, 24);
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Image = global::project_cinema.Properties.Resources.save48;
            this.save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(64, 24);
            this.save_btn.Text = "Save";
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1413, 47);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Image = global::project_cinema.Properties.Resources.back48;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1301, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 701);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editor";
            this.Text = "editor";
            this.Load += new System.EventHandler(this.editor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cinestarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_project)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinestarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private Data.Dataset.DataSet_project dataSet_project;
        private System.Windows.Forms.BindingSource cinestarBindingSource;
        private Data.Dataset.DataSet_projectTableAdapters.CinestarTableAdapter cinestarTableAdapter;
        private Data.Dataset.DataSet_projectTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox movie_nameTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.DateTimePicker date_showDateTimePicker;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox arenaTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView cinestarDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton add_btn;
        private System.Windows.Forms.ToolStripButton edit_btn;
        private System.Windows.Forms.ToolStripButton del_btn;
        private System.Windows.Forms.ToolStripButton cancel_btn;
        private System.Windows.Forms.ToolStripButton save_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}