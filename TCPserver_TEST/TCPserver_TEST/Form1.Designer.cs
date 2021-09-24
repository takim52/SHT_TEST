
namespace TCPserver_TEST
{
    partial class Form1
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
            this.ipList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nup_port = new System.Windows.Forms.NumericUpDown();
            this.btn_serverStart = new System.Windows.Forms.Button();
            this.listbox_UI_LOG = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sendtxt = new System.Windows.Forms.TextBox();
            this.btn_DataSend = new System.Windows.Forms.Button();
            this.btn_serverState = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nup_port)).BeginInit();
            this.SuspendLayout();
            // 
            // ipList
            // 
            this.ipList.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ipList.FormattingEnabled = true;
            this.ipList.Location = new System.Drawing.Point(41, 6);
            this.ipList.Name = "ipList";
            this.ipList.Size = new System.Drawing.Size(167, 27);
            this.ipList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(226, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "PORT";
            // 
            // nup_port
            // 
            this.nup_port.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nup_port.Location = new System.Drawing.Point(286, 7);
            this.nup_port.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nup_port.Name = "nup_port";
            this.nup_port.Size = new System.Drawing.Size(120, 29);
            this.nup_port.TabIndex = 3;
            // 
            // btn_serverStart
            // 
            this.btn_serverStart.BackColor = System.Drawing.Color.Gray;
            this.btn_serverStart.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_serverStart.ForeColor = System.Drawing.Color.White;
            this.btn_serverStart.Location = new System.Drawing.Point(439, 6);
            this.btn_serverStart.Name = "btn_serverStart";
            this.btn_serverStart.Size = new System.Drawing.Size(119, 41);
            this.btn_serverStart.TabIndex = 4;
            this.btn_serverStart.Text = "Start";
            this.btn_serverStart.UseVisualStyleBackColor = false;
            this.btn_serverStart.Click += new System.EventHandler(this.btn_serverStart_Click);
            // 
            // listbox_UI_LOG
            // 
            this.listbox_UI_LOG.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listbox_UI_LOG.FormattingEnabled = true;
            this.listbox_UI_LOG.ItemHeight = 19;
            this.listbox_UI_LOG.Location = new System.Drawing.Point(16, 102);
            this.listbox_UI_LOG.Name = "listbox_UI_LOG";
            this.listbox_UI_LOG.ScrollAlwaysVisible = true;
            this.listbox_UI_LOG.Size = new System.Drawing.Size(840, 422);
            this.listbox_UI_LOG.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Send_Text";
            // 
            // txt_sendtxt
            // 
            this.txt_sendtxt.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_sendtxt.Location = new System.Drawing.Point(112, 61);
            this.txt_sendtxt.Name = "txt_sendtxt";
            this.txt_sendtxt.Size = new System.Drawing.Size(294, 29);
            this.txt_sendtxt.TabIndex = 7;
            // 
            // btn_DataSend
            // 
            this.btn_DataSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_DataSend.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_DataSend.ForeColor = System.Drawing.Color.White;
            this.btn_DataSend.Location = new System.Drawing.Point(439, 53);
            this.btn_DataSend.Name = "btn_DataSend";
            this.btn_DataSend.Size = new System.Drawing.Size(119, 41);
            this.btn_DataSend.TabIndex = 8;
            this.btn_DataSend.Text = "DataSend";
            this.btn_DataSend.UseVisualStyleBackColor = false;
            this.btn_DataSend.Click += new System.EventHandler(this.btn_DataSend_Click);
            // 
            // btn_serverState
            // 
            this.btn_serverState.BackColor = System.Drawing.Color.Red;
            this.btn_serverState.Location = new System.Drawing.Point(564, 7);
            this.btn_serverState.Name = "btn_serverState";
            this.btn_serverState.Size = new System.Drawing.Size(27, 40);
            this.btn_serverState.TabIndex = 9;
            this.btn_serverState.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 534);
            this.Controls.Add(this.btn_serverState);
            this.Controls.Add(this.btn_DataSend);
            this.Controls.Add(this.txt_sendtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listbox_UI_LOG);
            this.Controls.Add(this.btn_serverStart);
            this.Controls.Add(this.nup_port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nup_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ipList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nup_port;
        private System.Windows.Forms.Button btn_serverStart;
        private System.Windows.Forms.ListBox listbox_UI_LOG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sendtxt;
        private System.Windows.Forms.Button btn_DataSend;
        private System.Windows.Forms.Button btn_serverState;
    }
}

