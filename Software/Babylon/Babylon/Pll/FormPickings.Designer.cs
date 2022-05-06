
namespace Pll
{
    partial class FormPickings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPickings));
            this.label2 = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewPickingsIn = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickingInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewPickingsOut = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickingOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewPickingInItems = new System.Windows.Forms.DataGridView();
            this.pickingInIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.literatureIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickingInItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxLiteratureTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPickingsIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickingInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPickingsOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickingOutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPickingInItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickingInItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(319, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Primke i otpremnice";
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.buttonHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.ForeColor = System.Drawing.Color.LightGray;
            this.buttonHelp.Location = new System.Drawing.Point(13, 764);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(138, 51);
            this.buttonHelp.TabIndex = 19;
            this.buttonHelp.Text = "Pomoć";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.LightGray;
            this.buttonClose.Location = new System.Drawing.Point(13, 22);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(81, 45);
            this.buttonClose.TabIndex = 20;
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
            this.buttonLogOut.Location = new System.Drawing.Point(847, 22);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(81, 45);
            this.buttonLogOut.TabIndex = 21;
            this.buttonLogOut.Text = "Odjava";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Primke:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(12, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Otpremnice:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(547, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Stavke primke:";
            // 
            // dataGridViewPickingsIn
            // 
            this.dataGridViewPickingsIn.AllowUserToAddRows = false;
            this.dataGridViewPickingsIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewPickingsIn.AutoGenerateColumns = false;
            this.dataGridViewPickingsIn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dataGridViewPickingsIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPickingsIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridViewPickingsIn.DataSource = this.pickingInBindingSource;
            this.dataGridViewPickingsIn.Location = new System.Drawing.Point(13, 150);
            this.dataGridViewPickingsIn.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPickingsIn.Name = "dataGridViewPickingsIn";
            this.dataGridViewPickingsIn.RowHeadersWidth = 51;
            this.dataGridViewPickingsIn.RowTemplate.Height = 24;
            this.dataGridViewPickingsIn.Size = new System.Drawing.Size(469, 244);
            this.dataGridViewPickingsIn.TabIndex = 28;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // pickingInBindingSource
            // 
            this.pickingInBindingSource.DataSource = typeof(Dll.Model.PickingIn);
            this.pickingInBindingSource.CurrentChanged += new System.EventHandler(this.pickingInBindingSource_CurrentChanged);
            // 
            // dataGridViewPickingsOut
            // 
            this.dataGridViewPickingsOut.AllowUserToAddRows = false;
            this.dataGridViewPickingsOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewPickingsOut.AutoGenerateColumns = false;
            this.dataGridViewPickingsOut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dataGridViewPickingsOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPickingsOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn1});
            this.dataGridViewPickingsOut.DataSource = this.pickingOutBindingSource;
            this.dataGridViewPickingsOut.Location = new System.Drawing.Point(16, 477);
            this.dataGridViewPickingsOut.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPickingsOut.Name = "dataGridViewPickingsOut";
            this.dataGridViewPickingsOut.RowHeadersWidth = 51;
            this.dataGridViewPickingsOut.RowTemplate.Height = 24;
            this.dataGridViewPickingsOut.Size = new System.Drawing.Size(903, 244);
            this.dataGridViewPickingsOut.TabIndex = 29;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 400;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Datum";
            this.dateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // pickingOutBindingSource
            // 
            this.pickingOutBindingSource.DataSource = typeof(Dll.Model.PickingOut);
            // 
            // dataGridViewPickingInItems
            // 
            this.dataGridViewPickingInItems.AllowUserToAddRows = false;
            this.dataGridViewPickingInItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewPickingInItems.AutoGenerateColumns = false;
            this.dataGridViewPickingInItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dataGridViewPickingInItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPickingInItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pickingInIdDataGridViewTextBoxColumn,
            this.literatureIdDataGridViewTextBoxColumn});
            this.dataGridViewPickingInItems.DataSource = this.pickingInItemBindingSource;
            this.dataGridViewPickingInItems.Location = new System.Drawing.Point(551, 150);
            this.dataGridViewPickingInItems.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPickingInItems.Name = "dataGridViewPickingInItems";
            this.dataGridViewPickingInItems.RowHeadersWidth = 51;
            this.dataGridViewPickingInItems.RowTemplate.Height = 24;
            this.dataGridViewPickingInItems.Size = new System.Drawing.Size(368, 244);
            this.dataGridViewPickingInItems.TabIndex = 30;
            this.dataGridViewPickingInItems.SelectionChanged += new System.EventHandler(this.dataGridViewPickingInItems_SelectionChanged);
            // 
            // pickingInIdDataGridViewTextBoxColumn
            // 
            this.pickingInIdDataGridViewTextBoxColumn.DataPropertyName = "PickingIn_Id";
            this.pickingInIdDataGridViewTextBoxColumn.HeaderText = "ID primke";
            this.pickingInIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pickingInIdDataGridViewTextBoxColumn.Name = "pickingInIdDataGridViewTextBoxColumn";
            this.pickingInIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // literatureIdDataGridViewTextBoxColumn
            // 
            this.literatureIdDataGridViewTextBoxColumn.DataPropertyName = "Literature_Id";
            this.literatureIdDataGridViewTextBoxColumn.HeaderText = "ID knjižne građe";
            this.literatureIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.literatureIdDataGridViewTextBoxColumn.Name = "literatureIdDataGridViewTextBoxColumn";
            this.literatureIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // pickingInItemBindingSource
            // 
            this.pickingInItemBindingSource.DataSource = typeof(Dll.Model.PickingInItem);
            // 
            // textBoxLiteratureTitle
            // 
            this.textBoxLiteratureTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLiteratureTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.textBoxLiteratureTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLiteratureTitle.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxLiteratureTitle.Location = new System.Drawing.Point(750, 104);
            this.textBoxLiteratureTitle.Multiline = true;
            this.textBoxLiteratureTitle.Name = "textBoxLiteratureTitle";
            this.textBoxLiteratureTitle.Size = new System.Drawing.Size(169, 30);
            this.textBoxLiteratureTitle.TabIndex = 31;
            this.textBoxLiteratureTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormPickings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(947, 828);
            this.Controls.Add(this.textBoxLiteratureTitle);
            this.Controls.Add(this.dataGridViewPickingInItems);
            this.Controls.Add(this.dataGridViewPickingsOut);
            this.Controls.Add(this.dataGridViewPickingsIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(965, 875);
            this.Name = "FormPickings";
            this.Text = "Primke i otpremnice";
            this.Load += new System.EventHandler(this.FormPickings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPickingsIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickingInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPickingsOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickingOutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPickingInItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickingInItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewPickingsIn;
        private System.Windows.Forms.DataGridView dataGridViewPickingsOut;
        private System.Windows.Forms.DataGridView dataGridViewPickingInItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pickingInBindingSource;
        private System.Windows.Forms.BindingSource pickingInItemBindingSource;
        private System.Windows.Forms.BindingSource pickingOutBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickingInIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn literatureIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxLiteratureTitle;
    }
}