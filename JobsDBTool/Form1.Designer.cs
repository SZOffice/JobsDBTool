namespace JobsDBTool
{
    partial class mainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.rbType_Excel = new System.Windows.Forms.RadioButton();
            this.rbType_DB = new System.Windows.Forms.RadioButton();
            this.gb_DBType = new System.Windows.Forms.GroupBox();
            this.rbType_String = new System.Windows.Forms.RadioButton();
            this.btnGetData = new System.Windows.Forms.Button();
            this.tc1 = new System.Windows.Forms.TabControl();
            this.tp_Common = new System.Windows.Forms.TabPage();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.tasks_btnSearch = new System.Windows.Forms.Button();
            this.tasks_txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.tasks_cbSearchStatus_Doing = new System.Windows.Forms.CheckBox();
            this.tasks_cbSearchStatus_Submitted = new System.Windows.Forms.CheckBox();
            this.tasks_cbSearchStatus_Pending = new System.Windows.Forms.CheckBox();
            this.tasks_cbSearchStatus_Done = new System.Windows.Forms.CheckBox();
            this.tasks_cbSearchStatus_Draft = new System.Windows.Forms.CheckBox();
            this.tasks_cbSearchStatus_WaitResource = new System.Windows.Forms.CheckBox();
            this.tasks_btnEditData = new System.Windows.Forms.Button();
            this.dgv_task = new System.Windows.Forms.DataGridView();
            this.tasks_btnDelData = new System.Windows.Forms.Button();
            this.tasks_btnAddData = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.document_cbIsAdd = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.document_txtNodeName = new System.Windows.Forms.TextBox();
            this.document_btnSaveNode = new System.Windows.Forms.Button();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.document_tvDoc = new System.Windows.Forms.TreeView();
            this.document_cmsDoc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.document_tsmi_addNode = new System.Windows.Forms.ToolStripMenuItem();
            this.document_tsmi_deleteNode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.document_tsmi_clearNode = new System.Windows.Forms.ToolStripMenuItem();
            this.document_rtbContent = new System.Windows.Forms.RichTextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.extractdll_btnExtract = new System.Windows.Forms.Button();
            this.extractdll_btnReorder = new System.Windows.Forms.Button();
            this.extractdll_rtbSource = new System.Windows.Forms.RichTextBox();
            this.extractdll_Result = new System.Windows.Forms.RichTextBox();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.rtbCommon_RunSql_SqlQuery = new System.Windows.Forms.RichTextBox();
            this.plCommon_RunSql_Params = new System.Windows.Forms.Panel();
            this.label45 = new System.Windows.Forms.Label();
            this.cbCommon_RunSql_SqlTemplate = new System.Windows.Forms.ComboBox();
            this.gvCommon_RunSql_SqlResult = new System.Windows.Forms.DataGridView();
            this.btnCommon_RunSql_Run = new System.Windows.Forms.Button();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.cbGenCopyBat_IsToLocal = new System.Windows.Forms.CheckBox();
            this.btnGenCopyBat_Gen = new System.Windows.Forms.Button();
            this.plGenCopyBat_ServerList = new System.Windows.Forms.Panel();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.txtGenCopyBat_BatPath = new System.Windows.Forms.TextBox();
            this.rtbGenCopyBat_Result = new System.Windows.Forms.RichTextBox();
            this.btnGenCopyBat_RunBat = new System.Windows.Forms.Button();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.cbGenCopyBat_ProductAgent = new System.Windows.Forms.CheckBox();
            this.cbGenCopyBat_ProductWeb = new System.Windows.Forms.CheckBox();
            this.cbGenCopyBat_PreviewAgent = new System.Windows.Forms.CheckBox();
            this.cbGenCopyBat_PreviewWeb = new System.Windows.Forms.CheckBox();
            this.label48 = new System.Windows.Forms.Label();
            this.txtGenCopyBat_TargetPath = new System.Windows.Forms.TextBox();
            this.cbGenCopyBat_Template = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.txtGenCopyBat_SourcePath = new System.Windows.Forms.TextBox();
            this.tp_AddWordings = new System.Windows.Forms.TabPage();
            this.tc_AddWordings = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.btnGoResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.cbLanguageTH = new System.Windows.Forms.ComboBox();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.cbLanguageID = new System.Windows.Forms.ComboBox();
            this.txtWordingKey = new System.Windows.Forms.TextBox();
            this.cbLanguageXX = new System.Windows.Forms.ComboBox();
            this.txtXXContent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtTHContent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbWordingGroup = new System.Windows.Forms.ListBox();
            this.tp_GetData = new System.Windows.Forms.TabPage();
            this.txtGetData = new System.Windows.Forms.TextBox();
            this.tp_GetString = new System.Windows.Forms.TabPage();
            this.clbCountry = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGetString = new System.Windows.Forms.TextBox();
            this.tp_AddData = new System.Windows.Forms.TabPage();
            this.txtAddWordings_WordingKeySql = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.tp_Result = new System.Windows.Forms.TabPage();
            this.lbWording_SqlQueryPathLabel = new System.Windows.Forms.Label();
            this.lbWording_SqlQueryPath = new System.Windows.Forms.Label();
            this.btnWording_GenSqlQuery = new System.Windows.Forms.Button();
            this.cbHelpColumns = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gv_Result = new System.Windows.Forms.DataGridView();
            this.btnWipe = new System.Windows.Forms.Button();
            this.txtTargetConnStr = new System.Windows.Forms.TextBox();
            this.cbTargetConnName = new System.Windows.Forms.ComboBox();
            this.tp_WordingSearch = new System.Windows.Forms.TabPage();
            this.cbWordingKey = new System.Windows.Forms.CheckBox();
            this.cbWordingContent = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.txtSearchContent = new System.Windows.Forms.TextBox();
            this.gv_SearchResult = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.tp_ClassFieldAbbr = new System.Windows.Forms.TabPage();
            this.gvClassFieldResult = new System.Windows.Forms.DataGridView();
            this.btnGetAbbr = new System.Windows.Forms.Button();
            this.txtClassField = new System.Windows.Forms.TextBox();
            this.tp_BackupTask = new System.Windows.Forms.TabPage();
            this.cbBackupTaskTaskName = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBackupTaskSubmitResult = new System.Windows.Forms.TextBox();
            this.btnBackupTaskLoad = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBackupTaskLastestPath = new System.Windows.Forms.TextBox();
            this.btnBackupTaskLastestPath = new System.Windows.Forms.Button();
            this.cbBackupTaskTargetPath = new System.Windows.Forms.ComboBox();
            this.cbBackupTaskBackWording = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBackupTaskTargetPath = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBackupTaskPath = new System.Windows.Forms.TextBox();
            this.btnBackupTaskPath = new System.Windows.Forms.Button();
            this.cbBackupTaskType = new System.Windows.Forms.ComboBox();
            this.txtBackupTaskFileList = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBackupSubmit = new System.Windows.Forms.Button();
            this.txtBackupTaskName = new System.Windows.Forms.TextBox();
            this.tp_OperateDB = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txtOthers_LastName = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtOthers_FirstName = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.cbOthers_ToCountryCode = new System.Windows.Forms.ComboBox();
            this.cbOthers_CountryCode = new System.Windows.Forms.ComboBox();
            this.cbOthers_IsNewWorkforce = new System.Windows.Forms.CheckBox();
            this.cbOthers_JobCount = new System.Windows.Forms.ComboBox();
            this.cbOthers_CandidateCount = new System.Windows.Forms.ComboBox();
            this.cbOthers_ProfilePrivacyLevel = new System.Windows.Forms.ComboBox();
            this.cbOthers_CountryOfResidence = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.cbOthers_Account = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtOthers_JobSeekerId = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtOthers_Email = new System.Windows.Forms.TextBox();
            this.btnOthers_Add = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.txtOthers_JobTitle = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtOthers_JobAdId = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtOthers_InvoiceItemID = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtOthers_EmployerId = new System.Windows.Forms.TextBox();
            this.cbOthers_AddJob = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtOthers_AccountNum = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbOthers_AddCandidate = new System.Windows.Forms.CheckBox();
            this.txtOthers_SubAccount = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtOperateDB_List = new System.Windows.Forms.TextBox();
            this.btnOperateDB_Start = new System.Windows.Forms.Button();
            this.btnOperateDB_GetDB = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbOperateDB_Restore = new System.Windows.Forms.RadioButton();
            this.rbOperateDB_Backup = new System.Windows.Forms.RadioButton();
            this.cbOperateDB_Database = new System.Windows.Forms.ComboBox();
            this.btnOperateDB_BrowseScriptList = new System.Windows.Forms.Button();
            this.btnOperateDB_LoadScriptList = new System.Windows.Forms.Button();
            this.txtOperateDB_ScriptListPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbOperateDB_ScriptSchema = new System.Windows.Forms.CheckBox();
            this.cbOperateDB_ScriptData = new System.Windows.Forms.CheckBox();
            this.cbOperateDB_ScriptDrops = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOperateDB_ScriptObj_IgnoreList = new System.Windows.Forms.RadioButton();
            this.rbOperateDB_ScriptObj_OnlyList = new System.Windows.Forms.RadioButton();
            this.rbOperateDB_ScriptObj_All = new System.Windows.Forms.RadioButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cbOperateDB_Country_US = new System.Windows.Forms.CheckBox();
            this.cbOperateDB_Country_TH = new System.Windows.Forms.CheckBox();
            this.cbOperateDB_Country_TW = new System.Windows.Forms.CheckBox();
            this.cbOperateDB_Country_PH = new System.Windows.Forms.CheckBox();
            this.cbOperateDB_Country_SG = new System.Windows.Forms.CheckBox();
            this.cbOperateDB_Country_ID = new System.Windows.Forms.CheckBox();
            this.cbOperateDB_Country_IN = new System.Windows.Forms.CheckBox();
            this.cbOperateDB_Country_KR = new System.Windows.Forms.CheckBox();
            this.cbOperateDB_Country_MY = new System.Windows.Forms.CheckBox();
            this.cbOperateDB_Country_AU = new System.Windows.Forms.CheckBox();
            this.cbOperateDB_Country_HK = new System.Windows.Forms.CheckBox();
            this.btnOperateDB_Country_Generate = new System.Windows.Forms.Button();
            this.txtOperateDB_Country_Content = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnOthers_DropRMSDB = new System.Windows.Forms.Button();
            this.btnOthers_RunSql = new System.Windows.Forms.Button();
            this.txtOperateDB_Sql = new System.Windows.Forms.TextBox();
            this.btOperateDB_LoadSql = new System.Windows.Forms.Button();
            this.txtOperateDB_SqlPath = new System.Windows.Forms.TextBox();
            this.btnOperateDB_Browse = new System.Windows.Forms.Button();
            this.btnOperateDB_Save = new System.Windows.Forms.Button();
            this.tp_SolrUpdate = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtbQuery = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSolrUpdate_FixDB = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSolrQueryUrl = new System.Windows.Forms.TextBox();
            this.txtSolrUrl = new System.Windows.Forms.TextBox();
            this.txtSolrUpdate_XmlPath = new System.Windows.Forms.TextBox();
            this.cbSolrName = new System.Windows.Forms.ComboBox();
            this.cbbOperation = new System.Windows.Forms.ComboBox();
            this.rbType_SqlQuery = new System.Windows.Forms.RadioButton();
            this.btnSolrUpdate_Browse = new System.Windows.Forms.Button();
            this.rbType_XmlQuery = new System.Windows.Forms.RadioButton();
            this.cbbCountry = new System.Windows.Forms.ComboBox();
            this.rbType_IdString = new System.Windows.Forms.RadioButton();
            this.rbType_SolrQuery = new System.Windows.Forms.RadioButton();
            this.btnSolrUpdate_Submit = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lbSolrUpdate_Note2 = new System.Windows.Forms.Label();
            this.lbSolrUpdate_Note = new System.Windows.Forms.Label();
            this.btnPartial_Save = new System.Windows.Forms.Button();
            this.plPartial_Field = new System.Windows.Forms.Panel();
            this.lbPartial_QueryResult = new System.Windows.Forms.ListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbPartial_CountryCode = new System.Windows.Forms.ComboBox();
            this.Query = new System.Windows.Forms.Label();
            this.txtPartial_Query = new System.Windows.Forms.TextBox();
            this.txtPartial_SolrUrl = new System.Windows.Forms.TextBox();
            this.cbPartial_SolrCore = new System.Windows.Forms.ComboBox();
            this.btnPartial_Delete = new System.Windows.Forms.Button();
            this.btnPartial_Query = new System.Windows.Forms.Button();
            this.tp_SendEmail = new System.Windows.Forms.TabPage();
            this.label38 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.sendEmail_rtbSql = new System.Windows.Forms.RichTextBox();
            this.sendEmail_btnSend = new System.Windows.Forms.Button();
            this.sendEmail_txtSubject = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.sendEmail_rbVM = new System.Windows.Forms.RadioButton();
            this.sendEmail_rb126 = new System.Windows.Forms.RadioButton();
            this.sendEmail_cbEmailDBInfo = new System.Windows.Forms.ComboBox();
            this.sendEmail_btnGetEmailInfo = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.sendEmail_txtCC = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.sendEmail_clbTo = new System.Windows.Forms.CheckedListBox();
            this.sendEmail_txtContent = new System.Windows.Forms.RichTextBox();
            this.tp_GenAuth = new System.Windows.Forms.TabPage();
            this.others_lbSqlQuery = new System.Windows.Forms.Label();
            this.others_cbCountryCode = new System.Windows.Forms.ComboBox();
            this.label43 = new System.Windows.Forms.Label();
            this.others_btnAdditionDomain = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.others_rbEnv_Preview = new System.Windows.Forms.RadioButton();
            this.others_rbEnv_Production = new System.Windows.Forms.RadioButton();
            this.others_rbEnv_Test = new System.Windows.Forms.RadioButton();
            this.others_rbEnv_Dev = new System.Windows.Forms.RadioButton();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.others_rbAuthenTicketType_SIS = new System.Windows.Forms.RadioButton();
            this.others_rbAuthenTicketType_External = new System.Windows.Forms.RadioButton();
            this.others_rbAuthenTicketType_Unknow = new System.Windows.Forms.RadioButton();
            this.others_btnGetAuthInfo = new System.Windows.Forms.Button();
            this.others_rtbResult = new System.Windows.Forms.RichTextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.others_rbAuthType_JobSeeker = new System.Windows.Forms.RadioButton();
            this.others_rbAuthType_Employer = new System.Windows.Forms.RadioButton();
            this.label41 = new System.Windows.Forms.Label();
            this.others_cbAccount = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.others_txtJobSeekerId = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.others_txtUserManagementId = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.others_txtEmployerId = new System.Windows.Forms.TextBox();
            this.tp_ABTesting = new System.Windows.Forms.TabPage();
            this.btnAB_GetGroup = new System.Windows.Forms.Button();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.rtbAB_Result = new System.Windows.Forms.RichTextBox();
            this.btnAB_GetValue = new System.Windows.Forms.Button();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txtAB_Proportion = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txtAB_GroupKey = new System.Windows.Forms.TextBox();
            this.rtbAB_EmployerIds = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSourceConnName = new System.Windows.Forms.ComboBox();
            this.txtSourceConnStr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtSourceConnProviderName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gb_DBType.SuspendLayout();
            this.tc1.SuspendLayout();
            this.tp_Common.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_task)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.document_cmsDoc.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCommon_RunSql_SqlResult)).BeginInit();
            this.tabPage11.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.tp_AddWordings.SuspendLayout();
            this.tc_AddWordings.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tp_GetData.SuspendLayout();
            this.tp_GetString.SuspendLayout();
            this.tp_AddData.SuspendLayout();
            this.tp_Result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Result)).BeginInit();
            this.tp_WordingSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SearchResult)).BeginInit();
            this.tp_ClassFieldAbbr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvClassFieldResult)).BeginInit();
            this.tp_BackupTask.SuspendLayout();
            this.tp_OperateDB.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tp_SolrUpdate.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tp_SendEmail.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.tp_GenAuth.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.tp_ABTesting.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(474, 17);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 25);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(210, 19);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(258, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // rbType_Excel
            // 
            this.rbType_Excel.AutoSize = true;
            this.rbType_Excel.Checked = true;
            this.rbType_Excel.Location = new System.Drawing.Point(6, 13);
            this.rbType_Excel.Name = "rbType_Excel";
            this.rbType_Excel.Size = new System.Drawing.Size(46, 17);
            this.rbType_Excel.TabIndex = 4;
            this.rbType_Excel.TabStop = true;
            this.rbType_Excel.Text = "CSV";
            this.rbType_Excel.UseVisualStyleBackColor = true;
            this.rbType_Excel.CheckedChanged += new System.EventHandler(this.rbType_Excel_CheckedChanged);
            // 
            // rbType_DB
            // 
            this.rbType_DB.AutoSize = true;
            this.rbType_DB.Location = new System.Drawing.Point(67, 12);
            this.rbType_DB.Name = "rbType_DB";
            this.rbType_DB.Size = new System.Drawing.Size(40, 17);
            this.rbType_DB.TabIndex = 5;
            this.rbType_DB.Text = "DB";
            this.rbType_DB.UseVisualStyleBackColor = true;
            this.rbType_DB.CheckedChanged += new System.EventHandler(this.rbType_DB_CheckedChanged);
            // 
            // gb_DBType
            // 
            this.gb_DBType.Controls.Add(this.rbType_String);
            this.gb_DBType.Controls.Add(this.rbType_DB);
            this.gb_DBType.Controls.Add(this.rbType_Excel);
            this.gb_DBType.Location = new System.Drawing.Point(18, 10);
            this.gb_DBType.Name = "gb_DBType";
            this.gb_DBType.Size = new System.Drawing.Size(181, 33);
            this.gb_DBType.TabIndex = 7;
            this.gb_DBType.TabStop = false;
            // 
            // rbType_String
            // 
            this.rbType_String.AutoSize = true;
            this.rbType_String.Location = new System.Drawing.Point(121, 11);
            this.rbType_String.Name = "rbType_String";
            this.rbType_String.Size = new System.Drawing.Size(52, 17);
            this.rbType_String.TabIndex = 6;
            this.rbType_String.Text = "String";
            this.rbType_String.UseVisualStyleBackColor = true;
            this.rbType_String.CheckedChanged += new System.EventHandler(this.rbType_String_CheckedChanged);
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(595, 18);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 23);
            this.btnGetData.TabIndex = 9;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // tc1
            // 
            this.tc1.Controls.Add(this.tp_Common);
            this.tc1.Controls.Add(this.tp_AddWordings);
            this.tc1.Controls.Add(this.tp_ClassFieldAbbr);
            this.tc1.Controls.Add(this.tp_BackupTask);
            this.tc1.Controls.Add(this.tp_OperateDB);
            this.tc1.Controls.Add(this.tp_SolrUpdate);
            this.tc1.Controls.Add(this.tp_SendEmail);
            this.tc1.Controls.Add(this.tp_GenAuth);
            this.tc1.Controls.Add(this.tp_ABTesting);
            this.tc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc1.Location = new System.Drawing.Point(0, 0);
            this.tc1.Multiline = true;
            this.tc1.Name = "tc1";
            this.tc1.SelectedIndex = 0;
            this.tc1.Size = new System.Drawing.Size(855, 447);
            this.tc1.TabIndex = 8;
            this.tc1.SelectedIndexChanged += new System.EventHandler(this.tc1_SelectedIndexChanged);
            // 
            // tp_Common
            // 
            this.tp_Common.Controls.Add(this.groupBox14);
            this.tp_Common.Location = new System.Drawing.Point(4, 22);
            this.tp_Common.Name = "tp_Common";
            this.tp_Common.Size = new System.Drawing.Size(847, 421);
            this.tp_Common.TabIndex = 11;
            this.tp_Common.Text = "   Common   ";
            this.tp_Common.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.tabControl3);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox14.Location = new System.Drawing.Point(0, 0);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(847, 421);
            this.groupBox14.TabIndex = 4;
            this.groupBox14.TabStop = false;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Controls.Add(this.tabPage9);
            this.tabControl3.Controls.Add(this.tabPage10);
            this.tabControl3.Controls.Add(this.tabPage11);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(3, 16);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(841, 402);
            this.tabControl3.TabIndex = 29;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.groupBox15);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(833, 376);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "    Tasks    ";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.tasks_btnSearch);
            this.groupBox15.Controls.Add(this.tasks_txtSearch);
            this.groupBox15.Controls.Add(this.groupBox16);
            this.groupBox15.Controls.Add(this.tasks_btnEditData);
            this.groupBox15.Controls.Add(this.dgv_task);
            this.groupBox15.Controls.Add(this.tasks_btnDelData);
            this.groupBox15.Controls.Add(this.tasks_btnAddData);
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox15.Location = new System.Drawing.Point(3, 3);
            this.groupBox15.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(827, 370);
            this.groupBox15.TabIndex = 28;
            this.groupBox15.TabStop = false;
            // 
            // tasks_btnSearch
            // 
            this.tasks_btnSearch.Location = new System.Drawing.Point(556, 19);
            this.tasks_btnSearch.Name = "tasks_btnSearch";
            this.tasks_btnSearch.Size = new System.Drawing.Size(78, 23);
            this.tasks_btnSearch.TabIndex = 54;
            this.tasks_btnSearch.Text = "Search";
            this.tasks_btnSearch.UseVisualStyleBackColor = true;
            this.tasks_btnSearch.Click += new System.EventHandler(this.tasks_btnSearch_Click);
            // 
            // tasks_txtSearch
            // 
            this.tasks_txtSearch.Location = new System.Drawing.Point(374, 20);
            this.tasks_txtSearch.Name = "tasks_txtSearch";
            this.tasks_txtSearch.Size = new System.Drawing.Size(176, 20);
            this.tasks_txtSearch.TabIndex = 53;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.tasks_cbSearchStatus_Doing);
            this.groupBox16.Controls.Add(this.tasks_cbSearchStatus_Submitted);
            this.groupBox16.Controls.Add(this.tasks_cbSearchStatus_Pending);
            this.groupBox16.Controls.Add(this.tasks_cbSearchStatus_Done);
            this.groupBox16.Controls.Add(this.tasks_cbSearchStatus_Draft);
            this.groupBox16.Controls.Add(this.tasks_cbSearchStatus_WaitResource);
            this.groupBox16.Location = new System.Drawing.Point(95, 3);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(273, 52);
            this.groupBox16.TabIndex = 52;
            this.groupBox16.TabStop = false;
            // 
            // tasks_cbSearchStatus_Doing
            // 
            this.tasks_cbSearchStatus_Doing.AutoSize = true;
            this.tasks_cbSearchStatus_Doing.Checked = true;
            this.tasks_cbSearchStatus_Doing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tasks_cbSearchStatus_Doing.Location = new System.Drawing.Point(185, 12);
            this.tasks_cbSearchStatus_Doing.Name = "tasks_cbSearchStatus_Doing";
            this.tasks_cbSearchStatus_Doing.Size = new System.Drawing.Size(54, 17);
            this.tasks_cbSearchStatus_Doing.TabIndex = 36;
            this.tasks_cbSearchStatus_Doing.Text = "Doing";
            this.tasks_cbSearchStatus_Doing.UseVisualStyleBackColor = true;
            // 
            // tasks_cbSearchStatus_Submitted
            // 
            this.tasks_cbSearchStatus_Submitted.AutoSize = true;
            this.tasks_cbSearchStatus_Submitted.Location = new System.Drawing.Point(185, 32);
            this.tasks_cbSearchStatus_Submitted.Name = "tasks_cbSearchStatus_Submitted";
            this.tasks_cbSearchStatus_Submitted.Size = new System.Drawing.Size(73, 17);
            this.tasks_cbSearchStatus_Submitted.TabIndex = 37;
            this.tasks_cbSearchStatus_Submitted.Text = "Submitted";
            this.tasks_cbSearchStatus_Submitted.UseVisualStyleBackColor = true;
            // 
            // tasks_cbSearchStatus_Pending
            // 
            this.tasks_cbSearchStatus_Pending.AutoSize = true;
            this.tasks_cbSearchStatus_Pending.Checked = true;
            this.tasks_cbSearchStatus_Pending.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tasks_cbSearchStatus_Pending.Location = new System.Drawing.Point(105, 12);
            this.tasks_cbSearchStatus_Pending.Name = "tasks_cbSearchStatus_Pending";
            this.tasks_cbSearchStatus_Pending.Size = new System.Drawing.Size(65, 17);
            this.tasks_cbSearchStatus_Pending.TabIndex = 30;
            this.tasks_cbSearchStatus_Pending.Text = "Pending";
            this.tasks_cbSearchStatus_Pending.UseVisualStyleBackColor = true;
            // 
            // tasks_cbSearchStatus_Done
            // 
            this.tasks_cbSearchStatus_Done.AutoSize = true;
            this.tasks_cbSearchStatus_Done.Checked = true;
            this.tasks_cbSearchStatus_Done.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tasks_cbSearchStatus_Done.Location = new System.Drawing.Point(105, 32);
            this.tasks_cbSearchStatus_Done.Name = "tasks_cbSearchStatus_Done";
            this.tasks_cbSearchStatus_Done.Size = new System.Drawing.Size(52, 17);
            this.tasks_cbSearchStatus_Done.TabIndex = 31;
            this.tasks_cbSearchStatus_Done.Text = "Done";
            this.tasks_cbSearchStatus_Done.UseVisualStyleBackColor = true;
            // 
            // tasks_cbSearchStatus_Draft
            // 
            this.tasks_cbSearchStatus_Draft.AutoSize = true;
            this.tasks_cbSearchStatus_Draft.Checked = true;
            this.tasks_cbSearchStatus_Draft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tasks_cbSearchStatus_Draft.Location = new System.Drawing.Point(7, 12);
            this.tasks_cbSearchStatus_Draft.Name = "tasks_cbSearchStatus_Draft";
            this.tasks_cbSearchStatus_Draft.Size = new System.Drawing.Size(49, 17);
            this.tasks_cbSearchStatus_Draft.TabIndex = 28;
            this.tasks_cbSearchStatus_Draft.Text = "Draft";
            this.tasks_cbSearchStatus_Draft.UseVisualStyleBackColor = true;
            // 
            // tasks_cbSearchStatus_WaitResource
            // 
            this.tasks_cbSearchStatus_WaitResource.AutoSize = true;
            this.tasks_cbSearchStatus_WaitResource.Checked = true;
            this.tasks_cbSearchStatus_WaitResource.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tasks_cbSearchStatus_WaitResource.Location = new System.Drawing.Point(7, 32);
            this.tasks_cbSearchStatus_WaitResource.Name = "tasks_cbSearchStatus_WaitResource";
            this.tasks_cbSearchStatus_WaitResource.Size = new System.Drawing.Size(94, 17);
            this.tasks_cbSearchStatus_WaitResource.TabIndex = 29;
            this.tasks_cbSearchStatus_WaitResource.Text = "WaitResource";
            this.tasks_cbSearchStatus_WaitResource.UseVisualStyleBackColor = true;
            // 
            // tasks_btnEditData
            // 
            this.tasks_btnEditData.Location = new System.Drawing.Point(664, 19);
            this.tasks_btnEditData.Name = "tasks_btnEditData";
            this.tasks_btnEditData.Size = new System.Drawing.Size(78, 23);
            this.tasks_btnEditData.TabIndex = 28;
            this.tasks_btnEditData.Text = "Edit Data";
            this.tasks_btnEditData.UseVisualStyleBackColor = true;
            this.tasks_btnEditData.Click += new System.EventHandler(this.tasks_btnEditData_Click);
            // 
            // dgv_task
            // 
            this.dgv_task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_task.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_task.Location = new System.Drawing.Point(3, 59);
            this.dgv_task.Name = "dgv_task";
            this.dgv_task.RowTemplate.Height = 30;
            this.dgv_task.Size = new System.Drawing.Size(821, 308);
            this.dgv_task.TabIndex = 3;
            this.dgv_task.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_task_CellMouseEnter);
            this.dgv_task.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_task_RowPrePaint);
            // 
            // tasks_btnDelData
            // 
            this.tasks_btnDelData.Location = new System.Drawing.Point(745, 19);
            this.tasks_btnDelData.Name = "tasks_btnDelData";
            this.tasks_btnDelData.Size = new System.Drawing.Size(76, 23);
            this.tasks_btnDelData.TabIndex = 11;
            this.tasks_btnDelData.Text = "Delete Data";
            this.tasks_btnDelData.UseVisualStyleBackColor = true;
            this.tasks_btnDelData.Click += new System.EventHandler(this.tasks_btnDelData_Click);
            // 
            // tasks_btnAddData
            // 
            this.tasks_btnAddData.Location = new System.Drawing.Point(10, 21);
            this.tasks_btnAddData.Name = "tasks_btnAddData";
            this.tasks_btnAddData.Size = new System.Drawing.Size(69, 23);
            this.tasks_btnAddData.TabIndex = 10;
            this.tasks_btnAddData.Text = "Add Data";
            this.tasks_btnAddData.UseVisualStyleBackColor = true;
            this.tasks_btnAddData.Click += new System.EventHandler(this.tasks_btnAddData_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.document_cbIsAdd);
            this.tabPage7.Controls.Add(this.label12);
            this.tabPage7.Controls.Add(this.document_txtNodeName);
            this.tabPage7.Controls.Add(this.document_btnSaveNode);
            this.tabPage7.Controls.Add(this.groupBox17);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(833, 376);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "    Document    ";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // document_cbIsAdd
            // 
            this.document_cbIsAdd.AutoSize = true;
            this.document_cbIsAdd.Location = new System.Drawing.Point(278, 18);
            this.document_cbIsAdd.Name = "document_cbIsAdd";
            this.document_cbIsAdd.Size = new System.Drawing.Size(56, 17);
            this.document_cbIsAdd.TabIndex = 21;
            this.document_cbIsAdd.Text = "Is Add";
            this.document_cbIsAdd.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(348, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "NodeName";
            // 
            // document_txtNodeName
            // 
            this.document_txtNodeName.Location = new System.Drawing.Point(424, 16);
            this.document_txtNodeName.Name = "document_txtNodeName";
            this.document_txtNodeName.Size = new System.Drawing.Size(303, 20);
            this.document_txtNodeName.TabIndex = 16;
            // 
            // document_btnSaveNode
            // 
            this.document_btnSaveNode.Location = new System.Drawing.Point(750, 16);
            this.document_btnSaveNode.Name = "document_btnSaveNode";
            this.document_btnSaveNode.Size = new System.Drawing.Size(69, 23);
            this.document_btnSaveNode.TabIndex = 11;
            this.document_btnSaveNode.Text = "Save Node";
            this.document_btnSaveNode.UseVisualStyleBackColor = true;
            this.document_btnSaveNode.Click += new System.EventHandler(this.document_btnSaveNode_Click);
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.document_tvDoc);
            this.groupBox17.Controls.Add(this.document_rtbContent);
            this.groupBox17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox17.Location = new System.Drawing.Point(3, 43);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(827, 330);
            this.groupBox17.TabIndex = 2;
            this.groupBox17.TabStop = false;
            // 
            // document_tvDoc
            // 
            this.document_tvDoc.ContextMenuStrip = this.document_cmsDoc;
            this.document_tvDoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.document_tvDoc.Location = new System.Drawing.Point(3, 16);
            this.document_tvDoc.Name = "document_tvDoc";
            this.document_tvDoc.Size = new System.Drawing.Size(245, 311);
            this.document_tvDoc.TabIndex = 0;
            this.document_tvDoc.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.document_tvDoc_AfterSelect);
            // 
            // document_cmsDoc
            // 
            this.document_cmsDoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.document_tsmi_addNode,
            this.document_tsmi_deleteNode,
            this.toolStripSeparator1,
            this.document_tsmi_clearNode});
            this.document_cmsDoc.Name = "document_cmsDoc";
            this.document_cmsDoc.Size = new System.Drawing.Size(149, 76);
            this.document_cmsDoc.Text = "Add Node";
            // 
            // document_tsmi_addNode
            // 
            this.document_tsmi_addNode.Name = "document_tsmi_addNode";
            this.document_tsmi_addNode.Size = new System.Drawing.Size(148, 22);
            this.document_tsmi_addNode.Text = "Add Node";
            this.document_tsmi_addNode.Click += new System.EventHandler(this.document_tsmi_addNode_Click);
            // 
            // document_tsmi_deleteNode
            // 
            this.document_tsmi_deleteNode.Name = "document_tsmi_deleteNode";
            this.document_tsmi_deleteNode.Size = new System.Drawing.Size(148, 22);
            this.document_tsmi_deleteNode.Text = "Delete Node";
            this.document_tsmi_deleteNode.Click += new System.EventHandler(this.document_tsmi_deleteNode_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // document_tsmi_clearNode
            // 
            this.document_tsmi_clearNode.Name = "document_tsmi_clearNode";
            this.document_tsmi_clearNode.Size = new System.Drawing.Size(148, 22);
            this.document_tsmi_clearNode.Text = "Clear Selected";
            this.document_tsmi_clearNode.Click += new System.EventHandler(this.document_tsmi_clearNode_Click);
            // 
            // document_rtbContent
            // 
            this.document_rtbContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.document_rtbContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.document_rtbContent.Location = new System.Drawing.Point(268, 16);
            this.document_rtbContent.Name = "document_rtbContent";
            this.document_rtbContent.Size = new System.Drawing.Size(556, 311);
            this.document_rtbContent.TabIndex = 1;
            this.document_rtbContent.Text = "";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.groupBox18);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(833, 376);
            this.tabPage9.TabIndex = 2;
            this.tabPage9.Text = "Extract DLL";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.extractdll_btnExtract);
            this.groupBox18.Controls.Add(this.extractdll_btnReorder);
            this.groupBox18.Controls.Add(this.extractdll_rtbSource);
            this.groupBox18.Controls.Add(this.extractdll_Result);
            this.groupBox18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox18.Location = new System.Drawing.Point(0, 0);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(833, 376);
            this.groupBox18.TabIndex = 3;
            this.groupBox18.TabStop = false;
            // 
            // extractdll_btnExtract
            // 
            this.extractdll_btnExtract.Location = new System.Drawing.Point(361, 135);
            this.extractdll_btnExtract.Name = "extractdll_btnExtract";
            this.extractdll_btnExtract.Size = new System.Drawing.Size(69, 23);
            this.extractdll_btnExtract.TabIndex = 13;
            this.extractdll_btnExtract.Text = "Extract";
            this.extractdll_btnExtract.UseVisualStyleBackColor = true;
            this.extractdll_btnExtract.Click += new System.EventHandler(this.extractdll_btnExtract_Click);
            // 
            // extractdll_btnReorder
            // 
            this.extractdll_btnReorder.Location = new System.Drawing.Point(361, 45);
            this.extractdll_btnReorder.Name = "extractdll_btnReorder";
            this.extractdll_btnReorder.Size = new System.Drawing.Size(69, 23);
            this.extractdll_btnReorder.TabIndex = 12;
            this.extractdll_btnReorder.Text = "Reorder";
            this.extractdll_btnReorder.UseVisualStyleBackColor = true;
            this.extractdll_btnReorder.Click += new System.EventHandler(this.extractdll_btnReorder_Click);
            // 
            // extractdll_rtbSource
            // 
            this.extractdll_rtbSource.Dock = System.Windows.Forms.DockStyle.Left;
            this.extractdll_rtbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extractdll_rtbSource.Location = new System.Drawing.Point(3, 16);
            this.extractdll_rtbSource.Name = "extractdll_rtbSource";
            this.extractdll_rtbSource.Size = new System.Drawing.Size(338, 357);
            this.extractdll_rtbSource.TabIndex = 2;
            this.extractdll_rtbSource.Text = "";
            // 
            // extractdll_Result
            // 
            this.extractdll_Result.Dock = System.Windows.Forms.DockStyle.Right;
            this.extractdll_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extractdll_Result.Location = new System.Drawing.Point(451, 16);
            this.extractdll_Result.Name = "extractdll_Result";
            this.extractdll_Result.Size = new System.Drawing.Size(379, 357);
            this.extractdll_Result.TabIndex = 1;
            this.extractdll_Result.Text = "";
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.rtbCommon_RunSql_SqlQuery);
            this.tabPage10.Controls.Add(this.plCommon_RunSql_Params);
            this.tabPage10.Controls.Add(this.label45);
            this.tabPage10.Controls.Add(this.cbCommon_RunSql_SqlTemplate);
            this.tabPage10.Controls.Add(this.gvCommon_RunSql_SqlResult);
            this.tabPage10.Controls.Add(this.btnCommon_RunSql_Run);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(833, 376);
            this.tabPage10.TabIndex = 3;
            this.tabPage10.Text = "Run Sql";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // rtbCommon_RunSql_SqlQuery
            // 
            this.rtbCommon_RunSql_SqlQuery.Location = new System.Drawing.Point(3, 39);
            this.rtbCommon_RunSql_SqlQuery.Name = "rtbCommon_RunSql_SqlQuery";
            this.rtbCommon_RunSql_SqlQuery.Size = new System.Drawing.Size(370, 88);
            this.rtbCommon_RunSql_SqlQuery.TabIndex = 54;
            this.rtbCommon_RunSql_SqlQuery.Text = "";
            // 
            // plCommon_RunSql_Params
            // 
            this.plCommon_RunSql_Params.AutoScroll = true;
            this.plCommon_RunSql_Params.BackColor = System.Drawing.Color.Transparent;
            this.plCommon_RunSql_Params.Location = new System.Drawing.Point(399, 5);
            this.plCommon_RunSql_Params.Name = "plCommon_RunSql_Params";
            this.plCommon_RunSql_Params.Size = new System.Drawing.Size(434, 120);
            this.plCommon_RunSql_Params.TabIndex = 53;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(19, 15);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(51, 13);
            this.label45.TabIndex = 27;
            this.label45.Text = "Template";
            // 
            // cbCommon_RunSql_SqlTemplate
            // 
            this.cbCommon_RunSql_SqlTemplate.FormattingEnabled = true;
            this.cbCommon_RunSql_SqlTemplate.Location = new System.Drawing.Point(81, 12);
            this.cbCommon_RunSql_SqlTemplate.Name = "cbCommon_RunSql_SqlTemplate";
            this.cbCommon_RunSql_SqlTemplate.Size = new System.Drawing.Size(160, 21);
            this.cbCommon_RunSql_SqlTemplate.TabIndex = 52;
            this.cbCommon_RunSql_SqlTemplate.SelectedIndexChanged += new System.EventHandler(this.cbCommon_RunSql__SqlTemplate_SelectedIndexChanged);
            // 
            // gvCommon_RunSql_SqlResult
            // 
            this.gvCommon_RunSql_SqlResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCommon_RunSql_SqlResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvCommon_RunSql_SqlResult.Location = new System.Drawing.Point(0, 129);
            this.gvCommon_RunSql_SqlResult.Name = "gvCommon_RunSql_SqlResult";
            this.gvCommon_RunSql_SqlResult.Size = new System.Drawing.Size(833, 247);
            this.gvCommon_RunSql_SqlResult.TabIndex = 51;
            // 
            // btnCommon_RunSql_Run
            // 
            this.btnCommon_RunSql_Run.Location = new System.Drawing.Point(298, 10);
            this.btnCommon_RunSql_Run.Name = "btnCommon_RunSql_Run";
            this.btnCommon_RunSql_Run.Size = new System.Drawing.Size(75, 23);
            this.btnCommon_RunSql_Run.TabIndex = 50;
            this.btnCommon_RunSql_Run.Text = "Run Sql";
            this.btnCommon_RunSql_Run.UseVisualStyleBackColor = true;
            this.btnCommon_RunSql_Run.Click += new System.EventHandler(this.btnCommon_RunSql_Run_Click);
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.cbGenCopyBat_IsToLocal);
            this.tabPage11.Controls.Add(this.btnGenCopyBat_Gen);
            this.tabPage11.Controls.Add(this.plGenCopyBat_ServerList);
            this.tabPage11.Controls.Add(this.groupBox22);
            this.tabPage11.Controls.Add(this.groupBox21);
            this.tabPage11.Controls.Add(this.label48);
            this.tabPage11.Controls.Add(this.txtGenCopyBat_TargetPath);
            this.tabPage11.Controls.Add(this.cbGenCopyBat_Template);
            this.tabPage11.Controls.Add(this.label47);
            this.tabPage11.Controls.Add(this.txtGenCopyBat_SourcePath);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(833, 376);
            this.tabPage11.TabIndex = 4;
            this.tabPage11.Text = "Gen Copy Bat";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // cbGenCopyBat_IsToLocal
            // 
            this.cbGenCopyBat_IsToLocal.AutoSize = true;
            this.cbGenCopyBat_IsToLocal.Location = new System.Drawing.Point(72, 120);
            this.cbGenCopyBat_IsToLocal.Name = "cbGenCopyBat_IsToLocal";
            this.cbGenCopyBat_IsToLocal.Size = new System.Drawing.Size(75, 17);
            this.cbGenCopyBat_IsToLocal.TabIndex = 96;
            this.cbGenCopyBat_IsToLocal.Text = "Is to Local";
            this.cbGenCopyBat_IsToLocal.UseVisualStyleBackColor = true;
            // 
            // btnGenCopyBat_Gen
            // 
            this.btnGenCopyBat_Gen.Location = new System.Drawing.Point(326, 116);
            this.btnGenCopyBat_Gen.Name = "btnGenCopyBat_Gen";
            this.btnGenCopyBat_Gen.Size = new System.Drawing.Size(105, 23);
            this.btnGenCopyBat_Gen.TabIndex = 93;
            this.btnGenCopyBat_Gen.Text = "Gen Bat";
            this.btnGenCopyBat_Gen.UseVisualStyleBackColor = true;
            this.btnGenCopyBat_Gen.Click += new System.EventHandler(this.btnGenCopyBat_Gen_Click);
            // 
            // plGenCopyBat_ServerList
            // 
            this.plGenCopyBat_ServerList.AutoScroll = true;
            this.plGenCopyBat_ServerList.BackColor = System.Drawing.Color.Transparent;
            this.plGenCopyBat_ServerList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plGenCopyBat_ServerList.Location = new System.Drawing.Point(0, 195);
            this.plGenCopyBat_ServerList.Name = "plGenCopyBat_ServerList";
            this.plGenCopyBat_ServerList.Size = new System.Drawing.Size(488, 181);
            this.plGenCopyBat_ServerList.TabIndex = 92;
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.txtGenCopyBat_BatPath);
            this.groupBox22.Controls.Add(this.rtbGenCopyBat_Result);
            this.groupBox22.Controls.Add(this.btnGenCopyBat_RunBat);
            this.groupBox22.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox22.Location = new System.Drawing.Point(488, 0);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(345, 376);
            this.groupBox22.TabIndex = 94;
            this.groupBox22.TabStop = false;
            // 
            // txtGenCopyBat_BatPath
            // 
            this.txtGenCopyBat_BatPath.Location = new System.Drawing.Point(5, 17);
            this.txtGenCopyBat_BatPath.Name = "txtGenCopyBat_BatPath";
            this.txtGenCopyBat_BatPath.Size = new System.Drawing.Size(256, 20);
            this.txtGenCopyBat_BatPath.TabIndex = 64;
            // 
            // rtbGenCopyBat_Result
            // 
            this.rtbGenCopyBat_Result.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbGenCopyBat_Result.Location = new System.Drawing.Point(3, 52);
            this.rtbGenCopyBat_Result.Name = "rtbGenCopyBat_Result";
            this.rtbGenCopyBat_Result.Size = new System.Drawing.Size(339, 321);
            this.rtbGenCopyBat_Result.TabIndex = 55;
            this.rtbGenCopyBat_Result.Text = "";
            // 
            // btnGenCopyBat_RunBat
            // 
            this.btnGenCopyBat_RunBat.Location = new System.Drawing.Point(267, 15);
            this.btnGenCopyBat_RunBat.Name = "btnGenCopyBat_RunBat";
            this.btnGenCopyBat_RunBat.Size = new System.Drawing.Size(75, 23);
            this.btnGenCopyBat_RunBat.TabIndex = 51;
            this.btnGenCopyBat_RunBat.Text = "Run Bat";
            this.btnGenCopyBat_RunBat.UseVisualStyleBackColor = true;
            this.btnGenCopyBat_RunBat.Click += new System.EventHandler(this.btnGenCopyBat_RunBat_Click);
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.cbGenCopyBat_ProductAgent);
            this.groupBox21.Controls.Add(this.cbGenCopyBat_ProductWeb);
            this.groupBox21.Controls.Add(this.cbGenCopyBat_PreviewAgent);
            this.groupBox21.Controls.Add(this.cbGenCopyBat_PreviewWeb);
            this.groupBox21.Location = new System.Drawing.Point(17, 145);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(465, 39);
            this.groupBox21.TabIndex = 91;
            this.groupBox21.TabStop = false;
            // 
            // cbGenCopyBat_ProductAgent
            // 
            this.cbGenCopyBat_ProductAgent.AutoSize = true;
            this.cbGenCopyBat_ProductAgent.Location = new System.Drawing.Point(359, 15);
            this.cbGenCopyBat_ProductAgent.Name = "cbGenCopyBat_ProductAgent";
            this.cbGenCopyBat_ProductAgent.Size = new System.Drawing.Size(94, 17);
            this.cbGenCopyBat_ProductAgent.TabIndex = 95;
            this.cbGenCopyBat_ProductAgent.Text = "Product Agent";
            this.cbGenCopyBat_ProductAgent.UseVisualStyleBackColor = true;
            this.cbGenCopyBat_ProductAgent.CheckedChanged += new System.EventHandler(this.cbGenCopyBat_ProductAgent_CheckedChanged);
            // 
            // cbGenCopyBat_ProductWeb
            // 
            this.cbGenCopyBat_ProductWeb.AutoSize = true;
            this.cbGenCopyBat_ProductWeb.Location = new System.Drawing.Point(241, 15);
            this.cbGenCopyBat_ProductWeb.Name = "cbGenCopyBat_ProductWeb";
            this.cbGenCopyBat_ProductWeb.Size = new System.Drawing.Size(89, 17);
            this.cbGenCopyBat_ProductWeb.TabIndex = 94;
            this.cbGenCopyBat_ProductWeb.Text = "Product Web";
            this.cbGenCopyBat_ProductWeb.UseVisualStyleBackColor = true;
            this.cbGenCopyBat_ProductWeb.CheckedChanged += new System.EventHandler(this.cbGenCopyBat_ProductWeb_CheckedChanged);
            // 
            // cbGenCopyBat_PreviewAgent
            // 
            this.cbGenCopyBat_PreviewAgent.AutoSize = true;
            this.cbGenCopyBat_PreviewAgent.Location = new System.Drawing.Point(118, 15);
            this.cbGenCopyBat_PreviewAgent.Name = "cbGenCopyBat_PreviewAgent";
            this.cbGenCopyBat_PreviewAgent.Size = new System.Drawing.Size(95, 17);
            this.cbGenCopyBat_PreviewAgent.TabIndex = 93;
            this.cbGenCopyBat_PreviewAgent.Text = "Preview Agent";
            this.cbGenCopyBat_PreviewAgent.UseVisualStyleBackColor = true;
            this.cbGenCopyBat_PreviewAgent.CheckedChanged += new System.EventHandler(this.cbGenCopyBat_PreviewAgent_CheckedChanged);
            // 
            // cbGenCopyBat_PreviewWeb
            // 
            this.cbGenCopyBat_PreviewWeb.AutoSize = true;
            this.cbGenCopyBat_PreviewWeb.Location = new System.Drawing.Point(15, 15);
            this.cbGenCopyBat_PreviewWeb.Name = "cbGenCopyBat_PreviewWeb";
            this.cbGenCopyBat_PreviewWeb.Size = new System.Drawing.Size(90, 17);
            this.cbGenCopyBat_PreviewWeb.TabIndex = 92;
            this.cbGenCopyBat_PreviewWeb.Text = "Preview Web";
            this.cbGenCopyBat_PreviewWeb.UseVisualStyleBackColor = true;
            this.cbGenCopyBat_PreviewWeb.CheckedChanged += new System.EventHandler(this.cbGenCopyBat_PreviewWeb_CheckedChanged);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(1, 84);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(63, 13);
            this.label48.TabIndex = 64;
            this.label48.Text = "Target Path";
            // 
            // txtGenCopyBat_TargetPath
            // 
            this.txtGenCopyBat_TargetPath.Location = new System.Drawing.Point(71, 84);
            this.txtGenCopyBat_TargetPath.Name = "txtGenCopyBat_TargetPath";
            this.txtGenCopyBat_TargetPath.Size = new System.Drawing.Size(360, 20);
            this.txtGenCopyBat_TargetPath.TabIndex = 63;
            // 
            // cbGenCopyBat_Template
            // 
            this.cbGenCopyBat_Template.FormattingEnabled = true;
            this.cbGenCopyBat_Template.Location = new System.Drawing.Point(72, 17);
            this.cbGenCopyBat_Template.Name = "cbGenCopyBat_Template";
            this.cbGenCopyBat_Template.Size = new System.Drawing.Size(185, 21);
            this.cbGenCopyBat_Template.TabIndex = 62;
            this.cbGenCopyBat_Template.SelectedIndexChanged += new System.EventHandler(this.cbGenCopyBat_Template_SelectedIndexChanged);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(1, 52);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(66, 13);
            this.label47.TabIndex = 61;
            this.label47.Text = "Source Path";
            // 
            // txtGenCopyBat_SourcePath
            // 
            this.txtGenCopyBat_SourcePath.Location = new System.Drawing.Point(71, 52);
            this.txtGenCopyBat_SourcePath.Name = "txtGenCopyBat_SourcePath";
            this.txtGenCopyBat_SourcePath.Size = new System.Drawing.Size(360, 20);
            this.txtGenCopyBat_SourcePath.TabIndex = 60;
            // 
            // tp_AddWordings
            // 
            this.tp_AddWordings.AutoScroll = true;
            this.tp_AddWordings.Controls.Add(this.tc_AddWordings);
            this.tp_AddWordings.Controls.Add(this.gb_DBType);
            this.tp_AddWordings.Controls.Add(this.btnBrowse);
            this.tp_AddWordings.Controls.Add(this.txtFilePath);
            this.tp_AddWordings.Controls.Add(this.btnExport);
            this.tp_AddWordings.Controls.Add(this.btnGetData);
            this.tp_AddWordings.Location = new System.Drawing.Point(4, 22);
            this.tp_AddWordings.Name = "tp_AddWordings";
            this.tp_AddWordings.Size = new System.Drawing.Size(847, 421);
            this.tp_AddWordings.TabIndex = 4;
            this.tp_AddWordings.Text = "    Add Wordings    ";
            this.tp_AddWordings.UseVisualStyleBackColor = true;
            // 
            // tc_AddWordings
            // 
            this.tc_AddWordings.Controls.Add(this.tabPage8);
            this.tc_AddWordings.Controls.Add(this.tp_GetData);
            this.tc_AddWordings.Controls.Add(this.tp_GetString);
            this.tc_AddWordings.Controls.Add(this.tp_AddData);
            this.tc_AddWordings.Controls.Add(this.tp_Result);
            this.tc_AddWordings.Controls.Add(this.tp_WordingSearch);
            this.tc_AddWordings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tc_AddWordings.Location = new System.Drawing.Point(0, 50);
            this.tc_AddWordings.Name = "tc_AddWordings";
            this.tc_AddWordings.SelectedIndex = 0;
            this.tc_AddWordings.Size = new System.Drawing.Size(847, 371);
            this.tc_AddWordings.TabIndex = 40;
            this.tc_AddWordings.Click += new System.EventHandler(this.tc_AddWordings_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.btnGoResult);
            this.tabPage8.Controls.Add(this.label1);
            this.tabPage8.Controls.Add(this.lbInfo);
            this.tabPage8.Controls.Add(this.cbLanguageTH);
            this.tabPage8.Controls.Add(this.btnAddGroup);
            this.tabPage8.Controls.Add(this.txtInfo);
            this.tabPage8.Controls.Add(this.cbLanguageID);
            this.tabPage8.Controls.Add(this.txtWordingKey);
            this.tabPage8.Controls.Add(this.cbLanguageXX);
            this.tabPage8.Controls.Add(this.txtXXContent);
            this.tabPage8.Controls.Add(this.label8);
            this.tabPage8.Controls.Add(this.txtComment);
            this.tabPage8.Controls.Add(this.txtTHContent);
            this.tabPage8.Controls.Add(this.label5);
            this.tabPage8.Controls.Add(this.label7);
            this.tabPage8.Controls.Add(this.label6);
            this.tabPage8.Controls.Add(this.txtIDContent);
            this.tabPage8.Controls.Add(this.label2);
            this.tabPage8.Controls.Add(this.lbWordingGroup);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(839, 345);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "    Custom    ";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // btnGoResult
            // 
            this.btnGoResult.Location = new System.Drawing.Point(547, 314);
            this.btnGoResult.Name = "btnGoResult";
            this.btnGoResult.Size = new System.Drawing.Size(134, 23);
            this.btnGoResult.TabIndex = 40;
            this.btnGoResult.Text = "Go to Result Tab";
            this.btnGoResult.UseVisualStyleBackColor = true;
            this.btnGoResult.Click += new System.EventHandler(this.btnGoResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Wording Key";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(482, 8);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(223, 13);
            this.lbInfo.TabIndex = 32;
            this.lbInfo.Text = "loading data to result tab(if exists then update)";
            this.lbInfo.Visible = false;
            // 
            // cbLanguageTH
            // 
            this.cbLanguageTH.FormattingEnabled = true;
            this.cbLanguageTH.Location = new System.Drawing.Point(102, 143);
            this.cbLanguageTH.Name = "cbLanguageTH";
            this.cbLanguageTH.Size = new System.Drawing.Size(52, 21);
            this.cbLanguageTH.TabIndex = 39;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(116, 316);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(75, 23);
            this.btnAddGroup.TabIndex = 31;
            this.btnAddGroup.Text = "Add Group";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Enabled = false;
            this.txtInfo.Location = new System.Drawing.Point(485, 30);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(316, 267);
            this.txtInfo.TabIndex = 30;
            this.txtInfo.Visible = false;
            // 
            // cbLanguageID
            // 
            this.cbLanguageID.FormattingEnabled = true;
            this.cbLanguageID.Location = new System.Drawing.Point(102, 101);
            this.cbLanguageID.Name = "cbLanguageID";
            this.cbLanguageID.Size = new System.Drawing.Size(52, 21);
            this.cbLanguageID.TabIndex = 38;
            // 
            // txtWordingKey
            // 
            this.txtWordingKey.Location = new System.Drawing.Point(160, 15);
            this.txtWordingKey.Name = "txtWordingKey";
            this.txtWordingKey.Size = new System.Drawing.Size(299, 20);
            this.txtWordingKey.TabIndex = 11;
            this.txtWordingKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWordingKey_KeyDown);
            // 
            // cbLanguageXX
            // 
            this.cbLanguageXX.FormattingEnabled = true;
            this.cbLanguageXX.Location = new System.Drawing.Point(101, 59);
            this.cbLanguageXX.Name = "cbLanguageXX";
            this.cbLanguageXX.Size = new System.Drawing.Size(52, 21);
            this.cbLanguageXX.TabIndex = 37;
            // 
            // txtXXContent
            // 
            this.txtXXContent.Location = new System.Drawing.Point(160, 59);
            this.txtXXContent.Name = "txtXXContent";
            this.txtXXContent.Size = new System.Drawing.Size(299, 20);
            this.txtXXContent.TabIndex = 12;
            this.txtXXContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtXXContent_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "TH Content";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(159, 277);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(299, 20);
            this.txtComment.TabIndex = 27;
            this.txtComment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComment_KeyDown);
            // 
            // txtTHContent
            // 
            this.txtTHContent.Location = new System.Drawing.Point(160, 143);
            this.txtTHContent.Name = "txtTHContent";
            this.txtTHContent.Size = new System.Drawing.Size(299, 20);
            this.txtTHContent.TabIndex = 14;
            this.txtTHContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTHContent_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "XX Content";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "ID Content";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Comment";
            // 
            // txtIDContent
            // 
            this.txtIDContent.Location = new System.Drawing.Point(160, 101);
            this.txtIDContent.Name = "txtIDContent";
            this.txtIDContent.Size = new System.Drawing.Size(299, 20);
            this.txtIDContent.TabIndex = 13;
            this.txtIDContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIDContent_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Wording Group";
            // 
            // lbWordingGroup
            // 
            this.lbWordingGroup.Font = new System.Drawing.Font("SimSun", 10F);
            this.lbWordingGroup.FormattingEnabled = true;
            this.lbWordingGroup.Location = new System.Drawing.Point(160, 178);
            this.lbWordingGroup.Name = "lbWordingGroup";
            this.lbWordingGroup.Size = new System.Drawing.Size(207, 82);
            this.lbWordingGroup.TabIndex = 15;
            // 
            // tp_GetData
            // 
            this.tp_GetData.Controls.Add(this.txtGetData);
            this.tp_GetData.Location = new System.Drawing.Point(4, 22);
            this.tp_GetData.Name = "tp_GetData";
            this.tp_GetData.Padding = new System.Windows.Forms.Padding(3);
            this.tp_GetData.Size = new System.Drawing.Size(839, 345);
            this.tp_GetData.TabIndex = 1;
            this.tp_GetData.Text = "    Get Data From DB    ";
            this.tp_GetData.UseVisualStyleBackColor = true;
            // 
            // txtGetData
            // 
            this.txtGetData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGetData.Font = new System.Drawing.Font("SimSun", 12F);
            this.txtGetData.Location = new System.Drawing.Point(3, 3);
            this.txtGetData.Multiline = true;
            this.txtGetData.Name = "txtGetData";
            this.txtGetData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGetData.Size = new System.Drawing.Size(833, 339);
            this.txtGetData.TabIndex = 4;
            this.txtGetData.WordWrap = false;
            // 
            // tp_GetString
            // 
            this.tp_GetString.Controls.Add(this.clbCountry);
            this.tp_GetString.Controls.Add(this.label3);
            this.tp_GetString.Controls.Add(this.txtGetString);
            this.tp_GetString.Location = new System.Drawing.Point(4, 22);
            this.tp_GetString.Name = "tp_GetString";
            this.tp_GetString.Size = new System.Drawing.Size(839, 345);
            this.tp_GetString.TabIndex = 2;
            this.tp_GetString.Text = "    Get Data From String    ";
            this.tp_GetString.UseVisualStyleBackColor = true;
            // 
            // clbCountry
            // 
            this.clbCountry.FormattingEnabled = true;
            this.clbCountry.Location = new System.Drawing.Point(6, 38);
            this.clbCountry.Name = "clbCountry";
            this.clbCountry.Size = new System.Drawing.Size(120, 79);
            this.clbCountry.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "input keys and split with \",\"";
            // 
            // txtGetString
            // 
            this.txtGetString.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtGetString.Font = new System.Drawing.Font("SimSun", 12F);
            this.txtGetString.Location = new System.Drawing.Point(186, 0);
            this.txtGetString.Multiline = true;
            this.txtGetString.Name = "txtGetString";
            this.txtGetString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGetString.Size = new System.Drawing.Size(653, 345);
            this.txtGetString.TabIndex = 8;
            this.txtGetString.WordWrap = false;
            // 
            // tp_AddData
            // 
            this.tp_AddData.Controls.Add(this.txtAddWordings_WordingKeySql);
            this.tp_AddData.Controls.Add(this.txtContent);
            this.tp_AddData.Location = new System.Drawing.Point(4, 22);
            this.tp_AddData.Name = "tp_AddData";
            this.tp_AddData.Size = new System.Drawing.Size(839, 345);
            this.tp_AddData.TabIndex = 3;
            this.tp_AddData.Text = "    Add Data To DB    ";
            this.tp_AddData.UseVisualStyleBackColor = true;
            // 
            // txtAddWordings_WordingKeySql
            // 
            this.txtAddWordings_WordingKeySql.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddWordings_WordingKeySql.Font = new System.Drawing.Font("SimSun", 12F);
            this.txtAddWordings_WordingKeySql.Location = new System.Drawing.Point(0, 0);
            this.txtAddWordings_WordingKeySql.Multiline = true;
            this.txtAddWordings_WordingKeySql.Name = "txtAddWordings_WordingKeySql";
            this.txtAddWordings_WordingKeySql.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAddWordings_WordingKeySql.Size = new System.Drawing.Size(839, 84);
            this.txtAddWordings_WordingKeySql.TabIndex = 4;
            this.txtAddWordings_WordingKeySql.WordWrap = false;
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtContent.Font = new System.Drawing.Font("SimSun", 12F);
            this.txtContent.Location = new System.Drawing.Point(0, 90);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(839, 255);
            this.txtContent.TabIndex = 3;
            this.txtContent.WordWrap = false;
            // 
            // tp_Result
            // 
            this.tp_Result.Controls.Add(this.lbWording_SqlQueryPathLabel);
            this.tp_Result.Controls.Add(this.lbWording_SqlQueryPath);
            this.tp_Result.Controls.Add(this.btnWording_GenSqlQuery);
            this.tp_Result.Controls.Add(this.cbHelpColumns);
            this.tp_Result.Controls.Add(this.label11);
            this.tp_Result.Controls.Add(this.btnSubmit);
            this.tp_Result.Controls.Add(this.gv_Result);
            this.tp_Result.Controls.Add(this.btnWipe);
            this.tp_Result.Controls.Add(this.txtTargetConnStr);
            this.tp_Result.Controls.Add(this.cbTargetConnName);
            this.tp_Result.Location = new System.Drawing.Point(4, 22);
            this.tp_Result.Name = "tp_Result";
            this.tp_Result.Size = new System.Drawing.Size(839, 345);
            this.tp_Result.TabIndex = 4;
            this.tp_Result.Text = "    Result    ";
            this.tp_Result.UseVisualStyleBackColor = true;
            // 
            // lbWording_SqlQueryPathLabel
            // 
            this.lbWording_SqlQueryPathLabel.AutoSize = true;
            this.lbWording_SqlQueryPathLabel.ForeColor = System.Drawing.Color.Red;
            this.lbWording_SqlQueryPathLabel.Location = new System.Drawing.Point(84, 35);
            this.lbWording_SqlQueryPathLabel.Name = "lbWording_SqlQueryPathLabel";
            this.lbWording_SqlQueryPathLabel.Size = new System.Drawing.Size(81, 13);
            this.lbWording_SqlQueryPathLabel.TabIndex = 57;
            this.lbWording_SqlQueryPathLabel.Text = "Sql Query Path:";
            this.lbWording_SqlQueryPathLabel.Visible = false;
            // 
            // lbWording_SqlQueryPath
            // 
            this.lbWording_SqlQueryPath.AutoSize = true;
            this.lbWording_SqlQueryPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbWording_SqlQueryPath.ForeColor = System.Drawing.Color.Red;
            this.lbWording_SqlQueryPath.Location = new System.Drawing.Point(163, 36);
            this.lbWording_SqlQueryPath.Name = "lbWording_SqlQueryPath";
            this.lbWording_SqlQueryPath.Size = new System.Drawing.Size(29, 13);
            this.lbWording_SqlQueryPath.TabIndex = 56;
            this.lbWording_SqlQueryPath.Text = "Path";
            this.lbWording_SqlQueryPath.Visible = false;
            // 
            // btnWording_GenSqlQuery
            // 
            this.btnWording_GenSqlQuery.Location = new System.Drawing.Point(532, 11);
            this.btnWording_GenSqlQuery.Name = "btnWording_GenSqlQuery";
            this.btnWording_GenSqlQuery.Size = new System.Drawing.Size(94, 23);
            this.btnWording_GenSqlQuery.TabIndex = 28;
            this.btnWording_GenSqlQuery.Text = "Gen Sql Query";
            this.btnWording_GenSqlQuery.UseVisualStyleBackColor = true;
            this.btnWording_GenSqlQuery.Click += new System.EventHandler(this.btnWording_GenSqlQuery_Click);
            // 
            // cbHelpColumns
            // 
            this.cbHelpColumns.AutoSize = true;
            this.cbHelpColumns.Location = new System.Drawing.Point(717, 40);
            this.cbHelpColumns.Name = "cbHelpColumns";
            this.cbHelpColumns.Size = new System.Drawing.Size(119, 17);
            this.cbHelpColumns.TabIndex = 27;
            this.cbHelpColumns.Text = " Hide Help Columns";
            this.cbHelpColumns.UseVisualStyleBackColor = true;
            this.cbHelpColumns.Visible = false;
            this.cbHelpColumns.CheckedChanged += new System.EventHandler(this.cbHelpColumns_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "TargetDB";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(451, 11);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "Add Data";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gv_Result
            // 
            this.gv_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Result.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gv_Result.Location = new System.Drawing.Point(0, 51);
            this.gv_Result.Name = "gv_Result";
            this.gv_Result.Size = new System.Drawing.Size(839, 294);
            this.gv_Result.TabIndex = 21;
            // 
            // btnWipe
            // 
            this.btnWipe.Location = new System.Drawing.Point(755, 10);
            this.btnWipe.Name = "btnWipe";
            this.btnWipe.Size = new System.Drawing.Size(75, 23);
            this.btnWipe.TabIndex = 23;
            this.btnWipe.Text = "Wipe Data";
            this.btnWipe.UseVisualStyleBackColor = true;
            this.btnWipe.Click += new System.EventHandler(this.btnWipe_Click);
            // 
            // txtTargetConnStr
            // 
            this.txtTargetConnStr.Location = new System.Drawing.Point(165, 13);
            this.txtTargetConnStr.Name = "txtTargetConnStr";
            this.txtTargetConnStr.Size = new System.Drawing.Size(277, 20);
            this.txtTargetConnStr.TabIndex = 25;
            this.txtTargetConnStr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTargetConnStr_KeyDown);
            // 
            // cbTargetConnName
            // 
            this.cbTargetConnName.FormattingEnabled = true;
            this.cbTargetConnName.Location = new System.Drawing.Point(61, 12);
            this.cbTargetConnName.Name = "cbTargetConnName";
            this.cbTargetConnName.Size = new System.Drawing.Size(97, 21);
            this.cbTargetConnName.TabIndex = 24;
            this.cbTargetConnName.SelectedIndexChanged += new System.EventHandler(this.cbTargetConnName_SelectedIndexChanged);
            // 
            // tp_WordingSearch
            // 
            this.tp_WordingSearch.Controls.Add(this.cbWordingKey);
            this.tp_WordingSearch.Controls.Add(this.cbWordingContent);
            this.tp_WordingSearch.Controls.Add(this.label9);
            this.tp_WordingSearch.Controls.Add(this.label4);
            this.tp_WordingSearch.Controls.Add(this.btnSearch);
            this.tp_WordingSearch.Controls.Add(this.txtSearchKey);
            this.tp_WordingSearch.Controls.Add(this.txtSearchContent);
            this.tp_WordingSearch.Controls.Add(this.gv_SearchResult);
            this.tp_WordingSearch.Location = new System.Drawing.Point(4, 22);
            this.tp_WordingSearch.Name = "tp_WordingSearch";
            this.tp_WordingSearch.Size = new System.Drawing.Size(839, 345);
            this.tp_WordingSearch.TabIndex = 5;
            this.tp_WordingSearch.Text = "    Search    ";
            this.tp_WordingSearch.UseVisualStyleBackColor = true;
            // 
            // cbWordingKey
            // 
            this.cbWordingKey.AutoSize = true;
            this.cbWordingKey.Checked = true;
            this.cbWordingKey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWordingKey.Location = new System.Drawing.Point(385, 49);
            this.cbWordingKey.Name = "cbWordingKey";
            this.cbWordingKey.Size = new System.Drawing.Size(84, 17);
            this.cbWordingKey.TabIndex = 16;
            this.cbWordingKey.Text = "Fuzzy Query";
            this.cbWordingKey.UseVisualStyleBackColor = true;
            // 
            // cbWordingContent
            // 
            this.cbWordingContent.AutoSize = true;
            this.cbWordingContent.Checked = true;
            this.cbWordingContent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWordingContent.Location = new System.Drawing.Point(385, 15);
            this.cbWordingContent.Name = "cbWordingContent";
            this.cbWordingContent.Size = new System.Drawing.Size(84, 17);
            this.cbWordingContent.TabIndex = 15;
            this.cbWordingContent.Text = "Fuzzy Query";
            this.cbWordingContent.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Wordings Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Wordings Content";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(484, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Location = new System.Drawing.Point(135, 48);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(235, 20);
            this.txtSearchKey.TabIndex = 11;
            this.txtSearchKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchKey_KeyDown);
            // 
            // txtSearchContent
            // 
            this.txtSearchContent.Location = new System.Drawing.Point(135, 12);
            this.txtSearchContent.Name = "txtSearchContent";
            this.txtSearchContent.Size = new System.Drawing.Size(235, 20);
            this.txtSearchContent.TabIndex = 10;
            this.txtSearchContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchContent_KeyDown);
            // 
            // gv_SearchResult
            // 
            this.gv_SearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_SearchResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gv_SearchResult.Location = new System.Drawing.Point(0, 85);
            this.gv_SearchResult.Name = "gv_SearchResult";
            this.gv_SearchResult.Size = new System.Drawing.Size(839, 260);
            this.gv_SearchResult.TabIndex = 9;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(748, 18);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 24);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export Data";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // tp_ClassFieldAbbr
            // 
            this.tp_ClassFieldAbbr.Controls.Add(this.gvClassFieldResult);
            this.tp_ClassFieldAbbr.Controls.Add(this.btnGetAbbr);
            this.tp_ClassFieldAbbr.Controls.Add(this.txtClassField);
            this.tp_ClassFieldAbbr.Location = new System.Drawing.Point(4, 22);
            this.tp_ClassFieldAbbr.Name = "tp_ClassFieldAbbr";
            this.tp_ClassFieldAbbr.Size = new System.Drawing.Size(847, 421);
            this.tp_ClassFieldAbbr.TabIndex = 6;
            this.tp_ClassFieldAbbr.Text = "    Class/Field Abbr    ";
            this.tp_ClassFieldAbbr.UseVisualStyleBackColor = true;
            // 
            // gvClassFieldResult
            // 
            this.gvClassFieldResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvClassFieldResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvClassFieldResult.Location = new System.Drawing.Point(0, 226);
            this.gvClassFieldResult.Name = "gvClassFieldResult";
            this.gvClassFieldResult.Size = new System.Drawing.Size(847, 195);
            this.gvClassFieldResult.TabIndex = 14;
            // 
            // btnGetAbbr
            // 
            this.btnGetAbbr.Location = new System.Drawing.Point(33, 163);
            this.btnGetAbbr.Name = "btnGetAbbr";
            this.btnGetAbbr.Size = new System.Drawing.Size(75, 24);
            this.btnGetAbbr.TabIndex = 13;
            this.btnGetAbbr.Text = "Start";
            this.btnGetAbbr.UseVisualStyleBackColor = true;
            this.btnGetAbbr.Click += new System.EventHandler(this.btnGetAbbr_Click);
            // 
            // txtClassField
            // 
            this.txtClassField.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtClassField.Font = new System.Drawing.Font("SimSun", 12F);
            this.txtClassField.Location = new System.Drawing.Point(0, 0);
            this.txtClassField.Multiline = true;
            this.txtClassField.Name = "txtClassField";
            this.txtClassField.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtClassField.Size = new System.Drawing.Size(847, 157);
            this.txtClassField.TabIndex = 4;
            this.txtClassField.WordWrap = false;
            // 
            // tp_BackupTask
            // 
            this.tp_BackupTask.Controls.Add(this.cbBackupTaskTaskName);
            this.tp_BackupTask.Controls.Add(this.label17);
            this.tp_BackupTask.Controls.Add(this.txtBackupTaskSubmitResult);
            this.tp_BackupTask.Controls.Add(this.btnBackupTaskLoad);
            this.tp_BackupTask.Controls.Add(this.label16);
            this.tp_BackupTask.Controls.Add(this.txtBackupTaskLastestPath);
            this.tp_BackupTask.Controls.Add(this.btnBackupTaskLastestPath);
            this.tp_BackupTask.Controls.Add(this.cbBackupTaskTargetPath);
            this.tp_BackupTask.Controls.Add(this.cbBackupTaskBackWording);
            this.tp_BackupTask.Controls.Add(this.label15);
            this.tp_BackupTask.Controls.Add(this.txtBackupTaskTargetPath);
            this.tp_BackupTask.Controls.Add(this.label14);
            this.tp_BackupTask.Controls.Add(this.txtBackupTaskPath);
            this.tp_BackupTask.Controls.Add(this.btnBackupTaskPath);
            this.tp_BackupTask.Controls.Add(this.cbBackupTaskType);
            this.tp_BackupTask.Controls.Add(this.txtBackupTaskFileList);
            this.tp_BackupTask.Controls.Add(this.label13);
            this.tp_BackupTask.Controls.Add(this.btnBackupSubmit);
            this.tp_BackupTask.Controls.Add(this.txtBackupTaskName);
            this.tp_BackupTask.Location = new System.Drawing.Point(4, 22);
            this.tp_BackupTask.Name = "tp_BackupTask";
            this.tp_BackupTask.Size = new System.Drawing.Size(847, 421);
            this.tp_BackupTask.TabIndex = 7;
            this.tp_BackupTask.Text = "    Backup Task    ";
            this.tp_BackupTask.UseVisualStyleBackColor = true;
            // 
            // cbBackupTaskTaskName
            // 
            this.cbBackupTaskTaskName.FormattingEnabled = true;
            this.cbBackupTaskTaskName.Location = new System.Drawing.Point(15, 180);
            this.cbBackupTaskTaskName.Name = "cbBackupTaskTaskName";
            this.cbBackupTaskTaskName.Size = new System.Drawing.Size(197, 21);
            this.cbBackupTaskTaskName.TabIndex = 43;
            this.cbBackupTaskTaskName.SelectedIndexChanged += new System.EventHandler(this.cbBackupTaskTaskName_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(467, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "Backup FileList";
            // 
            // txtBackupTaskSubmitResult
            // 
            this.txtBackupTaskSubmitResult.Font = new System.Drawing.Font("SimSun", 12F);
            this.txtBackupTaskSubmitResult.Location = new System.Drawing.Point(15, 263);
            this.txtBackupTaskSubmitResult.Multiline = true;
            this.txtBackupTaskSubmitResult.Name = "txtBackupTaskSubmitResult";
            this.txtBackupTaskSubmitResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBackupTaskSubmitResult.Size = new System.Drawing.Size(438, 121);
            this.txtBackupTaskSubmitResult.TabIndex = 41;
            this.txtBackupTaskSubmitResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBackupTaskSubmitResult_KeyDown);
            // 
            // btnBackupTaskLoad
            // 
            this.btnBackupTaskLoad.Location = new System.Drawing.Point(470, 21);
            this.btnBackupTaskLoad.Name = "btnBackupTaskLoad";
            this.btnBackupTaskLoad.Size = new System.Drawing.Size(76, 25);
            this.btnBackupTaskLoad.TabIndex = 40;
            this.btnBackupTaskLoad.Text = "Load";
            this.btnBackupTaskLoad.UseVisualStyleBackColor = true;
            this.btnBackupTaskLoad.Click += new System.EventHandler(this.btnBackupTaskLoad_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Pre Task";
            // 
            // txtBackupTaskLastestPath
            // 
            this.txtBackupTaskLastestPath.Location = new System.Drawing.Point(90, 26);
            this.txtBackupTaskLastestPath.Name = "txtBackupTaskLastestPath";
            this.txtBackupTaskLastestPath.Size = new System.Drawing.Size(271, 20);
            this.txtBackupTaskLastestPath.TabIndex = 38;
            // 
            // btnBackupTaskLastestPath
            // 
            this.btnBackupTaskLastestPath.Location = new System.Drawing.Point(378, 22);
            this.btnBackupTaskLastestPath.Name = "btnBackupTaskLastestPath";
            this.btnBackupTaskLastestPath.Size = new System.Drawing.Size(75, 25);
            this.btnBackupTaskLastestPath.TabIndex = 37;
            this.btnBackupTaskLastestPath.Text = "Browse...";
            this.btnBackupTaskLastestPath.UseVisualStyleBackColor = true;
            this.btnBackupTaskLastestPath.Click += new System.EventHandler(this.btnBackupTaskLastestPath_Click);
            // 
            // cbBackupTaskTargetPath
            // 
            this.cbBackupTaskTargetPath.FormattingEnabled = true;
            this.cbBackupTaskTargetPath.Location = new System.Drawing.Point(90, 106);
            this.cbBackupTaskTargetPath.Name = "cbBackupTaskTargetPath";
            this.cbBackupTaskTargetPath.Size = new System.Drawing.Size(124, 21);
            this.cbBackupTaskTargetPath.TabIndex = 36;
            this.cbBackupTaskTargetPath.SelectedIndexChanged += new System.EventHandler(this.cbBackupTaskTargetPath_SelectedIndexChanged);
            // 
            // cbBackupTaskBackWording
            // 
            this.cbBackupTaskBackWording.AutoSize = true;
            this.cbBackupTaskBackWording.Location = new System.Drawing.Point(250, 143);
            this.cbBackupTaskBackWording.Name = "cbBackupTaskBackWording";
            this.cbBackupTaskBackWording.Size = new System.Drawing.Size(111, 17);
            this.cbBackupTaskBackWording.TabIndex = 35;
            this.cbBackupTaskBackWording.Text = "Backup Wordings";
            this.cbBackupTaskBackWording.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Target Path";
            // 
            // txtBackupTaskTargetPath
            // 
            this.txtBackupTaskTargetPath.Location = new System.Drawing.Point(218, 107);
            this.txtBackupTaskTargetPath.Name = "txtBackupTaskTargetPath";
            this.txtBackupTaskTargetPath.Size = new System.Drawing.Size(235, 20);
            this.txtBackupTaskTargetPath.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Backup Path";
            // 
            // txtBackupTaskPath
            // 
            this.txtBackupTaskPath.Location = new System.Drawing.Point(90, 66);
            this.txtBackupTaskPath.Name = "txtBackupTaskPath";
            this.txtBackupTaskPath.Size = new System.Drawing.Size(271, 20);
            this.txtBackupTaskPath.TabIndex = 19;
            // 
            // btnBackupTaskPath
            // 
            this.btnBackupTaskPath.Location = new System.Drawing.Point(378, 64);
            this.btnBackupTaskPath.Name = "btnBackupTaskPath";
            this.btnBackupTaskPath.Size = new System.Drawing.Size(75, 25);
            this.btnBackupTaskPath.TabIndex = 18;
            this.btnBackupTaskPath.Text = "Browse...";
            this.btnBackupTaskPath.UseVisualStyleBackColor = true;
            this.btnBackupTaskPath.Click += new System.EventHandler(this.btnBackupTaskPath_Click);
            // 
            // cbBackupTaskType
            // 
            this.cbBackupTaskType.FormattingEnabled = true;
            this.cbBackupTaskType.Location = new System.Drawing.Point(90, 141);
            this.cbBackupTaskType.Name = "cbBackupTaskType";
            this.cbBackupTaskType.Size = new System.Drawing.Size(124, 21);
            this.cbBackupTaskType.TabIndex = 17;
            // 
            // txtBackupTaskFileList
            // 
            this.txtBackupTaskFileList.Font = new System.Drawing.Font("SimSun", 12F);
            this.txtBackupTaskFileList.Location = new System.Drawing.Point(470, 89);
            this.txtBackupTaskFileList.Multiline = true;
            this.txtBackupTaskFileList.Name = "txtBackupTaskFileList";
            this.txtBackupTaskFileList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBackupTaskFileList.Size = new System.Drawing.Size(374, 296);
            this.txtBackupTaskFileList.TabIndex = 16;
            this.txtBackupTaskFileList.WordWrap = false;
            this.txtBackupTaskFileList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBackupTaskFileList_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Task Type";
            // 
            // btnBackupSubmit
            // 
            this.btnBackupSubmit.Location = new System.Drawing.Point(15, 221);
            this.btnBackupSubmit.Name = "btnBackupSubmit";
            this.btnBackupSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnBackupSubmit.TabIndex = 11;
            this.btnBackupSubmit.Text = "Submit";
            this.btnBackupSubmit.UseVisualStyleBackColor = true;
            this.btnBackupSubmit.Click += new System.EventHandler(this.btnBackupSubmit_Click);
            // 
            // txtBackupTaskName
            // 
            this.txtBackupTaskName.Location = new System.Drawing.Point(218, 181);
            this.txtBackupTaskName.Name = "txtBackupTaskName";
            this.txtBackupTaskName.Size = new System.Drawing.Size(236, 20);
            this.txtBackupTaskName.TabIndex = 10;
            // 
            // tp_OperateDB
            // 
            this.tp_OperateDB.Controls.Add(this.tabControl1);
            this.tp_OperateDB.Controls.Add(this.groupBox6);
            this.tp_OperateDB.Location = new System.Drawing.Point(4, 22);
            this.tp_OperateDB.Name = "tp_OperateDB";
            this.tp_OperateDB.Size = new System.Drawing.Size(847, 421);
            this.tp_OperateDB.TabIndex = 8;
            this.tp_OperateDB.Text = "    Operate DB    ";
            this.tp_OperateDB.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(384, 421);
            this.tabControl1.TabIndex = 51;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "    Add Job & JobSeeker    ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label40);
            this.groupBox4.Controls.Add(this.txtOthers_LastName);
            this.groupBox4.Controls.Add(this.label39);
            this.groupBox4.Controls.Add(this.txtOthers_FirstName);
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.cbOthers_ToCountryCode);
            this.groupBox4.Controls.Add(this.cbOthers_CountryCode);
            this.groupBox4.Controls.Add(this.cbOthers_IsNewWorkforce);
            this.groupBox4.Controls.Add(this.cbOthers_JobCount);
            this.groupBox4.Controls.Add(this.cbOthers_CandidateCount);
            this.groupBox4.Controls.Add(this.cbOthers_ProfilePrivacyLevel);
            this.groupBox4.Controls.Add(this.cbOthers_CountryOfResidence);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.cbOthers_Account);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.txtOthers_JobSeekerId);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.txtOthers_Email);
            this.groupBox4.Controls.Add(this.btnOthers_Add);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.txtOthers_JobTitle);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.txtOthers_JobAdId);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.txtOthers_InvoiceItemID);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.txtOthers_EmployerId);
            this.groupBox4.Controls.Add(this.cbOthers_AddJob);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.txtOthers_AccountNum);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.cbOthers_AddCandidate);
            this.groupBox4.Controls.Add(this.txtOthers_SubAccount);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 389);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(209, 103);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(55, 13);
            this.label40.TabIndex = 73;
            this.label40.Text = "LastName";
            // 
            // txtOthers_LastName
            // 
            this.txtOthers_LastName.Location = new System.Drawing.Point(268, 99);
            this.txtOthers_LastName.Name = "txtOthers_LastName";
            this.txtOthers_LastName.Size = new System.Drawing.Size(94, 20);
            this.txtOthers_LastName.TabIndex = 72;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(19, 103);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(54, 13);
            this.label39.TabIndex = 71;
            this.label39.Text = "FirstName";
            // 
            // txtOthers_FirstName
            // 
            this.txtOthers_FirstName.Location = new System.Drawing.Point(97, 99);
            this.txtOthers_FirstName.Name = "txtOthers_FirstName";
            this.txtOthers_FirstName.Size = new System.Drawing.Size(94, 20);
            this.txtOthers_FirstName.TabIndex = 70;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(211, 275);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(20, 13);
            this.label30.TabIndex = 69;
            this.label30.Text = "To";
            // 
            // cbOthers_ToCountryCode
            // 
            this.cbOthers_ToCountryCode.FormattingEnabled = true;
            this.cbOthers_ToCountryCode.Location = new System.Drawing.Point(238, 271);
            this.cbOthers_ToCountryCode.Name = "cbOthers_ToCountryCode";
            this.cbOthers_ToCountryCode.Size = new System.Drawing.Size(82, 21);
            this.cbOthers_ToCountryCode.TabIndex = 68;
            // 
            // cbOthers_CountryCode
            // 
            this.cbOthers_CountryCode.FormattingEnabled = true;
            this.cbOthers_CountryCode.Location = new System.Drawing.Point(95, 272);
            this.cbOthers_CountryCode.Name = "cbOthers_CountryCode";
            this.cbOthers_CountryCode.Size = new System.Drawing.Size(83, 21);
            this.cbOthers_CountryCode.TabIndex = 67;
            // 
            // cbOthers_IsNewWorkforce
            // 
            this.cbOthers_IsNewWorkforce.AutoSize = true;
            this.cbOthers_IsNewWorkforce.Location = new System.Drawing.Point(267, 41);
            this.cbOthers_IsNewWorkforce.Name = "cbOthers_IsNewWorkforce";
            this.cbOthers_IsNewWorkforce.Size = new System.Drawing.Size(106, 17);
            this.cbOthers_IsNewWorkforce.TabIndex = 65;
            this.cbOthers_IsNewWorkforce.Text = "IsNewWorkforce";
            this.cbOthers_IsNewWorkforce.UseVisualStyleBackColor = true;
            // 
            // cbOthers_JobCount
            // 
            this.cbOthers_JobCount.FormattingEnabled = true;
            this.cbOthers_JobCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbOthers_JobCount.Location = new System.Drawing.Point(323, 134);
            this.cbOthers_JobCount.Name = "cbOthers_JobCount";
            this.cbOthers_JobCount.Size = new System.Drawing.Size(41, 21);
            this.cbOthers_JobCount.TabIndex = 64;
            // 
            // cbOthers_CandidateCount
            // 
            this.cbOthers_CandidateCount.DisplayMember = "1";
            this.cbOthers_CandidateCount.FormattingEnabled = true;
            this.cbOthers_CandidateCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbOthers_CandidateCount.Location = new System.Drawing.Point(323, 14);
            this.cbOthers_CandidateCount.Name = "cbOthers_CandidateCount";
            this.cbOthers_CandidateCount.Size = new System.Drawing.Size(41, 21);
            this.cbOthers_CandidateCount.TabIndex = 63;
            // 
            // cbOthers_ProfilePrivacyLevel
            // 
            this.cbOthers_ProfilePrivacyLevel.FormattingEnabled = true;
            this.cbOthers_ProfilePrivacyLevel.Location = new System.Drawing.Point(268, 69);
            this.cbOthers_ProfilePrivacyLevel.Name = "cbOthers_ProfilePrivacyLevel";
            this.cbOthers_ProfilePrivacyLevel.Size = new System.Drawing.Size(74, 21);
            this.cbOthers_ProfilePrivacyLevel.TabIndex = 62;
            // 
            // cbOthers_CountryOfResidence
            // 
            this.cbOthers_CountryOfResidence.FormattingEnabled = true;
            this.cbOthers_CountryOfResidence.Location = new System.Drawing.Point(196, 14);
            this.cbOthers_CountryOfResidence.Name = "cbOthers_CountryOfResidence";
            this.cbOthers_CountryOfResidence.Size = new System.Drawing.Size(124, 21);
            this.cbOthers_CountryOfResidence.TabIndex = 61;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(17, 278);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(68, 13);
            this.label29.TabIndex = 60;
            this.label29.Text = "CountryCode";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(144, 138);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(47, 13);
            this.label28.TabIndex = 58;
            this.label28.Text = "Account";
            // 
            // cbOthers_Account
            // 
            this.cbOthers_Account.FormattingEnabled = true;
            this.cbOthers_Account.Location = new System.Drawing.Point(196, 134);
            this.cbOthers_Account.Name = "cbOthers_Account";
            this.cbOthers_Account.Size = new System.Drawing.Size(124, 21);
            this.cbOthers_Account.TabIndex = 57;
            this.cbOthers_Account.SelectedIndexChanged += new System.EventHandler(this.cbOthers_Account_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(17, 73);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(67, 13);
            this.label27.TabIndex = 56;
            this.label27.Text = "JobSeekerId";
            // 
            // txtOthers_JobSeekerId
            // 
            this.txtOthers_JobSeekerId.Location = new System.Drawing.Point(95, 69);
            this.txtOthers_JobSeekerId.Name = "txtOthers_JobSeekerId";
            this.txtOthers_JobSeekerId.Size = new System.Drawing.Size(160, 20);
            this.txtOthers_JobSeekerId.TabIndex = 55;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(17, 43);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 13);
            this.label25.TabIndex = 54;
            this.label25.Text = "Email";
            // 
            // txtOthers_Email
            // 
            this.txtOthers_Email.Location = new System.Drawing.Point(95, 39);
            this.txtOthers_Email.Name = "txtOthers_Email";
            this.txtOthers_Email.Size = new System.Drawing.Size(160, 20);
            this.txtOthers_Email.TabIndex = 53;
            // 
            // btnOthers_Add
            // 
            this.btnOthers_Add.Location = new System.Drawing.Point(20, 355);
            this.btnOthers_Add.Name = "btnOthers_Add";
            this.btnOthers_Add.Size = new System.Drawing.Size(75, 23);
            this.btnOthers_Add.TabIndex = 52;
            this.btnOthers_Add.Text = "Add";
            this.btnOthers_Add.UseVisualStyleBackColor = true;
            this.btnOthers_Add.Click += new System.EventHandler(this.btnOthers_Add_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(17, 326);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 13);
            this.label26.TabIndex = 51;
            this.label26.Text = "JobTitle";
            // 
            // txtOthers_JobTitle
            // 
            this.txtOthers_JobTitle.Location = new System.Drawing.Point(95, 322);
            this.txtOthers_JobTitle.Name = "txtOthers_JobTitle";
            this.txtOthers_JobTitle.Size = new System.Drawing.Size(225, 20);
            this.txtOthers_JobTitle.TabIndex = 50;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(17, 302);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(46, 13);
            this.label24.TabIndex = 49;
            this.label24.Text = "JobAdId";
            // 
            // txtOthers_JobAdId
            // 
            this.txtOthers_JobAdId.Location = new System.Drawing.Point(95, 298);
            this.txtOthers_JobAdId.Name = "txtOthers_JobAdId";
            this.txtOthers_JobAdId.Size = new System.Drawing.Size(225, 20);
            this.txtOthers_JobAdId.TabIndex = 48;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(17, 250);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 13);
            this.label23.TabIndex = 47;
            this.label23.Text = "InvoiceItemID";
            // 
            // txtOthers_InvoiceItemID
            // 
            this.txtOthers_InvoiceItemID.Location = new System.Drawing.Point(95, 246);
            this.txtOthers_InvoiceItemID.Name = "txtOthers_InvoiceItemID";
            this.txtOthers_InvoiceItemID.Size = new System.Drawing.Size(225, 20);
            this.txtOthers_InvoiceItemID.TabIndex = 46;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 224);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 13);
            this.label22.TabIndex = 45;
            this.label22.Text = "EmployerId";
            // 
            // txtOthers_EmployerId
            // 
            this.txtOthers_EmployerId.Location = new System.Drawing.Point(95, 220);
            this.txtOthers_EmployerId.Name = "txtOthers_EmployerId";
            this.txtOthers_EmployerId.Size = new System.Drawing.Size(225, 20);
            this.txtOthers_EmployerId.TabIndex = 44;
            // 
            // cbOthers_AddJob
            // 
            this.cbOthers_AddJob.AutoSize = true;
            this.cbOthers_AddJob.Checked = true;
            this.cbOthers_AddJob.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOthers_AddJob.Location = new System.Drawing.Point(20, 136);
            this.cbOthers_AddJob.Name = "cbOthers_AddJob";
            this.cbOthers_AddJob.Size = new System.Drawing.Size(65, 17);
            this.cbOthers_AddJob.TabIndex = 28;
            this.cbOthers_AddJob.Text = "Add Job";
            this.cbOthers_AddJob.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 168);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 13);
            this.label20.TabIndex = 43;
            this.label20.Text = "AccountNum";
            // 
            // txtOthers_AccountNum
            // 
            this.txtOthers_AccountNum.Location = new System.Drawing.Point(95, 165);
            this.txtOthers_AccountNum.Name = "txtOthers_AccountNum";
            this.txtOthers_AccountNum.Size = new System.Drawing.Size(225, 20);
            this.txtOthers_AccountNum.TabIndex = 42;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 197);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 13);
            this.label21.TabIndex = 41;
            this.label21.Text = "SubAccount";
            // 
            // cbOthers_AddCandidate
            // 
            this.cbOthers_AddCandidate.AutoSize = true;
            this.cbOthers_AddCandidate.Checked = true;
            this.cbOthers_AddCandidate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOthers_AddCandidate.Location = new System.Drawing.Point(20, 16);
            this.cbOthers_AddCandidate.Name = "cbOthers_AddCandidate";
            this.cbOthers_AddCandidate.Size = new System.Drawing.Size(96, 17);
            this.cbOthers_AddCandidate.TabIndex = 29;
            this.cbOthers_AddCandidate.Text = "Add Candidate";
            this.cbOthers_AddCandidate.UseVisualStyleBackColor = true;
            // 
            // txtOthers_SubAccount
            // 
            this.txtOthers_SubAccount.Location = new System.Drawing.Point(95, 193);
            this.txtOthers_SubAccount.Name = "txtOthers_SubAccount";
            this.txtOthers_SubAccount.Size = new System.Drawing.Size(225, 20);
            this.txtOthers_SubAccount.TabIndex = 40;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "    Operate DB    ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtOperateDB_List);
            this.groupBox7.Controls.Add(this.btnOperateDB_Start);
            this.groupBox7.Controls.Add(this.btnOperateDB_GetDB);
            this.groupBox7.Controls.Add(this.groupBox3);
            this.groupBox7.Controls.Add(this.cbOperateDB_Database);
            this.groupBox7.Controls.Add(this.btnOperateDB_BrowseScriptList);
            this.groupBox7.Controls.Add(this.btnOperateDB_LoadScriptList);
            this.groupBox7.Controls.Add(this.txtOperateDB_ScriptListPath);
            this.groupBox7.Controls.Add(this.groupBox2);
            this.groupBox7.Controls.Add(this.groupBox1);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(370, 389);
            this.groupBox7.TabIndex = 51;
            this.groupBox7.TabStop = false;
            // 
            // txtOperateDB_List
            // 
            this.txtOperateDB_List.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtOperateDB_List.Font = new System.Drawing.Font("SimSun", 12F);
            this.txtOperateDB_List.Location = new System.Drawing.Point(3, 206);
            this.txtOperateDB_List.Multiline = true;
            this.txtOperateDB_List.Name = "txtOperateDB_List";
            this.txtOperateDB_List.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOperateDB_List.Size = new System.Drawing.Size(364, 180);
            this.txtOperateDB_List.TabIndex = 27;
            this.txtOperateDB_List.WordWrap = false;
            this.txtOperateDB_List.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOperateDB_List_KeyDown);
            // 
            // btnOperateDB_Start
            // 
            this.btnOperateDB_Start.Location = new System.Drawing.Point(169, 120);
            this.btnOperateDB_Start.Name = "btnOperateDB_Start";
            this.btnOperateDB_Start.Size = new System.Drawing.Size(75, 23);
            this.btnOperateDB_Start.TabIndex = 23;
            this.btnOperateDB_Start.Text = "Start";
            this.btnOperateDB_Start.UseVisualStyleBackColor = true;
            this.btnOperateDB_Start.Click += new System.EventHandler(this.btnOperateDB_Start_Click);
            // 
            // btnOperateDB_GetDB
            // 
            this.btnOperateDB_GetDB.Location = new System.Drawing.Point(221, 11);
            this.btnOperateDB_GetDB.Name = "btnOperateDB_GetDB";
            this.btnOperateDB_GetDB.Size = new System.Drawing.Size(75, 23);
            this.btnOperateDB_GetDB.TabIndex = 34;
            this.btnOperateDB_GetDB.Text = "Get";
            this.btnOperateDB_GetDB.UseVisualStyleBackColor = true;
            this.btnOperateDB_GetDB.Click += new System.EventHandler(this.btnOperateDB_GetDB_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbOperateDB_Restore);
            this.groupBox3.Controls.Add(this.rbOperateDB_Backup);
            this.groupBox3.Location = new System.Drawing.Point(211, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 33);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            // 
            // rbOperateDB_Restore
            // 
            this.rbOperateDB_Restore.AutoSize = true;
            this.rbOperateDB_Restore.Location = new System.Drawing.Point(77, 11);
            this.rbOperateDB_Restore.Name = "rbOperateDB_Restore";
            this.rbOperateDB_Restore.Size = new System.Drawing.Size(62, 17);
            this.rbOperateDB_Restore.TabIndex = 5;
            this.rbOperateDB_Restore.Text = "Restore";
            this.rbOperateDB_Restore.UseVisualStyleBackColor = true;
            // 
            // rbOperateDB_Backup
            // 
            this.rbOperateDB_Backup.AutoSize = true;
            this.rbOperateDB_Backup.Checked = true;
            this.rbOperateDB_Backup.Location = new System.Drawing.Point(12, 12);
            this.rbOperateDB_Backup.Name = "rbOperateDB_Backup";
            this.rbOperateDB_Backup.Size = new System.Drawing.Size(62, 17);
            this.rbOperateDB_Backup.TabIndex = 4;
            this.rbOperateDB_Backup.TabStop = true;
            this.rbOperateDB_Backup.Text = "Backup";
            this.rbOperateDB_Backup.UseVisualStyleBackColor = true;
            // 
            // cbOperateDB_Database
            // 
            this.cbOperateDB_Database.FormattingEnabled = true;
            this.cbOperateDB_Database.Location = new System.Drawing.Point(6, 11);
            this.cbOperateDB_Database.Name = "cbOperateDB_Database";
            this.cbOperateDB_Database.Size = new System.Drawing.Size(193, 21);
            this.cbOperateDB_Database.TabIndex = 32;
            // 
            // btnOperateDB_BrowseScriptList
            // 
            this.btnOperateDB_BrowseScriptList.Location = new System.Drawing.Point(209, 171);
            this.btnOperateDB_BrowseScriptList.Name = "btnOperateDB_BrowseScriptList";
            this.btnOperateDB_BrowseScriptList.Size = new System.Drawing.Size(75, 25);
            this.btnOperateDB_BrowseScriptList.TabIndex = 44;
            this.btnOperateDB_BrowseScriptList.Text = "Browse...";
            this.btnOperateDB_BrowseScriptList.UseVisualStyleBackColor = true;
            this.btnOperateDB_BrowseScriptList.Click += new System.EventHandler(this.btnOperateDB_BrowseScriptList_Click);
            // 
            // btnOperateDB_LoadScriptList
            // 
            this.btnOperateDB_LoadScriptList.Location = new System.Drawing.Point(295, 171);
            this.btnOperateDB_LoadScriptList.Name = "btnOperateDB_LoadScriptList";
            this.btnOperateDB_LoadScriptList.Size = new System.Drawing.Size(76, 25);
            this.btnOperateDB_LoadScriptList.TabIndex = 46;
            this.btnOperateDB_LoadScriptList.Text = "Load";
            this.btnOperateDB_LoadScriptList.UseVisualStyleBackColor = true;
            this.btnOperateDB_LoadScriptList.Click += new System.EventHandler(this.btnOperateDB_LoadScriptList_Click);
            // 
            // txtOperateDB_ScriptListPath
            // 
            this.txtOperateDB_ScriptListPath.Location = new System.Drawing.Point(6, 174);
            this.txtOperateDB_ScriptListPath.Name = "txtOperateDB_ScriptListPath";
            this.txtOperateDB_ScriptListPath.Size = new System.Drawing.Size(197, 20);
            this.txtOperateDB_ScriptListPath.TabIndex = 45;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbOperateDB_ScriptSchema);
            this.groupBox2.Controls.Add(this.cbOperateDB_ScriptData);
            this.groupBox2.Controls.Add(this.cbOperateDB_ScriptDrops);
            this.groupBox2.Location = new System.Drawing.Point(6, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 40);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // cbOperateDB_ScriptSchema
            // 
            this.cbOperateDB_ScriptSchema.AutoSize = true;
            this.cbOperateDB_ScriptSchema.Checked = true;
            this.cbOperateDB_ScriptSchema.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOperateDB_ScriptSchema.Location = new System.Drawing.Point(7, 15);
            this.cbOperateDB_ScriptSchema.Name = "cbOperateDB_ScriptSchema";
            this.cbOperateDB_ScriptSchema.Size = new System.Drawing.Size(95, 17);
            this.cbOperateDB_ScriptSchema.TabIndex = 28;
            this.cbOperateDB_ScriptSchema.Text = "Script Schema";
            this.cbOperateDB_ScriptSchema.UseVisualStyleBackColor = true;
            // 
            // cbOperateDB_ScriptData
            // 
            this.cbOperateDB_ScriptData.AutoSize = true;
            this.cbOperateDB_ScriptData.Location = new System.Drawing.Point(230, 17);
            this.cbOperateDB_ScriptData.Name = "cbOperateDB_ScriptData";
            this.cbOperateDB_ScriptData.Size = new System.Drawing.Size(79, 17);
            this.cbOperateDB_ScriptData.TabIndex = 26;
            this.cbOperateDB_ScriptData.Text = "Script Data";
            this.cbOperateDB_ScriptData.UseVisualStyleBackColor = true;
            // 
            // cbOperateDB_ScriptDrops
            // 
            this.cbOperateDB_ScriptDrops.AutoSize = true;
            this.cbOperateDB_ScriptDrops.Checked = true;
            this.cbOperateDB_ScriptDrops.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOperateDB_ScriptDrops.Location = new System.Drawing.Point(119, 17);
            this.cbOperateDB_ScriptDrops.Name = "cbOperateDB_ScriptDrops";
            this.cbOperateDB_ScriptDrops.Size = new System.Drawing.Size(84, 17);
            this.cbOperateDB_ScriptDrops.TabIndex = 29;
            this.cbOperateDB_ScriptDrops.Text = "Script Drops";
            this.cbOperateDB_ScriptDrops.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOperateDB_ScriptObj_IgnoreList);
            this.groupBox1.Controls.Add(this.rbOperateDB_ScriptObj_OnlyList);
            this.groupBox1.Controls.Add(this.rbOperateDB_ScriptObj_All);
            this.groupBox1.Location = new System.Drawing.Point(6, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 33);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // rbOperateDB_ScriptObj_IgnoreList
            // 
            this.rbOperateDB_ScriptObj_IgnoreList.AutoSize = true;
            this.rbOperateDB_ScriptObj_IgnoreList.Location = new System.Drawing.Point(121, 11);
            this.rbOperateDB_ScriptObj_IgnoreList.Name = "rbOperateDB_ScriptObj_IgnoreList";
            this.rbOperateDB_ScriptObj_IgnoreList.Size = new System.Drawing.Size(71, 17);
            this.rbOperateDB_ScriptObj_IgnoreList.TabIndex = 6;
            this.rbOperateDB_ScriptObj_IgnoreList.Text = "IgnoreList";
            this.rbOperateDB_ScriptObj_IgnoreList.UseVisualStyleBackColor = true;
            this.rbOperateDB_ScriptObj_IgnoreList.CheckedChanged += new System.EventHandler(this.rbOperateDB_ScriptObj_IgnoreList_CheckedChanged);
            // 
            // rbOperateDB_ScriptObj_OnlyList
            // 
            this.rbOperateDB_ScriptObj_OnlyList.AutoSize = true;
            this.rbOperateDB_ScriptObj_OnlyList.Location = new System.Drawing.Point(50, 12);
            this.rbOperateDB_ScriptObj_OnlyList.Name = "rbOperateDB_ScriptObj_OnlyList";
            this.rbOperateDB_ScriptObj_OnlyList.Size = new System.Drawing.Size(62, 17);
            this.rbOperateDB_ScriptObj_OnlyList.TabIndex = 5;
            this.rbOperateDB_ScriptObj_OnlyList.Text = "OnlyList";
            this.rbOperateDB_ScriptObj_OnlyList.UseVisualStyleBackColor = true;
            this.rbOperateDB_ScriptObj_OnlyList.CheckedChanged += new System.EventHandler(this.rbOperateDB_ScriptObj_OnlyList_CheckedChanged);
            // 
            // rbOperateDB_ScriptObj_All
            // 
            this.rbOperateDB_ScriptObj_All.AutoSize = true;
            this.rbOperateDB_ScriptObj_All.Checked = true;
            this.rbOperateDB_ScriptObj_All.Location = new System.Drawing.Point(6, 13);
            this.rbOperateDB_ScriptObj_All.Name = "rbOperateDB_ScriptObj_All";
            this.rbOperateDB_ScriptObj_All.Size = new System.Drawing.Size(36, 17);
            this.rbOperateDB_ScriptObj_All.TabIndex = 4;
            this.rbOperateDB_ScriptObj_All.TabStop = true;
            this.rbOperateDB_ScriptObj_All.Text = "All";
            this.rbOperateDB_ScriptObj_All.UseVisualStyleBackColor = true;
            this.rbOperateDB_ScriptObj_All.CheckedChanged += new System.EventHandler(this.rbOperateDB_ScriptObj_All_CheckedChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox9);
            this.tabPage5.Controls.Add(this.btnOperateDB_Country_Generate);
            this.tabPage5.Controls.Add(this.txtOperateDB_Country_Content);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(376, 395);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "    Generate Country Sql    ";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cbOperateDB_Country_US);
            this.groupBox9.Controls.Add(this.cbOperateDB_Country_TH);
            this.groupBox9.Controls.Add(this.cbOperateDB_Country_TW);
            this.groupBox9.Controls.Add(this.cbOperateDB_Country_PH);
            this.groupBox9.Controls.Add(this.cbOperateDB_Country_SG);
            this.groupBox9.Controls.Add(this.cbOperateDB_Country_ID);
            this.groupBox9.Controls.Add(this.cbOperateDB_Country_IN);
            this.groupBox9.Controls.Add(this.cbOperateDB_Country_KR);
            this.groupBox9.Controls.Add(this.cbOperateDB_Country_MY);
            this.groupBox9.Controls.Add(this.cbOperateDB_Country_AU);
            this.groupBox9.Controls.Add(this.cbOperateDB_Country_HK);
            this.groupBox9.Location = new System.Drawing.Point(6, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(270, 52);
            this.groupBox9.TabIndex = 51;
            this.groupBox9.TabStop = false;
            // 
            // cbOperateDB_Country_US
            // 
            this.cbOperateDB_Country_US.AutoSize = true;
            this.cbOperateDB_Country_US.Checked = true;
            this.cbOperateDB_Country_US.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOperateDB_Country_US.Location = new System.Drawing.Point(231, 12);
            this.cbOperateDB_Country_US.Name = "cbOperateDB_Country_US";
            this.cbOperateDB_Country_US.Size = new System.Drawing.Size(41, 17);
            this.cbOperateDB_Country_US.TabIndex = 52;
            this.cbOperateDB_Country_US.Text = "US";
            this.cbOperateDB_Country_US.UseVisualStyleBackColor = true;
            // 
            // cbOperateDB_Country_TH
            // 
            this.cbOperateDB_Country_TH.AutoSize = true;
            this.cbOperateDB_Country_TH.Checked = true;
            this.cbOperateDB_Country_TH.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOperateDB_Country_TH.Location = new System.Drawing.Point(185, 12);
            this.cbOperateDB_Country_TH.Name = "cbOperateDB_Country_TH";
            this.cbOperateDB_Country_TH.Size = new System.Drawing.Size(41, 17);
            this.cbOperateDB_Country_TH.TabIndex = 36;
            this.cbOperateDB_Country_TH.Text = "TH";
            this.cbOperateDB_Country_TH.UseVisualStyleBackColor = true;
            // 
            // cbOperateDB_Country_TW
            // 
            this.cbOperateDB_Country_TW.AutoSize = true;
            this.cbOperateDB_Country_TW.Checked = true;
            this.cbOperateDB_Country_TW.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOperateDB_Country_TW.Location = new System.Drawing.Point(185, 32);
            this.cbOperateDB_Country_TW.Name = "cbOperateDB_Country_TW";
            this.cbOperateDB_Country_TW.Size = new System.Drawing.Size(44, 17);
            this.cbOperateDB_Country_TW.TabIndex = 37;
            this.cbOperateDB_Country_TW.Text = "TW";
            this.cbOperateDB_Country_TW.UseVisualStyleBackColor = true;
            // 
            // cbOperateDB_Country_PH
            // 
            this.cbOperateDB_Country_PH.AutoSize = true;
            this.cbOperateDB_Country_PH.Checked = true;
            this.cbOperateDB_Country_PH.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOperateDB_Country_PH.Location = new System.Drawing.Point(139, 12);
            this.cbOperateDB_Country_PH.Name = "cbOperateDB_Country_PH";
            this.cbOperateDB_Country_PH.Size = new System.Drawing.Size(41, 17);
            this.cbOperateDB_Country_PH.TabIndex = 34;
            this.cbOperateDB_Country_PH.Text = "PH";
            this.cbOperateDB_Country_PH.UseVisualStyleBackColor = true;
            // 
            // cbOperateDB_Country_SG
            // 
            this.cbOperateDB_Country_SG.AutoSize = true;
            this.cbOperateDB_Country_SG.Checked = true;
            this.cbOperateDB_Country_SG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOperateDB_Country_SG.Location = new System.Drawing.Point(139, 32);
            this.cbOperateDB_Country_SG.Name = "cbOperateDB_Country_SG";
            this.cbOperateDB_Country_SG.Size = new System.Drawing.Size(41, 17);
            this.cbOperateDB_Country_SG.TabIndex = 35;
            this.cbOperateDB_Country_SG.Text = "SG";
            this.cbOperateDB_Country_SG.UseVisualStyleBackColor = true;
            // 
            // cbOperateDB_Country_ID
            // 
            this.cbOperateDB_Country_ID.AutoSize = true;
            this.cbOperateDB_Country_ID.Checked = true;
            this.cbOperateDB_Country_ID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOperateDB_Country_ID.Location = new System.Drawing.Point(51, 12);
            this.cbOperateDB_Country_ID.Name = "cbOperateDB_Country_ID";
            this.cbOperateDB_Country_ID.Size = new System.Drawing.Size(37, 17);
            this.cbOperateDB_Country_ID.TabIndex = 32;
            this.cbOperateDB_Country_ID.Text = "ID";
            this.cbOperateDB_Country_ID.UseVisualStyleBackColor = true;
            // 
            // cbOperateDB_Country_IN
            // 
            this.cbOperateDB_Country_IN.AutoSize = true;
            this.cbOperateDB_Country_IN.Checked = true;
            this.cbOperateDB_Country_IN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOperateDB_Country_IN.Location = new System.Drawing.Point(51, 32);
            this.cbOperateDB_Country_IN.Name = "cbOperateDB_Country_IN";
            this.cbOperateDB_Country_IN.Size = new System.Drawing.Size(37, 17);
            this.cbOperateDB_Country_IN.TabIndex = 33;
            this.cbOperateDB_Country_IN.Text = "IN";
            this.cbOperateDB_Country_IN.UseVisualStyleBackColor = true;
            // 
            // cbOperateDB_Country_KR
            // 
            this.cbOperateDB_Country_KR.AutoSize = true;
            this.cbOperateDB_Country_KR.Checked = true;
            this.cbOperateDB_Country_KR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOperateDB_Country_KR.Location = new System.Drawing.Point(93, 12);
            this.cbOperateDB_Country_KR.Name = "cbOperateDB_Country_KR";
            this.cbOperateDB_Country_KR.Size = new System.Drawing.Size(41, 17);
            this.cbOperateDB_Country_KR.TabIndex = 30;
            this.cbOperateDB_Country_KR.Text = "KR";
            this.cbOperateDB_Country_KR.UseVisualStyleBackColor = true;
            // 
            // cbOperateDB_Country_MY
            // 
            this.cbOperateDB_Country_MY.AutoSize = true;
            this.cbOperateDB_Country_MY.Checked = true;
            this.cbOperateDB_Country_MY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOperateDB_Country_MY.Location = new System.Drawing.Point(93, 32);
            this.cbOperateDB_Country_MY.Name = "cbOperateDB_Country_MY";
            this.cbOperateDB_Country_MY.Size = new System.Drawing.Size(42, 17);
            this.cbOperateDB_Country_MY.TabIndex = 31;
            this.cbOperateDB_Country_MY.Text = "MY";
            this.cbOperateDB_Country_MY.UseVisualStyleBackColor = true;
            // 
            // cbOperateDB_Country_AU
            // 
            this.cbOperateDB_Country_AU.AutoSize = true;
            this.cbOperateDB_Country_AU.Checked = true;
            this.cbOperateDB_Country_AU.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOperateDB_Country_AU.Location = new System.Drawing.Point(7, 12);
            this.cbOperateDB_Country_AU.Name = "cbOperateDB_Country_AU";
            this.cbOperateDB_Country_AU.Size = new System.Drawing.Size(41, 17);
            this.cbOperateDB_Country_AU.TabIndex = 28;
            this.cbOperateDB_Country_AU.Text = "AU";
            this.cbOperateDB_Country_AU.UseVisualStyleBackColor = true;
            // 
            // cbOperateDB_Country_HK
            // 
            this.cbOperateDB_Country_HK.AutoSize = true;
            this.cbOperateDB_Country_HK.Checked = true;
            this.cbOperateDB_Country_HK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOperateDB_Country_HK.Location = new System.Drawing.Point(7, 32);
            this.cbOperateDB_Country_HK.Name = "cbOperateDB_Country_HK";
            this.cbOperateDB_Country_HK.Size = new System.Drawing.Size(41, 17);
            this.cbOperateDB_Country_HK.TabIndex = 29;
            this.cbOperateDB_Country_HK.Text = "HK";
            this.cbOperateDB_Country_HK.UseVisualStyleBackColor = true;
            // 
            // btnOperateDB_Country_Generate
            // 
            this.btnOperateDB_Country_Generate.Location = new System.Drawing.Point(286, 31);
            this.btnOperateDB_Country_Generate.Name = "btnOperateDB_Country_Generate";
            this.btnOperateDB_Country_Generate.Size = new System.Drawing.Size(75, 23);
            this.btnOperateDB_Country_Generate.TabIndex = 50;
            this.btnOperateDB_Country_Generate.Text = "Generate Sql";
            this.btnOperateDB_Country_Generate.UseVisualStyleBackColor = true;
            this.btnOperateDB_Country_Generate.Click += new System.EventHandler(this.btnOperateDB_Country_Generate_Click);
            // 
            // txtOperateDB_Country_Content
            // 
            this.txtOperateDB_Country_Content.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtOperateDB_Country_Content.Font = new System.Drawing.Font("SimSun", 12F);
            this.txtOperateDB_Country_Content.Location = new System.Drawing.Point(0, 78);
            this.txtOperateDB_Country_Content.Multiline = true;
            this.txtOperateDB_Country_Content.Name = "txtOperateDB_Country_Content";
            this.txtOperateDB_Country_Content.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOperateDB_Country_Content.Size = new System.Drawing.Size(376, 317);
            this.txtOperateDB_Country_Content.TabIndex = 34;
            this.txtOperateDB_Country_Content.WordWrap = false;
            this.txtOperateDB_Country_Content.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOperateDB_Country_Content_KeyDown);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnOthers_DropRMSDB);
            this.groupBox6.Controls.Add(this.btnOthers_RunSql);
            this.groupBox6.Controls.Add(this.txtOperateDB_Sql);
            this.groupBox6.Controls.Add(this.btOperateDB_LoadSql);
            this.groupBox6.Controls.Add(this.txtOperateDB_SqlPath);
            this.groupBox6.Controls.Add(this.btnOperateDB_Browse);
            this.groupBox6.Controls.Add(this.btnOperateDB_Save);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox6.Location = new System.Drawing.Point(387, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(460, 421);
            this.groupBox6.TabIndex = 49;
            this.groupBox6.TabStop = false;
            // 
            // btnOthers_DropRMSDB
            // 
            this.btnOthers_DropRMSDB.ForeColor = System.Drawing.Color.Red;
            this.btnOthers_DropRMSDB.Location = new System.Drawing.Point(309, 58);
            this.btnOthers_DropRMSDB.Name = "btnOthers_DropRMSDB";
            this.btnOthers_DropRMSDB.Size = new System.Drawing.Size(145, 23);
            this.btnOthers_DropRMSDB.TabIndex = 50;
            this.btnOthers_DropRMSDB.Text = "Drop RMS DB";
            this.btnOthers_DropRMSDB.UseVisualStyleBackColor = true;
            this.btnOthers_DropRMSDB.Click += new System.EventHandler(this.btnOthers_DropRMSDB_Click);
            // 
            // btnOthers_RunSql
            // 
            this.btnOthers_RunSql.Location = new System.Drawing.Point(6, 58);
            this.btnOthers_RunSql.Name = "btnOthers_RunSql";
            this.btnOthers_RunSql.Size = new System.Drawing.Size(75, 23);
            this.btnOthers_RunSql.TabIndex = 49;
            this.btnOthers_RunSql.Text = "Run Sql";
            this.btnOthers_RunSql.UseVisualStyleBackColor = true;
            this.btnOthers_RunSql.Click += new System.EventHandler(this.btnOthers_RunSql_Click);
            // 
            // txtOperateDB_Sql
            // 
            this.txtOperateDB_Sql.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtOperateDB_Sql.Font = new System.Drawing.Font("SimSun", 12F);
            this.txtOperateDB_Sql.Location = new System.Drawing.Point(3, 100);
            this.txtOperateDB_Sql.Multiline = true;
            this.txtOperateDB_Sql.Name = "txtOperateDB_Sql";
            this.txtOperateDB_Sql.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOperateDB_Sql.Size = new System.Drawing.Size(454, 318);
            this.txtOperateDB_Sql.TabIndex = 33;
            this.txtOperateDB_Sql.WordWrap = false;
            this.txtOperateDB_Sql.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOperateDB_Sql_KeyDown);
            // 
            // btOperateDB_LoadSql
            // 
            this.btOperateDB_LoadSql.Location = new System.Drawing.Point(385, 16);
            this.btOperateDB_LoadSql.Name = "btOperateDB_LoadSql";
            this.btOperateDB_LoadSql.Size = new System.Drawing.Size(69, 25);
            this.btOperateDB_LoadSql.TabIndex = 48;
            this.btOperateDB_LoadSql.Text = "Load";
            this.btOperateDB_LoadSql.UseVisualStyleBackColor = true;
            this.btOperateDB_LoadSql.Click += new System.EventHandler(this.btOperateDB_LoadSql_Click);
            // 
            // txtOperateDB_SqlPath
            // 
            this.txtOperateDB_SqlPath.Location = new System.Drawing.Point(6, 19);
            this.txtOperateDB_SqlPath.Name = "txtOperateDB_SqlPath";
            this.txtOperateDB_SqlPath.Size = new System.Drawing.Size(210, 20);
            this.txtOperateDB_SqlPath.TabIndex = 42;
            // 
            // btnOperateDB_Browse
            // 
            this.btnOperateDB_Browse.Location = new System.Drawing.Point(216, 18);
            this.btnOperateDB_Browse.Name = "btnOperateDB_Browse";
            this.btnOperateDB_Browse.Size = new System.Drawing.Size(75, 22);
            this.btnOperateDB_Browse.TabIndex = 41;
            this.btnOperateDB_Browse.Text = "Browse...";
            this.btnOperateDB_Browse.UseVisualStyleBackColor = true;
            this.btnOperateDB_Browse.Click += new System.EventHandler(this.btnOperateDB_Browse_Click);
            // 
            // btnOperateDB_Save
            // 
            this.btnOperateDB_Save.Location = new System.Drawing.Point(309, 17);
            this.btnOperateDB_Save.Name = "btnOperateDB_Save";
            this.btnOperateDB_Save.Size = new System.Drawing.Size(70, 25);
            this.btnOperateDB_Save.TabIndex = 43;
            this.btnOperateDB_Save.Text = "Save";
            this.btnOperateDB_Save.UseVisualStyleBackColor = true;
            this.btnOperateDB_Save.Click += new System.EventHandler(this.btnOperateDB_Save_Click);
            // 
            // tp_SolrUpdate
            // 
            this.tp_SolrUpdate.Controls.Add(this.tabControl2);
            this.tp_SolrUpdate.Location = new System.Drawing.Point(4, 22);
            this.tp_SolrUpdate.Name = "tp_SolrUpdate";
            this.tp_SolrUpdate.Size = new System.Drawing.Size(847, 421);
            this.tp_SolrUpdate.TabIndex = 9;
            this.tp_SolrUpdate.Text = "    Solr Update    ";
            this.tp_SolrUpdate.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(847, 421);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtbQuery);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(839, 395);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "    Solr Update    ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtbQuery
            // 
            this.rtbQuery.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbQuery.Location = new System.Drawing.Point(3, 114);
            this.rtbQuery.Name = "rtbQuery";
            this.rtbQuery.Size = new System.Drawing.Size(833, 278);
            this.rtbQuery.TabIndex = 6;
            this.rtbQuery.Text = "";
            this.rtbQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbQuery_KeyDown);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSolrUpdate_FixDB);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.txtSolrQueryUrl);
            this.groupBox5.Controls.Add(this.txtSolrUrl);
            this.groupBox5.Controls.Add(this.txtSolrUpdate_XmlPath);
            this.groupBox5.Controls.Add(this.cbSolrName);
            this.groupBox5.Controls.Add(this.cbbOperation);
            this.groupBox5.Controls.Add(this.rbType_SqlQuery);
            this.groupBox5.Controls.Add(this.btnSolrUpdate_Browse);
            this.groupBox5.Controls.Add(this.rbType_XmlQuery);
            this.groupBox5.Controls.Add(this.cbbCountry);
            this.groupBox5.Controls.Add(this.rbType_IdString);
            this.groupBox5.Controls.Add(this.rbType_SolrQuery);
            this.groupBox5.Controls.Add(this.btnSolrUpdate_Submit);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(833, 105);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // btnSolrUpdate_FixDB
            // 
            this.btnSolrUpdate_FixDB.ForeColor = System.Drawing.Color.Red;
            this.btnSolrUpdate_FixDB.Location = new System.Drawing.Point(181, 75);
            this.btnSolrUpdate_FixDB.Name = "btnSolrUpdate_FixDB";
            this.btnSolrUpdate_FixDB.Size = new System.Drawing.Size(75, 23);
            this.btnSolrUpdate_FixDB.TabIndex = 20;
            this.btnSolrUpdate_FixDB.Text = "Fix DB";
            this.btnSolrUpdate_FixDB.UseVisualStyleBackColor = true;
            this.btnSolrUpdate_FixDB.Click += new System.EventHandler(this.btnSolrUpdate_FixDB_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(346, 79);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "GetIdByXml";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(345, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 14;
            this.label19.Text = "GetIdBySolr";
            // 
            // txtSolrQueryUrl
            // 
            this.txtSolrQueryUrl.Enabled = false;
            this.txtSolrQueryUrl.Location = new System.Drawing.Point(422, 48);
            this.txtSolrQueryUrl.Name = "txtSolrQueryUrl";
            this.txtSolrQueryUrl.Size = new System.Drawing.Size(381, 20);
            this.txtSolrQueryUrl.TabIndex = 13;
            this.txtSolrQueryUrl.Text = "http://10.1.9.55:8080/solr-Example";
            this.txtSolrQueryUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSolrQueryUrl_KeyDown);
            // 
            // txtSolrUrl
            // 
            this.txtSolrUrl.Location = new System.Drawing.Point(349, 15);
            this.txtSolrUrl.Name = "txtSolrUrl";
            this.txtSolrUrl.Size = new System.Drawing.Size(454, 20);
            this.txtSolrUrl.TabIndex = 12;
            this.txtSolrUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSolrUrl_KeyDown);
            // 
            // txtSolrUpdate_XmlPath
            // 
            this.txtSolrUpdate_XmlPath.Enabled = false;
            this.txtSolrUpdate_XmlPath.Location = new System.Drawing.Point(422, 77);
            this.txtSolrUpdate_XmlPath.Name = "txtSolrUpdate_XmlPath";
            this.txtSolrUpdate_XmlPath.Size = new System.Drawing.Size(302, 20);
            this.txtSolrUpdate_XmlPath.TabIndex = 7;
            this.txtSolrUpdate_XmlPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSolrUpdate_XmlPath_KeyDown);
            // 
            // cbSolrName
            // 
            this.cbSolrName.FormattingEnabled = true;
            this.cbSolrName.Location = new System.Drawing.Point(8, 13);
            this.cbSolrName.Name = "cbSolrName";
            this.cbSolrName.Size = new System.Drawing.Size(170, 21);
            this.cbSolrName.TabIndex = 11;
            this.cbSolrName.SelectedIndexChanged += new System.EventHandler(this.cbSolrName_SelectedIndexChanged);
            // 
            // cbbOperation
            // 
            this.cbbOperation.FormattingEnabled = true;
            this.cbbOperation.Items.AddRange(new object[] {
            "Update",
            "Delete"});
            this.cbbOperation.Location = new System.Drawing.Point(259, 14);
            this.cbbOperation.Name = "cbbOperation";
            this.cbbOperation.Size = new System.Drawing.Size(83, 21);
            this.cbbOperation.TabIndex = 10;
            this.cbbOperation.Text = "Update";
            // 
            // rbType_SqlQuery
            // 
            this.rbType_SqlQuery.AutoSize = true;
            this.rbType_SqlQuery.Location = new System.Drawing.Point(85, 49);
            this.rbType_SqlQuery.Name = "rbType_SqlQuery";
            this.rbType_SqlQuery.Size = new System.Drawing.Size(68, 17);
            this.rbType_SqlQuery.TabIndex = 9;
            this.rbType_SqlQuery.TabStop = true;
            this.rbType_SqlQuery.Text = "SqlQuery";
            this.rbType_SqlQuery.UseVisualStyleBackColor = true;
            this.rbType_SqlQuery.CheckedChanged += new System.EventHandler(this.rbType_SqlQuery_CheckedChanged);
            // 
            // btnSolrUpdate_Browse
            // 
            this.btnSolrUpdate_Browse.Enabled = false;
            this.btnSolrUpdate_Browse.Location = new System.Drawing.Point(728, 76);
            this.btnSolrUpdate_Browse.Name = "btnSolrUpdate_Browse";
            this.btnSolrUpdate_Browse.Size = new System.Drawing.Size(75, 23);
            this.btnSolrUpdate_Browse.TabIndex = 6;
            this.btnSolrUpdate_Browse.Text = "Browse...";
            this.btnSolrUpdate_Browse.UseVisualStyleBackColor = true;
            this.btnSolrUpdate_Browse.Click += new System.EventHandler(this.btnSolrUpdate_Browse_Click);
            // 
            // rbType_XmlQuery
            // 
            this.rbType_XmlQuery.AutoSize = true;
            this.rbType_XmlQuery.Location = new System.Drawing.Point(253, 49);
            this.rbType_XmlQuery.Name = "rbType_XmlQuery";
            this.rbType_XmlQuery.Size = new System.Drawing.Size(70, 17);
            this.rbType_XmlQuery.TabIndex = 4;
            this.rbType_XmlQuery.TabStop = true;
            this.rbType_XmlQuery.Text = "XmlQuery";
            this.rbType_XmlQuery.UseVisualStyleBackColor = true;
            this.rbType_XmlQuery.CheckedChanged += new System.EventHandler(this.rbType_XmlQuery_CheckedChanged);
            // 
            // cbbCountry
            // 
            this.cbbCountry.FormattingEnabled = true;
            this.cbbCountry.Items.AddRange(new object[] {
            "HK",
            "ID",
            "TH",
            "SG",
            "MY",
            "PH"});
            this.cbbCountry.Location = new System.Drawing.Point(184, 14);
            this.cbbCountry.Name = "cbbCountry";
            this.cbbCountry.Size = new System.Drawing.Size(69, 21);
            this.cbbCountry.TabIndex = 8;
            this.cbbCountry.Text = "HK";
            this.cbbCountry.SelectedIndexChanged += new System.EventHandler(this.cbbCountry_SelectedIndexChanged);
            // 
            // rbType_IdString
            // 
            this.rbType_IdString.AutoSize = true;
            this.rbType_IdString.Checked = true;
            this.rbType_IdString.Location = new System.Drawing.Point(10, 49);
            this.rbType_IdString.Name = "rbType_IdString";
            this.rbType_IdString.Size = new System.Drawing.Size(64, 17);
            this.rbType_IdString.TabIndex = 2;
            this.rbType_IdString.TabStop = true;
            this.rbType_IdString.Text = " IdString";
            this.rbType_IdString.UseVisualStyleBackColor = true;
            this.rbType_IdString.CheckedChanged += new System.EventHandler(this.rbType_IdString_CheckedChanged);
            // 
            // rbType_SolrQuery
            // 
            this.rbType_SolrQuery.AutoSize = true;
            this.rbType_SolrQuery.Location = new System.Drawing.Point(164, 49);
            this.rbType_SolrQuery.Name = "rbType_SolrQuery";
            this.rbType_SolrQuery.Size = new System.Drawing.Size(71, 17);
            this.rbType_SolrQuery.TabIndex = 3;
            this.rbType_SolrQuery.TabStop = true;
            this.rbType_SolrQuery.Text = "SolrQuery";
            this.rbType_SolrQuery.UseVisualStyleBackColor = true;
            this.rbType_SolrQuery.CheckedChanged += new System.EventHandler(this.rbType_SolrQuery_CheckedChanged);
            // 
            // btnSolrUpdate_Submit
            // 
            this.btnSolrUpdate_Submit.Location = new System.Drawing.Point(29, 75);
            this.btnSolrUpdate_Submit.Name = "btnSolrUpdate_Submit";
            this.btnSolrUpdate_Submit.Size = new System.Drawing.Size(75, 23);
            this.btnSolrUpdate_Submit.TabIndex = 0;
            this.btnSolrUpdate_Submit.Text = "Submit";
            this.btnSolrUpdate_Submit.UseVisualStyleBackColor = true;
            this.btnSolrUpdate_Submit.Click += new System.EventHandler(this.btnSolrUpdate_Submit_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lbSolrUpdate_Note2);
            this.tabPage4.Controls.Add(this.lbSolrUpdate_Note);
            this.tabPage4.Controls.Add(this.btnPartial_Save);
            this.tabPage4.Controls.Add(this.plPartial_Field);
            this.tabPage4.Controls.Add(this.lbPartial_QueryResult);
            this.tabPage4.Controls.Add(this.groupBox8);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(839, 395);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "    Solr Partial Update    ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lbSolrUpdate_Note2
            // 
            this.lbSolrUpdate_Note2.AutoSize = true;
            this.lbSolrUpdate_Note2.ForeColor = System.Drawing.Color.Blue;
            this.lbSolrUpdate_Note2.Location = new System.Drawing.Point(422, 367);
            this.lbSolrUpdate_Note2.Name = "lbSolrUpdate_Note2";
            this.lbSolrUpdate_Note2.Size = new System.Drawing.Size(217, 13);
            this.lbSolrUpdate_Note2.TabIndex = 52;
            this.lbSolrUpdate_Note2.Text = "2.it will be shows empty if field is stored=false";
            this.lbSolrUpdate_Note2.Visible = false;
            // 
            // lbSolrUpdate_Note
            // 
            this.lbSolrUpdate_Note.AutoSize = true;
            this.lbSolrUpdate_Note.ForeColor = System.Drawing.Color.Red;
            this.lbSolrUpdate_Note.Location = new System.Drawing.Point(118, 367);
            this.lbSolrUpdate_Note.Name = "lbSolrUpdate_Note";
            this.lbSolrUpdate_Note.Size = new System.Drawing.Size(298, 13);
            this.lbSolrUpdate_Note.TabIndex = 51;
            this.lbSolrUpdate_Note.Text = " Note: 1.please don\'t change id field if you want partial update";
            this.lbSolrUpdate_Note.Visible = false;
            // 
            // btnPartial_Save
            // 
            this.btnPartial_Save.Location = new System.Drawing.Point(34, 362);
            this.btnPartial_Save.Name = "btnPartial_Save";
            this.btnPartial_Save.Size = new System.Drawing.Size(75, 23);
            this.btnPartial_Save.TabIndex = 50;
            this.btnPartial_Save.Text = "Save";
            this.btnPartial_Save.UseVisualStyleBackColor = true;
            this.btnPartial_Save.Visible = false;
            this.btnPartial_Save.Click += new System.EventHandler(this.btnPartial_Save_Click);
            // 
            // plPartial_Field
            // 
            this.plPartial_Field.AutoScroll = true;
            this.plPartial_Field.BackColor = System.Drawing.Color.Transparent;
            this.plPartial_Field.Location = new System.Drawing.Point(6, 120);
            this.plPartial_Field.Name = "plPartial_Field";
            this.plPartial_Field.Size = new System.Drawing.Size(830, 235);
            this.plPartial_Field.TabIndex = 49;
            // 
            // lbPartial_QueryResult
            // 
            this.lbPartial_QueryResult.Font = new System.Drawing.Font("SimSun", 10F);
            this.lbPartial_QueryResult.FormattingEnabled = true;
            this.lbPartial_QueryResult.Location = new System.Drawing.Point(403, 8);
            this.lbPartial_QueryResult.Name = "lbPartial_QueryResult";
            this.lbPartial_QueryResult.Size = new System.Drawing.Size(433, 108);
            this.lbPartial_QueryResult.TabIndex = 48;
            this.lbPartial_QueryResult.SelectedIndexChanged += new System.EventHandler(this.lbPartial_QueryResult_SelectedIndexChanged);
            this.lbPartial_QueryResult.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbPartial_QueryResult_MouseMove);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cbPartial_CountryCode);
            this.groupBox8.Controls.Add(this.Query);
            this.groupBox8.Controls.Add(this.txtPartial_Query);
            this.groupBox8.Controls.Add(this.txtPartial_SolrUrl);
            this.groupBox8.Controls.Add(this.cbPartial_SolrCore);
            this.groupBox8.Controls.Add(this.btnPartial_Delete);
            this.groupBox8.Controls.Add(this.btnPartial_Query);
            this.groupBox8.Location = new System.Drawing.Point(6, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(391, 110);
            this.groupBox8.TabIndex = 16;
            this.groupBox8.TabStop = false;
            // 
            // cbPartial_CountryCode
            // 
            this.cbPartial_CountryCode.FormattingEnabled = true;
            this.cbPartial_CountryCode.Items.AddRange(new object[] {
            "HK",
            "ID",
            "TH",
            "SG",
            "MY",
            "PH"});
            this.cbPartial_CountryCode.Location = new System.Drawing.Point(11, 13);
            this.cbPartial_CountryCode.Name = "cbPartial_CountryCode";
            this.cbPartial_CountryCode.Size = new System.Drawing.Size(92, 21);
            this.cbPartial_CountryCode.TabIndex = 15;
            this.cbPartial_CountryCode.Text = "HK";
            // 
            // Query
            // 
            this.Query.AutoSize = true;
            this.Query.Location = new System.Drawing.Point(12, 75);
            this.Query.Name = "Query";
            this.Query.Size = new System.Drawing.Size(35, 13);
            this.Query.TabIndex = 14;
            this.Query.Text = "Query";
            // 
            // txtPartial_Query
            // 
            this.txtPartial_Query.Location = new System.Drawing.Point(51, 72);
            this.txtPartial_Query.Name = "txtPartial_Query";
            this.txtPartial_Query.Size = new System.Drawing.Size(172, 20);
            this.txtPartial_Query.TabIndex = 13;
            this.txtPartial_Query.Text = "*:*";
            this.txtPartial_Query.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPartial_Query_KeyDown);
            // 
            // txtPartial_SolrUrl
            // 
            this.txtPartial_SolrUrl.Location = new System.Drawing.Point(11, 40);
            this.txtPartial_SolrUrl.Name = "txtPartial_SolrUrl";
            this.txtPartial_SolrUrl.Size = new System.Drawing.Size(374, 20);
            this.txtPartial_SolrUrl.TabIndex = 12;
            // 
            // cbPartial_SolrCore
            // 
            this.cbPartial_SolrCore.FormattingEnabled = true;
            this.cbPartial_SolrCore.Location = new System.Drawing.Point(109, 13);
            this.cbPartial_SolrCore.Name = "cbPartial_SolrCore";
            this.cbPartial_SolrCore.Size = new System.Drawing.Size(276, 21);
            this.cbPartial_SolrCore.TabIndex = 11;
            this.cbPartial_SolrCore.SelectedIndexChanged += new System.EventHandler(this.cbPartial_SolrCore_SelectedIndexChanged);
            // 
            // btnPartial_Delete
            // 
            this.btnPartial_Delete.ForeColor = System.Drawing.Color.Red;
            this.btnPartial_Delete.Location = new System.Drawing.Point(310, 72);
            this.btnPartial_Delete.Name = "btnPartial_Delete";
            this.btnPartial_Delete.Size = new System.Drawing.Size(75, 23);
            this.btnPartial_Delete.TabIndex = 6;
            this.btnPartial_Delete.Text = "Delete";
            this.btnPartial_Delete.UseVisualStyleBackColor = true;
            this.btnPartial_Delete.Click += new System.EventHandler(this.btnPartial_Delete_Click);
            // 
            // btnPartial_Query
            // 
            this.btnPartial_Query.Location = new System.Drawing.Point(229, 71);
            this.btnPartial_Query.Name = "btnPartial_Query";
            this.btnPartial_Query.Size = new System.Drawing.Size(75, 23);
            this.btnPartial_Query.TabIndex = 0;
            this.btnPartial_Query.Text = "Query";
            this.btnPartial_Query.UseVisualStyleBackColor = true;
            this.btnPartial_Query.Click += new System.EventHandler(this.btnPartial_Query_Click);
            // 
            // tp_SendEmail
            // 
            this.tp_SendEmail.Controls.Add(this.label38);
            this.tp_SendEmail.Controls.Add(this.label32);
            this.tp_SendEmail.Controls.Add(this.sendEmail_rtbSql);
            this.tp_SendEmail.Controls.Add(this.sendEmail_btnSend);
            this.tp_SendEmail.Controls.Add(this.sendEmail_txtSubject);
            this.tp_SendEmail.Controls.Add(this.label34);
            this.tp_SendEmail.Controls.Add(this.groupBox13);
            this.tp_SendEmail.Controls.Add(this.sendEmail_cbEmailDBInfo);
            this.tp_SendEmail.Controls.Add(this.sendEmail_btnGetEmailInfo);
            this.tp_SendEmail.Controls.Add(this.label31);
            this.tp_SendEmail.Controls.Add(this.sendEmail_txtCC);
            this.tp_SendEmail.Controls.Add(this.label33);
            this.tp_SendEmail.Controls.Add(this.sendEmail_clbTo);
            this.tp_SendEmail.Controls.Add(this.sendEmail_txtContent);
            this.tp_SendEmail.Location = new System.Drawing.Point(4, 22);
            this.tp_SendEmail.Name = "tp_SendEmail";
            this.tp_SendEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tp_SendEmail.Size = new System.Drawing.Size(847, 421);
            this.tp_SendEmail.TabIndex = 10;
            this.tp_SendEmail.Text = "    Send Email    ";
            this.tp_SendEmail.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.ForeColor = System.Drawing.Color.Red;
            this.label38.Location = new System.Drawing.Point(745, 82);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(51, 13);
            this.label38.TabIndex = 93;
            this.label38.Text = "Split by \';\'";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(2, 101);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(95, 13);
            this.label32.TabIndex = 92;
            this.label32.Text = "Find email from DB";
            // 
            // sendEmail_rtbSql
            // 
            this.sendEmail_rtbSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmail_rtbSql.Location = new System.Drawing.Point(105, 128);
            this.sendEmail_rtbSql.Name = "sendEmail_rtbSql";
            this.sendEmail_rtbSql.Size = new System.Drawing.Size(691, 93);
            this.sendEmail_rtbSql.TabIndex = 91;
            this.sendEmail_rtbSql.Text = "";
            // 
            // sendEmail_btnSend
            // 
            this.sendEmail_btnSend.Location = new System.Drawing.Point(543, 241);
            this.sendEmail_btnSend.Name = "sendEmail_btnSend";
            this.sendEmail_btnSend.Size = new System.Drawing.Size(76, 25);
            this.sendEmail_btnSend.TabIndex = 88;
            this.sendEmail_btnSend.Text = "Send";
            this.sendEmail_btnSend.UseVisualStyleBackColor = true;
            this.sendEmail_btnSend.Click += new System.EventHandler(this.sendEmail_btnSend_Click);
            // 
            // sendEmail_txtSubject
            // 
            this.sendEmail_txtSubject.Location = new System.Drawing.Point(105, 243);
            this.sendEmail_txtSubject.Name = "sendEmail_txtSubject";
            this.sendEmail_txtSubject.Size = new System.Drawing.Size(381, 20);
            this.sendEmail_txtSubject.TabIndex = 89;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(43, 244);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(43, 13);
            this.label34.TabIndex = 90;
            this.label34.Text = "Subject";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.sendEmail_rbVM);
            this.groupBox13.Controls.Add(this.sendEmail_rb126);
            this.groupBox13.Location = new System.Drawing.Point(513, 7);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(283, 41);
            this.groupBox13.TabIndex = 87;
            this.groupBox13.TabStop = false;
            // 
            // sendEmail_rbVM
            // 
            this.sendEmail_rbVM.AutoSize = true;
            this.sendEmail_rbVM.Location = new System.Drawing.Point(123, 14);
            this.sendEmail_rbVM.Name = "sendEmail_rbVM";
            this.sendEmail_rbVM.Size = new System.Drawing.Size(83, 17);
            this.sendEmail_rbVM.TabIndex = 8;
            this.sendEmail_rbVM.Text = "Send by VM";
            this.sendEmail_rbVM.UseVisualStyleBackColor = true;
            // 
            // sendEmail_rb126
            // 
            this.sendEmail_rb126.AutoSize = true;
            this.sendEmail_rb126.Checked = true;
            this.sendEmail_rb126.Location = new System.Drawing.Point(9, 14);
            this.sendEmail_rb126.Name = "sendEmail_rb126";
            this.sendEmail_rb126.Size = new System.Drawing.Size(85, 17);
            this.sendEmail_rb126.TabIndex = 7;
            this.sendEmail_rb126.TabStop = true;
            this.sendEmail_rb126.Text = "Send by 126";
            this.sendEmail_rb126.UseVisualStyleBackColor = true;
            // 
            // sendEmail_cbEmailDBInfo
            // 
            this.sendEmail_cbEmailDBInfo.FormattingEnabled = true;
            this.sendEmail_cbEmailDBInfo.Location = new System.Drawing.Point(105, 96);
            this.sendEmail_cbEmailDBInfo.Name = "sendEmail_cbEmailDBInfo";
            this.sendEmail_cbEmailDBInfo.Size = new System.Drawing.Size(167, 21);
            this.sendEmail_cbEmailDBInfo.TabIndex = 86;
            this.sendEmail_cbEmailDBInfo.SelectedIndexChanged += new System.EventHandler(this.sendEmail_cbEmailDBInfo_SelectedIndexChanged);
            // 
            // sendEmail_btnGetEmailInfo
            // 
            this.sendEmail_btnGetEmailInfo.Location = new System.Drawing.Point(302, 95);
            this.sendEmail_btnGetEmailInfo.Name = "sendEmail_btnGetEmailInfo";
            this.sendEmail_btnGetEmailInfo.Size = new System.Drawing.Size(105, 25);
            this.sendEmail_btnGetEmailInfo.TabIndex = 85;
            this.sendEmail_btnGetEmailInfo.Text = "Get Email Info";
            this.sendEmail_btnGetEmailInfo.UseVisualStyleBackColor = true;
            this.sendEmail_btnGetEmailInfo.Click += new System.EventHandler(this.sendEmail_btnGetEmailInfo_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(508, 61);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(49, 13);
            this.label31.TabIndex = 84;
            this.label31.Text = "Other To";
            // 
            // sendEmail_txtCC
            // 
            this.sendEmail_txtCC.Location = new System.Drawing.Point(560, 57);
            this.sendEmail_txtCC.Name = "sendEmail_txtCC";
            this.sendEmail_txtCC.Size = new System.Drawing.Size(236, 20);
            this.sendEmail_txtCC.TabIndex = 83;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(66, 12);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(20, 13);
            this.label33.TabIndex = 81;
            this.label33.Text = "To";
            // 
            // sendEmail_clbTo
            // 
            this.sendEmail_clbTo.FormattingEnabled = true;
            this.sendEmail_clbTo.Items.AddRange(new object[] {
            "miragelu@jobsdb.com",
            "mandywang@jobsdb.com",
            "sumousli@jobsdb.com"});
            this.sendEmail_clbTo.Location = new System.Drawing.Point(105, 12);
            this.sendEmail_clbTo.Name = "sendEmail_clbTo";
            this.sendEmail_clbTo.Size = new System.Drawing.Size(381, 64);
            this.sendEmail_clbTo.TabIndex = 82;
            // 
            // sendEmail_txtContent
            // 
            this.sendEmail_txtContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sendEmail_txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmail_txtContent.Location = new System.Drawing.Point(3, 278);
            this.sendEmail_txtContent.Name = "sendEmail_txtContent";
            this.sendEmail_txtContent.Size = new System.Drawing.Size(841, 140);
            this.sendEmail_txtContent.TabIndex = 80;
            this.sendEmail_txtContent.Text = "";
            // 
            // tp_GenAuth
            // 
            this.tp_GenAuth.Controls.Add(this.others_lbSqlQuery);
            this.tp_GenAuth.Controls.Add(this.others_cbCountryCode);
            this.tp_GenAuth.Controls.Add(this.label43);
            this.tp_GenAuth.Controls.Add(this.others_btnAdditionDomain);
            this.tp_GenAuth.Controls.Add(this.groupBox12);
            this.tp_GenAuth.Controls.Add(this.groupBox11);
            this.tp_GenAuth.Controls.Add(this.others_btnGetAuthInfo);
            this.tp_GenAuth.Controls.Add(this.others_rtbResult);
            this.tp_GenAuth.Controls.Add(this.groupBox10);
            this.tp_GenAuth.Controls.Add(this.label41);
            this.tp_GenAuth.Controls.Add(this.others_cbAccount);
            this.tp_GenAuth.Controls.Add(this.label37);
            this.tp_GenAuth.Controls.Add(this.others_txtJobSeekerId);
            this.tp_GenAuth.Controls.Add(this.label36);
            this.tp_GenAuth.Controls.Add(this.others_txtUserManagementId);
            this.tp_GenAuth.Controls.Add(this.label35);
            this.tp_GenAuth.Controls.Add(this.others_txtEmployerId);
            this.tp_GenAuth.Location = new System.Drawing.Point(4, 22);
            this.tp_GenAuth.Name = "tp_GenAuth";
            this.tp_GenAuth.Size = new System.Drawing.Size(847, 421);
            this.tp_GenAuth.TabIndex = 12;
            this.tp_GenAuth.Text = "    Gen Auth Info    ";
            this.tp_GenAuth.UseVisualStyleBackColor = true;
            // 
            // others_lbSqlQuery
            // 
            this.others_lbSqlQuery.AutoSize = true;
            this.others_lbSqlQuery.ForeColor = System.Drawing.Color.Red;
            this.others_lbSqlQuery.Location = new System.Drawing.Point(3, 211);
            this.others_lbSqlQuery.Name = "others_lbSqlQuery";
            this.others_lbSqlQuery.Size = new System.Drawing.Size(53, 13);
            this.others_lbSqlQuery.TabIndex = 97;
            this.others_lbSqlQuery.Text = "Sql Query";
            this.others_lbSqlQuery.Click += new System.EventHandler(this.others_lbSqlQuery_Click);
            // 
            // others_cbCountryCode
            // 
            this.others_cbCountryCode.FormattingEnabled = true;
            this.others_cbCountryCode.Location = new System.Drawing.Point(537, 131);
            this.others_cbCountryCode.Name = "others_cbCountryCode";
            this.others_cbCountryCode.Size = new System.Drawing.Size(124, 21);
            this.others_cbCountryCode.TabIndex = 96;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(452, 135);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(68, 13);
            this.label43.TabIndex = 95;
            this.label43.Text = "CountryCode";
            // 
            // others_btnAdditionDomain
            // 
            this.others_btnAdditionDomain.Location = new System.Drawing.Point(634, 170);
            this.others_btnAdditionDomain.Name = "others_btnAdditionDomain";
            this.others_btnAdditionDomain.Size = new System.Drawing.Size(152, 23);
            this.others_btnAdditionDomain.TabIndex = 94;
            this.others_btnAdditionDomain.Text = "Addition Domain";
            this.others_btnAdditionDomain.UseVisualStyleBackColor = true;
            this.others_btnAdditionDomain.Click += new System.EventHandler(this.others_btnAdditionDomain_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.others_rbEnv_Preview);
            this.groupBox12.Controls.Add(this.others_rbEnv_Production);
            this.groupBox12.Controls.Add(this.others_rbEnv_Test);
            this.groupBox12.Controls.Add(this.others_rbEnv_Dev);
            this.groupBox12.Location = new System.Drawing.Point(453, 69);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(333, 39);
            this.groupBox12.TabIndex = 90;
            this.groupBox12.TabStop = false;
            // 
            // others_rbEnv_Preview
            // 
            this.others_rbEnv_Preview.AutoSize = true;
            this.others_rbEnv_Preview.Location = new System.Drawing.Point(126, 12);
            this.others_rbEnv_Preview.Name = "others_rbEnv_Preview";
            this.others_rbEnv_Preview.Size = new System.Drawing.Size(63, 17);
            this.others_rbEnv_Preview.TabIndex = 17;
            this.others_rbEnv_Preview.Text = "Preview";
            this.others_rbEnv_Preview.UseVisualStyleBackColor = true;
            // 
            // others_rbEnv_Production
            // 
            this.others_rbEnv_Production.AutoSize = true;
            this.others_rbEnv_Production.Location = new System.Drawing.Point(200, 12);
            this.others_rbEnv_Production.Name = "others_rbEnv_Production";
            this.others_rbEnv_Production.Size = new System.Drawing.Size(76, 17);
            this.others_rbEnv_Production.TabIndex = 16;
            this.others_rbEnv_Production.Text = "Production";
            this.others_rbEnv_Production.UseVisualStyleBackColor = true;
            // 
            // others_rbEnv_Test
            // 
            this.others_rbEnv_Test.AutoSize = true;
            this.others_rbEnv_Test.Location = new System.Drawing.Point(69, 13);
            this.others_rbEnv_Test.Name = "others_rbEnv_Test";
            this.others_rbEnv_Test.Size = new System.Drawing.Size(46, 17);
            this.others_rbEnv_Test.TabIndex = 15;
            this.others_rbEnv_Test.Text = "Test";
            this.others_rbEnv_Test.UseVisualStyleBackColor = true;
            // 
            // others_rbEnv_Dev
            // 
            this.others_rbEnv_Dev.AutoSize = true;
            this.others_rbEnv_Dev.Checked = true;
            this.others_rbEnv_Dev.Location = new System.Drawing.Point(12, 13);
            this.others_rbEnv_Dev.Name = "others_rbEnv_Dev";
            this.others_rbEnv_Dev.Size = new System.Drawing.Size(45, 17);
            this.others_rbEnv_Dev.TabIndex = 14;
            this.others_rbEnv_Dev.TabStop = true;
            this.others_rbEnv_Dev.Text = "Dev";
            this.others_rbEnv_Dev.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.others_rbAuthenTicketType_SIS);
            this.groupBox11.Controls.Add(this.others_rbAuthenTicketType_External);
            this.groupBox11.Controls.Add(this.others_rbAuthenTicketType_Unknow);
            this.groupBox11.Location = new System.Drawing.Point(453, 17);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(208, 41);
            this.groupBox11.TabIndex = 93;
            this.groupBox11.TabStop = false;
            // 
            // others_rbAuthenTicketType_SIS
            // 
            this.others_rbAuthenTicketType_SIS.AutoSize = true;
            this.others_rbAuthenTicketType_SIS.Location = new System.Drawing.Point(148, 14);
            this.others_rbAuthenTicketType_SIS.Name = "others_rbAuthenTicketType_SIS";
            this.others_rbAuthenTicketType_SIS.Size = new System.Drawing.Size(42, 17);
            this.others_rbAuthenTicketType_SIS.TabIndex = 9;
            this.others_rbAuthenTicketType_SIS.Text = "SIS";
            this.others_rbAuthenTicketType_SIS.UseVisualStyleBackColor = true;
            // 
            // others_rbAuthenTicketType_External
            // 
            this.others_rbAuthenTicketType_External.AutoSize = true;
            this.others_rbAuthenTicketType_External.Checked = true;
            this.others_rbAuthenTicketType_External.Location = new System.Drawing.Point(79, 14);
            this.others_rbAuthenTicketType_External.Name = "others_rbAuthenTicketType_External";
            this.others_rbAuthenTicketType_External.Size = new System.Drawing.Size(63, 17);
            this.others_rbAuthenTicketType_External.TabIndex = 8;
            this.others_rbAuthenTicketType_External.TabStop = true;
            this.others_rbAuthenTicketType_External.Text = "External";
            this.others_rbAuthenTicketType_External.UseVisualStyleBackColor = true;
            // 
            // others_rbAuthenTicketType_Unknow
            // 
            this.others_rbAuthenTicketType_Unknow.AutoSize = true;
            this.others_rbAuthenTicketType_Unknow.Location = new System.Drawing.Point(7, 14);
            this.others_rbAuthenTicketType_Unknow.Name = "others_rbAuthenTicketType_Unknow";
            this.others_rbAuthenTicketType_Unknow.Size = new System.Drawing.Size(65, 17);
            this.others_rbAuthenTicketType_Unknow.TabIndex = 7;
            this.others_rbAuthenTicketType_Unknow.Text = "Unknow";
            this.others_rbAuthenTicketType_Unknow.UseVisualStyleBackColor = true;
            // 
            // others_btnGetAuthInfo
            // 
            this.others_btnGetAuthInfo.Location = new System.Drawing.Point(453, 170);
            this.others_btnGetAuthInfo.Name = "others_btnGetAuthInfo";
            this.others_btnGetAuthInfo.Size = new System.Drawing.Size(166, 23);
            this.others_btnGetAuthInfo.TabIndex = 92;
            this.others_btnGetAuthInfo.Text = "Get Authentication Info";
            this.others_btnGetAuthInfo.UseVisualStyleBackColor = true;
            this.others_btnGetAuthInfo.Click += new System.EventHandler(this.others_btnGetAuthInfo_Click);
            // 
            // others_rtbResult
            // 
            this.others_rtbResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.others_rtbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.others_rtbResult.Location = new System.Drawing.Point(0, 227);
            this.others_rtbResult.Name = "others_rtbResult";
            this.others_rtbResult.Size = new System.Drawing.Size(847, 194);
            this.others_rtbResult.TabIndex = 91;
            this.others_rtbResult.Text = "";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.others_rbAuthType_JobSeeker);
            this.groupBox10.Controls.Add(this.others_rbAuthType_Employer);
            this.groupBox10.Location = new System.Drawing.Point(55, 17);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(249, 41);
            this.groupBox10.TabIndex = 89;
            this.groupBox10.TabStop = false;
            // 
            // others_rbAuthType_JobSeeker
            // 
            this.others_rbAuthType_JobSeeker.AutoSize = true;
            this.others_rbAuthType_JobSeeker.Location = new System.Drawing.Point(123, 14);
            this.others_rbAuthType_JobSeeker.Name = "others_rbAuthType_JobSeeker";
            this.others_rbAuthType_JobSeeker.Size = new System.Drawing.Size(105, 17);
            this.others_rbAuthType_JobSeeker.TabIndex = 8;
            this.others_rbAuthType_JobSeeker.Text = "JobSeeker Login";
            this.others_rbAuthType_JobSeeker.UseVisualStyleBackColor = true;
            this.others_rbAuthType_JobSeeker.CheckedChanged += new System.EventHandler(this.others_rbAuthType_JobSeeker_CheckedChanged);
            // 
            // others_rbAuthType_Employer
            // 
            this.others_rbAuthType_Employer.AutoSize = true;
            this.others_rbAuthType_Employer.Checked = true;
            this.others_rbAuthType_Employer.Location = new System.Drawing.Point(9, 14);
            this.others_rbAuthType_Employer.Name = "others_rbAuthType_Employer";
            this.others_rbAuthType_Employer.Size = new System.Drawing.Size(97, 17);
            this.others_rbAuthType_Employer.TabIndex = 7;
            this.others_rbAuthType_Employer.TabStop = true;
            this.others_rbAuthType_Employer.Text = "Employer Login";
            this.others_rbAuthType_Employer.UseVisualStyleBackColor = true;
            this.others_rbAuthType_Employer.Click += new System.EventHandler(this.others_rbAuthType_Employer_CheckedChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(52, 75);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(47, 13);
            this.label41.TabIndex = 88;
            this.label41.Text = "Account";
            // 
            // others_cbAccount
            // 
            this.others_cbAccount.FormattingEnabled = true;
            this.others_cbAccount.Location = new System.Drawing.Point(180, 66);
            this.others_cbAccount.Name = "others_cbAccount";
            this.others_cbAccount.Size = new System.Drawing.Size(188, 21);
            this.others_cbAccount.TabIndex = 87;
            this.others_cbAccount.SelectedIndexChanged += new System.EventHandler(this.others_cbAccount_SelectedIndexChanged);
            this.others_cbAccount.SelectedValueChanged += new System.EventHandler(this.others_cbAccount_SelectedIndexChanged);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(52, 174);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(67, 13);
            this.label37.TabIndex = 86;
            this.label37.Text = "JobSeekerId";
            // 
            // others_txtJobSeekerId
            // 
            this.others_txtJobSeekerId.Location = new System.Drawing.Point(180, 171);
            this.others_txtJobSeekerId.Name = "others_txtJobSeekerId";
            this.others_txtJobSeekerId.Size = new System.Drawing.Size(188, 20);
            this.others_txtJobSeekerId.TabIndex = 85;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(52, 137);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(100, 13);
            this.label36.TabIndex = 84;
            this.label36.Text = "UserManagementId";
            // 
            // others_txtUserManagementId
            // 
            this.others_txtUserManagementId.Location = new System.Drawing.Point(180, 134);
            this.others_txtUserManagementId.Name = "others_txtUserManagementId";
            this.others_txtUserManagementId.Size = new System.Drawing.Size(188, 20);
            this.others_txtUserManagementId.TabIndex = 83;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(52, 103);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(59, 13);
            this.label35.TabIndex = 82;
            this.label35.Text = "EmployerId";
            // 
            // others_txtEmployerId
            // 
            this.others_txtEmployerId.Location = new System.Drawing.Point(180, 100);
            this.others_txtEmployerId.Name = "others_txtEmployerId";
            this.others_txtEmployerId.Size = new System.Drawing.Size(188, 20);
            this.others_txtEmployerId.TabIndex = 81;
            // 
            // tp_ABTesting
            // 
            this.tp_ABTesting.Controls.Add(this.btnAB_GetGroup);
            this.tp_ABTesting.Controls.Add(this.groupBox20);
            this.tp_ABTesting.Controls.Add(this.btnAB_GetValue);
            this.tp_ABTesting.Controls.Add(this.groupBox19);
            this.tp_ABTesting.Location = new System.Drawing.Point(4, 22);
            this.tp_ABTesting.Name = "tp_ABTesting";
            this.tp_ABTesting.Size = new System.Drawing.Size(847, 421);
            this.tp_ABTesting.TabIndex = 13;
            this.tp_ABTesting.Text = "A/B Testing";
            this.tp_ABTesting.UseVisualStyleBackColor = true;
            // 
            // btnAB_GetGroup
            // 
            this.btnAB_GetGroup.Location = new System.Drawing.Point(430, 233);
            this.btnAB_GetGroup.Name = "btnAB_GetGroup";
            this.btnAB_GetGroup.Size = new System.Drawing.Size(166, 23);
            this.btnAB_GetGroup.TabIndex = 96;
            this.btnAB_GetGroup.Text = "Get A/B Testing Group";
            this.btnAB_GetGroup.UseVisualStyleBackColor = true;
            this.btnAB_GetGroup.Click += new System.EventHandler(this.btnAB_GetGroup_Click);
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.rtbAB_Result);
            this.groupBox20.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox20.Location = new System.Drawing.Point(0, 262);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(847, 159);
            this.groupBox20.TabIndex = 95;
            this.groupBox20.TabStop = false;
            // 
            // rtbAB_Result
            // 
            this.rtbAB_Result.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbAB_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAB_Result.Location = new System.Drawing.Point(3, 10);
            this.rtbAB_Result.Name = "rtbAB_Result";
            this.rtbAB_Result.Size = new System.Drawing.Size(841, 146);
            this.rtbAB_Result.TabIndex = 94;
            this.rtbAB_Result.Text = "";
            // 
            // btnAB_GetValue
            // 
            this.btnAB_GetValue.Location = new System.Drawing.Point(208, 233);
            this.btnAB_GetValue.Name = "btnAB_GetValue";
            this.btnAB_GetValue.Size = new System.Drawing.Size(166, 23);
            this.btnAB_GetValue.TabIndex = 93;
            this.btnAB_GetValue.Text = "Get A/B Testing Value";
            this.btnAB_GetValue.UseVisualStyleBackColor = true;
            this.btnAB_GetValue.Click += new System.EventHandler(this.btnAB_GetValue_Click);
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.label44);
            this.groupBox19.Controls.Add(this.txtAB_Proportion);
            this.groupBox19.Controls.Add(this.label42);
            this.groupBox19.Controls.Add(this.txtAB_GroupKey);
            this.groupBox19.Controls.Add(this.rtbAB_EmployerIds);
            this.groupBox19.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox19.Location = new System.Drawing.Point(0, 0);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(847, 216);
            this.groupBox19.TabIndex = 90;
            this.groupBox19.TabStop = false;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(465, 20);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(55, 13);
            this.label44.TabIndex = 96;
            this.label44.Text = "Proportion";
            // 
            // txtAB_Proportion
            // 
            this.txtAB_Proportion.Location = new System.Drawing.Point(539, 17);
            this.txtAB_Proportion.Name = "txtAB_Proportion";
            this.txtAB_Proportion.Size = new System.Drawing.Size(222, 20);
            this.txtAB_Proportion.TabIndex = 95;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(39, 20);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(57, 13);
            this.label42.TabIndex = 94;
            this.label42.Text = "Group Key";
            // 
            // txtAB_GroupKey
            // 
            this.txtAB_GroupKey.Location = new System.Drawing.Point(102, 17);
            this.txtAB_GroupKey.Name = "txtAB_GroupKey";
            this.txtAB_GroupKey.Size = new System.Drawing.Size(237, 20);
            this.txtAB_GroupKey.TabIndex = 93;
            // 
            // rtbAB_EmployerIds
            // 
            this.rtbAB_EmployerIds.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbAB_EmployerIds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAB_EmployerIds.Location = new System.Drawing.Point(3, 62);
            this.rtbAB_EmployerIds.Name = "rtbAB_EmployerIds";
            this.rtbAB_EmployerIds.Size = new System.Drawing.Size(841, 151);
            this.rtbAB_EmployerIds.TabIndex = 92;
            this.rtbAB_EmployerIds.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tc1);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 447);
            this.panel1.TabIndex = 10;
            // 
            // cbSourceConnName
            // 
            this.cbSourceConnName.FormattingEnabled = true;
            this.cbSourceConnName.Location = new System.Drawing.Point(75, 35);
            this.cbSourceConnName.Name = "cbSourceConnName";
            this.cbSourceConnName.Size = new System.Drawing.Size(124, 21);
            this.cbSourceConnName.TabIndex = 14;
            this.cbSourceConnName.SelectedIndexChanged += new System.EventHandler(this.cbSourceConnName_SelectedIndexChanged);
            // 
            // txtSourceConnStr
            // 
            this.txtSourceConnStr.Location = new System.Drawing.Point(210, 36);
            this.txtSourceConnStr.Name = "txtSourceConnStr";
            this.txtSourceConnStr.Size = new System.Drawing.Size(568, 20);
            this.txtSourceConnStr.TabIndex = 15;
            this.txtSourceConnStr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSourceConnStr_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "SourceDB";
            // 
            // txtSourceConnProviderName
            // 
            this.txtSourceConnProviderName.Location = new System.Drawing.Point(853, 33);
            this.txtSourceConnProviderName.Name = "txtSourceConnProviderName";
            this.txtSourceConnProviderName.Size = new System.Drawing.Size(14, 20);
            this.txtSourceConnProviderName.TabIndex = 24;
            this.txtSourceConnProviderName.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 523);
            this.Controls.Add(this.txtSourceConnProviderName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSourceConnStr);
            this.Controls.Add(this.cbSourceConnName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainFrm";
            this.Text = "JobsDBTool";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.gb_DBType.ResumeLayout(false);
            this.gb_DBType.PerformLayout();
            this.tc1.ResumeLayout(false);
            this.tp_Common.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_task)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.document_cmsDoc.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCommon_RunSql_SqlResult)).EndInit();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.tp_AddWordings.ResumeLayout(false);
            this.tp_AddWordings.PerformLayout();
            this.tc_AddWordings.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tp_GetData.ResumeLayout(false);
            this.tp_GetData.PerformLayout();
            this.tp_GetString.ResumeLayout(false);
            this.tp_GetString.PerformLayout();
            this.tp_AddData.ResumeLayout(false);
            this.tp_AddData.PerformLayout();
            this.tp_Result.ResumeLayout(false);
            this.tp_Result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Result)).EndInit();
            this.tp_WordingSearch.ResumeLayout(false);
            this.tp_WordingSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SearchResult)).EndInit();
            this.tp_ClassFieldAbbr.ResumeLayout(false);
            this.tp_ClassFieldAbbr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvClassFieldResult)).EndInit();
            this.tp_BackupTask.ResumeLayout(false);
            this.tp_BackupTask.PerformLayout();
            this.tp_OperateDB.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tp_SolrUpdate.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tp_SendEmail.ResumeLayout(false);
            this.tp_SendEmail.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.tp_GenAuth.ResumeLayout(false);
            this.tp_GenAuth.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.tp_ABTesting.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.RadioButton rbType_Excel;
        private System.Windows.Forms.RadioButton rbType_DB;
        private System.Windows.Forms.GroupBox gb_DBType;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.TabControl tc1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.RadioButton rbType_String;
        private System.Windows.Forms.TabPage tp_AddWordings;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.TextBox txtWordingKey;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtXXContent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbWordingGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTHContent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDContent;
        private System.Windows.Forms.ComboBox cbSourceConnName;
        private System.Windows.Forms.TextBox txtSourceConnStr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbLanguageXX;
        private System.Windows.Forms.ComboBox cbLanguageTH;
        private System.Windows.Forms.ComboBox cbLanguageID;
        private System.Windows.Forms.TabPage tp_ClassFieldAbbr;
        private System.Windows.Forms.TextBox txtClassField;
        private System.Windows.Forms.Button btnGetAbbr;
        private System.Windows.Forms.DataGridView gvClassFieldResult;
        private System.Windows.Forms.TabPage tp_BackupTask;
        private System.Windows.Forms.TextBox txtBackupTaskFileList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBackupSubmit;
        private System.Windows.Forms.TextBox txtBackupTaskName;
        private System.Windows.Forms.ComboBox cbBackupTaskType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBackupTaskPath;
        private System.Windows.Forms.Button btnBackupTaskPath;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBackupTaskTargetPath;
        private System.Windows.Forms.CheckBox cbBackupTaskBackWording;
        private System.Windows.Forms.ComboBox cbBackupTaskTargetPath;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBackupTaskLastestPath;
        private System.Windows.Forms.Button btnBackupTaskLastestPath;
        private System.Windows.Forms.Button btnBackupTaskLoad;
        private System.Windows.Forms.TextBox txtBackupTaskSubmitResult;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tp_OperateDB;
        private System.Windows.Forms.TextBox txtOperateDB_Sql;
        private System.Windows.Forms.Button btnOperateDB_Save;
        private System.Windows.Forms.TextBox txtOperateDB_SqlPath;
        private System.Windows.Forms.Button btnOperateDB_Browse;
        private System.Windows.Forms.Button btOperateDB_LoadSql;
        private System.Windows.Forms.TabPage tp_SolrUpdate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnOthers_DropRMSDB;
        private System.Windows.Forms.Button btnOthers_RunSql;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtOperateDB_List;
        private System.Windows.Forms.Button btnOperateDB_Start;
        private System.Windows.Forms.Button btnOperateDB_GetDB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbOperateDB_Restore;
        private System.Windows.Forms.RadioButton rbOperateDB_Backup;
        private System.Windows.Forms.ComboBox cbOperateDB_Database;
        private System.Windows.Forms.Button btnOperateDB_BrowseScriptList;
        private System.Windows.Forms.Button btnOperateDB_LoadScriptList;
        private System.Windows.Forms.TextBox txtOperateDB_ScriptListPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbOperateDB_ScriptSchema;
        private System.Windows.Forms.CheckBox cbOperateDB_ScriptData;
        private System.Windows.Forms.CheckBox cbOperateDB_ScriptDrops;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOperateDB_ScriptObj_IgnoreList;
        private System.Windows.Forms.RadioButton rbOperateDB_ScriptObj_OnlyList;
        private System.Windows.Forms.RadioButton rbOperateDB_ScriptObj_All;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cbOthers_Account;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtOthers_JobSeekerId;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtOthers_Email;
        private System.Windows.Forms.Button btnOthers_Add;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtOthers_JobTitle;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtOthers_JobAdId;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtOthers_InvoiceItemID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtOthers_EmployerId;
        private System.Windows.Forms.CheckBox cbOthers_AddJob;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtOthers_AccountNum;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox cbOthers_AddCandidate;
        private System.Windows.Forms.TextBox txtOthers_SubAccount;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox rtbQuery;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtSolrQueryUrl;
        private System.Windows.Forms.TextBox txtSolrUrl;
        private System.Windows.Forms.TextBox txtSolrUpdate_XmlPath;
        private System.Windows.Forms.ComboBox cbSolrName;
        private System.Windows.Forms.ComboBox cbbOperation;
        private System.Windows.Forms.RadioButton rbType_SqlQuery;
        private System.Windows.Forms.Button btnSolrUpdate_Browse;
        private System.Windows.Forms.RadioButton rbType_XmlQuery;
        private System.Windows.Forms.ComboBox cbbCountry;
        private System.Windows.Forms.RadioButton rbType_IdString;
        private System.Windows.Forms.RadioButton rbType_SolrQuery;
        private System.Windows.Forms.Button btnSolrUpdate_Submit;
        private System.Windows.Forms.ListBox lbPartial_QueryResult;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Panel plPartial_Field;
        private System.Windows.Forms.ComboBox cbPartial_CountryCode;
        private System.Windows.Forms.Label Query;
        private System.Windows.Forms.TextBox txtPartial_Query;
        private System.Windows.Forms.TextBox txtPartial_SolrUrl;
        private System.Windows.Forms.ComboBox cbPartial_SolrCore;
        private System.Windows.Forms.Button btnPartial_Delete;
        private System.Windows.Forms.Button btnPartial_Query;
        private System.Windows.Forms.Button btnPartial_Save;
        private System.Windows.Forms.TextBox txtSourceConnProviderName;
        private System.Windows.Forms.Label lbSolrUpdate_Note2;
        private System.Windows.Forms.Label lbSolrUpdate_Note;
        private System.Windows.Forms.ComboBox cbOthers_CountryOfResidence;
        private System.Windows.Forms.Button btnSolrUpdate_FixDB;
        private System.Windows.Forms.ComboBox cbOthers_ProfilePrivacyLevel;
        private System.Windows.Forms.ComboBox cbOthers_JobCount;
        private System.Windows.Forms.ComboBox cbOthers_CandidateCount;
        private System.Windows.Forms.CheckBox cbOthers_IsNewWorkforce;
        private System.Windows.Forms.ComboBox cbOthers_ToCountryCode;
        private System.Windows.Forms.ComboBox cbOthers_CountryCode;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TabPage tp_SendEmail;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox cbOperateDB_Country_AU;
        private System.Windows.Forms.CheckBox cbOperateDB_Country_HK;
        private System.Windows.Forms.Button btnOperateDB_Country_Generate;
        private System.Windows.Forms.TextBox txtOperateDB_Country_Content;
        private System.Windows.Forms.CheckBox cbOperateDB_Country_TH;
        private System.Windows.Forms.CheckBox cbOperateDB_Country_TW;
        private System.Windows.Forms.CheckBox cbOperateDB_Country_PH;
        private System.Windows.Forms.CheckBox cbOperateDB_Country_SG;
        private System.Windows.Forms.CheckBox cbOperateDB_Country_ID;
        private System.Windows.Forms.CheckBox cbOperateDB_Country_IN;
        private System.Windows.Forms.CheckBox cbOperateDB_Country_KR;
        private System.Windows.Forms.CheckBox cbOperateDB_Country_MY;
        private System.Windows.Forms.CheckBox cbOperateDB_Country_US;
        private System.Windows.Forms.ComboBox cbBackupTaskTaskName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tc_AddWordings;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Button btnGoResult;
        private System.Windows.Forms.TabPage tp_GetData;
        private System.Windows.Forms.TextBox txtGetData;
        private System.Windows.Forms.TabPage tp_GetString;
        private System.Windows.Forms.CheckedListBox clbCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGetString;
        private System.Windows.Forms.TabPage tp_AddData;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TabPage tp_Common;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.RichTextBox sendEmail_rtbSql;
        private System.Windows.Forms.Button sendEmail_btnSend;
        private System.Windows.Forms.TextBox sendEmail_txtSubject;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.RadioButton sendEmail_rbVM;
        private System.Windows.Forms.RadioButton sendEmail_rb126;
        private System.Windows.Forms.ComboBox sendEmail_cbEmailDBInfo;
        private System.Windows.Forms.Button sendEmail_btnGetEmailInfo;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox sendEmail_txtCC;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.CheckedListBox sendEmail_clbTo;
        private System.Windows.Forms.RichTextBox sendEmail_txtContent;
        private System.Windows.Forms.TabPage tp_Result;
        private System.Windows.Forms.CheckBox cbHelpColumns;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView gv_Result;
        private System.Windows.Forms.Button btnWipe;
        private System.Windows.Forms.TextBox txtTargetConnStr;
        private System.Windows.Forms.ComboBox cbTargetConnName;
        private System.Windows.Forms.TabPage tp_WordingSearch;
        private System.Windows.Forms.CheckBox cbWordingKey;
        private System.Windows.Forms.CheckBox cbWordingContent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.TextBox txtSearchContent;
        private System.Windows.Forms.DataGridView gv_SearchResult;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.DataGridView dgv_task;
        private System.Windows.Forms.Button tasks_btnAddData;
        private System.Windows.Forms.Button tasks_btnDelData;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.RichTextBox document_rtbContent;
        private System.Windows.Forms.TreeView document_tvDoc;
        private System.Windows.Forms.Button tasks_btnEditData;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.CheckBox tasks_cbSearchStatus_Doing;
        private System.Windows.Forms.CheckBox tasks_cbSearchStatus_Submitted;
        private System.Windows.Forms.CheckBox tasks_cbSearchStatus_Pending;
        private System.Windows.Forms.CheckBox tasks_cbSearchStatus_Done;
        private System.Windows.Forms.CheckBox tasks_cbSearchStatus_Draft;
        private System.Windows.Forms.CheckBox tasks_cbSearchStatus_WaitResource;
        private System.Windows.Forms.Button tasks_btnSearch;
        private System.Windows.Forms.TextBox tasks_txtSearch;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Button document_btnSaveNode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox document_txtNodeName;
        private System.Windows.Forms.ContextMenuStrip document_cmsDoc;
        private System.Windows.Forms.ToolStripMenuItem document_tsmi_addNode;
        private System.Windows.Forms.CheckBox document_cbIsAdd;
        private System.Windows.Forms.ToolStripMenuItem document_tsmi_deleteNode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem document_tsmi_clearNode;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TabPage tp_GenAuth;
        private System.Windows.Forms.Label others_lbSqlQuery;
        private System.Windows.Forms.ComboBox others_cbCountryCode;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button others_btnAdditionDomain;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.RadioButton others_rbEnv_Preview;
        private System.Windows.Forms.RadioButton others_rbEnv_Production;
        private System.Windows.Forms.RadioButton others_rbEnv_Test;
        private System.Windows.Forms.RadioButton others_rbEnv_Dev;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.RadioButton others_rbAuthenTicketType_SIS;
        private System.Windows.Forms.RadioButton others_rbAuthenTicketType_External;
        private System.Windows.Forms.RadioButton others_rbAuthenTicketType_Unknow;
        private System.Windows.Forms.Button others_btnGetAuthInfo;
        private System.Windows.Forms.RichTextBox others_rtbResult;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RadioButton others_rbAuthType_JobSeeker;
        private System.Windows.Forms.RadioButton others_rbAuthType_Employer;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox others_cbAccount;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox others_txtJobSeekerId;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox others_txtUserManagementId;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox others_txtEmployerId;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtOthers_LastName;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtOthers_FirstName;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Button extractdll_btnExtract;
        private System.Windows.Forms.Button extractdll_btnReorder;
        private System.Windows.Forms.RichTextBox extractdll_rtbSource;
        private System.Windows.Forms.RichTextBox extractdll_Result;
        private System.Windows.Forms.Button btnWording_GenSqlQuery;
        private System.Windows.Forms.Label lbWording_SqlQueryPath;
        private System.Windows.Forms.Label lbWording_SqlQueryPathLabel;
        private System.Windows.Forms.TextBox txtAddWordings_WordingKeySql;
        private System.Windows.Forms.TabPage tp_ABTesting;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.RichTextBox rtbAB_Result;
        private System.Windows.Forms.Button btnAB_GetValue;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.RichTextBox rtbAB_EmployerIds;
        private System.Windows.Forms.Button btnAB_GetGroup;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtAB_Proportion;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtAB_GroupKey;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.DataGridView gvCommon_RunSql_SqlResult;
        private System.Windows.Forms.Button btnCommon_RunSql_Run;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ComboBox cbCommon_RunSql_SqlTemplate;
        private System.Windows.Forms.Panel plCommon_RunSql_Params;
        private System.Windows.Forms.RichTextBox rtbCommon_RunSql_SqlQuery;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.ComboBox cbGenCopyBat_Template;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox txtGenCopyBat_SourcePath;
        private System.Windows.Forms.RichTextBox rtbGenCopyBat_Result;
        private System.Windows.Forms.Button btnGenCopyBat_RunBat;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox txtGenCopyBat_TargetPath;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.CheckBox cbGenCopyBat_ProductAgent;
        private System.Windows.Forms.CheckBox cbGenCopyBat_ProductWeb;
        private System.Windows.Forms.CheckBox cbGenCopyBat_PreviewAgent;
        private System.Windows.Forms.CheckBox cbGenCopyBat_PreviewWeb;
        private System.Windows.Forms.Panel plGenCopyBat_ServerList;
        private System.Windows.Forms.Button btnGenCopyBat_Gen;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.TextBox txtGenCopyBat_BatPath;
        private System.Windows.Forms.CheckBox cbGenCopyBat_IsToLocal;
    }
}

