namespace QLBH_XuanHa.GUII
{
    partial class SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            this.btRead = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.dgvsp = new System.Windows.Forms.DataGridView();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKC = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btFile = new System.Windows.Forms.Button();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lbquantity_in_stock = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbten = new System.Windows.Forms.Label();
            this.lbma = new System.Windows.Forms.Label();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(12, 557);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(120, 37);
            this.btRead.TabIndex = 19;
            this.btRead.Text = "Đọc ";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(640, 557);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(108, 37);
            this.btNew.TabIndex = 20;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(771, 557);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(108, 37);
            this.btDelete.TabIndex = 21;
            this.btDelete.Text = "Xoá";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(885, 557);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(108, 37);
            this.btEdit.TabIndex = 22;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(1010, 557);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(108, 37);
            this.btExit.TabIndex = 23;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // dgvsp
            // 
            this.dgvsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colName,
            this.colPrice,
            this.colQuantityInStock,
            this.colImage,
            this.ColKC});
            this.dgvsp.Location = new System.Drawing.Point(12, 258);
            this.dgvsp.Name = "dgvsp";
            this.dgvsp.RowHeadersWidth = 51;
            this.dgvsp.RowTemplate.Height = 24;
            this.dgvsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsp.Size = new System.Drawing.Size(1117, 293);
            this.dgvsp.TabIndex = 24;
            this.dgvsp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsp_CellContentClick_1);
            // 
            // colProductID
            // 
            this.colProductID.HeaderText = "Mã Điện Thoại";
            this.colProductID.MinimumWidth = 6;
            this.colProductID.Name = "colProductID";
            this.colProductID.Width = 150;
            // 
            // colName
            // 
            this.colName.HeaderText = "Tên Điện Thoại";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 200;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Giá Điện Thoại";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 200;
            // 
            // colQuantityInStock
            // 
            this.colQuantityInStock.HeaderText = "Số Lượng";
            this.colQuantityInStock.MinimumWidth = 6;
            this.colQuantityInStock.Name = "colQuantityInStock";
            this.colQuantityInStock.Width = 200;
            // 
            // colImage
            // 
            this.colImage.HeaderText = "Hình";
            this.colImage.MinimumWidth = 6;
            this.colImage.Name = "colImage";
            this.colImage.Width = 200;
            // 
            // ColKC
            // 
            this.ColKC.HeaderText = "Ký Hiệu Mã Màu";
            this.ColKC.MinimumWidth = 6;
            this.ColKC.Name = "ColKC";
            this.ColKC.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 32);
            this.button1.TabIndex = 50;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(270, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 49;
            this.label3.Text = "Ký Hiệu Mã Màu:";
            // 
            // cbKC
            // 
            this.cbKC.FormattingEnabled = true;
            this.cbKC.Items.AddRange(new object[] {
            "X",
            "S",
            "M",
            "Xl"});
            this.cbKC.Location = new System.Drawing.Point(449, 189);
            this.cbKC.Name = "cbKC";
            this.cbKC.Size = new System.Drawing.Size(121, 24);
            this.cbKC.TabIndex = 48;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 28);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(220, 159);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 47;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // btFile
            // 
            this.btFile.Location = new System.Drawing.Point(64, 193);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(88, 33);
            this.btFile.TabIndex = 46;
            this.btFile.Text = "chọn ảnh";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click_1);
            // 
            // tbSL
            // 
            this.tbSL.Location = new System.Drawing.Point(830, 135);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(232, 22);
            this.tbSL.TabIndex = 45;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(449, 136);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(232, 22);
            this.txtGia.TabIndex = 44;
            this.txtGia.TextChanged += new System.EventHandler(this.txtGia_TextChanged);
            // 
            // lbquantity_in_stock
            // 
            this.lbquantity_in_stock.AutoSize = true;
            this.lbquantity_in_stock.BackColor = System.Drawing.Color.Transparent;
            this.lbquantity_in_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbquantity_in_stock.Location = new System.Drawing.Point(717, 140);
            this.lbquantity_in_stock.Name = "lbquantity_in_stock";
            this.lbquantity_in_stock.Size = new System.Drawing.Size(85, 18);
            this.lbquantity_in_stock.TabIndex = 43;
            this.lbquantity_in_stock.Text = "Số Lượng:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPrice.Location = new System.Drawing.Point(276, 140);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(125, 18);
            this.lbPrice.TabIndex = 42;
            this.lbPrice.Text = "Giá Điện Thoại:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(830, 88);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(232, 22);
            this.tbName.TabIndex = 41;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.BackColor = System.Drawing.Color.Transparent;
            this.lbten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbten.Location = new System.Drawing.Point(675, 89);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(127, 18);
            this.lbten.TabIndex = 40;
            this.lbten.Text = "Tên Điện Thoai:";
            // 
            // lbma
            // 
            this.lbma.AutoSize = true;
            this.lbma.BackColor = System.Drawing.Color.Transparent;
            this.lbma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbma.Location = new System.Drawing.Point(281, 89);
            this.lbma.Name = "lbma";
            this.lbma.Size = new System.Drawing.Size(127, 18);
            this.lbma.TabIndex = 39;
            this.lbma.Text = "Mã Điện Thoại: ";
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(437, 85);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(232, 22);
            this.tbMa.TabIndex = 38;
            this.tbMa.TextChanged += new System.EventHandler(this.tbMa_TextChanged_1);
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(429, 605);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(10, 22);
            this.txtTK.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(585, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 53;
            this.label1.Text = "Sản Phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 615);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbKC);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.tbSL);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.lbquantity_in_stock);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbten);
            this.Controls.Add(this.lbma);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.dgvsp);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.btRead);
            this.Name = "SanPham";
            this.Text = "gd";
            this.Load += new System.EventHandler(this.gd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dgvsp_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
           
        }

        #endregion
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DataGridView dgvsp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKC;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btFile;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lbquantity_in_stock;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.Label lbma;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantityInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKC;
        private System.Windows.Forms.Label label1;
    }
}