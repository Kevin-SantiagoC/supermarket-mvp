namespace Supermarket_mvp.Views
{
    partial class ProvidersView
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageProvidersList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProviders = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageProvidersDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProvidersObservation = new TextBox();
            label5 = new Label();
            TxtProvidersName = new TextBox();
            label4 = new Label();
            TxtProvidersId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProvidersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).BeginInit();
            tabPageProvidersDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.providers;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 28);
            label1.Name = "label1";
            label1.Size = new Size(161, 45);
            label1.TabIndex = 0;
            label1.Text = "Providers";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProvidersList);
            tabControl1.Controls.Add(tabPageProvidersDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabPageProvidersList
            // 
            tabPageProvidersList.Controls.Add(BtnClose);
            tabPageProvidersList.Controls.Add(BtnDelete);
            tabPageProvidersList.Controls.Add(BtnEdit);
            tabPageProvidersList.Controls.Add(BtnNew);
            tabPageProvidersList.Controls.Add(DgProviders);
            tabPageProvidersList.Controls.Add(BtnSearch);
            tabPageProvidersList.Controls.Add(TxtSearch);
            tabPageProvidersList.Controls.Add(label2);
            tabPageProvidersList.Location = new Point(4, 24);
            tabPageProvidersList.Name = "tabPageProvidersList";
            tabPageProvidersList.Padding = new Padding(3);
            tabPageProvidersList.Size = new Size(792, 322);
            tabPageProvidersList.TabIndex = 0;
            tabPageProvidersList.Text = "Providers List";
            tabPageProvidersList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(655, 250);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(129, 47);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(655, 197);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(129, 47);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(655, 144);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(129, 47);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(655, 91);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(129, 47);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProviders
            // 
            DgProviders.AllowUserToAddRows = false;
            DgProviders.AllowUserToDeleteRows = false;
            DgProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProviders.Location = new Point(21, 76);
            DgProviders.Name = "DgProviders";
            DgProviders.ReadOnly = true;
            DgProviders.Size = new Size(628, 243);
            DgProviders.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(444, 31);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(51, 43);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(21, 47);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(417, 23);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 22);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Providers";
            // 
            // tabPageProvidersDetail
            // 
            tabPageProvidersDetail.Controls.Add(BtnCancel);
            tabPageProvidersDetail.Controls.Add(BtnSave);
            tabPageProvidersDetail.Controls.Add(TxtProvidersObservation);
            tabPageProvidersDetail.Controls.Add(label5);
            tabPageProvidersDetail.Controls.Add(TxtProvidersName);
            tabPageProvidersDetail.Controls.Add(label4);
            tabPageProvidersDetail.Controls.Add(TxtProvidersId);
            tabPageProvidersDetail.Controls.Add(label3);
            tabPageProvidersDetail.Location = new Point(4, 24);
            tabPageProvidersDetail.Name = "tabPageProvidersDetail";
            tabPageProvidersDetail.Padding = new Padding(3);
            tabPageProvidersDetail.Size = new Size(792, 322);
            tabPageProvidersDetail.TabIndex = 1;
            tabPageProvidersDetail.Text = "Providers Detail";
            tabPageProvidersDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(121, 251);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 55);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(19, 250);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 55);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProvidersObservation
            // 
            TxtProvidersObservation.Location = new Point(19, 152);
            TxtProvidersObservation.Multiline = true;
            TxtProvidersObservation.Name = "TxtProvidersObservation";
            TxtProvidersObservation.PlaceholderText = "Providers Observation";
            TxtProvidersObservation.Size = new Size(375, 83);
            TxtProvidersObservation.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 134);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 4;
            label5.Text = "Providers Observation";
            // 
            // TxtProvidersName
            // 
            TxtProvidersName.Location = new Point(19, 92);
            TxtProvidersName.Name = "TxtProvidersName";
            TxtProvidersName.PlaceholderText = "Providers Name";
            TxtProvidersName.Size = new Size(375, 23);
            TxtProvidersName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 74);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 2;
            label4.Text = "Providers Name";
            // 
            // TxtProvidersId
            // 
            TxtProvidersId.Location = new Point(19, 31);
            TxtProvidersId.Name = "TxtProvidersId";
            TxtProvidersId.Size = new Size(277, 23);
            TxtProvidersId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 13);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 0;
            label3.Text = "Providers Id";
            // 
            // ProvidersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProvidersView";
            Text = "ProvidersView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProvidersList.ResumeLayout(false);
            tabPageProvidersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).EndInit();
            tabPageProvidersDetail.ResumeLayout(false);
            tabPageProvidersDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageProvidersList;
        private TabPage tabPageProvidersDetail;
        private DataGridView DgProviders;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSave;
        private TextBox TxtProvidersObservation;
        private Label label5;
        private TextBox TxtProvidersName;
        private Label label4;
        private TextBox TxtProvidersId;
        private Label label3;
        private Button BtnCancel;
    }
}