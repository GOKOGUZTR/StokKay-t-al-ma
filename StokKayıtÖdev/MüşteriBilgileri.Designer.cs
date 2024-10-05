namespace StokKayıtÖdev
{
    partial class MüşteriBilgileri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müşteri1234BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vERİALMA1234DataSet3 = new StokKayıtÖdev.VERİALMA1234DataSet3();
            this.müşteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stok_TakipDataSet = new StokKayıtÖdev.Stok_TakipDataSet();
            this.müşteriTableAdapter = new StokKayıtÖdev.Stok_TakipDataSetTableAdapters.müşteriTableAdapter();
            this.Listele = new System.Windows.Forms.Button();
            this.vERİALMA1234DataSet2 = new StokKayıtÖdev.VERİALMA1234DataSet2();
            this.müşteri1234BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.müşteri1234TableAdapter = new StokKayıtÖdev.VERİALMA1234DataSet2TableAdapters.müşteri1234TableAdapter();
            this.müşteri1234TableAdapter1 = new StokKayıtÖdev.VERİALMA1234DataSet3TableAdapters.müşteri1234TableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.müşteri1234BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vERİALMA1234DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.müşteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vERİALMA1234DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.müşteri1234BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(292, 277);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 204);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Adres:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(83, 82);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 8;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(83, 12);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 22);
            this.txtTc.TabIndex = 6;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(83, 51);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtAdSoyad.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcDataGridViewTextBoxColumn,
            this.adSoyadDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.müşteri1234BindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(262, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(517, 259);
            this.dataGridView1.TabIndex = 11;
            // 
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "tc";
            this.tcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            this.tcDataGridViewTextBoxColumn.Width = 125;
            // 
            // adSoyadDataGridViewTextBoxColumn
            // 
            this.adSoyadDataGridViewTextBoxColumn.DataPropertyName = "ad soyad";
            this.adSoyadDataGridViewTextBoxColumn.HeaderText = "ad soyad";
            this.adSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adSoyadDataGridViewTextBoxColumn.Name = "adSoyadDataGridViewTextBoxColumn";
            this.adSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // müşteri1234BindingSource1
            // 
            this.müşteri1234BindingSource1.DataMember = "müşteri1234";
            this.müşteri1234BindingSource1.DataSource = this.vERİALMA1234DataSet3;
            // 
            // vERİALMA1234DataSet3
            // 
            this.vERİALMA1234DataSet3.DataSetName = "VERİALMA1234DataSet3";
            this.vERİALMA1234DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // müşteriBindingSource
            // 
            this.müşteriBindingSource.DataMember = "müşteri";
            this.müşteriBindingSource.DataSource = this.stok_TakipDataSet;
            // 
            // stok_TakipDataSet
            // 
            this.stok_TakipDataSet.DataSetName = "Stok_TakipDataSet";
            this.stok_TakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // müşteriTableAdapter
            // 
            this.müşteriTableAdapter.ClearBeforeFill = true;
            // 
            // Listele
            // 
            this.Listele.Location = new System.Drawing.Point(399, 277);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(75, 23);
            this.Listele.TabIndex = 18;
            this.Listele.Text = "Listele";
            this.Listele.UseVisualStyleBackColor = true;
            this.Listele.Click += new System.EventHandler(this.Listele_Click);
            // 
            // vERİALMA1234DataSet2
            // 
            this.vERİALMA1234DataSet2.DataSetName = "VERİALMA1234DataSet2";
            this.vERİALMA1234DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // müşteri1234BindingSource
            // 
            this.müşteri1234BindingSource.DataMember = "müşteri1234";
            this.müşteri1234BindingSource.DataSource = this.vERİALMA1234DataSet2;
            // 
            // müşteri1234TableAdapter
            // 
            this.müşteri1234TableAdapter.ClearBeforeFill = true;
            // 
            // müşteri1234TableAdapter1
            // 
            this.müşteri1234TableAdapter1.ClearBeforeFill = true;
            // 
            // MüşteriBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(873, 315);
            this.Controls.Add(this.Listele);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MüşteriBilgileri";
            this.Text = "Müşteri_Bilgileri";
            this.Load += new System.EventHandler(this.MüşteriBilgileri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.müşteri1234BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vERİALMA1234DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.müşteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vERİALMA1234DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.müşteri1234BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private Stok_TakipDataSet stok_TakipDataSet;
        private System.Windows.Forms.BindingSource müşteriBindingSource;
        private Stok_TakipDataSetTableAdapters.müşteriTableAdapter müşteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Listele;
        private VERİALMA1234DataSet2 vERİALMA1234DataSet2;
        private System.Windows.Forms.BindingSource müşteri1234BindingSource;
        private VERİALMA1234DataSet2TableAdapters.müşteri1234TableAdapter müşteri1234TableAdapter;
        private VERİALMA1234DataSet3 vERİALMA1234DataSet3;
        private System.Windows.Forms.BindingSource müşteri1234BindingSource1;
        private VERİALMA1234DataSet3TableAdapters.müşteri1234TableAdapter müşteri1234TableAdapter1;
    }
}