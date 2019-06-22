namespace RS232_TEST
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbbBaudRate4 = new System.Windows.Forms.ComboBox();
            this.cbbPortName4 = new System.Windows.Forms.ComboBox();
            this.chkPortUse4 = new System.Windows.Forms.CheckBox();
            this.txtRS4 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbBaudRate3 = new System.Windows.Forms.ComboBox();
            this.cbbPortName3 = new System.Windows.Forms.ComboBox();
            this.chkPortUse3 = new System.Windows.Forms.CheckBox();
            this.txtRS3 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbBaudRate2 = new System.Windows.Forms.ComboBox();
            this.cbbPortName2 = new System.Windows.Forms.ComboBox();
            this.chkPortUse2 = new System.Windows.Forms.CheckBox();
            this.txtRS2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtStopBit = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtDataBit = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbBaudRate1 = new System.Windows.Forms.ComboBox();
            this.cbbPortName1 = new System.Windows.Forms.ComboBox();
            this.chkPortUse1 = new System.Windows.Forms.CheckBox();
            this.txtRS1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbbBaudRate4);
            this.groupBox4.Controls.Add(this.cbbPortName4);
            this.groupBox4.Controls.Add(this.chkPortUse4);
            this.groupBox4.Controls.Add(this.txtRS4);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(241, 161);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(212, 130);
            this.groupBox4.TabIndex = 159;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RS232#4";
            // 
            // cbbBaudRate4
            // 
            this.cbbBaudRate4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBaudRate4.FormattingEnabled = true;
            this.cbbBaudRate4.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.cbbBaudRate4.Location = new System.Drawing.Point(123, 67);
            this.cbbBaudRate4.Name = "cbbBaudRate4";
            this.cbbBaudRate4.Size = new System.Drawing.Size(70, 23);
            this.cbbBaudRate4.TabIndex = 152;
            // 
            // cbbPortName4
            // 
            this.cbbPortName4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPortName4.FormattingEnabled = true;
            this.cbbPortName4.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.cbbPortName4.Location = new System.Drawing.Point(22, 35);
            this.cbbPortName4.Name = "cbbPortName4";
            this.cbbPortName4.Size = new System.Drawing.Size(120, 23);
            this.cbbPortName4.TabIndex = 151;
            // 
            // chkPortUse4
            // 
            this.chkPortUse4.AutoSize = true;
            this.chkPortUse4.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.chkPortUse4.Location = new System.Drawing.Point(161, 12);
            this.chkPortUse4.Name = "chkPortUse4";
            this.chkPortUse4.Size = new System.Drawing.Size(48, 19);
            this.chkPortUse4.TabIndex = 148;
            this.chkPortUse4.Text = "Use";
            this.chkPortUse4.UseVisualStyleBackColor = true;
            // 
            // txtRS4
            // 
            this.txtRS4.Location = new System.Drawing.Point(22, 96);
            this.txtRS4.Name = "txtRS4";
            this.txtRS4.Size = new System.Drawing.Size(171, 23);
            this.txtRS4.TabIndex = 145;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(19, 71);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(67, 15);
            this.label26.TabIndex = 133;
            this.label26.Text = "전 송 속 도";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbbBaudRate3);
            this.groupBox3.Controls.Add(this.cbbPortName3);
            this.groupBox3.Controls.Add(this.chkPortUse3);
            this.groupBox3.Controls.Add(this.txtRS3);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(23, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 130);
            this.groupBox3.TabIndex = 160;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RS232#3";
            // 
            // cbbBaudRate3
            // 
            this.cbbBaudRate3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBaudRate3.FormattingEnabled = true;
            this.cbbBaudRate3.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.cbbBaudRate3.Location = new System.Drawing.Point(123, 67);
            this.cbbBaudRate3.Name = "cbbBaudRate3";
            this.cbbBaudRate3.Size = new System.Drawing.Size(70, 23);
            this.cbbBaudRate3.TabIndex = 153;
            // 
            // cbbPortName3
            // 
            this.cbbPortName3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPortName3.FormattingEnabled = true;
            this.cbbPortName3.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.cbbPortName3.Location = new System.Drawing.Point(22, 35);
            this.cbbPortName3.Name = "cbbPortName3";
            this.cbbPortName3.Size = new System.Drawing.Size(120, 23);
            this.cbbPortName3.TabIndex = 152;
            // 
            // chkPortUse3
            // 
            this.chkPortUse3.AutoSize = true;
            this.chkPortUse3.Location = new System.Drawing.Point(161, 12);
            this.chkPortUse3.Name = "chkPortUse3";
            this.chkPortUse3.Size = new System.Drawing.Size(48, 19);
            this.chkPortUse3.TabIndex = 148;
            this.chkPortUse3.Text = "Use";
            this.chkPortUse3.UseVisualStyleBackColor = true;
            // 
            // txtRS3
            // 
            this.txtRS3.Location = new System.Drawing.Point(22, 96);
            this.txtRS3.Name = "txtRS3";
            this.txtRS3.Size = new System.Drawing.Size(171, 23);
            this.txtRS3.TabIndex = 145;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(19, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 15);
            this.label18.TabIndex = 133;
            this.label18.Text = "전 송 속 도";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbBaudRate2);
            this.groupBox2.Controls.Add(this.cbbPortName2);
            this.groupBox2.Controls.Add(this.chkPortUse2);
            this.groupBox2.Controls.Add(this.txtRS2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(241, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 130);
            this.groupBox2.TabIndex = 157;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RS232#2";
            // 
            // cbbBaudRate2
            // 
            this.cbbBaudRate2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBaudRate2.FormattingEnabled = true;
            this.cbbBaudRate2.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.cbbBaudRate2.Location = new System.Drawing.Point(123, 67);
            this.cbbBaudRate2.Name = "cbbBaudRate2";
            this.cbbBaudRate2.Size = new System.Drawing.Size(70, 23);
            this.cbbBaudRate2.TabIndex = 151;
            // 
            // cbbPortName2
            // 
            this.cbbPortName2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPortName2.FormattingEnabled = true;
            this.cbbPortName2.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.cbbPortName2.Location = new System.Drawing.Point(22, 35);
            this.cbbPortName2.Name = "cbbPortName2";
            this.cbbPortName2.Size = new System.Drawing.Size(120, 23);
            this.cbbPortName2.TabIndex = 150;
            // 
            // chkPortUse2
            // 
            this.chkPortUse2.AutoSize = true;
            this.chkPortUse2.Checked = true;
            this.chkPortUse2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPortUse2.Location = new System.Drawing.Point(161, 12);
            this.chkPortUse2.Name = "chkPortUse2";
            this.chkPortUse2.Size = new System.Drawing.Size(48, 19);
            this.chkPortUse2.TabIndex = 149;
            this.chkPortUse2.Text = "Use";
            this.chkPortUse2.UseVisualStyleBackColor = true;
            // 
            // txtRS2
            // 
            this.txtRS2.Location = new System.Drawing.Point(22, 96);
            this.txtRS2.Name = "txtRS2";
            this.txtRS2.Size = new System.Drawing.Size(171, 23);
            this.txtRS2.TabIndex = 145;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 133;
            this.label6.Text = "전 송 속 도";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(127, 327);
            this.txtInterval.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtInterval.MaxLength = 15;
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(70, 21);
            this.txtInterval.TabIndex = 155;
            this.txtInterval.Text = "1000";
            this.txtInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(278, 331);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 151;
            this.label22.Text = "정 지 비 트";
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTest.Location = new System.Drawing.Point(25, 362);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(99, 33);
            this.btnTest.TabIndex = 161;
            this.btnTest.Text = "IR";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 154;
            this.label7.Text = "연 결 시 간";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(23, 305);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 12);
            this.label14.TabIndex = 150;
            this.label14.Text = "패 리 티";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(241, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 33);
            this.btnSave.TabIndex = 162;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtStopBit
            // 
            this.txtStopBit.Location = new System.Drawing.Point(382, 327);
            this.txtStopBit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtStopBit.MaxLength = 2;
            this.txtStopBit.Name = "txtStopBit";
            this.txtStopBit.Size = new System.Drawing.Size(70, 21);
            this.txtStopBit.TabIndex = 152;
            this.txtStopBit.Text = "1";
            this.txtStopBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(353, 362);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 33);
            this.btnClose.TabIndex = 158;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtDataBit
            // 
            this.txtDataBit.Location = new System.Drawing.Point(382, 302);
            this.txtDataBit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDataBit.MaxLength = 2;
            this.txtDataBit.Name = "txtDataBit";
            this.txtDataBit.Size = new System.Drawing.Size(70, 21);
            this.txtDataBit.TabIndex = 149;
            this.txtDataBit.Text = "8";
            this.txtDataBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbBaudRate1);
            this.groupBox1.Controls.Add(this.cbbPortName1);
            this.groupBox1.Controls.Add(this.chkPortUse1);
            this.groupBox1.Controls.Add(this.txtRS1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(23, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 130);
            this.groupBox1.TabIndex = 156;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RS232#1";
            // 
            // cbbBaudRate1
            // 
            this.cbbBaudRate1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBaudRate1.FormattingEnabled = true;
            this.cbbBaudRate1.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.cbbBaudRate1.Location = new System.Drawing.Point(123, 67);
            this.cbbBaudRate1.Name = "cbbBaudRate1";
            this.cbbBaudRate1.Size = new System.Drawing.Size(70, 23);
            this.cbbBaudRate1.TabIndex = 150;
            // 
            // cbbPortName1
            // 
            this.cbbPortName1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPortName1.FormattingEnabled = true;
            this.cbbPortName1.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.cbbPortName1.Location = new System.Drawing.Point(22, 35);
            this.cbbPortName1.Name = "cbbPortName1";
            this.cbbPortName1.Size = new System.Drawing.Size(120, 23);
            this.cbbPortName1.TabIndex = 149;
            // 
            // chkPortUse1
            // 
            this.chkPortUse1.AutoSize = true;
            this.chkPortUse1.Checked = true;
            this.chkPortUse1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPortUse1.Location = new System.Drawing.Point(161, 12);
            this.chkPortUse1.Name = "chkPortUse1";
            this.chkPortUse1.Size = new System.Drawing.Size(48, 19);
            this.chkPortUse1.TabIndex = 148;
            this.chkPortUse1.Text = "Use";
            this.chkPortUse1.UseVisualStyleBackColor = true;
            // 
            // txtRS1
            // 
            this.txtRS1.Location = new System.Drawing.Point(22, 96);
            this.txtRS1.Name = "txtRS1";
            this.txtRS1.Size = new System.Drawing.Size(171, 23);
            this.txtRS1.TabIndex = 145;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 133;
            this.label8.Text = "전 송 속 도";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(278, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 12);
            this.label9.TabIndex = 148;
            this.label9.Text = "비 트 수";
            // 
            // cmbParity
            // 
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cmbParity.Location = new System.Drawing.Point(127, 301);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(70, 20);
            this.cmbParity.TabIndex = 153;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(493, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(295, 370);
            this.richTextBox1.TabIndex = 163;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(25, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 33);
            this.button1.TabIndex = 164;
            this.button1.Text = "높이측정";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtStopBit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtDataBit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbParity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbbBaudRate4;
        private System.Windows.Forms.ComboBox cbbPortName4;
        private System.Windows.Forms.CheckBox chkPortUse4;
        private System.Windows.Forms.TextBox txtRS4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbbBaudRate3;
        private System.Windows.Forms.ComboBox cbbPortName3;
        private System.Windows.Forms.CheckBox chkPortUse3;
        private System.Windows.Forms.TextBox txtRS3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbBaudRate2;
        private System.Windows.Forms.ComboBox cbbPortName2;
        private System.Windows.Forms.CheckBox chkPortUse2;
        private System.Windows.Forms.TextBox txtRS2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtStopBit;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.TextBox txtDataBit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbBaudRate1;
        private System.Windows.Forms.ComboBox cbbPortName1;
        private System.Windows.Forms.CheckBox chkPortUse1;
        private System.Windows.Forms.TextBox txtRS1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}

