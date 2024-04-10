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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPagePayModeList = new TabPage();
            tabPagePayModeDetail = new TabPage();
            label2 = new Label();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            DgPayMode = new DataGridView();
            BtnNew = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Adobe Gothic Std B", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 128);
            label1.Location = new Point(121, 30);
            label1.Name = "label1";
            label1.Size = new Size(163, 40);
            label1.TabIndex = 0;
            label1.Text = "Pay Mode";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(640, 312);
            tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Controls.Add(BtnNew);
            tabPagePayModeList.Controls.Add(DgPayMode);
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(label2);
            tabPagePayModeList.Location = new Point(4, 24);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(632, 284);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Location = new Point(4, 24);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(632, 284);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 15);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(22, 33);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(417, 23);
            TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(445, 23);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(41, 41);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(22, 70);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.Size = new Size(464, 208);
            DgPayMode.TabIndex = 3;
            // 
            // BtnNew
            // 
            BtnNew.Location = new Point(492, 88);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(132, 35);
            BtnNew.TabIndex = 4;
            BtnNew.Text = "button1";
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Location = new Point(492, 138);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(132, 35);
            BtnEdit.TabIndex = 5;
            BtnEdit.Text = "button2";
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(492, 179);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(132, 35);
            BtnDelete.TabIndex = 6;
            BtnDelete.Text = "button3";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Location = new Point(492, 220);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(132, 35);
            BtnClose.TabIndex = 7;
            BtnClose.Text = "button4";
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 412);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private TabPage tabPagePayModeDetail;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnSearch;
        private DataGridView DgPayMode;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
    }
}