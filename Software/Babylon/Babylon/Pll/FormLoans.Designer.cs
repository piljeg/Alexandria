
namespace Pll
{
    partial class FormLoans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoans));
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewLoans = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Finished = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonNewLoan = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonLateLoansList = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.dataGridViewLoanItems = new System.Windows.Forms.DataGridView();
            this.loanItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLiteratureTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReceipts = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.literatureIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoanItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(383, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 32);
            this.label4.TabIndex = 21;
            this.label4.Text = "Posudbe";
            // 
            // dataGridViewLoans
            // 
            this.dataGridViewLoans.AllowUserToAddRows = false;
            this.dataGridViewLoans.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewLoans.AutoGenerateColumns = false;
            this.dataGridViewLoans.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dataGridViewLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Username,
            this.startedDataGridViewCheckBoxColumn,
            this.Finished,
            this.dateFromDataGridViewTextBoxColumn,
            this.dateToDataGridViewTextBoxColumn});
            this.dataGridViewLoans.DataSource = this.loanBindingSource;
            this.dataGridViewLoans.Location = new System.Drawing.Point(29, 157);
            this.dataGridViewLoans.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewLoans.Name = "dataGridViewLoans";
            this.dataGridViewLoans.RowHeadersWidth = 51;
            this.dataGridViewLoans.RowTemplate.Height = 24;
            this.dataGridViewLoans.Size = new System.Drawing.Size(838, 257);
            this.dataGridViewLoans.TabIndex = 22;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Korisničko ime";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 125;
            // 
            // startedDataGridViewCheckBoxColumn
            // 
            this.startedDataGridViewCheckBoxColumn.DataPropertyName = "Started";
            this.startedDataGridViewCheckBoxColumn.HeaderText = "Započeta";
            this.startedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.startedDataGridViewCheckBoxColumn.Name = "startedDataGridViewCheckBoxColumn";
            this.startedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // Finished
            // 
            this.Finished.DataPropertyName = "Finished";
            this.Finished.HeaderText = "Završena";
            this.Finished.MinimumWidth = 6;
            this.Finished.Name = "Finished";
            this.Finished.Width = 125;
            // 
            // dateFromDataGridViewTextBoxColumn
            // 
            this.dateFromDataGridViewTextBoxColumn.DataPropertyName = "DateFrom";
            this.dateFromDataGridViewTextBoxColumn.HeaderText = "Datum od";
            this.dateFromDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateFromDataGridViewTextBoxColumn.Name = "dateFromDataGridViewTextBoxColumn";
            this.dateFromDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateToDataGridViewTextBoxColumn
            // 
            this.dateToDataGridViewTextBoxColumn.DataPropertyName = "DateTo";
            this.dateToDataGridViewTextBoxColumn.HeaderText = "Datum do";
            this.dateToDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateToDataGridViewTextBoxColumn.Name = "dateToDataGridViewTextBoxColumn";
            this.dateToDataGridViewTextBoxColumn.Width = 125;
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataSource = typeof(Dll.Model.Loan);
            this.loanBindingSource.CurrentChanged += new System.EventHandler(this.loanBindingSource_CurrentChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(25, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Posudbe:";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.LightGray;
            this.buttonClose.Location = new System.Drawing.Point(13, 13);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(81, 45);
            this.buttonClose.TabIndex = 24;
            this.buttonClose.Text = "Natrag";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.ForeColor = System.Drawing.Color.LightGray;
            this.buttonLogOut.Location = new System.Drawing.Point(792, 13);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(81, 45);
            this.buttonLogOut.TabIndex = 25;
            this.buttonLogOut.Text = "Odjava";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonNewLoan
            // 
            this.buttonNewLoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNewLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.buttonNewLoan.FlatAppearance.BorderSize = 0;
            this.buttonNewLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewLoan.ForeColor = System.Drawing.Color.LightGray;
            this.buttonNewLoan.Location = new System.Drawing.Point(24, 713);
            this.buttonNewLoan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNewLoan.Name = "buttonNewLoan";
            this.buttonNewLoan.Size = new System.Drawing.Size(138, 49);
            this.buttonNewLoan.TabIndex = 26;
            this.buttonNewLoan.Text = "Nova posudba";
            this.buttonNewLoan.UseVisualStyleBackColor = false;
            this.buttonNewLoan.Click += new System.EventHandler(this.buttonNewLoan_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.buttonHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.ForeColor = System.Drawing.Color.LightGray;
            this.buttonHelp.Location = new System.Drawing.Point(24, 788);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(138, 51);
            this.buttonHelp.TabIndex = 27;
            this.buttonHelp.Text = "Pomoć";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonLateLoansList
            // 
            this.buttonLateLoansList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLateLoansList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.buttonLateLoansList.FlatAppearance.BorderSize = 0;
            this.buttonLateLoansList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLateLoansList.ForeColor = System.Drawing.Color.LightGray;
            this.buttonLateLoansList.Location = new System.Drawing.Point(376, 713);
            this.buttonLateLoansList.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLateLoansList.Name = "buttonLateLoansList";
            this.buttonLateLoansList.Size = new System.Drawing.Size(138, 49);
            this.buttonLateLoansList.TabIndex = 28;
            this.buttonLateLoansList.Text = "Zakasnine";
            this.buttonLateLoansList.UseVisualStyleBackColor = false;
            this.buttonLateLoansList.Click += new System.EventHandler(this.buttonLateLoansList_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.buttonReturn.FlatAppearance.BorderSize = 0;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.ForeColor = System.Drawing.Color.LightGray;
            this.buttonReturn.Location = new System.Drawing.Point(200, 713);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(138, 49);
            this.buttonReturn.TabIndex = 29;
            this.buttonReturn.Text = "Vrati";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // dataGridViewLoanItems
            // 
            this.dataGridViewLoanItems.AllowUserToAddRows = false;
            this.dataGridViewLoanItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewLoanItems.AutoGenerateColumns = false;
            this.dataGridViewLoanItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dataGridViewLoanItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoanItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.loanIdDataGridViewTextBoxColumn,
            this.literatureIdDataGridViewTextBoxColumn});
            this.dataGridViewLoanItems.DataSource = this.loanItemBindingSource;
            this.dataGridViewLoanItems.Location = new System.Drawing.Point(29, 480);
            this.dataGridViewLoanItems.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewLoanItems.Name = "dataGridViewLoanItems";
            this.dataGridViewLoanItems.RowHeadersWidth = 51;
            this.dataGridViewLoanItems.RowTemplate.Height = 24;
            this.dataGridViewLoanItems.Size = new System.Drawing.Size(838, 198);
            this.dataGridViewLoanItems.TabIndex = 30;
            this.dataGridViewLoanItems.SelectionChanged += new System.EventHandler(this.dataGridViewLoanItems_SelectionChanged);
            // 
            // loanItemBindingSource
            // 
            this.loanItemBindingSource.DataSource = typeof(Dll.Model.LoanItem);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(25, 438);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Stavke posudbe:";
            // 
            // textBoxLiteratureTitle
            // 
            this.textBoxLiteratureTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLiteratureTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.textBoxLiteratureTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLiteratureTitle.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxLiteratureTitle.Location = new System.Drawing.Point(382, 434);
            this.textBoxLiteratureTitle.Multiline = true;
            this.textBoxLiteratureTitle.Name = "textBoxLiteratureTitle";
            this.textBoxLiteratureTitle.Size = new System.Drawing.Size(150, 30);
            this.textBoxLiteratureTitle.TabIndex = 32;
            this.textBoxLiteratureTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(304, 438);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Naslov:";
            // 
            // buttonReceipts
            // 
            this.buttonReceipts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReceipts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.buttonReceipts.FlatAppearance.BorderSize = 0;
            this.buttonReceipts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReceipts.ForeColor = System.Drawing.Color.LightGray;
            this.buttonReceipts.Location = new System.Drawing.Point(552, 713);
            this.buttonReceipts.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReceipts.Name = "buttonReceipts";
            this.buttonReceipts.Size = new System.Drawing.Size(138, 49);
            this.buttonReceipts.TabIndex = 34;
            this.buttonReceipts.Text = "Izdani računi";
            this.buttonReceipts.UseVisualStyleBackColor = false;
            this.buttonReceipts.Click += new System.EventHandler(this.buttonReceipts_Click);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // loanIdDataGridViewTextBoxColumn
            // 
            this.loanIdDataGridViewTextBoxColumn.DataPropertyName = "LoanId";
            this.loanIdDataGridViewTextBoxColumn.HeaderText = "ID posudbe";
            this.loanIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loanIdDataGridViewTextBoxColumn.Name = "loanIdDataGridViewTextBoxColumn";
            this.loanIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // literatureIdDataGridViewTextBoxColumn
            // 
            this.literatureIdDataGridViewTextBoxColumn.DataPropertyName = "LiteratureId";
            this.literatureIdDataGridViewTextBoxColumn.HeaderText = "ID knjižne građe";
            this.literatureIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.literatureIdDataGridViewTextBoxColumn.Name = "literatureIdDataGridViewTextBoxColumn";
            this.literatureIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(891, 861);
            this.Controls.Add(this.buttonReceipts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLiteratureTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewLoanItems);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonLateLoansList);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonNewLoan);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewLoans);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(909, 908);
            this.Name = "FormLoans";
            this.Text = "Posudbe";
            this.Load += new System.EventHandler(this.FormLoans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoanItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewLoans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private System.Windows.Forms.Button buttonNewLoan;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewCheckBoxColumn startedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Finished;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateToDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonLateLoansList;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.DataGridView dataGridViewLoanItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource loanItemBindingSource;
        private System.Windows.Forms.TextBox textBoxLiteratureTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReceipts;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn literatureIdDataGridViewTextBoxColumn;
    }
}