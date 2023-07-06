namespace sqlite_test
{
    partial class Form1
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
            this.add_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.company_tbx = new System.Windows.Forms.TextBox();
            this.name_tbx = new System.Windows.Forms.TextBox();
            this.location_tbx = new System.Windows.Forms.TextBox();
            this.company_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.location_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ok_btn = new System.Windows.Forms.Button();
            this.search_tbx = new System.Windows.Forms.TextBox();
            this.Search_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(47, 290);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(150, 56);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(214, 290);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(155, 56);
            this.del_btn.TabIndex = 2;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // company_tbx
            // 
            this.company_tbx.Location = new System.Drawing.Point(47, 76);
            this.company_tbx.Name = "company_tbx";
            this.company_tbx.Size = new System.Drawing.Size(322, 25);
            this.company_tbx.TabIndex = 3;
            // 
            // name_tbx
            // 
            this.name_tbx.Location = new System.Drawing.Point(47, 149);
            this.name_tbx.Name = "name_tbx";
            this.name_tbx.Size = new System.Drawing.Size(322, 25);
            this.name_tbx.TabIndex = 4;
            // 
            // location_tbx
            // 
            this.location_tbx.Location = new System.Drawing.Point(47, 221);
            this.location_tbx.Name = "location_tbx";
            this.location_tbx.Size = new System.Drawing.Size(322, 25);
            this.location_tbx.TabIndex = 5;
            // 
            // company_label
            // 
            this.company_label.Location = new System.Drawing.Point(44, 47);
            this.company_label.Name = "company_label";
            this.company_label.Size = new System.Drawing.Size(95, 26);
            this.company_label.TabIndex = 6;
            this.company_label.Text = "COMPANY";
            this.company_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name_label
            // 
            this.name_label.Location = new System.Drawing.Point(44, 120);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(153, 26);
            this.name_label.TabIndex = 7;
            this.name_label.Text = "MEDICINE NAME";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // location_label
            // 
            this.location_label.Location = new System.Drawing.Point(44, 192);
            this.location_label.Name = "location_label";
            this.location_label.Size = new System.Drawing.Size(153, 26);
            this.location_label.TabIndex = 8;
            this.location_label.Text = "LOCATION";
            this.location_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(427, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(579, 391);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(918, 47);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(88, 28);
            this.ok_btn.TabIndex = 10;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // search_tbx
            // 
            this.search_tbx.Location = new System.Drawing.Point(503, 50);
            this.search_tbx.Name = "search_tbx";
            this.search_tbx.Size = new System.Drawing.Size(399, 25);
            this.search_tbx.TabIndex = 11;
            // 
            // Search_label
            // 
            this.Search_label.Location = new System.Drawing.Point(424, 50);
            this.Search_label.Name = "Search_label";
            this.Search_label.Size = new System.Drawing.Size(73, 26);
            this.Search_label.TabIndex = 12;
            this.Search_label.Text = "SEARCH";
            this.Search_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 527);
            this.Controls.Add(this.Search_label);
            this.Controls.Add(this.search_tbx);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.location_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.company_label);
            this.Controls.Add(this.location_tbx);
            this.Controls.Add(this.name_tbx);
            this.Controls.Add(this.company_tbx);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.add_btn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.TextBox company_tbx;
        private System.Windows.Forms.TextBox name_tbx;
        private System.Windows.Forms.TextBox location_tbx;
        private System.Windows.Forms.Label company_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label location_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.TextBox search_tbx;
        private System.Windows.Forms.Label Search_label;
    }
}

