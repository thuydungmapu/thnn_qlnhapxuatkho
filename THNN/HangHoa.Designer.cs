namespace THNN
{
    partial class HangHoa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txttenloai1 = new System.Windows.Forms.TextBox();
            this.lOAIHANGHOABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tHNNDataSetLHH1 = new THNN.THNNDataSetLHH1();
            this.ccblhh1 = new System.Windows.Forms.ComboBox();
            this.txttenloai = new System.Windows.Forms.TextBox();
            this.lOAIHANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHNNDataSetLHH_HH = new THNN.THNNDataSetLHH_HH();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbmota = new System.Windows.Forms.RichTextBox();
            this.hANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHNNDataSetHH_HH = new THNN.THNNDataSetHH_HH();
            this.txtdvt = new System.Windows.Forms.TextBox();
            this.txttenhh = new System.Windows.Forms.TextBox();
            this.txtmahh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ccblhh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mAHHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mALOAIHHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENHHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hANGHOATableAdapter = new THNN.THNNDataSetHH_HHTableAdapters.HANGHOATableAdapter();
            this.lOAIHANGHOATableAdapter = new THNN.THNNDataSetLHH_HHTableAdapters.LOAIHANGHOATableAdapter();
            this.lOAIHANGHOATableAdapter1 = new THNN.THNNDataSetLHH1TableAdapters.LOAIHANGHOATableAdapter();
            this.lblHotennv = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIHANGHOABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHNNDataSetLHH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIHANGHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHNNDataSetLHH_HH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHNNDataSetHH_HH)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txttenloai1);
            this.groupBox1.Controls.Add(this.ccblhh1);
            this.groupBox1.Controls.Add(this.txttenloai);
            this.groupBox1.Controls.Add(this.txtmaloai);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rtbmota);
            this.groupBox1.Controls.Add(this.txtdvt);
            this.groupBox1.Controls.Add(this.txttenhh);
            this.groupBox1.Controls.Add(this.txtmahh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hàng hóa";
            // 
            // Txttenloai1
            // 
            this.Txttenloai1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAIHANGHOABindingSource1, "TENLOAIHH", true));
            this.Txttenloai1.Location = new System.Drawing.Point(161, 66);
            this.Txttenloai1.Name = "Txttenloai1";
            this.Txttenloai1.Size = new System.Drawing.Size(241, 26);
            this.Txttenloai1.TabIndex = 16;
            this.Txttenloai1.Visible = false;
            // 
            // lOAIHANGHOABindingSource1
            // 
            this.lOAIHANGHOABindingSource1.DataMember = "LOAIHANGHOA";
            this.lOAIHANGHOABindingSource1.DataSource = this.tHNNDataSetLHH1;
            // 
            // tHNNDataSetLHH1
            // 
            this.tHNNDataSetLHH1.DataSetName = "THNNDataSetLHH1";
            this.tHNNDataSetLHH1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ccblhh1
            // 
            this.ccblhh1.DataSource = this.lOAIHANGHOABindingSource1;
            this.ccblhh1.DisplayMember = "MALOAIHH";
            this.ccblhh1.FormattingEnabled = true;
            this.ccblhh1.Location = new System.Drawing.Point(161, 26);
            this.ccblhh1.Name = "ccblhh1";
            this.ccblhh1.Size = new System.Drawing.Size(241, 28);
            this.ccblhh1.TabIndex = 15;
            this.ccblhh1.ValueMember = "MALOAIHH";
            this.ccblhh1.Visible = false;
            // 
            // txttenloai
            // 
            this.txttenloai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAIHANGHOABindingSource, "TENLOAIHH", true));
            this.txttenloai.Enabled = false;
            this.txttenloai.Location = new System.Drawing.Point(161, 66);
            this.txttenloai.Name = "txttenloai";
            this.txttenloai.Size = new System.Drawing.Size(241, 26);
            this.txttenloai.TabIndex = 14;
            // 
            // lOAIHANGHOABindingSource
            // 
            this.lOAIHANGHOABindingSource.DataMember = "LOAIHANGHOA";
            this.lOAIHANGHOABindingSource.DataSource = this.tHNNDataSetLHH_HH;
            // 
            // tHNNDataSetLHH_HH
            // 
            this.tHNNDataSetLHH_HH.DataSetName = "THNNDataSetLHH_HH";
            this.tHNNDataSetLHH_HH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtmaloai
            // 
            this.txtmaloai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAIHANGHOABindingSource, "MALOAIHH", true));
            this.txtmaloai.Enabled = false;
            this.txtmaloai.Location = new System.Drawing.Point(161, 28);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(241, 26);
            this.txtmaloai.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mã loại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tên loại:";
            // 
            // rtbmota
            // 
            this.rtbmota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hANGHOABindingSource, "MOTA", true));
            this.rtbmota.Enabled = false;
            this.rtbmota.Location = new System.Drawing.Point(578, 69);
            this.rtbmota.Name = "rtbmota";
            this.rtbmota.Size = new System.Drawing.Size(326, 67);
            this.rtbmota.TabIndex = 10;
            this.rtbmota.Text = "";
            // 
            // hANGHOABindingSource
            // 
            this.hANGHOABindingSource.DataMember = "HANGHOA";
            this.hANGHOABindingSource.DataSource = this.tHNNDataSetHH_HH;
            // 
            // tHNNDataSetHH_HH
            // 
            this.tHNNDataSetHH_HH.DataSetName = "THNNDataSetHH_HH";
            this.tHNNDataSetHH_HH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtdvt
            // 
            this.txtdvt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hANGHOABindingSource, "DVT", true));
            this.txtdvt.Enabled = false;
            this.txtdvt.Location = new System.Drawing.Point(578, 25);
            this.txtdvt.Name = "txtdvt";
            this.txtdvt.Size = new System.Drawing.Size(241, 26);
            this.txtdvt.TabIndex = 9;
            // 
            // txttenhh
            // 
            this.txttenhh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hANGHOABindingSource, "TENHH", true));
            this.txttenhh.Enabled = false;
            this.txttenhh.Location = new System.Drawing.Point(161, 141);
            this.txttenhh.Name = "txttenhh";
            this.txttenhh.Size = new System.Drawing.Size(241, 26);
            this.txttenhh.TabIndex = 8;
            // 
            // txtmahh
            // 
            this.txtmahh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hANGHOABindingSource, "MAHH", true));
            this.txtmahh.Enabled = false;
            this.txtmahh.Location = new System.Drawing.Point(161, 103);
            this.txtmahh.Name = "txtmahh";
            this.txtmahh.Size = new System.Drawing.Size(241, 26);
            this.txtmahh.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mô tả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đơn vị tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã hàng hóa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên hàng hóa:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Highlight;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(800, 530);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 54);
            this.button4.TabIndex = 15;
            this.button4.Text = "THOÁT";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(579, 530);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(119, 54);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(373, 530);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(126, 54);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "SỬA";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(167, 530);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(117, 54);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ccblhh);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(921, 311);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thông tin hàng hóa";
            // 
            // ccblhh
            // 
            this.ccblhh.DataSource = this.lOAIHANGHOABindingSource;
            this.ccblhh.DisplayMember = "TENLOAIHH";
            this.ccblhh.FormattingEnabled = true;
            this.ccblhh.Location = new System.Drawing.Point(139, 26);
            this.ccblhh.Name = "ccblhh";
            this.ccblhh.Size = new System.Drawing.Size(211, 28);
            this.ccblhh.TabIndex = 4;
            this.ccblhh.ValueMember = "MALOAIHH";
            this.ccblhh.SelectedIndexChanged += new System.EventHandler(this.ccblhh_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Loại hàng hóa:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAHHDataGridViewTextBoxColumn,
            this.mALOAIHHDataGridViewTextBoxColumn,
            this.tENHHDataGridViewTextBoxColumn,
            this.dVTDataGridViewTextBoxColumn,
            this.mOTADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hANGHOABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(880, 230);
            this.dataGridView1.TabIndex = 2;
            // 
            // mAHHDataGridViewTextBoxColumn
            // 
            this.mAHHDataGridViewTextBoxColumn.DataPropertyName = "MAHH";
            this.mAHHDataGridViewTextBoxColumn.HeaderText = "Mã hàng hóa";
            this.mAHHDataGridViewTextBoxColumn.Name = "mAHHDataGridViewTextBoxColumn";
            // 
            // mALOAIHHDataGridViewTextBoxColumn
            // 
            this.mALOAIHHDataGridViewTextBoxColumn.DataPropertyName = "MALOAIHH";
            this.mALOAIHHDataGridViewTextBoxColumn.HeaderText = "Mã loại hàng hóa";
            this.mALOAIHHDataGridViewTextBoxColumn.Name = "mALOAIHHDataGridViewTextBoxColumn";
            // 
            // tENHHDataGridViewTextBoxColumn
            // 
            this.tENHHDataGridViewTextBoxColumn.DataPropertyName = "TENHH";
            this.tENHHDataGridViewTextBoxColumn.HeaderText = "Tên hàng hóa";
            this.tENHHDataGridViewTextBoxColumn.Name = "tENHHDataGridViewTextBoxColumn";
            // 
            // dVTDataGridViewTextBoxColumn
            // 
            this.dVTDataGridViewTextBoxColumn.DataPropertyName = "DVT";
            this.dVTDataGridViewTextBoxColumn.HeaderText = "ĐVT";
            this.dVTDataGridViewTextBoxColumn.Name = "dVTDataGridViewTextBoxColumn";
            // 
            // mOTADataGridViewTextBoxColumn
            // 
            this.mOTADataGridViewTextBoxColumn.DataPropertyName = "MOTA";
            this.mOTADataGridViewTextBoxColumn.HeaderText = "Mô tả";
            this.mOTADataGridViewTextBoxColumn.Name = "mOTADataGridViewTextBoxColumn";
            // 
            // hANGHOATableAdapter
            // 
            this.hANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // lOAIHANGHOATableAdapter
            // 
            this.lOAIHANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // lOAIHANGHOATableAdapter1
            // 
            this.lOAIHANGHOATableAdapter1.ClearBeforeFill = true;
            // 
            // lblHotennv
            // 
            this.lblHotennv.AutoSize = true;
            this.lblHotennv.Location = new System.Drawing.Point(710, 9);
            this.lblHotennv.Name = "lblHotennv";
            this.lblHotennv.Size = new System.Drawing.Size(51, 20);
            this.lblHotennv.TabIndex = 17;
            this.lblHotennv.Text = "label8";
            // 
            // HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 589);
            this.Controls.Add(this.lblHotennv);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnxoa);
            this.Name = "HangHoa";
            this.Text = "HangHoa";
            this.Load += new System.EventHandler(this.HangHoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIHANGHOABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHNNDataSetLHH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIHANGHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHNNDataSetLHH_HH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHNNDataSetHH_HH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbmota;
        private System.Windows.Forms.TextBox txtdvt;
        private System.Windows.Forms.TextBox txttenhh;
        private System.Windows.Forms.TextBox txtmahh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenloai;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private THNNDataSetHH_HH tHNNDataSetHH_HH;
        private System.Windows.Forms.BindingSource hANGHOABindingSource;
        private THNNDataSetHH_HHTableAdapters.HANGHOATableAdapter hANGHOATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mALOAIHHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENHHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOTADataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox ccblhh;
        private System.Windows.Forms.Label label7;
        private THNNDataSetLHH_HH tHNNDataSetLHH_HH;
        private System.Windows.Forms.BindingSource lOAIHANGHOABindingSource;
        private THNNDataSetLHH_HHTableAdapters.LOAIHANGHOATableAdapter lOAIHANGHOATableAdapter;
        private System.Windows.Forms.ComboBox ccblhh1;
        private System.Windows.Forms.TextBox Txttenloai1;
        private THNNDataSetLHH1 tHNNDataSetLHH1;
        private System.Windows.Forms.BindingSource lOAIHANGHOABindingSource1;
        private THNNDataSetLHH1TableAdapters.LOAIHANGHOATableAdapter lOAIHANGHOATableAdapter1;
        private System.Windows.Forms.Label lblHotennv;
    }
}