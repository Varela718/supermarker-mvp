namespace Supermarket_mvp.Views
{
    partial class PayModeView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePayModeList = new System.Windows.Forms.TabPage();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.DgPayMode = new System.Windows.Forms.DataGridView();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPagePayModeDetail = new System.Windows.Forms.TabPage();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtPayModeObservation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TxtPayModeName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtPayModeId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgPayMode)).BeginInit();
            this.tabPagePayModeDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 110);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarket_mvp.Properties.Resources.buy;
            this.pictureBox1.Location = new System.Drawing.Point(10, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(166, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAY MODE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePayModeList);
            this.tabControl1.Controls.Add(this.tabPagePayModeDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 110);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 378);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            this.tabPagePayModeList.Controls.Add(this.BtnClose);
            this.tabPagePayModeList.Controls.Add(this.BtnDelete);
            this.tabPagePayModeList.Controls.Add(this.BtnEdit);
            this.tabPagePayModeList.Controls.Add(this.BtnNew);
            this.tabPagePayModeList.Controls.Add(this.DgPayMode);
            this.tabPagePayModeList.Controls.Add(this.BtnSearch);
            this.tabPagePayModeList.Controls.Add(this.TxtSearch);
            this.tabPagePayModeList.Controls.Add(this.label2);
            this.tabPagePayModeList.Location = new System.Drawing.Point(4, 24);
            this.tabPagePayModeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePayModeList.Name = "tabPagePayModeList";
            this.tabPagePayModeList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePayModeList.Size = new System.Drawing.Size(939, 350);
            this.tabPagePayModeList.TabIndex = 0;
            this.tabPagePayModeList.Text = "Pay Mode List";
            this.tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Image = global::Supermarket_mvp.Properties.Resources.cerrar;
            this.BtnClose.Location = new System.Drawing.Point(717, 271);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(213, 64);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Image = global::Supermarket_mvp.Properties.Resources.delete;
            this.BtnDelete.Location = new System.Drawing.Point(717, 202);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(213, 64);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Image = global::Supermarket_mvp.Properties.Resources.edit;
            this.BtnEdit.Location = new System.Drawing.Point(717, 134);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(213, 64);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Image = global::Supermarket_mvp.Properties.Resources._new;
            this.BtnNew.Location = new System.Drawing.Point(717, 66);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(213, 64);
            this.BtnNew.TabIndex = 4;
            this.BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            this.DgPayMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgPayMode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgPayMode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPayMode.Location = new System.Drawing.Point(19, 63);
            this.DgPayMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgPayMode.Name = "DgPayMode";
            this.DgPayMode.RowHeadersWidth = 51;
            this.DgPayMode.RowTemplate.Height = 29;
            this.DgPayMode.Size = new System.Drawing.Size(681, 286);
            this.DgPayMode.TabIndex = 3;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.Image = global::Supermarket_mvp.Properties.Resources.search_small;
            this.BtnSearch.Location = new System.Drawing.Point(651, 10);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(55, 48);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.Location = new System.Drawing.Point(19, 28);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PlaceholderText = "Data to search";
            this.TxtSearch.Size = new System.Drawing.Size(627, 23);
            this.TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Pay Mode";
            // 
            // tabPagePayModeDetail
            // 
            this.tabPagePayModeDetail.Controls.Add(this.BtnCancel);
            this.tabPagePayModeDetail.Controls.Add(this.BtnSave);
            this.tabPagePayModeDetail.Controls.Add(this.TxtPayModeObservation);
            this.tabPagePayModeDetail.Controls.Add(this.label3);
            this.tabPagePayModeDetail.Controls.Add(this.textBox2);
            this.tabPagePayModeDetail.Controls.Add(this.TxtPayModeName);
            this.tabPagePayModeDetail.Controls.Add(this.textBox1);
            this.tabPagePayModeDetail.Controls.Add(this.TxtPayModeId);
            this.tabPagePayModeDetail.Location = new System.Drawing.Point(4, 24);
            this.tabPagePayModeDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            this.tabPagePayModeDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePayModeDetail.Size = new System.Drawing.Size(939, 350);
            this.tabPagePayModeDetail.TabIndex = 1;
            this.tabPagePayModeDetail.Text = "Pay Mode Detail";
            this.tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Image = global::Supermarket_mvp.Properties.Resources.cancel;
            this.BtnCancel.Location = new System.Drawing.Point(178, 256);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(119, 55);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::Supermarket_mvp.Properties.Resources.save;
            this.BtnSave.Location = new System.Drawing.Point(34, 256);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(119, 55);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtPayModeObservation
            // 
            this.TxtPayModeObservation.Location = new System.Drawing.Point(24, 166);
            this.TxtPayModeObservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPayModeObservation.Multiline = true;
            this.TxtPayModeObservation.Name = "TxtPayModeObservation";
            this.TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            this.TxtPayModeObservation.Size = new System.Drawing.Size(292, 74);
            this.TxtPayModeObservation.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pay Mode Observation";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 98);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Pay Mode Name";
            this.textBox2.Size = new System.Drawing.Size(292, 23);
            this.textBox2.TabIndex = 3;
            // 
            // TxtPayModeName
            // 
            this.TxtPayModeName.AutoSize = true;
            this.TxtPayModeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtPayModeName.Location = new System.Drawing.Point(24, 75);
            this.TxtPayModeName.Name = "TxtPayModeName";
            this.TxtPayModeName.Size = new System.Drawing.Size(136, 21);
            this.TxtPayModeName.TabIndex = 2;
            this.TxtPayModeName.Text = "Pay Mode Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 23);
            this.textBox1.TabIndex = 1;
            // 
            // TxtPayModeId
            // 
            this.TxtPayModeId.AutoSize = true;
            this.TxtPayModeId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtPayModeId.Location = new System.Drawing.Point(24, 14);
            this.TxtPayModeId.Name = "TxtPayModeId";
            this.TxtPayModeId.Size = new System.Drawing.Size(105, 21);
            this.TxtPayModeId.TabIndex = 0;
            this.TxtPayModeId.Text = "Pay Mode Id";
            // 
            // PayModeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 488);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(180, 60);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PayModeView";
            this.Text = "Pay Mode Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePayModeList.ResumeLayout(false);
            this.tabPagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgPayMode)).EndInit();
            this.tabPagePayModeDetail.ResumeLayout(false);
            this.tabPagePayModeDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private Label label2;
        private TabPage tabPagePayModeDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgPayMode;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label3;
        private TextBox textBox2;
        private Label TxtPayModeName;
        private TextBox textBox1;
        private Label TxtPayModeId;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtPayModeObservation;
    }
}