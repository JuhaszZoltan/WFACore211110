namespace WFACore211110
{
    partial class FrmTermeles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTermeles = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbUj = new System.Windows.Forms.GroupBox();
            this.nudDB = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMunkas = new System.Windows.Forms.ComboBox();
            this.cbTojas = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermeles)).BeginInit();
            this.gbUj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTermeles
            // 
            this.dgvTermeles.AllowUserToAddRows = false;
            this.dgvTermeles.AllowUserToDeleteRows = false;
            this.dgvTermeles.AllowUserToResizeColumns = false;
            this.dgvTermeles.AllowUserToResizeRows = false;
            this.dgvTermeles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTermeles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTermeles.BackgroundColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTermeles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTermeles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermeles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvTermeles.Location = new System.Drawing.Point(12, 12);
            this.dgvTermeles.Name = "dgvTermeles";
            this.dgvTermeles.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightCoral;
            this.dgvTermeles.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTermeles.RowTemplate.Height = 25;
            this.dgvTermeles.Size = new System.Drawing.Size(749, 249);
            this.dgvTermeles.TabIndex = 0;
            // 
            // Column1
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column1.FillWeight = 3F;
            this.Column1.HeaderText = "Dátum";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 3F;
            this.Column2.HeaderText = "Tojás színe";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 2F;
            this.Column3.HeaderText = "Mennyiség";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 4F;
            this.Column4.HeaderText = "Munkás";
            this.Column4.Name = "Column4";
            // 
            // gbUj
            // 
            this.gbUj.BackColor = System.Drawing.Color.LightCoral;
            this.gbUj.Controls.Add(this.nudDB);
            this.gbUj.Controls.Add(this.label4);
            this.gbUj.Controls.Add(this.label3);
            this.gbUj.Controls.Add(this.label2);
            this.gbUj.Controls.Add(this.label1);
            this.gbUj.Controls.Add(this.cbMunkas);
            this.gbUj.Controls.Add(this.cbTojas);
            this.gbUj.Controls.Add(this.dtpDatum);
            this.gbUj.Controls.Add(this.btnInsert);
            this.gbUj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbUj.Location = new System.Drawing.Point(12, 289);
            this.gbUj.Name = "gbUj";
            this.gbUj.Size = new System.Drawing.Size(749, 185);
            this.gbUj.TabIndex = 1;
            this.gbUj.TabStop = false;
            this.gbUj.Text = "Új bejegyzés:";
            // 
            // nudDB
            // 
            this.nudDB.Location = new System.Drawing.Point(327, 67);
            this.nudDB.Name = "nudDB";
            this.nudDB.Size = new System.Drawing.Size(78, 29);
            this.nudDB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Munkás:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mennyiség:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tojás:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dátum:";
            // 
            // cbMunkas
            // 
            this.cbMunkas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMunkas.FormattingEnabled = true;
            this.cbMunkas.Location = new System.Drawing.Point(444, 66);
            this.cbMunkas.Name = "cbMunkas";
            this.cbMunkas.Size = new System.Drawing.Size(299, 29);
            this.cbMunkas.TabIndex = 2;
            // 
            // cbTojas
            // 
            this.cbTojas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTojas.FormattingEnabled = true;
            this.cbTojas.Location = new System.Drawing.Point(191, 67);
            this.cbTojas.Name = "cbTojas";
            this.cbTojas.Size = new System.Drawing.Size(104, 29);
            this.cbTojas.TabIndex = 2;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(6, 67);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(148, 29);
            this.dtpDatum.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Red;
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(6, 116);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(737, 56);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Új bejegyzés felvétele";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // FrmTermeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(774, 496);
            this.Controls.Add(this.gbUj);
            this.Controls.Add(this.dgvTermeles);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTermeles";
            this.Text = "FrmTermeles";
            this.Load += new System.EventHandler(this.FrmTermeles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermeles)).EndInit();
            this.gbUj.ResumeLayout(false);
            this.gbUj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvTermeles;
        private GroupBox gbUj;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ComboBox cbTojas;
        private DateTimePicker dtpDatum;
        private Button btnInsert;
        private NumericUpDown nudDB;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbMunkas;
    }
}