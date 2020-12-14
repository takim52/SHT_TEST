using System.Drawing;
using System.Windows.Forms;

namespace Blade_Monitoring
{
    partial class Blocking_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Main1_splitter = new System.Windows.Forms.SplitContainer();
            this.Top_lbSplitter = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.Top_txtSplitter = new System.Windows.Forms.SplitContainer();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.Top_btnSplitter = new System.Windows.Forms.SplitContainer();
            this.btn_SaveBarcode = new System.Windows.Forms.Button();
            this.Top_Exitsplitter = new System.Windows.Forms.SplitContainer();
            this.btn_DeleteData = new System.Windows.Forms.Button();
            this.Main2_Splitter = new System.Windows.Forms.SplitContainer();
            this.Middle_AllSplitter = new System.Windows.Forms.SplitContainer();
            this.cb_AllCheck = new System.Windows.Forms.CheckBox();
            this.Middle_SelectSplitter = new System.Windows.Forms.SplitContainer();
            this.cb_SelectData = new System.Windows.Forms.CheckBox();
            this.Middle_NGlistSplitter = new System.Windows.Forms.SplitContainer();
            this.cb_NGList = new System.Windows.Forms.CheckBox();
            this.Middle_ImageSplitter = new System.Windows.Forms.SplitContainer();
            this.cb_NG_IMAGE = new System.Windows.Forms.CheckBox();
            this.btn_AllDelete = new System.Windows.Forms.Button();
            this.dgv_BlockingData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Main1_splitter)).BeginInit();
            this.Main1_splitter.Panel1.SuspendLayout();
            this.Main1_splitter.Panel2.SuspendLayout();
            this.Main1_splitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Top_lbSplitter)).BeginInit();
            this.Top_lbSplitter.Panel1.SuspendLayout();
            this.Top_lbSplitter.Panel2.SuspendLayout();
            this.Top_lbSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Top_txtSplitter)).BeginInit();
            this.Top_txtSplitter.Panel1.SuspendLayout();
            this.Top_txtSplitter.Panel2.SuspendLayout();
            this.Top_txtSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Top_btnSplitter)).BeginInit();
            this.Top_btnSplitter.Panel1.SuspendLayout();
            this.Top_btnSplitter.Panel2.SuspendLayout();
            this.Top_btnSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Top_Exitsplitter)).BeginInit();
            this.Top_Exitsplitter.Panel1.SuspendLayout();
            this.Top_Exitsplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main2_Splitter)).BeginInit();
            this.Main2_Splitter.Panel1.SuspendLayout();
            this.Main2_Splitter.Panel2.SuspendLayout();
            this.Main2_Splitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Middle_AllSplitter)).BeginInit();
            this.Middle_AllSplitter.Panel1.SuspendLayout();
            this.Middle_AllSplitter.Panel2.SuspendLayout();
            this.Middle_AllSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Middle_SelectSplitter)).BeginInit();
            this.Middle_SelectSplitter.Panel1.SuspendLayout();
            this.Middle_SelectSplitter.Panel2.SuspendLayout();
            this.Middle_SelectSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Middle_NGlistSplitter)).BeginInit();
            this.Middle_NGlistSplitter.Panel1.SuspendLayout();
            this.Middle_NGlistSplitter.Panel2.SuspendLayout();
            this.Middle_NGlistSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Middle_ImageSplitter)).BeginInit();
            this.Middle_ImageSplitter.Panel1.SuspendLayout();
            this.Middle_ImageSplitter.Panel2.SuspendLayout();
            this.Middle_ImageSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BlockingData)).BeginInit();
            this.SuspendLayout();
            // 
            // Main1_splitter
            // 
            this.Main1_splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main1_splitter.Location = new System.Drawing.Point(0, 0);
            this.Main1_splitter.Margin = new System.Windows.Forms.Padding(10);
            this.Main1_splitter.Name = "Main1_splitter";
            this.Main1_splitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Main1_splitter.Panel1
            // 
            this.Main1_splitter.Panel1.Controls.Add(this.Top_lbSplitter);
            // 
            // Main1_splitter.Panel2
            // 
            this.Main1_splitter.Panel2.Controls.Add(this.Main2_Splitter);
            this.Main1_splitter.Size = new System.Drawing.Size(823, 521);
            this.Main1_splitter.SplitterWidth = 1;
            this.Main1_splitter.TabIndex = 0;
            // 
            // Top_lbSplitter
            // 
            this.Top_lbSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Top_lbSplitter.Location = new System.Drawing.Point(0, 0);
            this.Top_lbSplitter.Name = "Top_lbSplitter";
            // 
            // Top_lbSplitter.Panel1
            // 
            this.Top_lbSplitter.Panel1.Controls.Add(this.label1);
            // 
            // Top_lbSplitter.Panel2
            // 
            this.Top_lbSplitter.Panel2.Controls.Add(this.Top_txtSplitter);
            this.Top_lbSplitter.Size = new System.Drawing.Size(823, 50);
            this.Top_lbSplitter.SplitterDistance = 140;
            this.Top_lbSplitter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "바코드";
            // 
            // Top_txtSplitter
            // 
            this.Top_txtSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Top_txtSplitter.Location = new System.Drawing.Point(0, 0);
            this.Top_txtSplitter.Name = "Top_txtSplitter";
            // 
            // Top_txtSplitter.Panel1
            // 
            this.Top_txtSplitter.Panel1.Controls.Add(this.txt_barcode);
            // 
            // Top_txtSplitter.Panel2
            // 
            this.Top_txtSplitter.Panel2.Controls.Add(this.Top_btnSplitter);
            this.Top_txtSplitter.Size = new System.Drawing.Size(679, 50);
            this.Top_txtSplitter.SplitterDistance = 160;
            this.Top_txtSplitter.TabIndex = 0;
            // 
            // txt_barcode
            // 
            this.txt_barcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_barcode.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_barcode.Location = new System.Drawing.Point(0, 0);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(160, 48);
            this.txt_barcode.TabIndex = 0;
            // 
            // Top_btnSplitter
            // 
            this.Top_btnSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Top_btnSplitter.Location = new System.Drawing.Point(0, 0);
            this.Top_btnSplitter.Name = "Top_btnSplitter";
            // 
            // Top_btnSplitter.Panel1
            // 
            this.Top_btnSplitter.Panel1.Controls.Add(this.btn_SaveBarcode);
            // 
            // Top_btnSplitter.Panel2
            // 
            this.Top_btnSplitter.Panel2.Controls.Add(this.Top_Exitsplitter);
            this.Top_btnSplitter.Size = new System.Drawing.Size(515, 50);
            this.Top_btnSplitter.SplitterDistance = 119;
            this.Top_btnSplitter.TabIndex = 0;
            // 
            // btn_SaveBarcode
            // 
            this.btn_SaveBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SaveBarcode.Font = new System.Drawing.Font("Gulim", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_SaveBarcode.Location = new System.Drawing.Point(0, 0);
            this.btn_SaveBarcode.Name = "btn_SaveBarcode";
            this.btn_SaveBarcode.Size = new System.Drawing.Size(119, 50);
            this.btn_SaveBarcode.TabIndex = 0;
            this.btn_SaveBarcode.Text = "저장";
            this.btn_SaveBarcode.UseVisualStyleBackColor = true;
            this.btn_SaveBarcode.Click += new System.EventHandler(this.btn_SaveBarcode_Click);
            // 
            // Top_Exitsplitter
            // 
            this.Top_Exitsplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Top_Exitsplitter.Location = new System.Drawing.Point(0, 0);
            this.Top_Exitsplitter.Name = "Top_Exitsplitter";
            // 
            // Top_Exitsplitter.Panel1
            // 
            this.Top_Exitsplitter.Panel1.Controls.Add(this.btn_DeleteData);
            this.Top_Exitsplitter.Size = new System.Drawing.Size(392, 50);
            this.Top_Exitsplitter.SplitterDistance = 160;
            this.Top_Exitsplitter.SplitterWidth = 1;
            this.Top_Exitsplitter.TabIndex = 0;
            // 
            // btn_DeleteData
            // 
            this.btn_DeleteData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_DeleteData.Font = new System.Drawing.Font("Gulim", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_DeleteData.Location = new System.Drawing.Point(0, 0);
            this.btn_DeleteData.Name = "btn_DeleteData";
            this.btn_DeleteData.Size = new System.Drawing.Size(160, 50);
            this.btn_DeleteData.TabIndex = 1;
            this.btn_DeleteData.Text = "삭제";
            this.btn_DeleteData.UseVisualStyleBackColor = true;
            this.btn_DeleteData.Click += new System.EventHandler(this.btn_DeleteData_Click);
            // 
            // Main2_Splitter
            // 
            this.Main2_Splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main2_Splitter.Location = new System.Drawing.Point(0, 0);
            this.Main2_Splitter.Name = "Main2_Splitter";
            this.Main2_Splitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Main2_Splitter.Panel1
            // 
            this.Main2_Splitter.Panel1.Controls.Add(this.Middle_AllSplitter);
            // 
            // Main2_Splitter.Panel2
            // 
            this.Main2_Splitter.Panel2.Controls.Add(this.dgv_BlockingData);
            this.Main2_Splitter.Size = new System.Drawing.Size(823, 470);
            this.Main2_Splitter.SplitterDistance = 78;
            this.Main2_Splitter.SplitterWidth = 1;
            this.Main2_Splitter.TabIndex = 0;
            // 
            // Middle_AllSplitter
            // 
            this.Middle_AllSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Middle_AllSplitter.Location = new System.Drawing.Point(0, 0);
            this.Middle_AllSplitter.Name = "Middle_AllSplitter";
            // 
            // Middle_AllSplitter.Panel1
            // 
            this.Middle_AllSplitter.Panel1.Controls.Add(this.cb_AllCheck);
            // 
            // Middle_AllSplitter.Panel2
            // 
            this.Middle_AllSplitter.Panel2.Controls.Add(this.Middle_SelectSplitter);
            this.Middle_AllSplitter.Size = new System.Drawing.Size(823, 78);
            this.Middle_AllSplitter.SplitterDistance = 120;
            this.Middle_AllSplitter.TabIndex = 0;
            // 
            // cb_AllCheck
            // 
            this.cb_AllCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_AllCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_AllCheck.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_AllCheck.Location = new System.Drawing.Point(0, 0);
            this.cb_AllCheck.Name = "cb_AllCheck";
            this.cb_AllCheck.Size = new System.Drawing.Size(120, 78);
            this.cb_AllCheck.TabIndex = 0;
            this.cb_AllCheck.Text = "전체선택";
            this.cb_AllCheck.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cb_AllCheck.UseVisualStyleBackColor = true;
            this.cb_AllCheck.CheckedChanged += new System.EventHandler(this.cb_AllCheck_CheckedChanged);
            // 
            // Middle_SelectSplitter
            // 
            this.Middle_SelectSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Middle_SelectSplitter.Location = new System.Drawing.Point(0, 0);
            this.Middle_SelectSplitter.Name = "Middle_SelectSplitter";
            // 
            // Middle_SelectSplitter.Panel1
            // 
            this.Middle_SelectSplitter.Panel1.Controls.Add(this.cb_SelectData);
            // 
            // Middle_SelectSplitter.Panel2
            // 
            this.Middle_SelectSplitter.Panel2.Controls.Add(this.Middle_NGlistSplitter);
            this.Middle_SelectSplitter.Size = new System.Drawing.Size(699, 78);
            this.Middle_SelectSplitter.SplitterDistance = 160;
            this.Middle_SelectSplitter.TabIndex = 0;
            // 
            // cb_SelectData
            // 
            this.cb_SelectData.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_SelectData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_SelectData.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_SelectData.Location = new System.Drawing.Point(0, 0);
            this.cb_SelectData.Name = "cb_SelectData";
            this.cb_SelectData.Size = new System.Drawing.Size(160, 78);
            this.cb_SelectData.TabIndex = 0;
            this.cb_SelectData.Text = "조회";
            this.cb_SelectData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cb_SelectData.UseVisualStyleBackColor = true;
            this.cb_SelectData.CheckedChanged += new System.EventHandler(this.cb_SelectData_CheckedChanged);
            // 
            // Middle_NGlistSplitter
            // 
            this.Middle_NGlistSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Middle_NGlistSplitter.Location = new System.Drawing.Point(0, 0);
            this.Middle_NGlistSplitter.Name = "Middle_NGlistSplitter";
            // 
            // Middle_NGlistSplitter.Panel1
            // 
            this.Middle_NGlistSplitter.Panel1.Controls.Add(this.cb_NGList);
            // 
            // Middle_NGlistSplitter.Panel2
            // 
            this.Middle_NGlistSplitter.Panel2.Controls.Add(this.Middle_ImageSplitter);
            this.Middle_NGlistSplitter.Size = new System.Drawing.Size(535, 78);
            this.Middle_NGlistSplitter.SplitterDistance = 160;
            this.Middle_NGlistSplitter.TabIndex = 0;
            // 
            // cb_NGList
            // 
            this.cb_NGList.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_NGList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_NGList.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_NGList.Location = new System.Drawing.Point(0, 0);
            this.cb_NGList.Name = "cb_NGList";
            this.cb_NGList.Size = new System.Drawing.Size(160, 78);
            this.cb_NGList.TabIndex = 0;
            this.cb_NGList.Text = "NG List";
            this.cb_NGList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cb_NGList.UseVisualStyleBackColor = true;
            this.cb_NGList.CheckedChanged += new System.EventHandler(this.cb_NGList_CheckedChanged);
            // 
            // Middle_ImageSplitter
            // 
            this.Middle_ImageSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Middle_ImageSplitter.Location = new System.Drawing.Point(0, 0);
            this.Middle_ImageSplitter.Name = "Middle_ImageSplitter";
            // 
            // Middle_ImageSplitter.Panel1
            // 
            this.Middle_ImageSplitter.Panel1.Controls.Add(this.cb_NG_IMAGE);
            // 
            // Middle_ImageSplitter.Panel2
            // 
            this.Middle_ImageSplitter.Panel2.Controls.Add(this.btn_AllDelete);
            this.Middle_ImageSplitter.Size = new System.Drawing.Size(371, 78);
            this.Middle_ImageSplitter.SplitterDistance = 160;
            this.Middle_ImageSplitter.TabIndex = 0;
            // 
            // cb_NG_IMAGE
            // 
            this.cb_NG_IMAGE.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_NG_IMAGE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_NG_IMAGE.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_NG_IMAGE.Location = new System.Drawing.Point(0, 0);
            this.cb_NG_IMAGE.Name = "cb_NG_IMAGE";
            this.cb_NG_IMAGE.Size = new System.Drawing.Size(160, 78);
            this.cb_NG_IMAGE.TabIndex = 1;
            this.cb_NG_IMAGE.Text = "NG 이미지";
            this.cb_NG_IMAGE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cb_NG_IMAGE.UseVisualStyleBackColor = true;
            this.cb_NG_IMAGE.CheckedChanged += new System.EventHandler(this.cb_NG_IMAGE_CheckedChanged);
            // 
            // btn_AllDelete
            // 
            this.btn_AllDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AllDelete.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_AllDelete.Location = new System.Drawing.Point(0, 0);
            this.btn_AllDelete.Name = "btn_AllDelete";
            this.btn_AllDelete.Size = new System.Drawing.Size(207, 78);
            this.btn_AllDelete.TabIndex = 0;
            this.btn_AllDelete.Text = "전체삭제";
            this.btn_AllDelete.UseVisualStyleBackColor = true;
            this.btn_AllDelete.Click += new System.EventHandler(this.btn_AllDelete_Click);
            // 
            // dgv_BlockingData
            // 
            this.dgv_BlockingData.AllowUserToAddRows = false;
            this.dgv_BlockingData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BlockingData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_BlockingData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BlockingData.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_BlockingData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BlockingData.Location = new System.Drawing.Point(0, 0);
            this.dgv_BlockingData.Name = "dgv_BlockingData";
            this.dgv_BlockingData.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BlockingData.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_BlockingData.RowHeadersVisible = false;
            this.dgv_BlockingData.RowTemplate.Height = 23;
            this.dgv_BlockingData.Size = new System.Drawing.Size(823, 391);
            this.dgv_BlockingData.TabIndex = 0;
            // 
            // Blocking_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 521);
            this.Controls.Add(this.Main1_splitter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Blocking_Form";
            this.Text = "Blocking_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Main1_splitter.Panel1.ResumeLayout(false);
            this.Main1_splitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Main1_splitter)).EndInit();
            this.Main1_splitter.ResumeLayout(false);
            this.Top_lbSplitter.Panel1.ResumeLayout(false);
            this.Top_lbSplitter.Panel1.PerformLayout();
            this.Top_lbSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Top_lbSplitter)).EndInit();
            this.Top_lbSplitter.ResumeLayout(false);
            this.Top_txtSplitter.Panel1.ResumeLayout(false);
            this.Top_txtSplitter.Panel1.PerformLayout();
            this.Top_txtSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Top_txtSplitter)).EndInit();
            this.Top_txtSplitter.ResumeLayout(false);
            this.Top_btnSplitter.Panel1.ResumeLayout(false);
            this.Top_btnSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Top_btnSplitter)).EndInit();
            this.Top_btnSplitter.ResumeLayout(false);
            this.Top_Exitsplitter.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Top_Exitsplitter)).EndInit();
            this.Top_Exitsplitter.ResumeLayout(false);
            this.Main2_Splitter.Panel1.ResumeLayout(false);
            this.Main2_Splitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Main2_Splitter)).EndInit();
            this.Main2_Splitter.ResumeLayout(false);
            this.Middle_AllSplitter.Panel1.ResumeLayout(false);
            this.Middle_AllSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Middle_AllSplitter)).EndInit();
            this.Middle_AllSplitter.ResumeLayout(false);
            this.Middle_SelectSplitter.Panel1.ResumeLayout(false);
            this.Middle_SelectSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Middle_SelectSplitter)).EndInit();
            this.Middle_SelectSplitter.ResumeLayout(false);
            this.Middle_NGlistSplitter.Panel1.ResumeLayout(false);
            this.Middle_NGlistSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Middle_NGlistSplitter)).EndInit();
            this.Middle_NGlistSplitter.ResumeLayout(false);
            this.Middle_ImageSplitter.Panel1.ResumeLayout(false);
            this.Middle_ImageSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Middle_ImageSplitter)).EndInit();
            this.Middle_ImageSplitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BlockingData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Main1_splitter;
        private System.Windows.Forms.SplitContainer Main2_Splitter;
        private System.Windows.Forms.SplitContainer Top_lbSplitter;
        private System.Windows.Forms.SplitContainer Top_txtSplitter;
        private System.Windows.Forms.SplitContainer Top_btnSplitter;
        private System.Windows.Forms.SplitContainer Middle_AllSplitter;
        private System.Windows.Forms.SplitContainer Middle_SelectSplitter;
        private System.Windows.Forms.SplitContainer Middle_NGlistSplitter;
        private System.Windows.Forms.SplitContainer Middle_ImageSplitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Button btn_SaveBarcode;
        private System.Windows.Forms.Button btn_DeleteData;
        private System.Windows.Forms.Button btn_AllDelete;
        private CheckBox cb_AllCheck;
        private CheckBox cb_SelectData;
        private CheckBox cb_NGList;
        private CheckBox cb_NG_IMAGE;
        private DataGridView dgv_BlockingData;
        private SplitContainer Top_Exitsplitter;
    }

}