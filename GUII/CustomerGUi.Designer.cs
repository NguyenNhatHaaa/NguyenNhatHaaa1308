namespace QLBH_XuanHa.GUII
{
    partial class CustomerGUi
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
            this.btNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbDC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDC = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKV = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(531, 556);
            this.btNew.Margin = new System.Windows.Forms.Padding(4);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(109, 46);
            this.btNew.TabIndex = 11;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(692, 556);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(102, 46);
            this.btDelete.TabIndex = 12;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(830, 556);
            this.btEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(112, 46);
            this.btEdit.TabIndex = 13;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.BtEdit_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(992, 556);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(124, 46);
            this.btExit.TabIndex = 14;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(13, 555);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(106, 47);
            this.btRead.TabIndex = 20;
            this.btRead.Text = "Đọc";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMa,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView.Location = new System.Drawing.Point(5, 223);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1111, 315);
            this.dataGridView.TabIndex = 21;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColMa
            // 
            this.ColMa.HeaderText = "Mã Khách Hàng";
            this.ColMa.MinimumWidth = 6;
            this.ColMa.Name = "ColMa";
            this.ColMa.Width = 170;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên Khách Hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 170;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số Điện Thoại Khách Hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Địa Chỉ Khách Hàng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 170;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Email Khách Hàng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 170;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Khu Vực Khách Hàng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(758, 119);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(269, 22);
            this.tbEmail.TabIndex = 33;
            // 
            // tbDC
            // 
            this.tbDC.Location = new System.Drawing.Point(758, 69);
            this.tbDC.Margin = new System.Windows.Forms.Padding(4);
            this.tbDC.Name = "tbDC";
            this.tbDC.Size = new System.Drawing.Size(269, 22);
            this.tbDC.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(569, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "Email Khách Hàng:";
            // 
            // lbDC
            // 
            this.lbDC.AutoSize = true;
            this.lbDC.BackColor = System.Drawing.Color.Transparent;
            this.lbDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDC.Location = new System.Drawing.Point(556, 73);
            this.lbDC.Name = "lbDC";
            this.lbDC.Size = new System.Drawing.Size(164, 18);
            this.lbDC.TabIndex = 30;
            this.lbDC.Text = "Địa Chỉ Khách Hàng:";
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(310, 159);
            this.tbSDT.Margin = new System.Windows.Forms.Padding(4);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(211, 22);
            this.tbSDT.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(165, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Điện Thoại:";
            // 
            // cbKV
            // 
            this.cbKV.FormattingEnabled = true;
            this.cbKV.Items.AddRange(new object[] {
            "Thành phố Hà Nội",
            "Thành phố Hồ Chí Minh",
            "Thành phố Hải Phòng",
            "Thành phố Đà Nẵng",
            "Thành phố Cần Thơ",
            "Tỉnh Hà Giang",
            "Tỉnh Cao Bằng",
            "Tỉnh Lai Châu",
            "Tỉnh Lào Cai",
            "Tỉnh Tuyên Quang",
            "Tỉnh Lạng Sơn",
            "Tỉnh Bắc Kạn",
            "Tỉnh Thái Nguyên",
            "Tỉnh Phú Thọ",
            "Tỉnh Yên Bái",
            "Tỉnh Sơn La",
            "Tỉnh Hòa Bình",
            "Tỉnh Thanh Hóa",
            "Tỉnh Nghệ An",
            "Tỉnh Hà Tĩnh",
            "Tỉnh Quảng Bình",
            "Tỉnh Quảng Trị",
            "Tỉnh Thừa Thiên-Huế",
            "Tỉnh Quảng Nam",
            "Tỉnh Quảng Ngãi",
            "Tỉnh Bình Định",
            "Tỉnh Phú Yên",
            "Tỉnh Khánh Hòa",
            "Tỉnh Ninh Thuận",
            "Tỉnh Bình Thuận",
            "Tỉnh Kon Tum",
            "Tỉnh Gia Lai",
            "Tỉnh Đắk Lắk",
            "Tỉnh Đắk Nông",
            "Tỉnh Lâm Đồng",
            "Tỉnh Bình Phước",
            "Tỉnh Tây Ninh",
            "Tỉnh Bình Dương",
            "Tỉnh Đồng Nai",
            "Tỉnh Bà Rịa-Vũng Tàu",
            "Tỉnh Long An",
            "Tỉnh Tiền Giang",
            "Tỉnh Bến Tre",
            "Tỉnh Trà Vinh",
            "Tỉnh Vĩnh Long",
            "Tỉnh Đồng Tháp",
            "Tỉnh An Giang",
            "Tỉnh Kiên Giang",
            "Tỉnh Cần Thơ",
            "Tỉnh Hậu Giang",
            "Tỉnh Sóc Trăng",
            "Tỉnh Bạc Liêu",
            "Tỉnh Cà Mau",
            "Tỉnh Tuyên Quang",
            "Tỉnh Bắc Giang",
            "Tỉnh Bắc Ninh",
            "Tỉnh Hà Nam",
            "Tỉnh Hưng Yên",
            "Tỉnh Nam Định",
            "Tỉnh Thái Bình",
            "Tỉnh Vĩnh Phúc",
            "Tỉnh Ninh Bình",
            "Tỉnh Phú Thọ"});
            this.cbKV.Location = new System.Drawing.Point(758, 165);
            this.cbKV.Name = "cbKV";
            this.cbKV.Size = new System.Drawing.Size(269, 24);
            this.cbKV.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(549, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Khu Vực Khách Hàng:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(310, 118);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(211, 22);
            this.tbName.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(122, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên Khách Hàng:";
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(310, 73);
            this.tbMa.Margin = new System.Windows.Forms.Padding(4);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(217, 22);
            this.tbMa.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(129, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã Khách Hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(479, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "Khách Hàng ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustomerGUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1128, 615);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbDC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbDC);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbKV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btNew);
            this.Name = "CustomerGUi";
            this.Text = "CustomerGUi";
            this.Load += new System.EventHandler(this.CustomerGUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbDC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDC;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}