namespace project_cinema
{
    partial class discount_box
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
            System.Windows.Forms.Label movie_nameLabel;
            System.Windows.Forms.Label dayLabel;
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label arenaLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pro_btn = new System.Windows.Forms.Button();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.cinestarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_project = new project_cinema.Data.Dataset.DataSet_project();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.movie_nameTextBox = new System.Windows.Forms.TextBox();
            this.arenaTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.price_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.cinestarDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.option_btn = new System.Windows.Forms.ToolStripDropDownButton();
            this.movieEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.help_btn = new System.Windows.Forms.ToolStripButton();
            this.exit_btn = new System.Windows.Forms.ToolStripButton();
            this.cash_box = new System.Windows.Forms.GroupBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.buy_btn = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.total_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cinestarTableAdapter = new project_cinema.Data.Dataset.DataSet_projectTableAdapters.CinestarTableAdapter();
            this.tableAdapterManager = new project_cinema.Data.Dataset.DataSet_projectTableAdapters.TableAdapterManager();
            movie_nameLabel = new System.Windows.Forms.Label();
            dayLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            arenaLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinestarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_project)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinestarDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.cash_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // movie_nameLabel
            // 
            movie_nameLabel.AutoSize = true;
            movie_nameLabel.Location = new System.Drawing.Point(57, 442);
            movie_nameLabel.Name = "movie_nameLabel";
            movie_nameLabel.Size = new System.Drawing.Size(77, 25);
            movie_nameLabel.TabIndex = 3;
            movie_nameLabel.Text = "Movie:";
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Location = new System.Drawing.Point(77, 482);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new System.Drawing.Size(57, 25);
            dayLabel.TabIndex = 5;
            dayLabel.Text = "Day:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(67, 522);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(67, 25);
            timeLabel.TabIndex = 9;
            timeLabel.Text = "Time:";
            // 
            // arenaLabel
            // 
            arenaLabel.AutoSize = true;
            arenaLabel.Location = new System.Drawing.Point(57, 562);
            arenaLabel.Name = "arenaLabel";
            arenaLabel.Size = new System.Drawing.Size(77, 25);
            arenaLabel.TabIndex = 11;
            arenaLabel.Text = "Arena:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(66, 602);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(68, 25);
            priceLabel.TabIndex = 13;
            priceLabel.Text = "Price:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(7, 642);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(127, 25);
            descriptionLabel.TabIndex = 15;
            descriptionLabel.Text = "Description:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pro_btn);
            this.groupBox1.Controls.Add(this.imagePictureBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(timeLabel);
            this.groupBox1.Controls.Add(movie_nameLabel);
            this.groupBox1.Controls.Add(this.timeTextBox);
            this.groupBox1.Controls.Add(arenaLabel);
            this.groupBox1.Controls.Add(this.movie_nameTextBox);
            this.groupBox1.Controls.Add(this.arenaTextBox);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(priceLabel);
            this.groupBox1.Controls.Add(dayLabel);
            this.groupBox1.Controls.Add(this.price_Box);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dayTextBox);
            this.groupBox1.Controls.Add(this.cinestarDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 949);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movie List";
            // 
            // pro_btn
            // 
            this.pro_btn.BackColor = System.Drawing.Color.White;
            this.pro_btn.ForeColor = System.Drawing.Color.Black;
            this.pro_btn.Location = new System.Drawing.Point(541, 779);
            this.pro_btn.Name = "pro_btn";
            this.pro_btn.Size = new System.Drawing.Size(138, 30);
            this.pro_btn.TabIndex = 19;
            this.pro_btn.Text = "Proceed";
            this.pro_btn.UseVisualStyleBackColor = false;
            this.pro_btn.Click += new System.EventHandler(this.pro_btn_Click);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.cinestarBindingSource, "Image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(358, 442);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(321, 186);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 18;
            this.imagePictureBox.TabStop = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "€";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.Maroon;
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cinestarBindingSource, "Description", true));
            this.descriptionTextBox.ForeColor = System.Drawing.Color.White;
            this.descriptionTextBox.Location = new System.Drawing.Point(140, 645);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(539, 119);
            this.descriptionTextBox.TabIndex = 16;
            // 
            // timeTextBox
            // 
            this.timeTextBox.BackColor = System.Drawing.Color.Maroon;
            this.timeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cinestarBindingSource, "Time", true));
            this.timeTextBox.ForeColor = System.Drawing.Color.White;
            this.timeTextBox.Location = new System.Drawing.Point(140, 520);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(200, 30);
            this.timeTextBox.TabIndex = 10;
            // 
            // movie_nameTextBox
            // 
            this.movie_nameTextBox.BackColor = System.Drawing.Color.Maroon;
            this.movie_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cinestarBindingSource, "Movie_name", true));
            this.movie_nameTextBox.ForeColor = System.Drawing.Color.White;
            this.movie_nameTextBox.Location = new System.Drawing.Point(140, 442);
            this.movie_nameTextBox.Name = "movie_nameTextBox";
            this.movie_nameTextBox.Size = new System.Drawing.Size(200, 30);
            this.movie_nameTextBox.TabIndex = 4;
            // 
            // arenaTextBox
            // 
            this.arenaTextBox.BackColor = System.Drawing.Color.Maroon;
            this.arenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cinestarBindingSource, "Arena", true));
            this.arenaTextBox.ForeColor = System.Drawing.Color.White;
            this.arenaTextBox.Location = new System.Drawing.Point(140, 559);
            this.arenaTextBox.Name = "arenaTextBox";
            this.arenaTextBox.Size = new System.Drawing.Size(200, 30);
            this.arenaTextBox.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightCoral;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Week",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboBox1.Location = new System.Drawing.Point(160, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 33);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // price_Box
            // 
            this.price_Box.BackColor = System.Drawing.Color.Maroon;
            this.price_Box.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cinestarBindingSource, "Price", true));
            this.price_Box.ForeColor = System.Drawing.Color.White;
            this.price_Box.Location = new System.Drawing.Point(140, 598);
            this.price_Box.Name = "price_Box";
            this.price_Box.Size = new System.Drawing.Size(37, 30);
            this.price_Box.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a day:";
            // 
            // dayTextBox
            // 
            this.dayTextBox.BackColor = System.Drawing.Color.Maroon;
            this.dayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cinestarBindingSource, "Day", true));
            this.dayTextBox.ForeColor = System.Drawing.Color.White;
            this.dayTextBox.Location = new System.Drawing.Point(140, 481);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(200, 30);
            this.dayTextBox.TabIndex = 6;
            // 
            // cinestarDataGridView
            // 
            this.cinestarDataGridView.AllowUserToAddRows = false;
            this.cinestarDataGridView.AllowUserToDeleteRows = false;
            this.cinestarDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cinestarDataGridView.AutoGenerateColumns = false;
            this.cinestarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cinestarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.Time});
            this.cinestarDataGridView.DataSource = this.cinestarBindingSource;
            this.cinestarDataGridView.Location = new System.Drawing.Point(6, 65);
            this.cinestarDataGridView.Name = "cinestarDataGridView";
            this.cinestarDataGridView.ReadOnly = true;
            this.cinestarDataGridView.RowHeadersWidth = 51;
            this.cinestarDataGridView.RowTemplate.Height = 24;
            this.cinestarDataGridView.Size = new System.Drawing.Size(673, 364);
            this.cinestarDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Movie_name";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "Movie";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date_show";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Time.DefaultCellStyle = dataGridViewCellStyle3;
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1456, 38);
            this.panel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.option_btn,
            this.help_btn,
            this.exit_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1456, 30);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // option_btn
            // 
            this.option_btn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieEditorToolStripMenuItem});
            this.option_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option_btn.ForeColor = System.Drawing.Color.Black;
            this.option_btn.Image = global::project_cinema.Properties.Resources.settings;
            this.option_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.option_btn.Name = "option_btn";
            this.option_btn.Size = new System.Drawing.Size(107, 27);
            this.option_btn.Text = "Options";
            // 
            // movieEditorToolStripMenuItem
            // 
            this.movieEditorToolStripMenuItem.Image = global::project_cinema.Properties.Resources.movie24;
            this.movieEditorToolStripMenuItem.Name = "movieEditorToolStripMenuItem";
            this.movieEditorToolStripMenuItem.Size = new System.Drawing.Size(197, 28);
            this.movieEditorToolStripMenuItem.Text = "Movie Editor";
            this.movieEditorToolStripMenuItem.Click += new System.EventHandler(this.movieEditorToolStripMenuItem_Click);
            // 
            // help_btn
            // 
            this.help_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_btn.ForeColor = System.Drawing.Color.Black;
            this.help_btn.Image = global::project_cinema.Properties.Resources.help;
            this.help_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(72, 27);
            this.help_btn.Text = "Help";
            // 
            // exit_btn
            // 
            this.exit_btn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exit_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.Black;
            this.exit_btn.Image = global::project_cinema.Properties.Resources.exit24;
            this.exit_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(64, 27);
            this.exit_btn.Text = "Exit";
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // cash_box
            // 
            this.cash_box.Controls.Add(this.back_btn);
            this.cash_box.Controls.Add(this.buy_btn);
            this.cash_box.Controls.Add(this.domainUpDown1);
            this.cash_box.Controls.Add(this.total_box);
            this.cash_box.Controls.Add(this.label6);
            this.cash_box.Controls.Add(this.label3);
            this.cash_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_box.ForeColor = System.Drawing.Color.White;
            this.cash_box.Location = new System.Drawing.Point(735, 37);
            this.cash_box.Name = "cash_box";
            this.cash_box.Size = new System.Drawing.Size(709, 364);
            this.cash_box.TabIndex = 2;
            this.cash_box.TabStop = false;
            this.cash_box.Text = "Cash";
            this.cash_box.Enter += new System.EventHandler(this.cash_box_Enter);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.Black;
            this.back_btn.Location = new System.Drawing.Point(198, 261);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(93, 30);
            this.back_btn.TabIndex = 12;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // buy_btn
            // 
            this.buy_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy_btn.ForeColor = System.Drawing.Color.Black;
            this.buy_btn.Location = new System.Drawing.Point(305, 261);
            this.buy_btn.Name = "buy_btn";
            this.buy_btn.Size = new System.Drawing.Size(93, 30);
            this.buy_btn.TabIndex = 11;
            this.buy_btn.Text = "Buy";
            this.buy_btn.UseVisualStyleBackColor = true;
            this.buy_btn.Click += new System.EventHandler(this.buy_btn_Click);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("10");
            this.domainUpDown1.Items.Add("9");
            this.domainUpDown1.Items.Add("8");
            this.domainUpDown1.Items.Add("7");
            this.domainUpDown1.Items.Add("6");
            this.domainUpDown1.Items.Add("5");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Items.Add("2");
            this.domainUpDown1.Items.Add("1");
            this.domainUpDown1.Location = new System.Drawing.Point(198, 39);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(80, 30);
            this.domainUpDown1.TabIndex = 10;
            this.domainUpDown1.Text = "1";
            this.domainUpDown1.TextChanged += new System.EventHandler(this.domainUpDown1_TextChanged);
            // 
            // total_box
            // 
            this.total_box.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cinestarBindingSource, "Price", true));
            this.total_box.Location = new System.Drawing.Point(102, 92);
            this.total_box.Name = "total_box";
            this.total_box.ReadOnly = true;
            this.total_box.Size = new System.Drawing.Size(124, 30);
            this.total_box.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Number of tickets:";
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
            // discount_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1456, 1002);
            this.Controls.Add(this.cash_box);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "discount_box";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinestarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_project)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinestarDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.cash_box.ResumeLayout(false);
            this.cash_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Data.Dataset.DataSet_project dataSet_project;
        private System.Windows.Forms.BindingSource cinestarBindingSource;
        private Data.Dataset.DataSet_projectTableAdapters.CinestarTableAdapter cinestarTableAdapter;
        private Data.Dataset.DataSet_projectTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView cinestarDataGridView;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox movie_nameTextBox;
        private System.Windows.Forms.TextBox arenaTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton help_btn;
        private System.Windows.Forms.ToolStripButton exit_btn;
        private System.Windows.Forms.ToolStripDropDownButton option_btn;
        private System.Windows.Forms.ToolStripMenuItem movieEditorToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pro_btn;
        private System.Windows.Forms.TextBox total_box;
        public System.Windows.Forms.TextBox price_Box;
        public System.Windows.Forms.GroupBox cash_box;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button buy_btn;
    }
}

