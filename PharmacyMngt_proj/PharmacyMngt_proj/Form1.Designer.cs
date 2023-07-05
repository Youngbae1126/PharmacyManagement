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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel6 = new System.Windows.Forms.Panel();
            this.search_tbx = new System.Windows.Forms.TextBox();
            this.ok_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.datagridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.company_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.Home_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Del_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Edit_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.location_tbx = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.name_tbx = new System.Windows.Forms.TextBox();
            this.company_tbx = new System.Windows.Forms.TextBox();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.ForestGreen;
            this.panel6.Controls.Add(this.search_tbx);
            this.panel6.Controls.Add(this.ok_btn);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.datagridview);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(343, 70);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(715, 554);
            this.panel6.TabIndex = 12;
            // 
            // search_tbx
            // 
            this.search_tbx.BackColor = System.Drawing.SystemColors.Menu;
            this.search_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_tbx.Location = new System.Drawing.Point(142, 45);
            this.search_tbx.Multiline = true;
            this.search_tbx.Name = "search_tbx";
            this.search_tbx.Size = new System.Drawing.Size(424, 43);
            this.search_tbx.TabIndex = 19;
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.Olive;
            this.ok_btn.BorderColor = System.Drawing.Color.ForestGreen;
            this.ok_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ok_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ok_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ok_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ok_btn.FillColor = System.Drawing.Color.White;
            this.ok_btn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ok_btn.ForeColor = System.Drawing.Color.Black;
            this.ok_btn.Location = new System.Drawing.Point(591, 45);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(100, 34);
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
            // datagridview
            // 
            this.datagridview.AllowUserToAddRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.datagridview.ColumnHeadersHeight = 28;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.company_col,
            this.name_col,
            this.location_col,
            this.date_col});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview.DefaultCellStyle = dataGridViewCellStyle18;
            this.datagridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview.Location = new System.Drawing.Point(31, 107);
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.RowHeadersVisible = false;
            this.datagridview.RowHeadersWidth = 51;
            this.datagridview.RowTemplate.Height = 27;
            this.datagridview.Size = new System.Drawing.Size(660, 421);
            this.datagridview.TabIndex = 0;
            this.datagridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.datagridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridview.ThemeStyle.HeaderStyle.Height = 28;
            this.datagridview.ThemeStyle.ReadOnly = true;
            this.datagridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.datagridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.datagridview.ThemeStyle.RowsStyle.Height = 27;
            this.datagridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // company_col
            // 
            this.company_col.HeaderText = "COMPANY";
            this.company_col.MinimumWidth = 6;
            this.company_col.Name = "company_col";
            this.company_col.ReadOnly = true;
            // 
            // name_col
            // 
            this.name_col.HeaderText = "NAME";
            this.name_col.MinimumWidth = 6;
            this.name_col.Name = "name_col";
            this.name_col.ReadOnly = true;
            // 
            // location_col
            // 
            this.location_col.HeaderText = "LOCATION";
            this.location_col.MinimumWidth = 6;
            this.location_col.Name = "location_col";
            this.location_col.ReadOnly = true;
            // 
            // date_col
            // 
            this.date_col.HeaderText = "DATE";
            this.date_col.MinimumWidth = 6;
            this.date_col.Name = "date_col";
            this.date_col.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 16);
            this.panel1.TabIndex = 11;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.date_picker);
            this.metroPanel1.Controls.Add(this.Home_btn);
            this.metroPanel1.Controls.Add(this.Del_btn);
            this.metroPanel1.Controls.Add(this.Edit_btn);
            this.metroPanel1.Controls.Add(this.Add_btn);
            this.metroPanel1.Controls.Add(this.panel5);
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
            this.metroPanel1.Size = new System.Drawing.Size(331, 554);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // date_picker
            // 
            this.date_picker.CustomFormat = "yyyy-MM-dd";
            this.date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_picker.Location = new System.Drawing.Point(17, 219);
            this.date_picker.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(290, 32);
            this.date_picker.TabIndex = 18;
            this.date_picker.Value = new System.DateTime(2023, 7, 6, 1, 30, 6, 0);
            // 
            // Home_btn
            // 
            this.Home_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Home_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Home_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Home_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Home_btn.FillColor = System.Drawing.Color.ForestGreen;
            this.Home_btn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Home_btn.ForeColor = System.Drawing.Color.White;
            this.Home_btn.Location = new System.Drawing.Point(82, 367);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(163, 44);
            this.Home_btn.TabIndex = 17;
            this.Home_btn.Text = "Home";
            // 
            // Del_btn
            // 
            this.Del_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Del_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Del_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Del_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Del_btn.FillColor = System.Drawing.Color.ForestGreen;
            this.Del_btn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Del_btn.ForeColor = System.Drawing.Color.White;
            this.Del_btn.Location = new System.Drawing.Point(205, 293);
            this.Del_btn.Name = "Del_btn";
            this.Del_btn.Size = new System.Drawing.Size(107, 44);
            this.Del_btn.TabIndex = 16;
            this.Del_btn.Text = "Delete";
            // 
            // Edit_btn
            // 
            this.Edit_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Edit_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Edit_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Edit_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Edit_btn.FillColor = System.Drawing.Color.ForestGreen;
            this.Edit_btn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Edit_btn.ForeColor = System.Drawing.Color.White;
            this.Edit_btn.Location = new System.Drawing.Point(110, 293);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(89, 44);
            this.Edit_btn.TabIndex = 15;
            this.Edit_btn.Text = "Edit";
            // 
            // Add_btn
            // 
            this.Add_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add_btn.FillColor = System.Drawing.Color.ForestGreen;
            this.Add_btn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Add_btn.ForeColor = System.Drawing.Color.White;
            this.Add_btn.Location = new System.Drawing.Point(17, 293);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(87, 44);
            this.Add_btn.TabIndex = 14;
            this.Add_btn.Text = "Add";
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.ForestGreen;
            this.panel5.Location = new System.Drawing.Point(17, 251);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(290, 3);
            this.panel5.TabIndex = 12;
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
            this.metroSetControlBox1.Location = new System.Drawing.Point(934, 15);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 636);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroSetControlBox1);
            this.Name = "MainForm";
            this.SmallLineColor1 = System.Drawing.Color.White;
            this.SmallLineColor2 = System.Drawing.Color.White;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView datagridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn location_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_col;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DateTimePicker date_picker;
        private Guna.UI2.WinForms.Guna2Button Home_btn;
        private Guna.UI2.WinForms.Guna2Button Del_btn;
        private Guna.UI2.WinForms.Guna2Button Edit_btn;
        private Guna.UI2.WinForms.Guna2Button Add_btn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox location_tbx;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox name_tbx;
        private System.Windows.Forms.TextBox company_tbx;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
    }
}

