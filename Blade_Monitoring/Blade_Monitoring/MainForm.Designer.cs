namespace Blade_Monitoring
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dtp_SelectStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_SelectEndDate = new System.Windows.Forms.DateTimePicker();
            this.lb_startData = new System.Windows.Forms.Label();
            this.lb_EndDate = new System.Windows.Forms.Label();
            this.btn_dateSetting = new System.Windows.Forms.Button();
            this.tb_StartDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_EndDate = new System.Windows.Forms.TextBox();
            this.btn_Show_Graph = new System.Windows.Forms.Button();
            this.btn_SelfTimeSetting = new System.Windows.Forms.Button();
            this.User_Tab = new System.Windows.Forms.TabControl();
            this.GraphPage = new System.Windows.Forms.TabPage();
            this.SelectPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn_nglist_select = new System.Windows.Forms.Button();
            this.btn_nglist_delete = new System.Windows.Forms.Button();
            this.dgv_ngList = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btn_Blocking = new System.Windows.Forms.Button();
            this.cb_ng = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_save_data = new System.Windows.Forms.Button();
            this.lb_Query_speed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_startdate = new System.Windows.Forms.Label();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.cb_date = new System.Windows.Forms.CheckBox();
            this.btn_TotalSelect = new System.Windows.Forms.Button();
            this.btn_Selct = new System.Windows.Forms.Button();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.dgv_selectData = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_data_folder_start = new System.Windows.Forms.Button();
            this.btn_image_folder_start = new System.Windows.Forms.Button();
            this.btn_directory_data = new System.Windows.Forms.Button();
            this.txt_data_Path = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_select_directory = new System.Windows.Forms.Button();
            this.txt_image_path = new System.Windows.Forms.TextBox();
            this.lb_image_Path = new System.Windows.Forms.Label();
            this.btn_setting_Save = new System.Windows.Forms.Button();
            this.nud_End_Minutes = new System.Windows.Forms.NumericUpDown();
            this.nud_End_Hour = new System.Windows.Forms.NumericUpDown();
            this.nud_Start_Minutes = new System.Windows.Forms.NumericUpDown();
            this.nud_Start_Hour = new System.Windows.Forms.NumericUpDown();
            this.User_Tab.SuspendLayout();
            this.GraphPage.SuspendLayout();
            this.SelectPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ngList)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selectData)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_End_Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_End_Hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Start_Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Start_Hour)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_SelectStartDate
            // 
            this.dtp_SelectStartDate.CalendarFont = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtp_SelectStartDate.Font = new System.Drawing.Font("Gulim", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtp_SelectStartDate.Location = new System.Drawing.Point(160, 42);
            this.dtp_SelectStartDate.Name = "dtp_SelectStartDate";
            this.dtp_SelectStartDate.Size = new System.Drawing.Size(493, 50);
            this.dtp_SelectStartDate.TabIndex = 0;
            // 
            // dtp_SelectEndDate
            // 
            this.dtp_SelectEndDate.CalendarFont = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtp_SelectEndDate.Font = new System.Drawing.Font("Gulim", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtp_SelectEndDate.Location = new System.Drawing.Point(160, 102);
            this.dtp_SelectEndDate.Name = "dtp_SelectEndDate";
            this.dtp_SelectEndDate.Size = new System.Drawing.Size(493, 50);
            this.dtp_SelectEndDate.TabIndex = 1;
            // 
            // lb_startData
            // 
            this.lb_startData.AutoSize = true;
            this.lb_startData.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_startData.Location = new System.Drawing.Point(-5, 53);
            this.lb_startData.Name = "lb_startData";
            this.lb_startData.Size = new System.Drawing.Size(159, 35);
            this.lb_startData.TabIndex = 2;
            this.lb_startData.Text = "시작날짜";
            // 
            // lb_EndDate
            // 
            this.lb_EndDate.AutoSize = true;
            this.lb_EndDate.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_EndDate.Location = new System.Drawing.Point(-5, 113);
            this.lb_EndDate.Name = "lb_EndDate";
            this.lb_EndDate.Size = new System.Drawing.Size(159, 35);
            this.lb_EndDate.TabIndex = 3;
            this.lb_EndDate.Text = "종료날짜";
            // 
            // btn_dateSetting
            // 
            this.btn_dateSetting.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_dateSetting.Location = new System.Drawing.Point(669, 285);
            this.btn_dateSetting.Name = "btn_dateSetting";
            this.btn_dateSetting.Size = new System.Drawing.Size(263, 101);
            this.btn_dateSetting.TabIndex = 4;
            this.btn_dateSetting.Text = "자동 날짜지정";
            this.btn_dateSetting.UseVisualStyleBackColor = true;
            this.btn_dateSetting.Click += new System.EventHandler(this.btn_dateSetting_Click);
            // 
            // tb_StartDate
            // 
            this.tb_StartDate.Font = new System.Drawing.Font("Gulim", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_StartDate.Location = new System.Drawing.Point(236, 288);
            this.tb_StartDate.Name = "tb_StartDate";
            this.tb_StartDate.ReadOnly = true;
            this.tb_StartDate.Size = new System.Drawing.Size(417, 44);
            this.tb_StartDate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(-1, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "조회시작날짜";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(-1, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "조회종료날짜";
            // 
            // tb_EndDate
            // 
            this.tb_EndDate.Font = new System.Drawing.Font("Gulim", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_EndDate.Location = new System.Drawing.Point(236, 342);
            this.tb_EndDate.Name = "tb_EndDate";
            this.tb_EndDate.ReadOnly = true;
            this.tb_EndDate.Size = new System.Drawing.Size(417, 44);
            this.tb_EndDate.TabIndex = 8;
            // 
            // btn_Show_Graph
            // 
            this.btn_Show_Graph.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Show_Graph.Location = new System.Drawing.Point(669, 492);
            this.btn_Show_Graph.Name = "btn_Show_Graph";
            this.btn_Show_Graph.Size = new System.Drawing.Size(287, 101);
            this.btn_Show_Graph.TabIndex = 9;
            this.btn_Show_Graph.Text = "그래프 확인";
            this.btn_Show_Graph.UseVisualStyleBackColor = true;
            this.btn_Show_Graph.Click += new System.EventHandler(this.btn_Show_Graph_Click);
            // 
            // btn_SelfTimeSetting
            // 
            this.btn_SelfTimeSetting.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_SelfTimeSetting.Location = new System.Drawing.Point(669, 47);
            this.btn_SelfTimeSetting.Name = "btn_SelfTimeSetting";
            this.btn_SelfTimeSetting.Size = new System.Drawing.Size(263, 101);
            this.btn_SelfTimeSetting.TabIndex = 10;
            this.btn_SelfTimeSetting.Text = "수동 날짜지정";
            this.btn_SelfTimeSetting.UseVisualStyleBackColor = true;
            this.btn_SelfTimeSetting.Click += new System.EventHandler(this.btn_SelfTimeSetting_Click);
            // 
            // User_Tab
            // 
            this.User_Tab.Controls.Add(this.GraphPage);
            this.User_Tab.Controls.Add(this.SelectPage);
            this.User_Tab.Controls.Add(this.tabPage1);
            this.User_Tab.Controls.Add(this.tabPage2);
            this.User_Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_Tab.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.User_Tab.ItemSize = new System.Drawing.Size(100, 40);
            this.User_Tab.Location = new System.Drawing.Point(0, 0);
            this.User_Tab.Margin = new System.Windows.Forms.Padding(0);
            this.User_Tab.Name = "User_Tab";
            this.User_Tab.Padding = new System.Drawing.Point(0, 0);
            this.User_Tab.SelectedIndex = 0;
            this.User_Tab.Size = new System.Drawing.Size(1003, 661);
            this.User_Tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.User_Tab.TabIndex = 1;
            this.User_Tab.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.User_Tab_DrawItem);
            // 
            // GraphPage
            // 
            this.GraphPage.Controls.Add(this.btn_Show_Graph);
            this.GraphPage.Controls.Add(this.btn_SelfTimeSetting);
            this.GraphPage.Controls.Add(this.btn_dateSetting);
            this.GraphPage.Controls.Add(this.tb_StartDate);
            this.GraphPage.Controls.Add(this.dtp_SelectStartDate);
            this.GraphPage.Controls.Add(this.label1);
            this.GraphPage.Controls.Add(this.dtp_SelectEndDate);
            this.GraphPage.Controls.Add(this.lb_startData);
            this.GraphPage.Controls.Add(this.label2);
            this.GraphPage.Controls.Add(this.lb_EndDate);
            this.GraphPage.Controls.Add(this.tb_EndDate);
            this.GraphPage.Location = new System.Drawing.Point(4, 44);
            this.GraphPage.Name = "GraphPage";
            this.GraphPage.Padding = new System.Windows.Forms.Padding(3);
            this.GraphPage.Size = new System.Drawing.Size(995, 613);
            this.GraphPage.TabIndex = 0;
            this.GraphPage.Text = "그래프 확인";
            this.GraphPage.UseVisualStyleBackColor = true;
            // 
            // SelectPage
            // 
            this.SelectPage.Controls.Add(this.splitContainer1);
            this.SelectPage.Location = new System.Drawing.Point(4, 44);
            this.SelectPage.Name = "SelectPage";
            this.SelectPage.Padding = new System.Windows.Forms.Padding(3);
            this.SelectPage.Size = new System.Drawing.Size(995, 613);
            this.SelectPage.TabIndex = 1;
            this.SelectPage.Text = "NG Count";
            this.SelectPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_ngList);
            this.splitContainer1.Size = new System.Drawing.Size(989, 607);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btn_nglist_select);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btn_nglist_delete);
            this.splitContainer2.Size = new System.Drawing.Size(989, 100);
            this.splitContainer2.SplitterDistance = 450;
            this.splitContainer2.SplitterWidth = 100;
            this.splitContainer2.TabIndex = 0;
            // 
            // btn_nglist_select
            // 
            this.btn_nglist_select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_nglist_select.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_nglist_select.Location = new System.Drawing.Point(0, 0);
            this.btn_nglist_select.Name = "btn_nglist_select";
            this.btn_nglist_select.Size = new System.Drawing.Size(450, 100);
            this.btn_nglist_select.TabIndex = 30;
            this.btn_nglist_select.Text = "조회";
            this.btn_nglist_select.UseVisualStyleBackColor = true;
            this.btn_nglist_select.Click += new System.EventHandler(this.btn_nglist_select_Click);
            // 
            // btn_nglist_delete
            // 
            this.btn_nglist_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_nglist_delete.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_nglist_delete.Location = new System.Drawing.Point(0, 0);
            this.btn_nglist_delete.Name = "btn_nglist_delete";
            this.btn_nglist_delete.Size = new System.Drawing.Size(439, 100);
            this.btn_nglist_delete.TabIndex = 31;
            this.btn_nglist_delete.Text = "삭제";
            this.btn_nglist_delete.UseVisualStyleBackColor = true;
            this.btn_nglist_delete.Click += new System.EventHandler(this.btn_nglist_delete_Click);
            // 
            // dgv_ngList
            // 
            this.dgv_ngList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ngList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ngList.Location = new System.Drawing.Point(0, 0);
            this.dgv_ngList.Name = "dgv_ngList";
            this.dgv_ngList.RowHeadersVisible = false;
            this.dgv_ngList.RowTemplate.Height = 23;
            this.dgv_ngList.Size = new System.Drawing.Size(989, 506);
            this.dgv_ngList.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer3);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(995, 613);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "조회";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.nud_End_Minutes);
            this.splitContainer3.Panel1.Controls.Add(this.nud_End_Hour);
            this.splitContainer3.Panel1.Controls.Add(this.btn_Blocking);
            this.splitContainer3.Panel1.Controls.Add(this.cb_ng);
            this.splitContainer3.Panel1.Controls.Add(this.nud_Start_Minutes);
            this.splitContainer3.Panel1.Controls.Add(this.button1);
            this.splitContainer3.Panel1.Controls.Add(this.nud_Start_Hour);
            this.splitContainer3.Panel1.Controls.Add(this.btn_save_data);
            this.splitContainer3.Panel1.Controls.Add(this.lb_Query_speed);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.lb_startdate);
            this.splitContainer3.Panel1.Controls.Add(this.dtp_EndDate);
            this.splitContainer3.Panel1.Controls.Add(this.dtp_StartDate);
            this.splitContainer3.Panel1.Controls.Add(this.cb_date);
            this.splitContainer3.Panel1.Controls.Add(this.btn_TotalSelect);
            this.splitContainer3.Panel1.Controls.Add(this.btn_Selct);
            this.splitContainer3.Panel1.Controls.Add(this.txt_barcode);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dgv_selectData);
            this.splitContainer3.Size = new System.Drawing.Size(989, 607);
            this.splitContainer3.SplitterDistance = 150;
            this.splitContainer3.SplitterWidth = 1;
            this.splitContainer3.TabIndex = 0;
            // 
            // btn_Blocking
            // 
            this.btn_Blocking.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Blocking.Location = new System.Drawing.Point(174, 78);
            this.btn_Blocking.Name = "btn_Blocking";
            this.btn_Blocking.Size = new System.Drawing.Size(172, 57);
            this.btn_Blocking.TabIndex = 36;
            this.btn_Blocking.Text = "필터링";
            this.btn_Blocking.UseVisualStyleBackColor = true;
            this.btn_Blocking.Click += new System.EventHandler(this.btn_Blocking_Click);
            // 
            // cb_ng
            // 
            this.cb_ng.AutoSize = true;
            this.cb_ng.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_ng.Location = new System.Drawing.Point(376, 106);
            this.cb_ng.Name = "cb_ng";
            this.cb_ng.Size = new System.Drawing.Size(102, 19);
            this.cb_ng.TabIndex = 35;
            this.cb_ng.Text = "OK도 보기";
            this.cb_ng.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(502, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(482, 53);
            this.button1.TabIndex = 34;
            this.button1.Text = "NG이미지 보기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_save_data
            // 
            this.btn_save_data.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_save_data.Location = new System.Drawing.Point(3, 57);
            this.btn_save_data.Name = "btn_save_data";
            this.btn_save_data.Size = new System.Drawing.Size(123, 35);
            this.btn_save_data.TabIndex = 33;
            this.btn_save_data.Text = "데이터 저장";
            this.btn_save_data.UseVisualStyleBackColor = true;
            this.btn_save_data.Click += new System.EventHandler(this.btn_save_data_Click);
            // 
            // lb_Query_speed
            // 
            this.lb_Query_speed.AutoSize = true;
            this.lb_Query_speed.Location = new System.Drawing.Point(5, 128);
            this.lb_Query_speed.Name = "lb_Query_speed";
            this.lb_Query_speed.Size = new System.Drawing.Size(56, 13);
            this.lb_Query_speed.TabIndex = 32;
            this.lb_Query_speed.Text = "0초 0행";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(499, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "종료날짜";
            // 
            // lb_startdate
            // 
            this.lb_startdate.AutoSize = true;
            this.lb_startdate.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_startdate.Location = new System.Drawing.Point(499, 77);
            this.lb_startdate.Name = "lb_startdate";
            this.lb_startdate.Size = new System.Drawing.Size(71, 15);
            this.lb_startdate.TabIndex = 30;
            this.lb_startdate.Text = "시작날짜";
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.CalendarFont = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtp_EndDate.CustomFormat = "yyyy/MM/dd";
            this.dtp_EndDate.Enabled = false;
            this.dtp_EndDate.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EndDate.Location = new System.Drawing.Point(576, 101);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(219, 35);
            this.dtp_EndDate.TabIndex = 29;
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.CalendarFont = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtp_StartDate.CustomFormat = "yyyy/MM/dd";
            this.dtp_StartDate.Enabled = false;
            this.dtp_StartDate.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_StartDate.Location = new System.Drawing.Point(576, 62);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(219, 35);
            this.dtp_StartDate.TabIndex = 28;
            // 
            // cb_date
            // 
            this.cb_date.AutoSize = true;
            this.cb_date.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_date.Location = new System.Drawing.Point(388, 76);
            this.cb_date.Name = "cb_date";
            this.cb_date.Size = new System.Drawing.Size(90, 19);
            this.cb_date.TabIndex = 27;
            this.cb_date.Text = "날짜제한";
            this.cb_date.UseVisualStyleBackColor = true;
            this.cb_date.CheckedChanged += new System.EventHandler(this.cb_date_CheckedChanged);
            // 
            // btn_TotalSelect
            // 
            this.btn_TotalSelect.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_TotalSelect.Location = new System.Drawing.Point(330, 3);
            this.btn_TotalSelect.Name = "btn_TotalSelect";
            this.btn_TotalSelect.Size = new System.Drawing.Size(148, 53);
            this.btn_TotalSelect.TabIndex = 26;
            this.btn_TotalSelect.Text = "조회";
            this.btn_TotalSelect.UseVisualStyleBackColor = true;
            this.btn_TotalSelect.Click += new System.EventHandler(this.btn_TotalSelect_Click);
            // 
            // btn_Selct
            // 
            this.btn_Selct.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Selct.Location = new System.Drawing.Point(174, 3);
            this.btn_Selct.Name = "btn_Selct";
            this.btn_Selct.Size = new System.Drawing.Size(150, 53);
            this.btn_Selct.TabIndex = 25;
            this.btn_Selct.Text = "개별조회";
            this.btn_Selct.UseVisualStyleBackColor = true;
            this.btn_Selct.Click += new System.EventHandler(this.btn_Selct_Click);
            // 
            // txt_barcode
            // 
            this.txt_barcode.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_barcode.Location = new System.Drawing.Point(3, 3);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(163, 48);
            this.txt_barcode.TabIndex = 24;
            // 
            // dgv_selectData
            // 
            this.dgv_selectData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_selectData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_selectData.Location = new System.Drawing.Point(0, 0);
            this.dgv_selectData.Name = "dgv_selectData";
            this.dgv_selectData.RowHeadersVisible = false;
            this.dgv_selectData.RowTemplate.Height = 23;
            this.dgv_selectData.Size = new System.Drawing.Size(989, 456);
            this.dgv_selectData.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_data_folder_start);
            this.tabPage2.Controls.Add(this.btn_image_folder_start);
            this.tabPage2.Controls.Add(this.btn_directory_data);
            this.tabPage2.Controls.Add(this.txt_data_Path);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btn_select_directory);
            this.tabPage2.Controls.Add(this.txt_image_path);
            this.tabPage2.Controls.Add(this.lb_image_Path);
            this.tabPage2.Controls.Add(this.btn_setting_Save);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(995, 613);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "설정";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_data_folder_start
            // 
            this.btn_data_folder_start.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_data_folder_start.Location = new System.Drawing.Point(153, 94);
            this.btn_data_folder_start.Name = "btn_data_folder_start";
            this.btn_data_folder_start.Size = new System.Drawing.Size(217, 44);
            this.btn_data_folder_start.TabIndex = 35;
            this.btn_data_folder_start.Text = "폴더열기";
            this.btn_data_folder_start.UseVisualStyleBackColor = true;
            this.btn_data_folder_start.Click += new System.EventHandler(this.btn_data_folder_start_Click);
            // 
            // btn_image_folder_start
            // 
            this.btn_image_folder_start.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_image_folder_start.Location = new System.Drawing.Point(147, 11);
            this.btn_image_folder_start.Name = "btn_image_folder_start";
            this.btn_image_folder_start.Size = new System.Drawing.Size(223, 37);
            this.btn_image_folder_start.TabIndex = 34;
            this.btn_image_folder_start.Text = "폴더열기";
            this.btn_image_folder_start.UseVisualStyleBackColor = true;
            this.btn_image_folder_start.Click += new System.EventHandler(this.btn_image_folder_start_Click);
            // 
            // btn_directory_data
            // 
            this.btn_directory_data.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_directory_data.Location = new System.Drawing.Point(376, 144);
            this.btn_directory_data.Name = "btn_directory_data";
            this.btn_directory_data.Size = new System.Drawing.Size(62, 27);
            this.btn_directory_data.TabIndex = 33;
            this.btn_directory_data.Text = "...";
            this.btn_directory_data.UseVisualStyleBackColor = true;
            this.btn_directory_data.Click += new System.EventHandler(this.btn_directory_data_Click);
            // 
            // txt_data_Path
            // 
            this.txt_data_Path.Enabled = false;
            this.txt_data_Path.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_data_Path.Location = new System.Drawing.Point(11, 144);
            this.txt_data_Path.Name = "txt_data_Path";
            this.txt_data_Path.Size = new System.Drawing.Size(359, 26);
            this.txt_data_Path.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(8, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "데이터 저장 경로";
            // 
            // btn_select_directory
            // 
            this.btn_select_directory.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_select_directory.Location = new System.Drawing.Point(376, 53);
            this.btn_select_directory.Name = "btn_select_directory";
            this.btn_select_directory.Size = new System.Drawing.Size(62, 27);
            this.btn_select_directory.TabIndex = 30;
            this.btn_select_directory.Text = "...";
            this.btn_select_directory.UseVisualStyleBackColor = true;
            this.btn_select_directory.Click += new System.EventHandler(this.btn_select_directory_Click);
            // 
            // txt_image_path
            // 
            this.txt_image_path.Enabled = false;
            this.txt_image_path.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_image_path.Location = new System.Drawing.Point(11, 54);
            this.txt_image_path.Name = "txt_image_path";
            this.txt_image_path.Size = new System.Drawing.Size(359, 26);
            this.txt_image_path.TabIndex = 29;
            // 
            // lb_image_Path
            // 
            this.lb_image_Path.AutoSize = true;
            this.lb_image_Path.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_image_Path.Location = new System.Drawing.Point(8, 21);
            this.lb_image_Path.Name = "lb_image_Path";
            this.lb_image_Path.Size = new System.Drawing.Size(133, 16);
            this.lb_image_Path.TabIndex = 28;
            this.lb_image_Path.Text = "이미지저장 경로";
            // 
            // btn_setting_Save
            // 
            this.btn_setting_Save.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_setting_Save.Location = new System.Drawing.Point(11, 206);
            this.btn_setting_Save.Name = "btn_setting_Save";
            this.btn_setting_Save.Size = new System.Drawing.Size(257, 87);
            this.btn_setting_Save.TabIndex = 27;
            this.btn_setting_Save.Text = "설정 저장";
            this.btn_setting_Save.UseVisualStyleBackColor = true;
            this.btn_setting_Save.Click += new System.EventHandler(this.btn_setting_Save_Click);
            // 
            // nud_End_Minutes
            // 
            this.nud_End_Minutes.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nud_End_Minutes.Location = new System.Drawing.Point(885, 101);
            this.nud_End_Minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_End_Minutes.Name = "nud_End_Minutes";
            this.nud_End_Minutes.Size = new System.Drawing.Size(99, 25);
            this.nud_End_Minutes.TabIndex = 41;
            // 
            // nud_End_Hour
            // 
            this.nud_End_Hour.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nud_End_Hour.Location = new System.Drawing.Point(801, 101);
            this.nud_End_Hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nud_End_Hour.Name = "nud_End_Hour";
            this.nud_End_Hour.Size = new System.Drawing.Size(54, 25);
            this.nud_End_Hour.TabIndex = 40;
            // 
            // nud_Start_Minutes
            // 
            this.nud_Start_Minutes.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nud_Start_Minutes.Location = new System.Drawing.Point(885, 62);
            this.nud_Start_Minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_Start_Minutes.Name = "nud_Start_Minutes";
            this.nud_Start_Minutes.Size = new System.Drawing.Size(99, 25);
            this.nud_Start_Minutes.TabIndex = 39;
            // 
            // nud_Start_Hour
            // 
            this.nud_Start_Hour.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nud_Start_Hour.Location = new System.Drawing.Point(801, 62);
            this.nud_Start_Hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nud_Start_Hour.Name = "nud_Start_Hour";
            this.nud_Start_Hour.Size = new System.Drawing.Size(54, 25);
            this.nud_Start_Hour.TabIndex = 38;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 661);
            this.Controls.Add(this.User_Tab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "모니터링 프로그램";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.User_Tab.ResumeLayout(false);
            this.GraphPage.ResumeLayout(false);
            this.GraphPage.PerformLayout();
            this.SelectPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ngList)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selectData)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_End_Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_End_Hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Start_Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Start_Hour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_SelectStartDate;
        private System.Windows.Forms.DateTimePicker dtp_SelectEndDate;
        private System.Windows.Forms.Label lb_startData;
        private System.Windows.Forms.Label lb_EndDate;
        private System.Windows.Forms.Button btn_dateSetting;
        private System.Windows.Forms.TextBox tb_StartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_EndDate;
        private System.Windows.Forms.Button btn_Show_Graph;
        private System.Windows.Forms.Button btn_SelfTimeSetting;
        private System.Windows.Forms.TabControl User_Tab;
        private System.Windows.Forms.TabPage GraphPage;
        private System.Windows.Forms.TabPage SelectPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn_nglist_select;
        private System.Windows.Forms.Button btn_nglist_delete;
        private System.Windows.Forms.DataGridView dgv_ngList;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.CheckBox cb_ng;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_save_data;
        private System.Windows.Forms.Label lb_Query_speed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_startdate;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.CheckBox cb_date;
        private System.Windows.Forms.Button btn_TotalSelect;
        private System.Windows.Forms.Button btn_Selct;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.DataGridView dgv_selectData;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_data_folder_start;
        private System.Windows.Forms.Button btn_image_folder_start;
        private System.Windows.Forms.Button btn_directory_data;
        internal System.Windows.Forms.TextBox txt_data_Path;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_select_directory;
        internal System.Windows.Forms.TextBox txt_image_path;
        private System.Windows.Forms.Label lb_image_Path;
        private System.Windows.Forms.Button btn_setting_Save;
        private System.Windows.Forms.Button btn_Blocking;
        private System.Windows.Forms.NumericUpDown nud_End_Minutes;
        private System.Windows.Forms.NumericUpDown nud_End_Hour;
        private System.Windows.Forms.NumericUpDown nud_Start_Minutes;
        private System.Windows.Forms.NumericUpDown nud_Start_Hour;
    }
}

