namespace TradingSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            dtpDateFrom = new DateTimePicker();
            dtpDateTo = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            txtBoxSecurity = new TextBox();
            label3 = new Label();
            cmbPortfolio = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cmbState = new ComboBox();
            label6 = new Label();
            cmbType = new ComboBox();
            btnGetTrades = new Button();
            btnConfirmTrade = new Button();
            btnCalPos = new Button();
            Portfolio = new Label();
            label8 = new Label();
            txtBoxPortfolioCal = new TextBox();
            txtBoxIsinCal = new TextBox();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1441, 313);
            dataGridView1.TabIndex = 0;
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.Location = new Point(54, 52);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(200, 23);
            dtpDateFrom.TabIndex = 1;
            // 
            // dtpDateTo
            // 
            dtpDateTo.Location = new Point(283, 52);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(200, 23);
            dtpDateTo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 34);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "Date From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 34);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 4;
            label2.Text = "Date to";
            // 
            // txtBoxSecurity
            // 
            txtBoxSecurity.Location = new Point(508, 52);
            txtBoxSecurity.Name = "txtBoxSecurity";
            txtBoxSecurity.Size = new Size(100, 23);
            txtBoxSecurity.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(508, 34);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Security";
            // 
            // cmbPortfolio
            // 
            cmbPortfolio.FormattingEnabled = true;
            cmbPortfolio.Location = new Point(639, 52);
            cmbPortfolio.Name = "cmbPortfolio";
            cmbPortfolio.Size = new Size(121, 23);
            cmbPortfolio.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(639, 34);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 8;
            label4.Text = "Portfolio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(790, 34);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 10;
            label5.Text = "State";
            // 
            // cmbState
            // 
            cmbState.FormattingEnabled = true;
            cmbState.Location = new Point(790, 52);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(121, 23);
            cmbState.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(927, 34);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 12;
            label6.Text = "Type";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(927, 52);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(121, 23);
            cmbType.TabIndex = 11;
            // 
            // btnGetTrades
            // 
            btnGetTrades.Location = new Point(1283, 412);
            btnGetTrades.Name = "btnGetTrades";
            btnGetTrades.Size = new Size(160, 64);
            btnGetTrades.TabIndex = 14;
            btnGetTrades.Text = "Get Trades";
            btnGetTrades.UseVisualStyleBackColor = true;
            btnGetTrades.Click += btnGetTrades_Click;
            // 
            // btnConfirmTrade
            // 
            btnConfirmTrade.Location = new Point(1117, 412);
            btnConfirmTrade.Name = "btnConfirmTrade";
            btnConfirmTrade.Size = new Size(160, 64);
            btnConfirmTrade.TabIndex = 15;
            btnConfirmTrade.Text = "Confirm trade";
            btnConfirmTrade.UseVisualStyleBackColor = true;
            btnConfirmTrade.Click += btnConfirmTrade_Click;
            // 
            // btnCalPos
            // 
            btnCalPos.Location = new Point(664, 512);
            btnCalPos.Name = "btnCalPos";
            btnCalPos.Size = new Size(160, 64);
            btnCalPos.TabIndex = 16;
            btnCalPos.Text = "Calculate positions";
            btnCalPos.UseVisualStyleBackColor = true;
            btnCalPos.Click += btnCalPos_Click;
            // 
            // Portfolio
            // 
            Portfolio.AutoSize = true;
            Portfolio.Location = new Point(664, 471);
            Portfolio.Name = "Portfolio";
            Portfolio.Size = new Size(53, 15);
            Portfolio.TabIndex = 17;
            Portfolio.Text = "Portfolio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(667, 426);
            label8.Name = "label8";
            label8.Size = new Size(25, 15);
            label8.TabIndex = 18;
            label8.Text = "Isin";
            // 
            // txtBoxPortfolioCal
            // 
            txtBoxPortfolioCal.Location = new Point(723, 468);
            txtBoxPortfolioCal.Name = "txtBoxPortfolioCal";
            txtBoxPortfolioCal.Size = new Size(100, 23);
            txtBoxPortfolioCal.TabIndex = 19;
            // 
            // txtBoxIsinCal
            // 
            txtBoxIsinCal.Location = new Point(723, 426);
            txtBoxIsinCal.Name = "txtBoxIsinCal";
            txtBoxIsinCal.Size = new Size(100, 23);
            txtBoxIsinCal.TabIndex = 20;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 426);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(636, 150);
            dataGridView2.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1465, 616);
            Controls.Add(dataGridView2);
            Controls.Add(txtBoxIsinCal);
            Controls.Add(txtBoxPortfolioCal);
            Controls.Add(label8);
            Controls.Add(Portfolio);
            Controls.Add(btnCalPos);
            Controls.Add(btnConfirmTrade);
            Controls.Add(btnGetTrades);
            Controls.Add(label6);
            Controls.Add(cmbType);
            Controls.Add(label5);
            Controls.Add(cmbState);
            Controls.Add(label4);
            Controls.Add(cmbPortfolio);
            Controls.Add(label3);
            Controls.Add(txtBoxSecurity);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpDateTo);
            Controls.Add(dtpDateFrom);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dtpDateFrom;
        private DateTimePicker dtpDateTo;
        private Label label1;
        private Label label2;
        private TextBox txtBoxSecurity;
        private Label label3;
        private ComboBox cmbPortfolio;
        private Label label4;
        private Label label5;
        private ComboBox cmbState;
        private Label label6;
        private ComboBox cmbType;
        private Button btnGetTrades;
        private Button btnConfirmTrade;
        private Button btnCalPos;
        private Label Portfolio;
        private Label label8;
        private TextBox txtBoxPortfolioCal;
        private TextBox txtBoxIsinCal;
        private DataGridView dataGridView2;
    }
}
