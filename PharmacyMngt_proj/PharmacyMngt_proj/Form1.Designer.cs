namespace PharmacyMngt_proj
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.search_tbx = new System.Windows.Forms.TextBox();
            this.ok_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.comboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.show_btn = new Guna.UI2.WinForms.Guna2Button();
            this.del_btn = new Guna.UI2.WinForms.Guna2Button();
            this.edit_btn = new Guna.UI2.WinForms.Guna2Button();
            this.add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.location_tbx = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.name_tbx = new System.Windows.Forms.TextBox();
            this.company_tbx = new System.Windows.Forms.TextBox();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.ForestGreen;
            this.panel6.Controls.Add(this.comboBox1);
            this.panel6.Controls.Add(this.search_tbx);
            this.panel6.Controls.Add(this.ok_btn);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(343, 70);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(985, 764);
            this.panel6.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.comboBox1.BorderColor = System.Drawing.Color.ForestGreen;
            this.comboBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.comboBox1.ItemHeight = 22;
            this.comboBox1.Items.AddRange(new object[] {
            "COMPANY",
            "NAME"});
            this.comboBox1.Location = new System.Drawing.Point(153, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 28);
            this.comboBox1.TabIndex = 21;
            // 
            // search_tbx
            // 
            this.search_tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_tbx.BackColor = System.Drawing.SystemColors.Menu;
            this.search_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.search_tbx.Location = new System.Drawing.Point(338, 44);
            this.search_tbx.Multiline = true;
            this.search_tbx.Name = "search_tbx";
            this.search_tbx.Size = new System.Drawing.Size(424, 35);
            this.search_tbx.TabIndex = 19;
            // 
            // ok_btn
            // 
            this.ok_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ok_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.ok_btn.BorderColor = System.Drawing.Color.ForestGreen;
            this.ok_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ok_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ok_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ok_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ok_btn.FillColor = System.Drawing.Color.White;
            this.ok_btn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ok_btn.ForeColor = System.Drawing.Color.Black;
            this.ok_btn.Location = new System.Drawing.Point(787, 43);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(100, 36);
            this.ok_btn.TabIndex = 19;
            this.ok_btn.Text = "OK";
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "SEARCH";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(31, 45);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(6, 30);
            this.panel7.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 28;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(31, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(930, 623);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 28;
            this.dataGridView1.ThemeStyle.ReadOnly = true;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 27;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.comboBox2);
            this.metroPanel1.Controls.Add(this.show_btn);
            this.metroPanel1.Controls.Add(this.del_btn);
            this.metroPanel1.Controls.Add(this.edit_btn);
            this.metroPanel1.Controls.Add(this.add_btn);
            this.metroPanel1.Controls.Add(this.panel4);
            this.metroPanel1.Controls.Add(this.location_tbx);
            this.metroPanel1.Controls.Add(this.panel3);
            this.metroPanel1.Controls.Add(this.panel2);
            this.metroPanel1.Controls.Add(this.name_tbx);
            this.metroPanel1.Controls.Add(this.company_tbx);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 70);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(331, 764);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.ForestGreen;
            this.comboBox2.BorderColor = System.Drawing.Color.ForestGreen;
            this.comboBox2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.comboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.comboBox2.ItemHeight = 22;
            this.comboBox2.Items.AddRange(new object[] {
            "COMPANY",
            "NAME"});
            this.comboBox2.Location = new System.Drawing.Point(17, 300);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(290, 28);
            this.comboBox2.TabIndex = 22;
            // 
            // show_btn
            // 
            this.show_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.show_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.show_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.show_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.show_btn.FillColor = System.Drawing.Color.ForestGreen;
            this.show_btn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.show_btn.ForeColor = System.Drawing.Color.White;
            this.show_btn.Location = new System.Drawing.Point(169, 419);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(138, 46);
            this.show_btn.TabIndex = 17;
            this.show_btn.Text = "Show";
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.del_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.del_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.del_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.del_btn.FillColor = System.Drawing.Color.ForestGreen;
            this.del_btn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.del_btn.ForeColor = System.Drawing.Color.White;
            this.del_btn.Location = new System.Drawing.Point(161, 235);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(146, 44);
            this.del_btn.TabIndex = 16;
            this.del_btn.Text = "Delete";
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.edit_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.edit_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.edit_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.edit_btn.FillColor = System.Drawing.Color.ForestGreen;
            this.edit_btn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.edit_btn.ForeColor = System.Drawing.Color.White;
            this.edit_btn.Location = new System.Drawing.Point(169, 349);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(138, 44);
            this.edit_btn.TabIndex = 15;
            this.edit_btn.Text = "Edit";
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_btn.FillColor = System.Drawing.Color.ForestGreen;
            this.add_btn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(17, 235);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(138, 44);
            this.add_btn.TabIndex = 14;
            this.add_btn.Text = "Add";
            this.add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.ForestGreen;
            this.panel4.Location = new System.Drawing.Point(17, 196);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 3);
            this.panel4.TabIndex = 10;
            // 
            // location_tbx
            // 
            this.location_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.location_tbx.Location = new System.Drawing.Point(17, 165);
            this.location_tbx.Name = "location_tbx";
            this.location_tbx.Size = new System.Drawing.Size(290, 25);
            this.location_tbx.TabIndex = 9;
            this.location_tbx.Text = "LOCATION";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.ForestGreen;
            this.panel3.Location = new System.Drawing.Point(17, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 3);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Location = new System.Drawing.Point(17, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 3);
            this.panel2.TabIndex = 6;
            // 
            // name_tbx
            // 
            this.name_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_tbx.Location = new System.Drawing.Point(17, 107);
            this.name_tbx.Name = "name_tbx";
            this.name_tbx.Size = new System.Drawing.Size(290, 25);
            this.name_tbx.TabIndex = 7;
            this.name_tbx.Text = "MEDICINE NAME";
            // 
            // company_tbx
            // 
            this.company_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.company_tbx.Location = new System.Drawing.Point(17, 54);
            this.company_tbx.Name = "company_tbx";
            this.company_tbx.Size = new System.Drawing.Size(290, 25);
            this.company_tbx.TabIndex = 3;
            this.company_tbx.Text = "COMPANY";
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(1204, 15);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 9;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1343, 10);
            this.panel1.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.DarkGreen;
            this.BorderThickness = 10F;
            this.ClientSize = new System.Drawing.Size(1340, 846);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroSetControlBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.SmallLineColor1 = System.Drawing.Color.White;
            this.SmallLineColor2 = System.Drawing.Color.White;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox search_tbx;
        private Guna.UI2.WinForms.Guna2Button ok_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Guna.UI2.WinForms.Guna2Button show_btn;
        private Guna.UI2.WinForms.Guna2Button del_btn;
        private Guna.UI2.WinForms.Guna2Button edit_btn;
        private Guna.UI2.WinForms.Guna2Button add_btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox location_tbx;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox name_tbx;
        private System.Windows.Forms.TextBox company_tbx;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox2;
    }
}

