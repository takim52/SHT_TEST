namespace INSIGHT_SDK_TEST
{
    partial class Camconfigform
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
            this.lb_DeviceName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNewdevices = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSt1 = new System.Windows.Forms.DataGridView();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsert1 = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewdevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSt1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_DeviceName
            // 
            this.lb_DeviceName.AutoSize = true;
            this.lb_DeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_DeviceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_DeviceName.Location = new System.Drawing.Point(12, 21);
            this.lb_DeviceName.Name = "lb_DeviceName";
            this.lb_DeviceName.Size = new System.Drawing.Size(124, 24);
            this.lb_DeviceName.TabIndex = 8;
            this.lb_DeviceName.Text = "Device Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(335, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "InspectionCam";
            // 
            // dgvNewdevices
            // 
            this.dgvNewdevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewdevices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.IP});
            this.dgvNewdevices.Location = new System.Drawing.Point(12, 48);
            this.dgvNewdevices.Name = "dgvNewdevices";
            this.dgvNewdevices.ReadOnly = true;
            this.dgvNewdevices.RowHeadersVisible = false;
            this.dgvNewdevices.RowTemplate.Height = 23;
            this.dgvNewdevices.Size = new System.Drawing.Size(237, 387);
            this.dgvNewdevices.TabIndex = 12;
            // 
            // Name
            // 
            this.Name.HeaderText = "Device Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 110;
            // 
            // IP
            // 
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            // 
            // dgvSt1
            // 
            this.dgvSt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSt1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceName,
            this._ip});
            this.dgvSt1.Location = new System.Drawing.Point(339, 46);
            this.dgvSt1.Name = "dgvSt1";
            this.dgvSt1.ReadOnly = true;
            this.dgvSt1.RowHeadersVisible = false;
            this.dgvSt1.RowTemplate.Height = 23;
            this.dgvSt1.Size = new System.Drawing.Size(255, 389);
            this.dgvSt1.TabIndex = 13;
            // 
            // DeviceName
            // 
            this.DeviceName.HeaderText = "Device Name";
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.ReadOnly = true;
            this.DeviceName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.DeviceName.Width = 110;
            // 
            // _ip
            // 
            this._ip.HeaderText = "IP";
            this._ip.Name = "_ip";
            this._ip.ReadOnly = true;
            // 
            // btnInsert1
            // 
            this.btnInsert1.BackColor = System.Drawing.Color.Gray;
            this.btnInsert1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInsert1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsert1.Location = new System.Drawing.Point(277, 154);
            this.btnInsert1.Name = "btnInsert1";
            this.btnInsert1.Size = new System.Drawing.Size(35, 39);
            this.btnInsert1.TabIndex = 14;
            this.btnInsert1.Text = "→";
            this.btnInsert1.UseVisualStyleBackColor = false;
            this.btnInsert1.Click += new System.EventHandler(this.BtnInsert1_Click);
            // 
            // btnDelete1
            // 
            this.btnDelete1.BackColor = System.Drawing.Color.Gray;
            this.btnDelete1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete1.Location = new System.Drawing.Point(277, 199);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(35, 39);
            this.btnDelete1.TabIndex = 16;
            this.btnDelete1.Text = "←";
            this.btnDelete1.UseVisualStyleBackColor = false;
            this.btnDelete1.Click += new System.EventHandler(this.BtnDelete1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gray;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(16, 489);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 36);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.Color.Gray;
            this.btn_enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_enter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_enter.Enabled = false;
            this.btn_enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_enter.Location = new System.Drawing.Point(410, 489);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(85, 36);
            this.btn_enter.TabIndex = 18;
            this.btn_enter.Text = "OK";
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.Btn_enter_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Gray;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Enabled = false;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_close.Location = new System.Drawing.Point(509, 489);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(85, 36);
            this.btn_close.TabIndex = 19;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // Camconfigform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(619, 549);
            this.ControlBox = false;
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.btnInsert1);
            this.Controls.Add(this.dgvSt1);
            this.Controls.Add(this.dgvNewdevices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_DeviceName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewdevices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSt1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_DeviceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNewdevices;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridView dgvSt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ip;
        private System.Windows.Forms.Button btnInsert1;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_close;
    }
}