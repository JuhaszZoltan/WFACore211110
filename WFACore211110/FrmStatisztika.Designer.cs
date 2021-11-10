namespace WFACore211110
{
    partial class FrmStatisztika
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStat = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.nudHonap = new System.Windows.Forms.NumericUpDown();
            this.cbMunkas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSzinDB = new System.Windows.Forms.TextBox();
            this.tbSulySum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHonap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Munkás neve:";
            // 
            // dgvStat
            // 
            this.dgvStat.AllowUserToAddRows = false;
            this.dgvStat.AllowUserToDeleteRows = false;
            this.dgvStat.AllowUserToResizeColumns = false;
            this.dgvStat.AllowUserToResizeRows = false;
            this.dgvStat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStat.BackgroundColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvStat.Location = new System.Drawing.Point(12, 110);
            this.dgvStat.Name = "dgvStat";
            this.dgvStat.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCoral;
            this.dgvStat.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStat.RowTemplate.Height = 25;
            this.dgvStat.Size = new System.Drawing.Size(690, 251);
            this.dgvStat.TabIndex = 1;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hónap sorszáma:";
            // 
            // nudHonap
            // 
            this.nudHonap.BackColor = System.Drawing.Color.LightCoral;
            this.nudHonap.Location = new System.Drawing.Point(643, 25);
            this.nudHonap.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudHonap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHonap.Name = "nudHonap";
            this.nudHonap.Size = new System.Drawing.Size(59, 29);
            this.nudHonap.TabIndex = 2;
            this.nudHonap.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudHonap.ValueChanged += new System.EventHandler(this.NudHonap_ValueChanged);
            // 
            // cbMunkas
            // 
            this.cbMunkas.BackColor = System.Drawing.Color.LightCoral;
            this.cbMunkas.FormattingEnabled = true;
            this.cbMunkas.Location = new System.Drawing.Point(135, 24);
            this.cbMunkas.Name = "cbMunkas";
            this.cbMunkas.Size = new System.Drawing.Size(261, 29);
            this.cbMunkas.TabIndex = 3;
            this.cbMunkas.SelectedIndexChanged += new System.EventHandler(this.CbMunkas_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Termelési napló:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 385);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "A hónapban legtöbbet gyártott tojás színe: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 427);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(335, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adott hónapban termelt tojások összsúlya:";
            // 
            // tbSzinDB
            // 
            this.tbSzinDB.BackColor = System.Drawing.Color.LightCoral;
            this.tbSzinDB.Location = new System.Drawing.Point(517, 377);
            this.tbSzinDB.Name = "tbSzinDB";
            this.tbSzinDB.Size = new System.Drawing.Size(185, 29);
            this.tbSzinDB.TabIndex = 4;
            // 
            // tbSulySum
            // 
            this.tbSulySum.BackColor = System.Drawing.Color.LightCoral;
            this.tbSulySum.Location = new System.Drawing.Point(517, 424);
            this.tbSulySum.Name = "tbSulySum";
            this.tbSulySum.Size = new System.Drawing.Size(185, 29);
            this.tbSulySum.TabIndex = 4;
            // 
            // FrmStatisztika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(714, 475);
            this.Controls.Add(this.tbSulySum);
            this.Controls.Add(this.tbSzinDB);
            this.Controls.Add(this.cbMunkas);
            this.Controls.Add(this.nudHonap);
            this.Controls.Add(this.dgvStat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStatisztika";
            this.Text = "FrmStatisztika";
            this.Load += new System.EventHandler(this.FrmStatisztika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHonap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgvStat;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label2;
        private NumericUpDown nudHonap;
        private ComboBox cbMunkas;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbSzinDB;
        private TextBox tbSulySum;
    }
}