using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;
using System.Collections;
using System.Xml.Linq;
using JobsDBTool.GetFiledId;
using System.Diagnostics;
using JobsDBTool.Helper;
using System.Reflection;
using EasyNet.Solr.Commons;
using System.Text.RegularExpressions;
using Spring.Context;
using Solr.Common.Interface;
using Spring.Context.Support;
using Solr.Common.Helper;
using System.Threading;
using JobsDB.Base.Security;
using JobsDBTool.SubForms;
using JobsDBTool.Models.Domain;

namespace JobsDBTool
{
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            InitializeComponent();

            htConfig = CommonHelper.GetConfigValue();

            htConfig = XmlHelper.GetSections("Config/Wording.xml", htConfig);
            htConfig = XmlHelper.GetSections("Config/OperateDB.xml", htConfig);
            htConfig = XmlHelper.GetSections("Config/BackupTask.xml", htConfig);
            htConfig = XmlHelper.GetSections("Config/DBInfo.xml", htConfig);
            htConfig = XmlHelper.GetSections("Config/AccountInfo.xml", htConfig);
            htConfig = XmlHelper.GetSections("Config/SolrInfo.xml", htConfig);

            if (htConfig.ContainsKey("BackupFolderPath"))
            {
                backupFolderPath = htConfig["BackupFolderPath"].ToString();
            }

            if (htConfig.ContainsKey("SourceCode"))
            {
                string sourceCode = textboxWrap(htConfig["SourceCode"].ToString());
                this.txtGetData.Text = sourceCode;

                rbType_DB.Checked = true;
                rbType_Change();
            }
            else
            {
                rbType_Excel.Checked = false;
                rbType_Change();
            }

            if (htConfig.ContainsKey("TargetCode2"))
            {
                string targetCode = textboxWrap(htConfig["TargetCode2"].ToString());
                this.txtContent.Text = targetCode;
            }
            if (htConfig.ContainsKey("TargetCode1"))
            {
                string targetCode2 = textboxWrap(htConfig["TargetCode1"].ToString());
                this.txtAddWordings_WordingKeySql.Text = targetCode2;
            }
            
            if (htConfig.ContainsKey("SheetName"))
            {
                sheetName = htConfig["SheetName"].ToString();
            }

            if (htConfig.ContainsKey("ClassField"))
            {
                this.txtClassField.Text = htConfig["ClassField"].ToString();
            }

            dicDropDownToText = GetDropDownToText();

            loadToolStripMenu();
            InitializeConnectionStringList();
            
            //solve spring slow loading problem
            ThreadPool.QueueUserWorkItem((object obj) =>
            {
                lock (lockProcessed)
                {
                    _context = ContextRegistry.GetContext();
                }
            });
        }

        private string textboxWrap(string content)
        {
            return string.IsNullOrEmpty(content)? "" : content.Replace("\r\n", "\n").Replace("\n", "\r\n");
        }

        #region menutrip
        private void loadToolStripMenu()
        {
            ToolStripItem[] items = new ToolStripItem[1];
            for (int i = 0; i < items.Length; i++)
            {
                ToolStripMenuItem item = new System.Windows.Forms.ToolStripMenuItem()
                {
                    Name = "tsm_View",
                    Size = new System.Drawing.Size(45, 21),
                    Text = "View"
                };

                ToolStripMenuItem itemTasks = new System.Windows.Forms.ToolStripMenuItem()
                {
                    Name = "tsm_View_Tasks",
                    Size = new System.Drawing.Size(152, 22),
                    Text = "Tasks"
                };
                ToolStripMenuItem itemAddWordings = new System.Windows.Forms.ToolStripMenuItem()
                {
                    Name = "tsm_View_AddWordings",
                    Size = new System.Drawing.Size(152, 22),
                    Text = "Add Wordings"
                };
                ToolStripMenuItem itemBackup = new System.Windows.Forms.ToolStripMenuItem()
                {
                    Name = "tsm_View_Backup",
                    Size = new System.Drawing.Size(152, 22),
                    Text = "Backup"
                };
                ToolStripMenuItem itemSolr = new System.Windows.Forms.ToolStripMenuItem()
                {
                    Name = "tsm_View_Solr",
                    Size = new System.Drawing.Size(152, 22),
                    Text = "Solr"
                };
                ToolStripMenuItem itemDB = new System.Windows.Forms.ToolStripMenuItem()
                {
                    Name = "tsm_View_DB",
                    Size = new System.Drawing.Size(152, 22),
                    Text = "Operate DB"
                };
                ToolStripMenuItem itemClassFieldAbbr = new System.Windows.Forms.ToolStripMenuItem()
                {
                    Name = "tsm_View_ClassFieldAbbr",
                    Size = new System.Drawing.Size(152, 22),
                    Text = "Class/Field Abbr"
                };
                ToolStripMenuItem itemSendEmail = new System.Windows.Forms.ToolStripMenuItem()
                {
                    Name = "tsm_View_SendEmail",
                    Size = new System.Drawing.Size(152, 22),
                    Text = "Send Email"
                };
                ToolStripMenuItem itemGenAuth = new System.Windows.Forms.ToolStripMenuItem()
                {
                    Name = "tsm_View_GenAuth",
                    Size = new System.Drawing.Size(152, 22),
                    Text = "Gen Auth Info"
                };

                itemTasks.Click += StripItem_Click;
                itemAddWordings.Click += StripItem_Click;
                itemBackup.Click += StripItem_Click;
                itemSolr.Click += StripItem_Click;
                itemDB.Click += StripItem_Click;
                itemClassFieldAbbr.Click += StripItem_Click;
                itemSendEmail.Click += StripItem_Click;
                itemGenAuth.Click += StripItem_Click;

                item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                    itemTasks,
                itemAddWordings,
                itemBackup,
                itemSolr,
                itemDB,
                itemClassFieldAbbr,
                itemSendEmail,
                itemGenAuth});
                items[i] = item;

                if (ConfigurationManager.AppSettings["IsDefaultLoaded_AddWordings"] != "true")
                    this.tc1.TabPages.Remove(this.tp_AddWordings);
                else
                {
                    itemAddWordings.Checked = true;
                    cbAddWordings_CheckedChanged(true);
                }
                if (ConfigurationManager.AppSettings["IsDefaultLoaded_ClassFieldAbbr"] != "true")
                    this.tc1.TabPages.Remove(this.tp_ClassFieldAbbr);
                else
                {
                    itemClassFieldAbbr.Checked = true;
                    cbClassFieldAbbr_CheckedChanged(true);
                }
                if (ConfigurationManager.AppSettings["IsDefaultLoaded_BackupTask"] != "true")
                    this.tc1.TabPages.Remove(this.tp_BackupTask);
                else
                {
                    itemBackup.Checked = true;
                    cbBackupTask_CheckedChanged(true);
                }
                if (ConfigurationManager.AppSettings["IsDefaultLoaded_OperateDB"] != "true")
                    this.tc1.TabPages.Remove(this.tp_OperateDB);
                else
                {
                    itemDB.Checked = true;
                    cbOperateDB_CheckedChanged(true);
                }
                if (ConfigurationManager.AppSettings["IsDefaultLoaded_SolrUpdate"] != "true")
                    this.tc1.TabPages.Remove(this.tp_SolrUpdate);
                else
                {
                    itemSolr.Checked = true;
                    cbSolrUpdate_CheckedChanged(true);
                }
                if (ConfigurationManager.AppSettings["IsDefaultLoaded_SendEmail"] != "true")
                    this.tc1.TabPages.Remove(this.tp_SendEmail);
                else
                {
                    itemSendEmail.Checked = true;
                    cbSendEmail_CheckedChanged(true);
                }
                if (ConfigurationManager.AppSettings["IsDefaultLoaded_GenAuth"] != "true")
                    this.tc1.TabPages.Remove(this.tp_GenAuth);
                else
                {
                    itemGenAuth.Checked = true;
                    cbGenAuth_CheckedChanged(true);
                }
                //the lastest one will be selected
                if (ConfigurationManager.AppSettings["IsDefaultLoaded_Common"] != "true")
                    this.tc1.TabPages.Remove(this.tp_Common);
                else
                {
                    itemTasks.Checked = true;
                    cbCommon_CheckedChanged(true);
                }
            }

            this.menuStrip1.Items.Clear();
            this.menuStrip1.Items.AddRange(items);
        }

        void StripItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            item.Checked = !item.Checked;
            switch (item.Name)
            {
                case "tsm_View_Common":
                    cbCommon_CheckedChanged(item.Checked);
                    break;
                case "tsm_View_AddWordings":
                    cbAddWordings_CheckedChanged(item.Checked);
                    break;
                case "tsm_View_Backup":
                    cbBackupTask_CheckedChanged(item.Checked);
                    break;
                case "tsm_View_Solr":
                    cbSolrUpdate_CheckedChanged(item.Checked);
                    break;
                case "tsm_View_DB":
                    cbOperateDB_CheckedChanged(item.Checked);
                    break;
                case "tsm_View_ClassFieldAbbr":
                    cbClassFieldAbbr_CheckedChanged(item.Checked);
                    break;
                case "tsm_View_SendEmail":
                    cbSendEmail_CheckedChanged(item.Checked);
                    break;
                case "tsm_View_GenAuth":
                    cbGenAuth_CheckedChanged(item.Checked);
                    break;
            }
            BaseHelper.InfoLog("click the menu strip: " + item.Name);
        }

        private void cbCommon_CheckedChanged(bool isChecked)
        {
            if (isChecked)
            {
                if (!this.tc1.TabPages.Contains(this.tp_Common))
                    this.tc1.TabPages.Add(this.tp_Common);
                this.tc1.SelectedTab = this.tp_Common;

                if (!isLoadedCommon)
                {
                    if (!KernelClass.PhysicalFile.FileExists("JobsDBTool.sqlite"))
                    {
                    //    if (!BaseHelper.IsExistTable(dbSqlite, "Task"))
                            BaseHelper.InitSQLiteDB(sqliteConn, 0);

                      //  if (!BaseHelper.IsExistTable(dbSqlite, "Document"))
                            BaseHelper.InitSQLiteDB(sqliteConn, 1);
                    }

                    loadTask();
                    initDocument();
                }
            }
            else
            {
                this.tc1.TabPages.Remove(this.tp_Common);
            }
        }
        
        private void cbAddWordings_CheckedChanged(bool isChecked)
        {
            if (isChecked)
            {
                if (!this.tc1.TabPages.Contains(this.tp_AddWordings))
                    this.tc1.TabPages.Add(this.tp_AddWordings);
                this.tc1.SelectedTab = this.tp_AddWordings;

                if (!isLoadedAddWordings)
                {
                    resourceExcelPath = htConfig["ExcelPath"].ToString();
                    genSqlQueryPathPath = htConfig["GenSqlQueryPath"].ToString();
                    this.txtFilePath.Text = resourceExcelPath;
                    this.btnSubmit.Enabled = false;
                    this.btnExport.Enabled = false;
                    this.btnWipe.Enabled = false;

                    clbCountry.Items.Add(Option.Country.XX.ToString(), true);
                    clbCountry.Items.Add(Option.Country.ID.ToString(), true);
                    clbCountry.Items.Add(Option.Country.TH.ToString(), true);

                    ArrayList lsWordingGroup = new ArrayList{
                        Option.WordingGroup.Label.ToString(),
                        Option.WordingGroup.Warning.ToString(),
                        Option.WordingGroup.Tip.ToString(),
                        Option.WordingGroup.Option.ToString(),
                        Option.WordingGroup.Error.ToString(),
                    };
                    this.lbWordingGroup.DataSource = lsWordingGroup;

                    cbLanguageXX.Items.Add(Option.Language.EN.ToString());
                    cbLanguageXX.Items.Add(Option.Language.ID.ToString());
                    cbLanguageXX.Items.Add(Option.Language.TH.ToString());

                    cbLanguageID.Items.Add(Option.Language.EN.ToString());
                    cbLanguageID.Items.Add(Option.Language.ID.ToString());
                    cbLanguageID.Items.Add(Option.Language.TH.ToString());

                    cbLanguageTH.Items.Add(Option.Language.EN.ToString());
                    cbLanguageTH.Items.Add(Option.Language.ID.ToString());
                    cbLanguageTH.Items.Add(Option.Language.TH.ToString());

                    initLanguage_AddWordings();
            
                    this.tc_AddWordings.TabPages.Remove(this.tp_AddWordings);
                }
            }
            else
            {
                this.tc1.TabPages.Remove(this.tp_AddWordings);
            }
        }

        private void cbClassFieldAbbr_CheckedChanged(bool isChecked)
        {
            if (isChecked)
            {
                if (!this.tc1.TabPages.Contains(this.tp_ClassFieldAbbr))
                    this.tc1.TabPages.Add(this.tp_ClassFieldAbbr);
                this.tc1.SelectedTab = this.tp_ClassFieldAbbr;
            }
            else
            {
                this.tc1.TabPages.Remove(this.tp_ClassFieldAbbr);
            }
        }

        private void cbBackupTask_CheckedChanged(bool isChecked)
        {
            if (isChecked)
            {
                if (!this.tc1.TabPages.Contains(this.tp_BackupTask))
                    this.tc1.TabPages.Add(this.tp_BackupTask);
                this.tc1.SelectedTab = this.tp_BackupTask;

                if (!isLoadedBackupTask)
                {
                    isLoadedBackupTask = true;
                    this.txtBackupTaskSubmitResult.Enabled = false;
                    this.txtBackupTaskLastestPath.Text = htConfig["BackupTaskLastestPath"].ToString();
                    if (htConfig.ContainsKey("BackupTaskBat"))
                    {
                        backupTaskBat = htConfig["BackupTaskBat"].ToString();
                    }
                    this.txtBackupTaskPath.Text = htConfig["BackupTaskPath"].ToString();
                    backupTaskPythonPath = htConfig["BackupTaskPythonPath"].ToString();
                    this.txtBackupTaskTargetPath.Text = "";
                    var taskTypeList = dicDropDownToText["BackupTask_TaskType"];
                    foreach (var taskType in taskTypeList)
                    {
                        cbBackupTaskType.Items.Add(taskType);
                    }
                    cbBackupTaskType.DisplayMember = "SelectItem.Name";
                    cbBackupTaskType.ValueMember = "SelectItem.Value";
                    if (this.cbBackupTaskType.Items.Count > 0)
                    {
                        this.cbBackupTaskType.SelectedIndex = 0;
                    }
                    var backupTaskTargetPathList = dicDropDownToText["BackupTask_TargetPaths"];
                    foreach (var targetPath in backupTaskTargetPathList)
                    {
                        cbBackupTaskTargetPath.Items.Add(targetPath);
                    }
                    cbBackupTaskTargetPath.DisplayMember = "SelectItem.Name";
                    cbBackupTaskTargetPath.ValueMember = "SelectItem.Value";
                    if (this.cbBackupTaskTargetPath.Items.Count > 0)
                    {
                        this.cbBackupTaskTargetPath.SelectedIndex = 0;
                    }
                    var backupTaskTaskNamePathList = dicDropDownToText["BackupTask_TaskName"];
                    foreach (var taskName in backupTaskTaskNamePathList)
                    {
                        cbBackupTaskTaskName.Items.Add(taskName);
                    }
                    cbBackupTaskTaskName.DisplayMember = "SelectItem.Name";
                    cbBackupTaskTaskName.ValueMember = "SelectItem.Value";
                    if (this.cbBackupTaskTaskName.Items.Count > 0)
                    {
                        this.cbBackupTaskTaskName.SelectedIndex = 0;
                    }
                }
            }
            else
            {
                this.tc1.TabPages.Remove(this.tp_BackupTask);
            }

        }

        private void cbSolrUpdate_CheckedChanged(bool isChecked)
        {
            if (isChecked)
            {
                if (!this.tc1.TabPages.Contains(this.tp_SolrUpdate))
                    this.tc1.TabPages.Add(this.tp_SolrUpdate);
                this.tc1.SelectedTab = this.tp_SolrUpdate;

                if (!isLoadedSolrUpdate)
                {
                    isLoadedSolrUpdate = true;

                    //this.btnSolrUpdate_FixDB.Visible = false;
                    var solrCoreList = dicDropDownToText["SolrUpdate_Cores"];
                    foreach (var solrCore in solrCoreList)
                    {
                        cbSolrName.Items.Add(solrCore);
                    }
                    cbSolrName.DisplayMember = "SelectItem.Name";
                    cbSolrName.ValueMember = "SelectItem.SolrUrl";
                    if (this.cbSolrName.Items.Count > 0)
                    {
                        this.cbSolrName.SelectedIndex = 0;
                    }
                    this.rtbQuery.Text = arrContext[0];

                    var solrPartialCoreList = dicDropDownToText["SolrPartialUpdate_Cores"];
                    foreach (var solrCore in solrPartialCoreList)
                    {
                        this.cbPartial_SolrCore.Items.Add(solrCore);
                    }
                    cbPartial_SolrCore.DisplayMember = "SelectItem.Name";
                    cbPartial_SolrCore.ValueMember = "SelectItem.SolrUrl";
                    if (this.cbPartial_SolrCore.Items.Count > 0)
                    {
                        this.cbPartial_SolrCore.SelectedIndex = 0;
                    }
                }
            }
            else
            {
                this.tc1.TabPages.Remove(this.tp_SolrUpdate);
            }
        }

        private void cbOperateDB_CheckedChanged(bool isChecked)
        {
            if (isChecked)
            {
                if (!this.tc1.TabPages.Contains(this.tp_OperateDB))
                    this.tc1.TabPages.Add(this.tp_OperateDB);
                this.tc1.SelectedTab = this.tp_OperateDB;

                if (!isLoadedOperateDB)
                {
                    var accountInfoList = dicDropDownToText["Others_AccountInfo"].Where(c => c.ItemType == Option.ItemType.All.ToString() || c.ItemType == Option.ItemType.DB.ToString());
                    foreach (var accountInfo in accountInfoList)
                    {
                        cbOthers_Account.Items.Add(accountInfo);
                    }
                    cbOthers_Account.DisplayMember = "SelectItem.Name";
                    cbOthers_Account.ValueMember = "SelectItem.EmployerId";
                    if (this.cbOthers_Account.Items.Count > 0)
                    {
                        this.cbOthers_Account.SelectedIndex = 0;
                    }

                    cbOthers_CountryOfResidence.Items.Add(Option.CountryOfResidence.HK.ToString());
                    cbOthers_CountryOfResidence.Items.Add(Option.CountryOfResidence.ID.ToString());
                    cbOthers_CountryOfResidence.Items.Add(Option.CountryOfResidence.TH.ToString());
                    cbOthers_CountryOfResidence.Items.Add(Option.CountryOfResidence.SG.ToString());
                    cbOthers_CountryOfResidence.SelectedIndex = 0;
                    cbOthers_ProfilePrivacyLevel.Items.Add(Option.ProfilePrivacyLevel.Open.ToString());
                    cbOthers_ProfilePrivacyLevel.Items.Add(Option.ProfilePrivacyLevel.Limited.ToString());
                    cbOthers_ProfilePrivacyLevel.Items.Add(Option.ProfilePrivacyLevel.Hidden.ToString());
                    cbOthers_ProfilePrivacyLevel.SelectedIndex = 0;

                    cbOthers_CandidateCount.SelectedIndex = 0;
                    cbOthers_JobCount.SelectedIndex = 0;

                    cbOthers_CountryCode.Items.Add(Option.Country.HK.ToString());
                    cbOthers_CountryCode.Items.Add(Option.Country.ID.ToString());
                    cbOthers_CountryCode.Items.Add(Option.Country.TH.ToString());
                    cbOthers_CountryCode.Items.Add(Option.Country.SG.ToString());
                    cbOthers_ToCountryCode.Items.Add(Option.Country.HK.ToString());
                    cbOthers_ToCountryCode.Items.Add(Option.Country.ID.ToString());
                    cbOthers_ToCountryCode.Items.Add(Option.Country.TH.ToString());
                    cbOthers_ToCountryCode.Items.Add(Option.Country.SG.ToString());

                    this.txtOthers_Email.Text = ConfigurationManager.AppSettings["Default_Others_Email"];
                    this.txtOthers_FirstName.Text = ConfigurationManager.AppSettings["Default_Others_FirstName"];
                    this.txtOthers_LastName.Text = ConfigurationManager.AppSettings["Default_Others_LastName"];
                    this.txtOthers_JobSeekerId.Text = ConfigurationManager.AppSettings["Default_Others_JobSeekerId"];

                    this.cbOperateDB_Database.Enabled = false;
                    string folderPath = Path.Combine(System.Environment.CurrentDirectory, "Backup");
                    this.txtOperateDB_SqlPath.Text = Path.Combine(folderPath, "Script_" + DateTime.Now.ToString("yyyyMMdd") + ".sql");
                    this.btnOperateDB_Start.Enabled = false;
                    isLoadedOperateDB = true;
                    operateDB_SwitchScript(true);
                }
            }
            else
            {
                this.tc1.TabPages.Remove(this.tp_OperateDB);
            }
        }

        private void cbSendEmail_CheckedChanged(bool isChecked)
        {
            if (isChecked)
            {
                if (!this.tc1.TabPages.Contains(this.tp_SendEmail))
                    this.tc1.TabPages.Add(this.tp_SendEmail);
                this.tc1.SelectedTab = this.tp_SendEmail;

                if (!isLoadedSendEmail)
                {
                    //for send email 
                    this.sendEmail_clbTo.SetItemChecked(0, true);
                    var emailDBInfoList = dicDropDownToText["SendEmail_EmailDBInfo"];
                    foreach (var emailDBInfo in emailDBInfoList)
                    {
                        this.sendEmail_cbEmailDBInfo.Items.Add(emailDBInfo);
                    }
                    sendEmail_cbEmailDBInfo.DisplayMember = "SelectItem.Name";
                    sendEmail_cbEmailDBInfo.ValueMember = "SelectItem.TableName";
                    if (this.sendEmail_cbEmailDBInfo.Items.Count > 0)
                    {
                        this.sendEmail_cbEmailDBInfo.SelectedIndex = 0;
                    }                    
                }
            }
        }

        private void cbGenAuth_CheckedChanged(bool isChecked)
        {
            if (isChecked)
            {
                if (!this.tc1.TabPages.Contains(this.tp_GenAuth))
                    this.tc1.TabPages.Add(this.tp_GenAuth);
                this.tc1.SelectedTab = this.tp_GenAuth;

                if (!isLoadedGenAuth)
                {
                    //for genernate auth
                    this.others_rbEnv_Dev.Checked = true;
                    var accountInfoList = dicDropDownToText["Others_AccountInfo"].Where(c => c.ItemType == Option.ItemType.All.ToString() || c.ItemType == Option.ItemType.Auth.ToString());
                    others_cbAccount.Items.Clear();
                    foreach (var accountInfo in accountInfoList)
                    {
                        others_cbAccount.Items.Add(accountInfo);
                    }
                    others_cbAccount.DisplayMember = "SelectItem.Name";
                    others_cbAccount.ValueMember = "SelectItem.EmployerId";
                    if (this.others_cbAccount.Items.Count > 0)
                    {
                        this.others_cbAccount.SelectedIndex = 0;
                    }

                    others_rbAuthType_Change(true);

                    this.others_cbCountryCode.Items.Add(Option.Country.HK.ToString());
                    this.others_cbCountryCode.Items.Add(Option.Country.ID.ToString());
                    this.others_cbCountryCode.Items.Add(Option.Country.TH.ToString());
                    this.others_cbCountryCode.Items.Add(Option.Country.SG.ToString());

                    if (htConfig.ContainsKey("GenAuth_QueryRMS"))
                    {
                        this.others_rtbResult.Text = htConfig["GenAuth_QueryRMS"].ToString();
                    }
                }
            }
            else
            {
                this.tc1.TabPages.Remove(this.tp_GenAuth);
            }
        }

        #endregion
        
        private string fName;
        private Hashtable htConfig;
        private DataSet dsDB;
        private List<int> arrSuccess;
        private static string sheetName = "Wording";
        private List<Dictionary<string, Type>> wordingColumns;
        private string backupTaskBat = string.Empty;
        private string backupTaskPythonPath = string.Empty;
        private bool isLoadedCommon = false;
        private bool isLoadedAddWordings = false;
        private bool isLoadedBackupTask = false;
        private bool isLoadedSolrUpdate = false;
        private bool isLoadedOperateDB = false;
        private bool isLoadedSendEmail = false;
        private bool isLoadedGenAuth = false;
        private string backupFolderPath = string.Empty;
        private string resourceExcelPath = string.Empty;
        private string genSqlQueryPathPath = string.Empty;
        private Dictionary<string, List<SelectItem>> dicDropDownToText;
        private IApplicationContext _context;
        private ICoreServiceBase _coreService;
        private IPartialCoreService _partialCoreService;
        private string[] arrContext;
        private int _flagType = 0;
        object lockProcessed = new object();
        public static string sqlitConnKeyName = "SQLite";
        public static string sqliteConn = ConfigurationManager.ConnectionStrings["SQLite"] == null ? "Data Source=JobsDBTool.sqlite;Version=3;" : ConfigurationManager.ConnectionStrings["SQLite"].ConnectionString;
        private static PetaPoco.Database dbSqlite = new PetaPoco.Database(sqlitConnKeyName);
        private static IList<Document> documentList;

        #region tasks
        
        private void loadTask()
        {        
            IList<string> statusList = new List<string>();
            if (this.tasks_cbSearchStatus_Draft.Checked)
                statusList.Add(TaskStatus.Draft.ToString());
            if (this.tasks_cbSearchStatus_Doing.Checked)
                statusList.Add(TaskStatus.Doing.ToString());
            if (this.tasks_cbSearchStatus_Pending.Checked)
                statusList.Add(TaskStatus.Pending.ToString());
            if (this.tasks_cbSearchStatus_WaitResource.Checked)
                statusList.Add(TaskStatus.WaitResource.ToString());
            if (this.tasks_cbSearchStatus_Done.Checked)
                statusList.Add(TaskStatus.Done.ToString());
            if (this.tasks_cbSearchStatus_Submitted.Checked)
                statusList.Add(TaskStatus.Submitted.ToString());
            string search = this.tasks_txtSearch.Text.Trim();
            loadTask(statusList, search);
        }
        private void loadTask(IList<string> statusList, string search)
        {
            var sql = PetaPoco.Sql.Builder;
            sql.Append("SELECT * FROM Task");
            if(statusList != null && statusList.Count>0)
                sql.Where("Status in (@tags)", new { tags = statusList.ToArray() });
            if (!string.IsNullOrEmpty(search)) {
                sql.Where("(Title like @0) Or (Url Like @0) Or (Summary Like @0) Or (Remark Like @0)", "%" + search + "%");
            }
            //sql.OrderBy("Status");
            var listTasks = dbSqlite.Query<Task>(sql).OrderBy(t => t.OrderByStatus).ToList();

            this.dgv_task.DataSource = listTasks;
            if (dgv_task.Columns.Contains("Id"))
                dgv_task.Columns["Id"].Visible = false;
            if (dgv_task.Columns.Contains("OrderByStatus"))
                dgv_task.Columns["OrderByStatus"].Visible = false;

            dgv_task.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            if (dgv_task.Columns.Contains("Title"))
            {
                dgv_task.Columns["Title"].Width = 200;
            }
            if (dgv_task.Columns.Contains("Url"))
            {
                dgv_task.Columns["Url"].Width = 260;
            }
        }
        private void tasks_btnSearch_Click(object sender, EventArgs e)
        {
            loadTask();
        }

        public static int mainFrm_TaskId = default(int);
        private void tasks_btnAddData_Click(object sender, EventArgs e)
        {
            mainFrm_TaskId = default(int);

            var taskFrm = new TaskForm();
            taskFrm.reloadTask += new TaskForm.ReLoadTask(loadTask);
            taskFrm.Show();
        }

        private void tasks_btnEditData_Click(object sender, EventArgs e)
        {
            mainFrm_TaskId = default(int);
            for (int i = 0; i < dgv_task.Rows.Count; i++)
            {
                if (dgv_task.Rows[i].Selected == true)
                {
                    mainFrm_TaskId = Convert.ToInt32(dgv_task.Rows[i].Cells["Id"].Value.ToString());
                    break;
                }
            }
            if (mainFrm_TaskId == default(int))
            {
                MessageBox.Show("Please select one row.");
                return;
            }

            var taskFrm = new TaskForm();
            taskFrm.reloadTask += new TaskForm.ReLoadTask(loadTask);
            taskFrm.Show();

        }

        private void tasks_btnDelData_Click(object sender, EventArgs e)
        {
            try
            {
                IList<int> idList = new List<int>();
                for (int i = 0; i < dgv_task.Rows.Count; i++)
                {
                    if (dgv_task.Rows[i].Selected == true)
                    {
                        idList.Add(Convert.ToInt32(dgv_task.Rows[i].Cells["Id"].Value.ToString()));
                    }
                }
                if (idList.Count > 0)
                {
                    var sql = PetaPoco.Sql.Builder;
                    sql.Append("Delete FROM Task");
                    sql.Where("Id in (@tags)", new { tags = idList.ToArray() });
                    BaseHelper.InfoLog("tasks delete data ids: " + string.Join(",", idList));
                    dbSqlite.Execute(sql);
                    loadTask();
                    MessageBox.Show("Deleted success~");
                }
                else{
                    MessageBox.Show("Please select one row.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void dgv_task_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow dgr = dgv_task.Rows[e.RowIndex];
            Color bgColor = Color.White;
            if (dgr.Cells["Status"].Value.ToString() == TaskStatus.Draft.ToString())
            {
                bgColor = Color.White;// Color.FromArgb(255, 255, 255);
            }
            else if (dgr.Cells["Status"].Value.ToString() == TaskStatus.Pending.ToString())
            {
               bgColor = Color.FromArgb(171, 186, 195);
            }
            else if (dgr.Cells["Status"].Value.ToString() == TaskStatus.Doing.ToString())
            {
                bgColor = Color.FromArgb(123, 156, 251);
            }
            else if (dgr.Cells["Status"].Value.ToString() == TaskStatus.WaitResource.ToString())
            {
                bgColor = Color.FromArgb(251, 219, 123);
            }
            else if (dgr.Cells["Status"].Value.ToString() == TaskStatus.Done.ToString())
            {
                bgColor = Color.FromArgb(244, 123, 251);
            }
            else if (dgr.Cells["Status"].Value.ToString() == TaskStatus.Submitted.ToString())
            {
                bgColor = Color.FromArgb(253, 55, 55);
            }
            else if (dgr.Cells["Status"].Value.ToString() == TaskStatus.ReDo.ToString())
            {
               bgColor = Color.FromArgb(203, 111, 215);
            }
            dgr.DefaultCellStyle.BackColor = bgColor;
        }

        /// <summary>
        /// 鼠标移到单元格时,设置当前单元格的ToolTipText属性内容为当前单元格内容
        /// 解决tip内容显示不全的问题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_task_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0 || dgv_task.Rows.Count <= 0) return;
            if (!new List<string>(){"Status", "CreatedTime", "LastModifiedTime", "SubmittedTime"}.Contains(dgv_task.Columns[e.ColumnIndex].Name))
            {
                dgv_task.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = (dgv_task.Rows[e.RowIndex].Cells[e.ColumnIndex].Value ?? string.Empty).ToString();
            }
        }

        #endregion


        #region document

        private void initDocument()
        {
            documentList = loadDocument();
            BindTree(documentList, 0, null);

        }

        private IList<Document> loadDocument()
        {
            var sql = PetaPoco.Sql.Builder;
            sql.Append("SELECT * FROM Document");
            sql.OrderBy("SortOrder");
            return dbSqlite.Query<Document>(sql).ToList();
        }

        private void BindTree(IList<Document> list, int pid, TreeNode tn)
        {
            if(pid == default(int)){
                this.document_tvDoc.Nodes.Clear();
            }
            if (list.Count > 0)
            {
                var curList = list.Where(l => l.ParentId == pid).ToList();
                if (curList.Count > 0)
                {
                    foreach (var item in curList)
                    {
                        TreeNode node = new TreeNode();
                        node.Text = item.Name;
                        node.Tag = item.Id;
                        if (pid == default(int))
                        {
                            this.document_tvDoc.Nodes.Add(node);
                            BindTree(list, item.Id, node);
                        }
                        else if(tn != null)
                        {
                            tn.Nodes.Add(node);
                            BindTree(list, item.Id, node);                            
                        }
                    }
                }
            }
        }

        private void document_btnSaveNode_Click(object sender, EventArgs e)
        {
            string name = this.document_txtNodeName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please input node name.");
                return;
            }

            Document doc = new Document();
            bool isEdit = !this.document_cbIsAdd.Checked && this.document_tvDoc.SelectedNode != null;
            if (isEdit)
            {
                doc = dbSqlite.Query<Document>("SELECT * FROM Document Where Id=" + Convert.ToInt32(this.document_tvDoc.SelectedNode.Tag)).FirstOrDefault();
            }
            doc.Name = name;
            doc.Content = this.document_rtbContent.Text;
            doc.LastModifiedTime = DateTime.Now;

            if (isEdit)
            {
                dbSqlite.Update("Document", "Id", doc);
                this.document_tvDoc.SelectedNode.Name = this.document_txtNodeName.Text.Trim();
                this.document_tvDoc.SelectedNode.Text = this.document_txtNodeName.Text.Trim();
            }
            else
            {
                doc.ParentId = document_tvDoc.SelectedNode == null ? 0 : Convert.ToInt32(document_tvDoc.SelectedNode.Tag);
                doc.SortOrder = document_tvDoc.SelectedNode == null ? (document_tvDoc.Nodes.Count + 1) : (document_tvDoc.SelectedNode.Nodes.Count + 1);
                doc.CreatedTime = DateTime.Now;
                int id = Convert.ToInt32(dbSqlite.Insert("Document", "Id", doc));

                TreeNode tmp = new TreeNode(name);
                tmp.Tag = id;
                if (document_tvDoc.SelectedNode == null)
                {
                    document_tvDoc.Nodes.Add(tmp);
                }
                else
                {
                    document_tvDoc.SelectedNode.Nodes.Add(tmp);
                }
                document_tvDoc.SelectedNode = tmp;
            }
            documentList = loadDocument();
        }

        private void document_tvDoc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedTag = document_tvDoc.SelectedNode.Tag;
            var doc = documentList.Where(d => d.Id == Convert.ToInt32(selectedTag)).FirstOrDefault();
            if (doc != null)
            {
                this.document_cbIsAdd.Checked = false;
                this.document_txtNodeName.Text = doc.Name;
                this.document_rtbContent.Text = doc.Content;
            }
        }

        private void document_tsmi_addNode_Click(object sender, EventArgs e)
        {
            this.document_cbIsAdd.Checked = true;
            this.document_txtNodeName.Text = "";
            this.document_rtbContent.Text = "";
        }

        private void document_tsmi_deleteNode_Click(object sender, EventArgs e)
        {
            var node = document_tvDoc.SelectedNode;
            var doc = documentList.Where(d => d.Id == Convert.ToInt32(node.Tag)).FirstOrDefault();
            documentList.Remove(doc);

            var sql = PetaPoco.Sql.Builder;
            sql.Append("Delete FROM Document");
            sql.Where("Id = @0", node.Tag);
            BaseHelper.InfoLog("document delete data id: " + node.Tag);
            dbSqlite.Execute(sql);

            //delete child nodes

            document_tvDoc.SelectedNode.Remove();
        }

        private void document_tsmi_clearNode_Click(object sender, EventArgs e)
        {
            document_tvDoc.SelectedNode = null;
        }
        #endregion

        #region wording
        private void InitializeConnectionStringList()
        {
            if (dicDropDownToText.ContainsKey("DBInfo"))
            {
                var dbInfoList = dicDropDownToText["DBInfo"];
                foreach (var dbInfo in dbInfoList)
                {
                    cbSourceConnName.Items.Add(dbInfo);
                    cbTargetConnName.Items.Add(dbInfo);
                }
                cbSourceConnName.DisplayMember = "SelectItem.Name";
                cbSourceConnName.ValueMember = "SelectItem.ConnStr";
                if (this.cbSourceConnName.Items.Count > 0)
                {
                    this.cbSourceConnName.SelectedIndex = 0;
                }

                cbTargetConnName.DisplayMember = "SelectItem.Name";
                cbTargetConnName.ValueMember = "SelectItem.ConnStr";
                if (this.cbTargetConnName.Items.Count > 0)
                {
                    this.cbTargetConnName.SelectedIndex = 0;
                }

            }
        }

        private void initLanguage_AddWordings()
        {
            cbLanguageXX.SelectedIndex = 0;
            cbLanguageID.SelectedIndex = 1;
            cbLanguageTH.SelectedIndex = 2;
        }

        private void tc_AddWordings_Click(object sender, EventArgs e)
        {
            if (this.tc_AddWordings.SelectedTab == tp_GetString)
            {
                if (!this.rbType_String.Checked)
                {
                    this.rbType_String.Checked = true;
                }
            }
            else if (this.tc_AddWordings.SelectedTab == tp_GetData)
            {
                if (!this.rbType_DB.Checked)
                {
                    this.rbType_DB.Checked = true;
                }
            }
        }

        #region radio group for Type
        private void rbType_Excel_CheckedChanged(object sender, EventArgs e)
        {
            rbType_Change();
        }

        private void rbType_DB_CheckedChanged(object sender, EventArgs e)
        {
            rbType_Change();

            if (this.rbType_DB.Checked)
            {
                this.tc_AddWordings.SelectedTab = tp_GetData;
            }
        }

        private void rbType_String_CheckedChanged(object sender, EventArgs e)
        {
            rbType_Change();

            if (this.rbType_String.Checked)
            {
                this.tc_AddWordings.SelectedTab = tp_GetString;
            }
        }

        private void rbType_Change()
        {
            if (this.rbType_DB.Checked || this.rbType_String.Checked)
            {
                if (this.rbType_DB.Checked)
                {
                    this.cbSourceConnName.Enabled = true;
                    this.txtSourceConnStr.Enabled = true;
                    this.txtGetData.Enabled = true;
                    this.txtGetString.Enabled = false;
                }
                if (this.rbType_String.Checked)
                {
                    this.cbSourceConnName.Enabled = false;
                    this.txtSourceConnStr.Enabled = false;
                    this.txtGetData.Enabled = false;
                    this.txtGetString.Enabled = true;
                }

                this.txtFilePath.Enabled = false;
                this.btnBrowse.Enabled = false;
            }
            if (this.rbType_Excel.Checked)
            {
                this.cbSourceConnName.Enabled = false;
                this.txtSourceConnStr.Enabled = false;

                this.txtGetData.Enabled = false;

                this.txtFilePath.Enabled = true;
                this.btnBrowse.Enabled = true;
            }
        }
        #endregion

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.Environment.CurrentDirectory;//注意这里写路径时要用c:\\而不是c:\
            //openFileDialog.Filter = "Excel文件|*.xlsx|所有文件|*.*";
            openFileDialog.Filter = "CSV文件|*.csv|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                fName = openFileDialog.FileName;
                this.txtFilePath.Text = fName;
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            OperateWording(true);
        }

        private void btnWording_GenSqlQuery_Click(object sender, EventArgs e)
        {
            OperateWording(false);
        }

        private void OperateWording(bool isAdd)
        {
            if (null != dsDB && dsDB.Tables.Count != 0)
            {
                string strConn = ReplaceCountryCode(this.txtTargetConnStr.Text.Trim());
                if (isAdd)
                {
                    if (string.IsNullOrEmpty(strConn))
                    {
                        MessageBox.Show("Please input target DB connection string");
                        return;
                    }
                }
                StringBuilder sbWholeSqlQuery = new StringBuilder();
                string errorMsg = WordingHelper.InsertDataToDB(isAdd, dsDB, strConn, this.txtAddWordings_WordingKeySql.Text, this.txtContent.Text, out arrSuccess, out sbWholeSqlQuery);
                if (!string.IsNullOrEmpty(errorMsg))
                {
                    MessageBox.Show(errorMsg, "提示信息",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (isAdd)
                {
                    this.gv_Result.DataSource = dsDB.Tables[0];
                    for (int i = 0; i < this.gv_Result.Rows.Count; i++)
                    {
                        if (arrSuccess.Contains(i))
                            this.gv_Result.Rows[i].Cells[0].Style.ForeColor = Color.Blue;
                        else
                            this.gv_Result.Rows[i].Cells[0].Style.ForeColor = Color.Red;
                    }
                    this.tc_AddWordings.SelectedTab = tp_Result;
                }
                else
                {
                    string filePath = string.Format(genSqlQueryPathPath, DateTime.Now.ToString("yyyyMMdd"));
                    KernelClass.PhysicalFile.SaveFile(sbWholeSqlQuery.ToString(), filePath, false, Encoding.UTF8);
                    this.lbWording_SqlQueryPath.Text = filePath;
                    this.lbWording_SqlQueryPath.Click += lbWording_SqlQueryPath_Click;
                    this.lbWording_SqlQueryPath.Visible = true;
                    this.lbWording_SqlQueryPathLabel.Visible = true;
                }

                MessageBox.Show("Successed.");
            }
        }

        private void lbWording_SqlQueryPath_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(this.lbWording_SqlQueryPath.Text);
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            dsDB = new DataSet();
            fName = this.txtFilePath.Text;
            if (rbType_Excel.Checked)
            {
                if (!string.IsNullOrEmpty(fName) && File.Exists(fName))
                {
                    //dsDB = FromExcel(fName);
                    dsDB = LoadDataForWording.LoadDataFromCSV(fName);
                }
                else
                {
                    MessageBox.Show("请选择正确的文件路径.", "提示信息",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (rbType_DB.Checked)
            {
                string sourceDB = ReplaceCountryCode(this.txtSourceConnStr.Text.Trim());
                if (string.IsNullOrEmpty(sourceDB))
                {
                    MessageBox.Show("Please input sourect DB connection string");
                    return;
                }

                dsDB = LoadDataForWording.LoadDataFromDB(this.txtGetData.Text, sourceDB);
            }
            if (rbType_String.Checked)
            {
                if (null == wordingColumns)
                {
                    wordingColumns = WordingHelper.GetColumns(htConfig);
                }
                dsDB = LoadDataForWording.LoadDataFromString(this.txtGetString.Text, clbCountry, wordingColumns);

            }

            AppendToResult();

            if (null != dsDB && dsDB.Tables.Count != 0)
            {
                this.tc_AddWordings.SelectedTab = tp_Result;
                this.btnExport.Enabled = true;
                this.btnSubmit.Enabled = true;
                this.btnWipe.Enabled = true;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string filePath = this.txtFilePath.Text;
            WordingHelper.saveToCSV(resourceExcelPath, dsDB.Tables[0]);

            string newFilePath = CommonHelper.copyFileToBK(backupFolderPath, resourceExcelPath, "", 1);
        }

        private void btnBKExport_Click(object sender, EventArgs e)
        {
            string filePath = this.txtFilePath.Text;
            string fileName = Path.GetFileNameWithoutExtension(filePath)
                + " " + DateTime.Now.ToString("yyyyMMdd");
            filePath = Path.Combine(Path.GetDirectoryName(filePath), fileName + Path.GetExtension(filePath));

            WordingHelper.saveToCSV(filePath, dsDB.Tables[0]);
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (null == dsDB || dsDB.Tables.Count == 0 || null == dsDB.Tables[0])
            {
                if (null == wordingColumns)
                {
                    wordingColumns = WordingHelper.GetColumns(htConfig);
                }
                dsDB = WordingHelper.InitDataSet(wordingColumns);
            }

            try
            {
                int autoId = dsDB.Tables[0].Rows.Count;
                string wordingKey = this.txtWordingKey.Text.Trim();
                string wordingGroup = ((int)Enum.Parse(typeof(Option.WordingGroup), this.lbWordingGroup.SelectedItem.ToString())).ToString();
                string wordingXXContent = this.txtXXContent.Text.Trim();
                string wordingXXLanguage = this.cbLanguageXX.Text.Trim();
                string wordingIDContent = this.txtIDContent.Text.Trim();
                string wordingIDLanguage = this.cbLanguageID.Text.Trim();
                string wordingTHContent = this.txtTHContent.Text.Trim();
                string wordingTHLanguage = this.cbLanguageTH.Text.Trim();
                string wordingCommit = this.txtComment.Text.Trim();

                if (string.IsNullOrEmpty(wordingKey))
                {
                    MessageBox.Show("插入数据失败!失败原因：Please input the Key value", "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(wordingXXContent)
                    && string.IsNullOrEmpty(wordingIDContent)
                    && string.IsNullOrEmpty(wordingTHContent))
                {
                    MessageBox.Show("插入数据失败!失败原因：Please input at the least Content value", "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.txtInfo.Text = "\r\n" + this.txtInfo.Text;

                    if (!string.IsNullOrEmpty(wordingXXContent))
                    {
                        dsDB.Tables[0].Rows.Add("Pending", autoId, wordingKey, wordingGroup
                        , Option.Country.XX
                        , (Option.Language)Enum.Parse(typeof(Option.Language), wordingXXLanguage)
                        , wordingXXContent, wordingCommit);

                        AppendToResult();

                        this.txtInfo.Text = Option.Country.XX.ToString()
                            + "_" + wordingXXLanguage
                            + "_" + wordingKey + "\r\n" + txtInfo.Text;
                        autoId++;
                    }
                    if (!string.IsNullOrEmpty(wordingIDContent))
                    {
                        dsDB.Tables[0].Rows.Add("Pending", autoId, wordingKey, wordingGroup
                        , Option.Country.ID
                        , (Option.Language)Enum.Parse(typeof(Option.Language), wordingIDLanguage)
                        , wordingIDContent, wordingCommit);

                        AppendToResult();

                        this.txtInfo.Text = Option.Country.ID.ToString()
                            + "_" + wordingIDLanguage
                            + "_" + wordingKey + "\r\n" + txtInfo.Text;
                        autoId++;
                    }
                    if (!string.IsNullOrEmpty(wordingTHContent))
                    {
                        dsDB.Tables[0].Rows.Add("Pending", autoId, wordingKey, wordingGroup
                        , Option.Country.TH
                        , (Option.Language)Enum.Parse(typeof(Option.Language), wordingTHLanguage)
                        , wordingTHContent, wordingCommit);

                        AppendToResult();

                        this.txtInfo.Text = Option.Country.TH.ToString()
                            + "_" + wordingTHLanguage
                            + "_" + wordingKey + "\r\n" + txtInfo.Text;
                        autoId++;
                    }

                    this.lbInfo.Visible = true;
                    this.txtInfo.Visible = true;

                    this.txtXXContent.Text = "";
                    this.txtIDContent.Text = "";
                    this.txtTHContent.Text = "";
                    this.txtWordingKey.Text = "";
                    this.txtComment.Text = "";

                    initLanguage_AddWordings();

                    this.btnSubmit.Enabled = true;
                    this.btnExport.Enabled = true;
                    this.btnWipe.Enabled = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("查询数据失败!失败原因：" + err.Message, "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGoResult_Click(object sender, EventArgs e)
        {
            this.tc_AddWordings.SelectedTab = tp_Result;            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.panel1.Width = this.Width - 30;
            this.panel1.Height = this.Height - 100;
        }

        private void tc1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void AppendToResult()
        {
            if (null != dsDB && dsDB.Tables.Count != 0)
            {
                if (!dsDB.Tables[0].Columns.Contains("InputStatus"))
                {
                    DataColumn dcStatus = new DataColumn("InputStatus", typeof(string));
                    dcStatus.DefaultValue = "Pending";
                    dsDB.Tables[0].Columns.Add(dcStatus);
                    dcStatus.SetOrdinal(0);
                }
                this.gv_Result.DataSource = dsDB.Tables[0];
                this.gv_Result.Columns[0].DefaultCellStyle.ForeColor = Color.DarkGray;
            }
        }

        public Dictionary<string, List<SelectItem>> GetDropDownToText()
        {
            Dictionary<string, List<SelectItem>> dic = new Dictionary<string, List<SelectItem>>();
            if (htConfig.ContainsKey("DropDownToText"))
            {
                XDocument doc = XDocument.Parse(string.Format("<root>{0}</root>", htConfig["DropDownToText"].ToString()));
                var items = from d in doc.Element("root").Elements("columns")
                            select d;
                foreach (var item in items)
                {
                    var result = from d in item.Elements("column")
                                 select d;
                    List<SelectItem> ls = new List<SelectItem>();

                    foreach (var column in result)
                    {
                        SelectItem selectItem = new SelectItem()
                        {
                            Name = column.Attribute("name").Value
                        };

                        XElement xe = null;
                        if (item.Attribute("name").Value == "DBInfo")
                        {
                            xe = column.Element("connStr");
                            if (xe != null)
                            {
                                selectItem.ConnStr = xe.Value;
                            }
                            xe = column.Element("providerName");
                            if (xe != null)
                            {
                                selectItem.ProviderName = xe.Value;
                            }
                        }

                        if (item.Attribute("name").Value == "SolrUpdate_Cores"
                            || item.Attribute("name").Value == "SolrPartialUpdate_Cores")
                        {
                            xe = column.Element("solrUrl");
                            if (xe != null)
                            {
                                selectItem.SolrUrl = xe.Value;
                            }
                            xe = column.Element("idString");
                            if (xe != null)
                            {
                                selectItem.IdString = xe.Value;
                            }
                            xe = column.Element("solrQueryUrl");
                            if (xe != null)
                            {
                                selectItem.SolrQueryUrl = xe.Value;
                            }
                            xe = column.Element("solrQuery");
                            if (xe != null)
                            {
                                selectItem.SolrQuery = xe.Value;
                            }
                            xe = column.Element("xmlFilePath");
                            if (xe != null)
                            {
                                selectItem.XmlFilePath = xe.Value;
                            }
                            xe = column.Element("sqlQuery");
                            if (xe != null)
                            {
                                selectItem.SqlQuery = xe.Value;
                            }
                        }
                        if (item.Attribute("name").Value == "Others_AccountInfo")
                        {
                            if (column.Attributes("itemType").Count() > 0)
                            {
                                selectItem.ItemType = column.Attribute("itemType").Value;
                            }
                            else
                            {
                                selectItem.ItemType = Option.ItemType.All.ToString();
                            }

                            xe = column.Element("AccountNum");
                            if (xe != null)
                            {
                                selectItem.AccountNum = xe.Value;
                            }
                            xe = column.Element("SubAccount");
                            if (xe != null)
                            {
                                selectItem.SubAccount = xe.Value;
                            }
                            xe = column.Element("EmployerId");
                            if (xe != null)
                            {
                                selectItem.EmployerId = xe.Value;
                            }
                            xe = column.Element("InvoiceItemID");
                            if (xe != null)
                            {
                                selectItem.InvoiceItemID = xe.Value;
                            }
                            xe = column.Element("CountryCode");
                            if (xe != null)
                            {
                                selectItem.CountryCode = xe.Value;
                            }
                            xe = column.Element("ToCountryCode");
                            if (xe != null)
                            {
                                selectItem.ToCountryCode = xe.Value;
                            }
                            xe = column.Element("JobAdId");
                            if (xe != null)
                            {
                                selectItem.JobAdId = xe.Value;
                            }
                            xe = column.Element("JobTitle");
                            if (xe != null)
                            {
                                selectItem.JobTitle = xe.Value;
                            }
                            xe = column.Element("UserManagementId");
                            if (xe != null)
                            {
                                selectItem.UserManagementId = xe.Value;
                            }
                            xe = column.Element("Environment");
                            if (xe != null)
                            {
                                selectItem.Environment = xe.Value;
                            }
                            else
                            {
                                selectItem.Environment = Option.EnvironmentType.Dev.ToString();
                            }
                        }
                        else
                        {
                            selectItem.Value = column.Value;
                        }

                        if (item.Attribute("name").Value == "SendEmail_EmailDBInfo")
                        {
                            xe = column.Element("SqlQuery");
                            if (xe != null)
                            {
                                selectItem.SqlQuery = xe.Value;
                            }
                        }

                        ls.Add(selectItem);
                    }
                    dic.Add(item.Attribute("name").Value, ls);
                }

            }
            else
            {
                MessageBox.Show("请先到App.config中定义DropDownToText.", "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dic;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sSql = @"
Select a.WordingsKey, b.WordingsContent, b.Countrycode, b.LanguageCode
From JobsDB_System.dbo.ResourceWordings a With(Nolock)
Inner join JobsDB_System.dbo.ResourceWordingsContent b With(Nolock) on a.Id = b.WordingsId
Where {0}
Order by b.LastUserUpdateTime;";
            string txtSearchContent = this.txtSearchContent.Text.ToString().Trim();
            string txtSearchKey = this.txtSearchKey.Text.ToString().Trim();
            bool cbSearchContent = this.cbWordingContent.Checked;
            bool cbSearchKey = this.cbWordingKey.Checked;
            if (string.IsNullOrEmpty(txtSearchContent) && string.IsNullOrEmpty(txtSearchKey))
            {
                MessageBox.Show("Please input search condition");
                return;
            }

            StringBuilder sb = new StringBuilder();
            int index = 0;
            if (!string.IsNullOrEmpty(txtSearchContent))
            {
                string where = cbSearchContent ? "{0} WordingsContent like '%{1}%' " : "{0} WordingsContent = '{1}' ";
                foreach (var item in txtSearchContent.Split(','))
                {
                    sb.AppendFormat(where, index == 0 ? "" : "or", item);
                    index++;
                }
            }
            if (!string.IsNullOrEmpty(txtSearchKey))
            {
                string where = cbSearchKey ? "{0} WordingsKey like '%{1}%' " : "{0} WordingsKey = '{1}' ";
                foreach (var item in txtSearchKey.Split(','))
                {
                    sb.AppendFormat(where, index == 0 ? "" : "or", item);
                    index++;
                }
            }

            string sourceDB = ReplaceCountryCode(this.txtSourceConnStr.Text.Trim());
            if (string.IsNullOrEmpty(sourceDB))
            {
                MessageBox.Show("Please input sourect DB connection string");
                return;
            }
            DataSet dsDB = LoadDataForWording.LoadDataFromDB(string.Format(sSql, sb.ToString()), sourceDB);
            this.gv_SearchResult.DataSource = dsDB.Tables[0];
            this.gv_SearchResult.Columns[0].Width = 300;
            this.gv_SearchResult.Columns[1].Width = 320;
        }

        private void btnWipe_Click(object sender, EventArgs e)
        {
            if (null != dsDB && dsDB.Tables.Count > 0)
            {
                dsDB.Tables[0].Rows.Clear();
                this.gv_SearchResult.DataSource = dsDB.Tables[0];
            }
        }

        #region select all text
        private void selectAllText(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                try
                {
                    ((TextBox)sender).SelectAll();
                }
                catch
                {
                    ((RichTextBox)sender).SelectAll();
                }
            }
        }

        private void txtGetData_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);
        }

        private void txtGetString_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);

        }

        private void txtWordingKey_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);

        }

        private void txtXXContent_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);

        }

        private void txtIDContent_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);

        }

        private void txtTHContent_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);

        }

        private void txtComment_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);

        }

        private void txtContent_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);

        }

        private void txtSearchContent_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);

        }

        private void txtSearchKey_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);

        }

        private void txtTargetConnStr_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);

        }

        private void txtSourceConnStr_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);

        }
        #endregion

        private void cbSourceConnName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectItem dbInfo = (SelectItem)this.cbSourceConnName.SelectedItem;
            this.txtSourceConnStr.Text = dbInfo.ConnStr;
            this.txtSourceConnProviderName.Text = dbInfo.ProviderName;
        }

        private void cbTargetConnName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectItem dbInfo = (SelectItem)this.cbTargetConnName.SelectedItem;
            this.txtTargetConnStr.Text = dbInfo.ConnStr;
            //this.txtTargetConnProviderName.Text = dbInfo.ProviderName;                
        }

        private void cbHelpColumns_CheckedChanged(object sender, EventArgs e)
        {
            if (this.gv_Result.Rows.Count > 0)
            {
                gv_Result.RowHeadersVisible = !cbHelpColumns.Checked;
                gv_Result.Columns[0].Visible = !cbHelpColumns.Checked;
                gv_Result.Columns[1].Visible = !cbHelpColumns.Checked;
            }
        }
        #endregion

        #region get class/filed abbr
        public readonly string outputFormat = "{0, 40} - {1, -30}: {2}";
        private void btnGetAbbr_Click(object sender, EventArgs e)
        {
            string xmlString = this.txtClassField.Text;


            DataSet ds = new DataSet();
            DataTable oDT = new DataTable("ClasFieldResult");
            oDT.Columns.Add("ClassName", typeof(string));
            oDT.Columns.Add("Field", typeof(string));
            oDT.Columns.Add("Abbr", typeof(string));
            ds.Tables.Add(oDT);


            XDocument xdoc = XDocument.Parse(xmlString);

            List<Abbreviation> result =
                (from elem in xdoc.Descendants("class").Descendants("field")
                 select new Abbreviation
                 {
                     ClassName = elem.Parent.Attribute("name").Value.ToString(),
                     FieldName = elem.Attribute("name").Value.ToString()
                 }).ToList();

            CamelCaseInputDataAliasMappingDictionary camelCase = new CamelCaseInputDataAliasMappingDictionary();
            string preClassName = string.Empty;
            StringBuilder sb = new StringBuilder();
            foreach (var r in result)
            {
                string id = InputDataKeys.ClassPrefix
                    + camelCase.GetClassAliasName(r.ClassName)

                    + InputDataKeys.PropertyPrefix
                    + camelCase.GetPropertyAliasName(r.FieldName);

                if (r.ClassName == preClassName)
                {
                    oDT.Rows.Add("", r.FieldName, id);
                }
                else
                {
                    oDT.Rows.Add("", "", "");
                    oDT.Rows.Add(r.ClassName, r.FieldName, id);
                }
                preClassName = r.ClassName;
            }

            this.gvClassFieldResult.DataSource = oDT;
            this.gvClassFieldResult.Columns[0].Width = 200;
            this.gvClassFieldResult.Columns[1].Width = 200;
            this.gvClassFieldResult.Columns[2].Width = 200;
        }

        #endregion

        #region backup task

        private void btnBackupTaskPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtBackupTaskPath.Text = folderDialog.SelectedPath;
            }
        }

        private void cbBackupTaskTargetPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectItem targetPath = (SelectItem)this.cbBackupTaskTargetPath.SelectedItem;

            this.txtBackupTaskTargetPath.Text = targetPath.Value;
        }

        private void cbBackupTaskTaskName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectItem taskName = (SelectItem)this.cbBackupTaskTaskName.SelectedItem;

            this.txtBackupTaskName.Text = taskName.Value;
        }

        private void btnBackupSubmit_Click(object sender, EventArgs e)
        {
            this.txtBackupTaskSubmitResult.Text = "";
            this.txtBackupTaskSubmitResult.Enabled = true;
            string backupTaskPath = this.txtBackupTaskPath.Text.Trim();
            string backupTaskName = this.txtBackupTaskName.Text.Trim();
            //backupTaskName = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(backupTaskName);
            string backupTaskFileList = this.txtBackupTaskFileList.Text.Trim();
            if (backupTaskPath == "")
            {
                MessageBox.Show("请填写需要备份路径", "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtBackupTaskPath.Focus();
                return;
            }
            if (backupTaskName == "" || backupTaskName.Contains(' '))
            {
                MessageBox.Show("请填写正确的需要备份的任务名称", "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtBackupTaskName.Focus();
                return;
            }
            if (backupTaskFileList == "")
            {
                MessageBox.Show("请填写需要备份文件的路径", "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtBackupTaskFileList.Focus();
                return;
            }

            SelectItem taskType = (SelectItem)this.cbBackupTaskType.SelectedItem;
            string backupTaskTaskPath = Path.Combine(backupTaskPath, taskType.Value + "_" + backupTaskName);
            if (!KernelClass.PhysicalFile.FolderExists(backupTaskTaskPath))
            {
                KernelClass.PhysicalFile.CreateFolder(backupTaskTaskPath);
            }

            int index = CommonHelper.getNameIndex(backupTaskTaskPath, "", ".txt", 1);
            string fileName = DateTime.Now.ToString("yyyyMMdd");
            string fileListPath = Path.Combine(backupTaskTaskPath, fileName + "_V" + index + ".txt");
            string batPath = Path.Combine(backupTaskTaskPath, fileName + "_V" + index + ".bat");
            string bkMaybePath = Path.Combine(backupTaskTaskPath, fileName + "_V" + index);

            if (KernelClass.PhysicalFile.AddToFile(backupTaskFileList, fileListPath))
            {

                this.txtBackupTaskSubmitResult.Text = "\r\n\r\n"
                    + "add file list to txt file:"
                    + "\r\n" + "    "
                    + fileListPath
                    + this.txtBackupTaskSubmitResult.Text;

                if (KernelClass.PhysicalFile.AddToFile(
                    string.Format(backupTaskBat, fileListPath,
                        this.txtBackupTaskTargetPath.Text,
                        backupTaskTaskPath + @"\", backupTaskPythonPath,
                        this.cbBackupTaskBackWording.Checked ? "True" : "Flase",
                        fileName + "_V" + index)
                    , batPath))
                {

                    this.txtBackupTaskSubmitResult.Text = "\r\n\r\n"
                        + "add bat file to:"
                        + "\r\n" + "    "
                        + batPath
                        + this.txtBackupTaskSubmitResult.Text;

                    CommonHelper.RunBat(batPath);

                    this.txtBackupTaskSubmitResult.Text = "\r\n\r\n"
                        + "runned bat file for backup:"
                        + this.txtBackupTaskSubmitResult.Text; ;

                    DataTable csvDataTable = new DataTable("");
                    csvDataTable.Columns.Add("TaskName", typeof(string));
                    csvDataTable.Columns.Add("TaskType", typeof(string));
                    csvDataTable.Columns.Add("BackupPath", typeof(string));
                    csvDataTable.Columns.Add("TargetPath", typeof(string));
                    csvDataTable.Columns.Add("IsBackupWordings", typeof(string));
                    csvDataTable.Columns.Add("FileListPath,", typeof(string));

                    csvDataTable.Rows.Add(backupTaskName,
                        taskType.Value,
                        backupTaskPath,
                        this.txtBackupTaskTargetPath.Text,
                        this.cbBackupTaskBackWording.Checked,
                        fileListPath);
                    string resourceBackupTaskPath = Path.Combine(System.Environment.CurrentDirectory, @"Resource\BackupTask.csv");
                    string msg = WordingHelper.saveBackupTaskToCSV(resourceBackupTaskPath, csvDataTable);

                    if (!string.IsNullOrEmpty(msg))
                    {
                        MessageBox.Show(msg, "提示信息",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    this.txtBackupTaskSubmitResult.Text = "\r\n\r\n"
                        + "backup task params to :"
                        + "\r\n" + "    "
                        + resourceBackupTaskPath
                        + this.txtBackupTaskSubmitResult.Text;

                    string newFilePath = CommonHelper.copyFileToBK(backupFolderPath, resourceBackupTaskPath, backupTaskName, 1);
                    this.txtBackupTaskSubmitResult.Text = "\r\n\r\n"
                        + "backup file from:"
                        + "\r\n" + "    "
                        + resourceBackupTaskPath
                        + "\r\n" + " to :"
                        + "\r\n" + "    "
                        + newFilePath
                        + this.txtBackupTaskSubmitResult.Text;


                    this.txtBackupTaskSubmitResult.Text = "\r\n\r\n"
                        + "bk folder path (maybe):"
                        + "\r\n" + "    "
                        + bkMaybePath
                        + this.txtBackupTaskSubmitResult.Text;
                }
            }
        }

        private void btnBackupTaskLastestPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.Environment.CurrentDirectory;//注意这里写路径时要用c:\\而不是c:\
            //openFileDialog.Filter = "Excel文件|*.xlsx|所有文件|*.*";
            openFileDialog.Filter = "CSV文件|*.csv|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fName = openFileDialog.FileName;
                this.txtBackupTaskLastestPath.Text = fName;
            }
        }

        private void btnBackupTaskLoad_Click(object sender, EventArgs e)
        {
            this.txtBackupTaskSubmitResult.Text = "";

            string backupTaskPath = this.txtBackupTaskLastestPath.Text;
            if (!string.IsNullOrEmpty(backupTaskPath) && File.Exists(backupTaskPath))
            {
                var backupDT = LoadDataForWording.LoadDataFromCSV(backupTaskPath).Tables[0];

                this.txtBackupTaskName.Text = backupDT.Rows[0]["TaskName"].ToString();
                string taskType = backupDT.Rows[0]["TaskType"].ToString();
                for (int i = 0; i < cbBackupTaskType.Items.Count; i++)
                {
                    SelectItem item = (SelectItem)cbBackupTaskType.Items[i];
                    if (item.Value == taskType)
                    {
                        this.cbBackupTaskType.SelectedIndex = i;
                        break;
                    }
                }
                this.txtBackupTaskPath.Text = backupDT.Rows[0]["BackupPath"].ToString();
                this.txtBackupTaskTargetPath.Text = backupDT.Rows[0]["TargetPath"].ToString();
                this.cbBackupTaskBackWording.Checked = Convert.ToBoolean(backupDT.Rows[0]["IsBackupWordings"]);
                string fileListPath = backupDT.Rows[0]["FileListPath"].ToString();
                if (File.Exists(fileListPath))
                {
                    this.txtBackupTaskFileList.Text = KernelClass.PhysicalFile.ReadFile(fileListPath);
                }

                this.txtBackupTaskSubmitResult.Text = "\r\n\r\n"
                        + "load fileList Path :"
                        + "\r\n" + "    "
                        + fileListPath
                        + this.txtBackupTaskSubmitResult.Text;
            }
            else
            {
                MessageBox.Show("请选择正确的文件路径.", "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBackupTaskFileList_KeyDown(object sender, KeyEventArgs e)
        {

            selectAllText(sender, e);
        }

        private void txtBackupTaskSubmitResult_KeyDown(object sender, KeyEventArgs e)
        {

            selectAllText(sender, e);
        }
        #endregion

        #region operateDB

        private void operateDB_SwitchScript(bool isAll)
        {
            this.txtOperateDB_List.Enabled = !isAll;
            this.txtOperateDB_ScriptListPath.Enabled = !isAll;
            this.btnOperateDB_LoadScriptList.Enabled = !isAll;
            this.btnOperateDB_BrowseScriptList.Enabled = !isAll;
        }

        public Microsoft.SqlServer.Management.Smo.Server Server;
        private void btnOperateDB_GetDB_Click(object sender, EventArgs e)
        {
            string sourceDB = ReplaceCountryCode(this.txtSourceConnStr.Text.Trim());
            if (string.IsNullOrEmpty(sourceDB))
            {
                MessageBox.Show("Please input sourect DB connection string");
                return;
            }

            try
            {
                Server = SmoHelper.GetServer(sourceDB);
                if (Server == null)
                {
                    MessageBox.Show("Connection Server failed");
                    return;
                }
                IList<SelectItem> selectItemList = OperateDBHelper.GetDbNameList(Server);
                this.cbOperateDB_Database.DataSource = selectItemList;
                this.cbOperateDB_Database.DisplayMember = "Name";
                this.cbOperateDB_Database.ValueMember = "Value";
                this.cbOperateDB_Database.Enabled = true;
                this.btnOperateDB_Start.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnOperateDB_Start_Click(object sender, EventArgs e)
        {
            string dbName = this.cbOperateDB_Database.SelectedValue.ToString();
            if (string.IsNullOrEmpty(dbName))
            {
                return;
            }
            try
            {
                if (rbOperateDB_Restore.Checked)
                {
                    var sql = this.txtOperateDB_Sql.Text;
                    if (string.IsNullOrEmpty(sql))
                    {
                        MessageBox.Show("Please input the sql.");
                        return;
                    }
                    Server.Databases[dbName].ExecuteNonQuery(sql);
                    MessageBox.Show("Runned Sql Scripts Success");
                }
                else
                {
                    ScriptParams scriptParams = new ScriptParams();
                    scriptParams.IsScriptSchema = cbOperateDB_ScriptSchema.Checked;
                    scriptParams.IsScriptDrops = cbOperateDB_ScriptDrops.Checked;
                    scriptParams.IsScriptData = cbOperateDB_ScriptData.Checked;
                    scriptParams.NameList = this.txtOperateDB_List.Text
                        .Split(new char[] { '\r', '\n' })
                        .Where(c => !string.IsNullOrEmpty(c.Trim()))
                        .Select(c => c.Trim())
                        .ToList();
                    if (rbOperateDB_ScriptObj_All.Checked)
                    {
                        scriptParams.ScriptObj = ScriptObj.All;
                    }
                    else if (rbOperateDB_ScriptObj_OnlyList.Checked)
                    {
                        scriptParams.ScriptObj = ScriptObj.OnlyList;
                    }
                    else
                    {
                        scriptParams.ScriptObj = ScriptObj.IgnoreList;
                    }

                    var urnList = OperateDBHelper.GetUrnList(Server.Databases[dbName], scriptParams);
                    this.txtOperateDB_Sql.Text = "USE [" + dbName + "]"
                        + Environment.NewLine + "Go" + Environment.NewLine
                        + OperateDBHelper.GetGenerateSql(Server, scriptParams, urnList);

                    string backupFolder = Path.Combine(System.Environment.CurrentDirectory, "Backup");
                    string baseName = "ScriptList_" + dbName;
                    int index = CommonHelper.getNameIndex(backupFolder, baseName, ".txt", 1);
                    string fileName = DateTime.Now.ToString("yyyyMMdd");
                    string filePath = Path.Combine(backupFolder, baseName + "_" + fileName + "_V" + index + ".txt");
                    KernelClass.PhysicalFile.AddToFile(this.txtOperateDB_List.Text, filePath);

                    CommonHelper.copyFileToBK(backupFolderPath, filePath, "", 1, true);

                    MessageBox.Show("Generate Sql Scripts Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtOperateDB_List_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);
        }

        private void txtOperateDB_Sql_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);
        }

        private void btnOperateDB_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.Environment.CurrentDirectory;//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "sql文件|*.sql|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fName = openFileDialog.FileName;
                this.txtOperateDB_SqlPath.Text = fName;
            }
        }

        private void btnOperateDB_Save_Click(object sender, EventArgs e)
        {
            string savePath = this.txtOperateDB_SqlPath.Text.Trim();
            if (savePath == "")
            {
                MessageBox.Show("请填写需要保存路径", "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtOperateDB_SqlPath.Focus();
                return;
            }
            if (KernelClass.PhysicalFile.AddToFile(this.txtOperateDB_Sql.Text, savePath))
            {
                MessageBox.Show("Save Sql Scripts Success");
            }
        }

        private void btnOperateDB_BrowseScriptList_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.Environment.CurrentDirectory;//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fName = openFileDialog.FileName;
                this.txtOperateDB_ScriptListPath.Text = fName;
            }
        }

        private void btnOperateDB_LoadScriptList_Click(object sender, EventArgs e)
        {
            string filePath = this.txtOperateDB_ScriptListPath.Text;
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                this.txtOperateDB_List.Text = KernelClass.PhysicalFile.ReadFile(filePath);

            }
            else
            {
                MessageBox.Show("请选择正确的文件路径.", "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btOperateDB_LoadSql_Click(object sender, EventArgs e)
        {
            string filePath = this.txtOperateDB_SqlPath.Text;
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                this.txtOperateDB_Sql.Text = KernelClass.PhysicalFile.ReadFile(filePath);
            }
            else
            {
                MessageBox.Show("请选择正确的文件路径.", "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rbOperateDB_ScriptObj_All_CheckedChanged(object sender, EventArgs e)
        {
            operateDB_SwitchScript(true);
        }

        private void rbOperateDB_ScriptObj_OnlyList_CheckedChanged(object sender, EventArgs e)
        {
            operateDB_SwitchScript(false);
        }

        private void rbOperateDB_ScriptObj_IgnoreList_CheckedChanged(object sender, EventArgs e)
        {
            operateDB_SwitchScript(false);
        }

        private void btnOperateDB_Country_Generate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtOperateDB_Country_Content.Text))
            {
                MessageBox.Show("Please input content");
                return;
            }
            string path = @"Resource\GenerateCountry.sql.tm";
            path = CommonHelper.GetAbsolutePath(path);
            Dictionary<string, object> dic = new Dictionary<string, object>();

            dic.Add("IsAddAU", this.cbOperateDB_Country_AU.Checked ? 1 : 0);
            dic.Add("IsAddHK", this.cbOperateDB_Country_HK.Checked ? 1 : 0);
            dic.Add("IsAddID", this.cbOperateDB_Country_ID.Checked ? 1 : 0);
            dic.Add("IsAddIN", this.cbOperateDB_Country_IN.Checked ? 1 : 0);
            dic.Add("IsAddKR", this.cbOperateDB_Country_KR.Checked ? 1 : 0);
            dic.Add("IsAddMy", this.cbOperateDB_Country_MY.Checked ? 1 : 0);
            dic.Add("IsAddPH", this.cbOperateDB_Country_PH.Checked ? 1 : 0);
            dic.Add("IsAddSG", this.cbOperateDB_Country_SG.Checked ? 1 : 0);
            dic.Add("IsAddTH", this.cbOperateDB_Country_TH.Checked ? 1 : 0);
            dic.Add("IsAddTW", this.cbOperateDB_Country_TW.Checked ? 1 : 0);
            dic.Add("IsAddUS", this.cbOperateDB_Country_US.Checked ? 1 : 0);

            dic.Add("Context", this.txtOperateDB_Country_Content.Text);
            this.txtOperateDB_Sql.Text = TemplateHelper.GetContent(path, dic);
        }

        private void txtOperateDB_Country_Content_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);
        }

        #endregion

        #region tab others
        private void btnOthers_RunSql_Click(object sender, EventArgs e)
        {
            string sourceDB = ReplaceCountryCode(this.txtSourceConnStr.Text.Trim());
            if (string.IsNullOrEmpty(sourceDB))
            {
                MessageBox.Show("Please input sourect DB connection string");
                return;
            }

            SqlConnection sqlConn = new SqlConnection(sourceDB);
            SqlCommand cmd = new SqlCommand(this.txtOperateDB_Sql.Text, sqlConn);
            try
            {
                ExtDBMethods.ExecuteNonQueryWithGo(cmd);
                MessageBox.Show("Runned");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnOthers_Add_Click(object sender, EventArgs e)
        {
            IDictionary<string, object> dic = new Dictionary<string, object>();
            string path = @"Resource\AddExample.tm";
            path = CommonHelper.GetAbsolutePath(path);
            long intervalId = long.Parse(ConfigurationManager.AppSettings["Others_IntervalId"] ?? "100000");
            int indexofJobAd = 1;
            int indexofCandidate = 1;
            bool isCheckExists = true;

            try
            {
                bool isAddJob = this.cbOthers_AddJob.Checked;
                bool isAddCandidate = this.cbOthers_AddCandidate.Checked;
                bool isNewWorkforce = this.cbOthers_IsNewWorkforce.Checked;
                long jobAdId = Convert.ToInt64(this.txtOthers_JobAdId.Text.Trim());
                long jobSeekerId = Convert.ToInt64(this.txtOthers_JobSeekerId.Text.Trim());
                string countryCode = this.cbOthers_CountryCode.Text.Trim();
                string toCountryCode = this.cbOthers_ToCountryCode.Text.Trim();
                string baseEmail = this.txtOthers_Email.Text.Trim();
                string firstName = this.txtOthers_FirstName.Text.Trim();
                string lastName = this.txtOthers_LastName.Text.Trim();
                string emailAddress = string.Format(baseEmail, indexofCandidate);
                long candidateCount = Convert.ToInt64(this.cbOthers_CandidateCount.Text.Trim());
                long jobCount = Convert.ToInt64(this.cbOthers_JobCount.Text.Trim());

                string sourceDB = ReplaceCountryCode(this.txtSourceConnStr.Text.Trim());
                bool isExistsBySql = false;

                IList<Dictionary<string, object>> jobList = new List<Dictionary<string, object>>();
                if (isAddJob)
                {
                    while (jobList.Count < jobCount)
                    {
                        Dictionary<string, object> dicJob = new Dictionary<string, object>();
                        string addJobSql = htConfig["OperateDBCheckJobExists"].ToString();
                        while (isCheckExists)
                        {
                            var ds = LoadDataForWording.LoadDataFromDB(string.Format(addJobSql, countryCode, jobAdId), sourceDB);
                            foreach (DataTable table in ds.Tables)
                            {
                                isExistsBySql = table.Rows.Count > 0;
                                if (isExistsBySql)
                                    break;
                            }
                            if (isExistsBySql)
                            {
                                indexofJobAd++;
                                jobAdId = jobAdId + intervalId;
                            }
                            else
                            {
                                isCheckExists = false;
                            }
                        }

                        dicJob.Add("JobAdId", jobAdId);
                        dicJob.Add("JobTitle", string.Format(this.txtOthers_JobTitle.Text.Trim(), jobAdId, countryCode == toCountryCode ? countryCode : (countryCode + "-" + toCountryCode)));
                        dicJob.Add("IndexofJobAd", indexofJobAd);

                        jobList.Add(dicJob);
                        indexofJobAd++;
                        jobAdId = jobAdId + intervalId;
                    }
                }

                isCheckExists = true;
                isExistsBySql = false;
                bool isFixEmail = !baseEmail.Contains("{0}");
                string errorMsg = string.Empty;

                IList<Dictionary<string, object>> candidateList = new List<Dictionary<string, object>>();
                if (isAddCandidate)
                {
                    while (candidateList.Count < candidateCount)
                    {
                        Dictionary<string, object> dicCandidate = new Dictionary<string, object>();
                        string addJobSql = htConfig["OperateDBCheckCandidateExists"].ToString();
                        while (isCheckExists)
                        {
                            var ds = LoadDataForWording.LoadDataFromDB(string.Format(addJobSql, jobSeekerId, emailAddress), sourceDB);
                            foreach (DataTable table in ds.Tables)
                            {
                                isExistsBySql = table.Rows.Count > 0;
                                if (isExistsBySql)
                                    break;
                            }
                            if (isExistsBySql)
                            {
                                if (isFixEmail && ds.Tables[0].Rows[0]["EmailAddress"].ToString() == emailAddress)
                                {
                                    isCheckExists = false;
                                    errorMsg = string.Format("The {0} already exists.", emailAddress);
                                }
                                else
                                {
                                    indexofCandidate++;
                                    jobSeekerId = jobSeekerId + intervalId;
                                    emailAddress = string.Format(baseEmail, indexofCandidate);
                                }
                            }
                            else
                            {
                                isCheckExists = false;
                            }
                        }
                        if (!string.IsNullOrEmpty(errorMsg))
                        {
                            break;
                        }
                        dicCandidate.Add("IndexofCandidate", indexofCandidate);
                        dicCandidate.Add("JobSeekerId", jobSeekerId);
                        dicCandidate.Add("Email", emailAddress);
                        dicCandidate.Add("FirstName", string.IsNullOrEmpty(firstName)?"mirage":firstName);
                        dicCandidate.Add("LastName", string.IsNullOrEmpty(lastName) ? "lu" : lastName);

                        candidateList.Add(dicCandidate);
                        indexofCandidate++;
                        jobSeekerId = jobSeekerId + intervalId;
                        emailAddress = string.Format(baseEmail, indexofCandidate);
                    }
                }
                if (!string.IsNullOrEmpty(errorMsg))
                {
                    MessageBox.Show(errorMsg);
                    return;
                }

                dic.Add("IsAddJob", isAddJob ? 1 : 0);
                dic.Add("JobCount", jobCount);
                dic.Add("AccountNum", Convert.ToInt64(this.txtOthers_AccountNum.Text.Trim()));
                dic.Add("SubAccount", Convert.ToInt64(this.txtOthers_SubAccount.Text.Trim()));
                dic.Add("EmployerId", Convert.ToInt64(this.txtOthers_EmployerId.Text.Trim()));
                dic.Add("InvoiceItemID", Convert.ToInt64(this.txtOthers_InvoiceItemID.Text.Trim()));
                dic.Add("CountryCode", countryCode);
                dic.Add("ToCountryCode", toCountryCode);
                dic.Add("JobList", jobList);

                dic.Add("IsAddCandidate", isAddCandidate ? 1 : 0);
                dic.Add("IsNewWorkforce", isNewWorkforce ? 1 : 0);
                dic.Add("CandidateCount", candidateCount);
                var jobSeekerCountryCode = this.cbOthers_CountryOfResidence.Text.Trim();
                dic.Add("JobSeekerCountryCode", jobSeekerCountryCode);
                dic.Add("CountryOfResidence", (int)Enum.Parse(typeof(Option.CountryOfResidence), jobSeekerCountryCode));
                dic.Add("ProfilePrivacyLevel", (int)Enum.Parse(typeof(Option.ProfilePrivacyLevel), this.cbOthers_ProfilePrivacyLevel.Text.Trim()));

                dic.Add("CandidateList", candidateList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.txtOperateDB_Sql.Text = TemplateHelper.GetContent(path, dic);
        }

        private void cbOthers_Account_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectItem accountInfo = (SelectItem)this.cbOthers_Account.SelectedItem;
            this.txtOthers_AccountNum.Text = accountInfo.AccountNum;
            this.txtOthers_SubAccount.Text = accountInfo.SubAccount;
            this.txtOthers_EmployerId.Text = accountInfo.EmployerId;
            this.txtOthers_InvoiceItemID.Text = accountInfo.InvoiceItemID;
            this.cbOthers_CountryCode.Text = accountInfo.CountryCode;
            this.cbOthers_ToCountryCode.Text = accountInfo.ToCountryCode;
            this.txtOthers_JobAdId.Text = accountInfo.JobAdId;
            this.txtOthers_JobTitle.Text = accountInfo.JobTitle;

        }

        private void btnOthers_DropRMSDB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete RSM DB?", "提示信息",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                IDictionary<string, object> dic = new Dictionary<string, object>();
                string path = @"Resource\DeleteRMSDB.tm";
                path = CommonHelper.GetAbsolutePath(path);

                Regex reg = new Regex("^.*server=(.*);.*User ID=(.*);.*Password=(.*)$", RegexOptions.IgnoreCase);
                string conn = ReplaceCountryCode(this.txtSourceConnStr.Text.Trim());
                var matchs = reg.Match(conn);
                if (!matchs.Success)
                {
                    reg = new Regex("^.*Data Source=(.*);.*User ID=(.*);.*Password=(.*)$", RegexOptions.IgnoreCase);
                    matchs = reg.Match(conn);
                }
                if (matchs.Success)
                {
                    dic.Add("ExecSql", string.Format("osql -S{0} -U{1} -P{2} -i ../Resource/DropRMSDB.sql",
                        matchs.Groups[1].Value.Split(';')[0], matchs.Groups[2].Value.Split(';')[0], matchs.Groups[3].Value.Split(';')[0]));
                }
                else
                {
                    dic.Add("ExecSql", "osql -E -i ../Resource/DropRMSDB.sql");
                }

                string execBatPath = CommonHelper.GetAbsolutePath(@"Backup\_Exec_DropRMSDB.bat");
                KernelClass.PhysicalFile.DeleteFile(execBatPath);
                KernelClass.PhysicalFile.AddToFile(TemplateHelper.GetContent(path, dic), execBatPath);

                if (MessageBox.Show("delete    " + (matchs.Success ? matchs.Groups[1].Value.Split(';')[0] : "local") + "     DB?", "提示信息",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CommonHelper.RunBat(execBatPath);
                    string newFilePath = CommonHelper.copyFileToBK(backupFolderPath, execBatPath, "", 1);
                }

            }
        }

        #endregion

        #region solr partial

        private int totalFieldProperty = 0;
        private IList<Dictionary<string, object>> listDicQueryResult;
        private IList<string> keyFieldList = new List<string>();

        private void lbPartial_QueryResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPartial_QueryResult.SelectedIndex >= 0)
                compositionControls(listDicQueryResult[lbPartial_QueryResult.SelectedIndex]);
        }

        private void lbPartial_QueryResult_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lbPartial_QueryResult.IndexFromPoint(e.Location);
            // Check if the index is valid.
            if (index != -1 && index < lbPartial_QueryResult.Items.Count)
            {
                // Check if the ToolTip's text isn't already the one
                // we are now processing.
                if (toolTip1.GetToolTip(lbPartial_QueryResult) != lbPartial_QueryResult.Items[index].ToString())
                {
                    // If it isn't, then a new item needs to be
                    // displayed on the toolTip. Update it.
                    toolTip1.SetToolTip(lbPartial_QueryResult, lbPartial_QueryResult.Items[index].ToString());
                }
            }
        }

        private void compositionControls(Dictionary<string, object> dic)
        {
            this.plPartial_Field.Controls.Clear();
            if (dic.Count() == 0)
                return;

            totalFieldProperty = dic.Count();
            CheckBox[] cbs = new CheckBox[totalFieldProperty];
            TextBox[] tbs = new TextBox[totalFieldProperty];
            int i = 0;
            int start_x = 15;
            int index_y = 0;
            int index_k = 0;
            string engineCoreUrl = string.Empty;
            string domainName = string.Empty;
            string query = string.Empty;
            string countryCode = string.Empty;
            getSolrInfo(out countryCode, out engineCoreUrl, out domainName, out query);
            var unStoredList = _partialCoreService.GetFieldByAttr("IsUnStored");

            foreach (var item in dic)
            {
                string piName = item.Key;
                var piValue = item.Value;
                if (piValue != null)
                {
                    if (piValue.GetType().IsGenericType && piValue.GetType().GetGenericTypeDefinition() == typeof(IList<>)
                        || piValue.GetType().IsGenericType && piValue.GetType().GetGenericTypeDefinition() == typeof(List<>))
                    {
                        IList<string> objList = new List<string>();
                        if (piValue.GetType().GetGenericArguments()[0] == typeof(int))
                        {
                            var objTempList = (IList<int>)piValue;
                            foreach (var obj in objTempList)
                            {
                                objList.Add(obj.ToString());
                            }
                        }
                        else if (piValue.GetType().GetGenericArguments()[0] == typeof(long))
                        {
                            var objTempList = (IList<long>)piValue;
                            foreach (var obj in objTempList)
                            {
                                objList.Add(obj.ToString());
                            }
                        }
                        else
                            objList = (IList<string>)piValue;
                        if (objList != null)
                        {
                            piValue = string.Join(",", objList);
                        }
                    }
                }
                cbs[i] = new CheckBox();
                tbs[i] = new TextBox();
                cbs[i].Name = "cbField_" + i;
                cbs[i].Text = piName;
                cbs[i].Width = 140;
                cbs[i].CheckedChanged += cbField_Changed;
                if (index_y % 5 == 0 && index_y > 1)
                {
                    start_x += 364;
                    index_y = 0;
                }
                if (keyFieldList.Contains(piName.ToLower()))
                {
                    //cbs[i].Enabled = false;
                    cbs[i].Location = new System.Drawing.Point(index_k * 364 + 15, 12);
                    tbs[i].Location = new System.Drawing.Point(index_k * 364 + 15 + 148, 12);
                    cbs[i].ForeColor = System.Drawing.Color.Red;
                    index_k++;
                }
                else
                {
                    cbs[i].Location = new System.Drawing.Point(start_x, 30 * index_y + 50);
                    tbs[i].Location = new System.Drawing.Point(start_x + 148, 30 * index_y + 50);
                    index_y++;
                }

                if (unStoredList.Contains(piName))
                {
                    cbs[i].ForeColor = System.Drawing.Color.Blue;
                }
                tbs[i].Name = "tbField_" + i;
                tbs[i].Width = 200;
                tbs[i].Enabled = false;
                if (piValue != null)
                    tbs[i].Text = piValue.ToString();

                this.plPartial_Field.Controls.Add(cbs[i]);
                this.plPartial_Field.Controls.Add(tbs[i]);

                i++;
            }
        }

        private void cbField_Changed(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            string index = cb.Name.Split('_')[1];
            Control tb = this.plPartial_Field.Controls.Find("tbField_" + index, false)[0];
            if (cb.Checked)
            {
                tb.Enabled = true;
            }
            else
            {
                //tb.Text="";
                tb.Enabled = false;
            }
        }

        private void btnPartial_Query_Click(object sender, EventArgs e)
        {
            string engineCoreUrl = string.Empty;
            string domainName = string.Empty;
            string query = string.Empty;
            string countryCode = string.Empty;
            getSolrInfo(out countryCode, out engineCoreUrl, out domainName, out query);

            listDicQueryResult = _partialCoreService.SolrQuery(engineCoreUrl, query, out keyFieldList);
            lbPartial_QueryResult.Items.Clear();
            int i = 0;
            foreach (var item in listDicQueryResult)
            {
                lbPartial_QueryResult.Items.Add(item.Take(10).ToJSON());
                i++;
            }

            if (listDicQueryResult.Count() != 0)
            {
                lbPartial_QueryResult.SelectedIndex = 0;
            }
            this.btnPartial_Save.Visible = true;
            this.lbSolrUpdate_Note.Visible = true;
            this.lbSolrUpdate_Note2.Visible = true;
        }

        private void btnPartial_Delete_Click(object sender, EventArgs e)
        {
            string engineCoreUrl = string.Empty;
            string domainName = string.Empty;
            string query = string.Empty;
            string countryCode = string.Empty;
            getSolrInfo(out countryCode, out engineCoreUrl, out domainName, out query);
            if (MessageBox.Show("Are you sure you want to delete this query-based data?", "提示信息",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool success = false;
                if (query.Contains("*"))
                {
                    var listDicQueryResult = _partialCoreService.SolrQuery(engineCoreUrl, query, out keyFieldList);
                    if (listDicQueryResult.Count > 2)
                    {
                        if (MessageBox.Show("Delete query will delete more then 2 records, are you sure to delete?", "提示信息",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            success = SolrHelper.Delete(engineCoreUrl, query);
                            MessageBox.Show(string.Format("删除{0}", success ? "成功" : "失败"), "提示信息",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                }

                success = SolrHelper.Delete(engineCoreUrl, query);
                MessageBox.Show(string.Format("删除{0}", success ? "成功" : "失败"), "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnPartial_Save_Click(object sender, EventArgs e)
        {
            string engineCoreUrl = string.Empty;
            string domainName = string.Empty;
            string query = string.Empty;
            string countryCode = string.Empty;
            getSolrInfo(out countryCode, out engineCoreUrl, out domainName, out query);

            IList<Dictionary<string, object>> dicList = new List<Dictionary<string, object>>();
            IList<string> updateFields = new List<string>();
            string queryString = string.Empty;
            var allFields = compositionField(out dicList, out updateFields, out queryString);
            if (updateFields.Count < 2)
            {
                MessageBox.Show(string.Format("必须要选择一个非Key Field才能提交"), "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool success = _partialCoreService.SolrUpdate(engineCoreUrl, dicList, updateFields);

            MessageBox.Show(string.Format("更新{0}", success ? "成功" : "失败"), "提示信息",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (success)
            {
                var cur = _partialCoreService.SolrQuery(engineCoreUrl, queryString, out keyFieldList);

                int i = this.lbPartial_QueryResult.SelectedIndex;
                lbPartial_QueryResult.Items.RemoveAt(i);
                lbPartial_QueryResult.Items.Insert(i, cur[0].ToJSON());
                listDicQueryResult[i] = cur[0];
                lbPartial_QueryResult.SelectedIndex = i;
            }
            return;
        }

        private void getSolrInfo(out string countryCode, out string engineCoreUrl, out string domainName, out string query)
        {
            countryCode = this.cbPartial_CountryCode.Text.Trim();
            engineCoreUrl = ReplaceCountryCode(this.txtPartial_SolrUrl.Text.Trim(), countryCode);
            if (string.IsNullOrEmpty(engineCoreUrl))
            {
                MessageBox.Show("请填入solr url.", "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            SelectItem solrCore = (SelectItem)this.cbPartial_SolrCore.SelectedItem;
            domainName = solrCore.Name;

            query = this.txtPartial_Query.Text.Trim();
            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("请填入query.", "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            _partialCoreService = _context.GetObject(countryCode + domainName.Split('_')[0] + "_Partial") as IPartialCoreService;
            SelectItem dbInfo = (SelectItem)this.cbSourceConnName.SelectedItem;
            if (dbInfo != null)
            {
                var dbConnStr = ReplaceCountryCode(this.txtSourceConnStr.Text.Trim(), countryCode);
                var dbProviderName = this.txtSourceConnProviderName.Text.Trim();
                _partialCoreService.OverrideDB(dbConnStr, dbProviderName);
            }
        }
        private Dictionary<string, object> compositionField(out IList<Dictionary<string, object>> dicList, out IList<string> updateFields, out string queryString)
        {
            Dictionary<string, object> allFields = new Dictionary<string, object>();
            dicList = new List<Dictionary<string, object>>();
            Dictionary<string, object> dic = new Dictionary<string, object>();
            updateFields = new List<string>();
            queryString = string.Empty;
            for (int i = 0; i < totalFieldProperty; i++)
            {
                CheckBox cb = (CheckBox)(this.plPartial_Field.Controls.Find("cbField_" + i, false)[0]);
                string cbTxt = cb.Text.Trim().ToLower();
                TextBox tb = (TextBox)(this.plPartial_Field.Controls.Find("tbField_" + i, false)[0]);
                if (cb.Checked || keyFieldList.Contains(cbTxt))
                {
                    if (keyFieldList.Contains(cbTxt))
                    {
                        queryString = cbTxt + ":" + tb.Text;
                    }
                    dic.Add(cbTxt, tb.Text);
                    updateFields.Add(cbTxt);
                }
                allFields.Add(cbTxt, tb.Text);
            }

            dicList.Add(dic);
            return allFields;
        }

        private void cbPartial_SolrCore_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectItem solrCore = (SelectItem)this.cbPartial_SolrCore.SelectedItem;
            this.txtPartial_SolrUrl.Text = solrCore.SolrUrl;
        }

        private void txtPartial_Query_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);
        }

        #endregion

        #region solr update

        private void btnSolrUpdate_FixDB_Click(object sender, EventArgs e)
        {
            string sourceDB = ReplaceCountryCode(this.txtSourceConnStr.Text.Trim());
            if (string.IsNullOrEmpty(sourceDB))
            {
                MessageBox.Show("Please input sourect DB connection string");
                return;
            }

            SqlConnection sqlConn = new SqlConnection(sourceDB);
            string path = @"Resource\TSSolrFixDB.sql";
            path = CommonHelper.GetAbsolutePath(path);
            string sqlStr = KernelClass.PhysicalFile.ReadFile(path);
            SqlCommand cmd = new SqlCommand(sqlStr, sqlConn);
            try
            {
                ExtDBMethods.ExecuteNonQueryWithGo(cmd);
                MessageBox.Show("Runned");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbSolrName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectItem solrCore = (SelectItem)this.cbSolrName.SelectedItem;
            this.txtSolrUrl.Text = solrCore.SolrUrl;
            arrContext = new string[4]{
                solrCore.IdString, 
                solrCore.SolrQuery, 
                solrCore.XmlFilePath,
                solrCore.SqlQuery
            };
            this.txtSolrQueryUrl.Text = solrCore.SolrQueryUrl;
            this.rtbQuery.Text = arrContext[_flagType];
            this.txtFilePath.Text = solrCore.XmlFilePath;
        }

        private void txtSolrUrl_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);
        }

        private void txtSolrQueryUrl_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);
        }

        private void rtbQuery_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);
        }

        private void btnSolrUpdate_Submit_Click(object sender, EventArgs e)
        {
            IList<string> idList = new List<string>();
            var countryCode = this.cbbCountry.Text.Trim();
            string sContent = ReplaceCountryCode(this.rtbQuery.Text.Trim(), countryCode);
            SelectItem solrCore = (SelectItem)this.cbSolrName.SelectedItem;
            var solrUrl = ReplaceCountryCode(this.txtSolrUrl.Text.Trim(), countryCode);

            if (string.IsNullOrEmpty((solrUrl)))
            {
                MessageBox.Show("Please input the solr url.");
                return;
            }
            try
            {
                var coreName = solrCore.Name.Split('_')[0];
                _coreService = _context.GetObject(countryCode + coreName) as ICoreServiceBase;
                SelectItem dbInfo = (SelectItem)this.cbSourceConnName.SelectedItem;
                if (dbInfo != null)
                {
                    var dbConnStr = ReplaceCountryCode(this.txtSourceConnStr.Text.Trim(), countryCode);
                    var dbProviderName = this.txtSourceConnProviderName.Text.Trim();
                    _coreService.OverrideDB(dbConnStr, dbProviderName);
                }

                if (rbType_IdString.Checked)
                {
                    idList = sContent.Split(',')
                        .Where(i => !string.IsNullOrEmpty(i))
                        .Select(i => i.Trim())
                        .ToList<string>();
                    UpdateCoreForJob(solrUrl, idList);
                }
                else if (rbType_SolrQuery.Checked)
                {
                    var solrQueryUrl = ReplaceCountryCode(this.txtSolrQueryUrl.Text.Trim(), countryCode);
                    IList<IList<string>> listQuery = _coreService.SolrQueryForId(solrQueryUrl, sContent);
                    if (listQuery != null)
                    {
                        foreach (IList<string> list in listQuery)
                        {
                            UpdateCoreForJob(solrUrl, list);
                        }
                    }
                }
                else if (rbType_XmlQuery.Checked)
                {
                    string filePath = this.txtSolrUpdate_XmlPath.Text.Trim();
                    if (File.Exists(filePath))
                    {
                        idList = _coreService.XmlQueryForId(filePath);
                        UpdateCoreForJob(solrUrl, idList);
                    }
                    else
                        MessageBox.Show("File does not exists.");
                }
                else if (this.rbType_SqlQuery.Checked)
                {
                    idList = _coreService.SqlQueryForId(sContent);
                    UpdateCoreForJob(solrUrl, idList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public string ReplaceCountryCode(string str)
        {
            return ReplaceCountryCode(str, "System");
        }
        public string ReplaceCountryCode(string str, string countryCode)
        {
            return str.Replace("{CountryCode}", countryCode)
                .Replace("{CountryCode_Lower}", countryCode.ToLower());
        }

        public void UpdateCoreForJob(string solrUrl, IList<string> idList)
        {
            if (idList.Count == 0)
            {
                MessageBox.Show("updated data is empty.");
                return;
            }

            string sReturn = null;
            if (this.cbbOperation.Text.Trim() == "Update")
            {
                sReturn = _coreService.CommitIndexForCore(solrUrl, idList);
            }
            else if (this.cbbOperation.Text.Trim() == "Delete")
            {
                sReturn = _coreService.DeleteIndexForCore(solrUrl, idList);
            }

            if (!string.IsNullOrEmpty(sReturn))
            {
                MessageBox.Show(sReturn);
            }
        }

        private void btnSolrUpdate_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.Environment.CurrentDirectory;
            openFileDialog.Filter = "Excel文件|*.xml|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                this.txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private void txtSolrUpdate_XmlPath_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);
        }

        private void rbType_IdString_CheckedChanged(object sender, EventArgs e)
        {
            changeType(0, false);
        }

        private void rbType_SolrQuery_CheckedChanged(object sender, EventArgs e)
        {
            changeType(1, false, true);
        }

        private void rbType_XmlQuery_CheckedChanged(object sender, EventArgs e)
        {
            changeType(2, true);
        }

        private void rbType_SqlQuery_CheckedChanged(object sender, EventArgs e)
        {
            changeType(3, false);
        }

        private void changeType(int flag, bool isXml, bool isSolrQuery = false)
        {
            //arrContext[_flagType] = this.rtbQuery.Text;
            _flagType = flag;
            this.rtbQuery.Text = arrContext[_flagType]; //flag == 3 ? arrContext[flagType].Replace("{CountryCode}", this.cbbCountry.Text.Trim()) : arrContext[flagType];

            this.rtbQuery.Enabled = !isXml;
            this.txtSolrUpdate_XmlPath.Enabled = isXml;
            this.btnSolrUpdate_Browse.Enabled = isXml;
            this.txtSolrQueryUrl.Enabled = isSolrQuery;
        }

        private void cbbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbbCountry.Text.Trim() != "HK")
            {
                var solrCore = (SelectItem)this.cbSolrName.SelectedItem;
                if (string.Compare(solrCore.Name.Split('_')[0], "TalentSearch", true) == 0)
                {
                    this.btnSolrUpdate_FixDB.Visible = true;
                }
            }
            else
            {
                this.btnSolrUpdate_FixDB.Visible = false;
            }
        }
        
        #endregion

        #region send email

        private void sendEmail_cbEmailDBInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectItem emailDBInfo = (SelectItem)this.sendEmail_cbEmailDBInfo.SelectedItem;
            this.sendEmail_rtbSql.Text = emailDBInfo.SqlQuery.Trim();
        }

        public static DataSet mainFrm_DS;
        private void sendEmail_btnGetEmailInfo_Click(object sender, EventArgs e)
        {
            string sourceDB = ReplaceCountryCode(this.txtSourceConnStr.Text.Trim());
            if (string.IsNullOrEmpty(sourceDB))
            {
                MessageBox.Show("Please input sourect DB connection string");
                return;
            }

            mainFrm_DS = LoadDataForWording.LoadDataFromDB(this.sendEmail_rtbSql.Text, sourceDB);
            var gridFrm = new GridForm();
            gridFrm.bindEmail += new GridForm.BindEmailHandle(sendEmail_bindEmail_fromGridForm);
            gridFrm.Show();
        }

        private void sendEmail_bindEmail_fromGridForm(string subject, string body)
        {
            this.sendEmail_txtSubject.Text = subject;
            this.sendEmail_txtContent.Text = body;
        }

        private void sendEmail_btnSend_Click(object sender, EventArgs e)
        {
            string to = string.Empty;
            for (int i = 0; i < sendEmail_clbTo.Items.Count; i++)
            {
                if (sendEmail_clbTo.GetItemChecked(i))
                {
                    to += (string.IsNullOrEmpty(to) ? "" : ";") + this.sendEmail_clbTo.GetItemText(sendEmail_clbTo.Items[i]);
                }
            }

            if (!string.IsNullOrEmpty(this.sendEmail_txtCC.Text.Trim()))
            {
                to += string.IsNullOrEmpty(to)?"":";" +this.sendEmail_txtCC.Text.Trim();
            }

            if (string.IsNullOrEmpty(to))
            {
                MessageBox.Show("Please input to address!");
                return;
            }

            int port = 25;
            string bcc = "";
            string cc = "";
            string replyToEmail = "";

            //string to = this.txtSendEmail_To.Text;
            string subject = this.sendEmail_txtSubject.Text;
            string body = this.sendEmail_txtContent.Text;

            try
            {
                string from = string.Empty;
                string host = string.Empty;
                string username = string.Empty;
                string password = string.Empty;
                if (this.sendEmail_rb126.Checked)
                {
                    from = "ifelse01@126.com";
                    host = "smtp.126.com";
                    username = "ifelse01@126.com";
                    password = "012345";
                }
                else
                {
                    from = "vm@jobsdb.com";
                    host = ConfigurationManager.AppSettings["EmailServer_VMIP"].ToString();
                    if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["EmailServer_VMUser"]))
                    {
                        username = ConfigurationManager.AppSettings["EmailServer_VMUser"].ToString();
                    }
                    if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["EmailServer_VMPWD"]))
                    {
                        username = ConfigurationManager.AppSettings["EmailServer_VMPWD"].ToString();
                    }
                }
                KernelClass.MailHelper_V2.SendMailMessage(from, to, bcc, cc, subject, body, replyToEmail, host, port, username, password);
                MessageBox.Show("Send successed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.ToString());
            }
        }

        private void txtSendEmail_To_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);
        }

        private void txtSendEmail_Subject_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);
        }

        private void txtSendEmail_Content_KeyDown(object sender, KeyEventArgs e)
        {
            selectAllText(sender, e);
        }

        #endregion

        #region gen auth
        private void others_lbSqlQuery_Click(object sender, EventArgs e)
        {
            if (htConfig.ContainsKey("GenAuth_QueryRMS"))
            {
                this.others_rtbResult.Text = htConfig["GenAuth_QueryRMS"].ToString();
            }
        }

        private void others_rbAuthType_Employer_CheckedChanged(object sender, EventArgs e)
        {
            others_rbAuthType_Change(true);
        }

        private void others_rbAuthType_JobSeeker_CheckedChanged(object sender, EventArgs e)
        {
            others_rbAuthType_Change(false);
        }

        private void others_rbAuthType_Change(bool isEmployer)
        {
            try
            {
                this.others_cbAccount.Enabled = isEmployer;
                this.others_txtEmployerId.Enabled = isEmployer;
                this.others_txtUserManagementId.Enabled = isEmployer;
                this.others_txtJobSeekerId.Enabled = !isEmployer;
            }
            catch { }
        }

        private void others_cbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectItem accountInfo = (SelectItem)this.others_cbAccount.SelectedItem;
            if (accountInfo == null)
                return;
            this.others_txtEmployerId.Text = accountInfo.EmployerId;
            this.others_txtUserManagementId.Text = accountInfo.UserManagementId;
            this.others_cbCountryCode.Text = accountInfo.CountryCode;
            if (accountInfo.Environment == Option.EnvironmentType.Dev.ToString())
            {
                this.others_rbEnv_Dev.Checked = true;
            }
            else if (accountInfo.Environment == Option.EnvironmentType.Test.ToString())
            {
                this.others_rbEnv_Test.Checked = true;
            }
            else if (accountInfo.Environment == Option.EnvironmentType.Preview.ToString())
            {
                this.others_rbEnv_Preview.Checked = true;
            }
            else if (accountInfo.Environment == Option.EnvironmentType.Production.ToString())
            {
                this.others_rbEnv_Production.Checked = true;
            }
        }

        private void others_btnGetAuthInfo_Click(object sender, EventArgs e)
        {
            AuthenTicketType authenTicketType = AuthenTicketType.External;
            if (this.others_rbAuthenTicketType_Unknow.Checked)
            {
                authenTicketType = AuthenTicketType.Unknown;
            }
            else if (this.others_rbAuthenTicketType_SIS.Checked)
            {
                authenTicketType = AuthenTicketType.SIS;
            }
            string baseUrl = string.Empty;
            string employerId = this.others_txtEmployerId.Text.Trim();
            string userManagementId = this.others_txtUserManagementId.Text.Trim();
            string jobSeekerId = this.others_txtJobSeekerId.Text.Trim();
            string result = string.Empty;
            if (this.others_rbAuthType_Employer.Checked)
            {
                if (string.IsNullOrEmpty(employerId) || string.IsNullOrEmpty(userManagementId))
                {
                    MessageBox.Show("Please input EmployerId and UserManagementId first");
                    return;
                }
                result = AuthenticationUtility.GetEmployerAccountUserLoginUrlWithAuthenticationInfo(Convert.ToInt32(employerId), Convert.ToInt32(userManagementId), baseUrl, authenTicketType);
            }
            else if (this.others_rbAuthType_JobSeeker.Checked)
            {
                if (string.IsNullOrEmpty(jobSeekerId))
                {
                    MessageBox.Show("Please input JobSeekerId first");
                    return;
                }
                var map = AuthenticationUtility.GetJobSeekerAuthenticateQueryStringArguments(jobSeekerId, authenTicketType);
                result = CommonHelper.ComposeHyperLink(baseUrl, map);
            }
            this.others_rtbResult.Text = result;
        }

        private void others_btnAdditionDomain_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.others_rtbResult.Text.Trim()))
            {
                MessageBox.Show("Please get authentication info first");
                return;
            }
            string countryCode = this.others_cbCountryCode.Text.Trim();
            countryCode = string.IsNullOrEmpty(countryCode) ? Option.Country.HK.ToString() : countryCode;
            string env = Option.EnvironmentType.Dev.ToString();
            if (this.others_rbEnv_Test.Checked)
            {
                env = Option.EnvironmentType.Test.ToString();
            }
            else if (this.others_rbEnv_Preview.Checked)
            {
                env = Option.EnvironmentType.Preview.ToString();
            }
            else if (this.others_rbEnv_Production.Checked)
            {
                env = Option.EnvironmentType.Production.ToString();
            }
            string loginType = "RMS";
            if (this.others_rbAuthType_JobSeeker.Checked)
            {
                loginType = "JobSeeker";
            }
            string configKey = "Url_{Env}_{CountryCode}_{LoginType}_Index"
                .Replace("{Env}", env)
                .Replace("{CountryCode}", countryCode)
                .Replace("{LoginType}", loginType);
            var appSettingKey = ConfigurationManager.AppSettings[configKey];
            if (appSettingKey == null)
            {
                MessageBox.Show("Please set appsetting key in config: " + configKey);
                return;
            }
            this.others_rtbResult.Text = Environment.NewLine + ConfigurationManager.AppSettings[configKey].ToString() + this.others_rtbResult.Text + Environment.NewLine;

        }

        #endregion

        private void extractdll_btnReorder_Click(object sender, EventArgs e)
        {
            IList<string> sourceList = this.extractdll_rtbSource.Text.Split('\n').ToList();
            this.extractdll_rtbSource.Text = string.Join("\n", sourceList.OrderBy(c => c));
        }

        private void extractdll_btnExtract_Click(object sender, EventArgs e)
        {
            IList<string> sourceList = this.extractdll_rtbSource.Text.Split('\n').ToList();
            IList<string> targetList = new List<string>();
            IList<string> dllList = new List<string>()
            {
                "/JobsDB.Web/bin/JobsDB.Common.dll"
            };
            foreach (var item in sourceList)
            {
                if (!targetList.Contains("/JobsDB.Web/bin/JobsDB.Common.dll") && item.IndexOf("JobsDB.Common/") > 0)
                {
                    targetList.Add("/JobsDB.Web/bin/JobsDB.Common.dll");
                }
            }
            this.extractdll_Result.Text = string.Join("\n", targetList.OrderBy(c => c));
        }


    }

    #region public class or enum
    public class SelectItem
    {
        public string Name { get; set; }
        public string Value { get; set; }

        //for operate db account info
        public string AccountNum { get; set; }
        public string SubAccount { get; set; }
        public string EmployerId { get; set; }
        public string InvoiceItemID { get; set; }
        public string CountryCode { get; set; }
        public string ToCountryCode { get; set; }
        public string JobAdId { get; set; }
        public string JobTitle { get; set; }
        public string UserManagementId { get; set; }
        public string Environment { get; set; }
        public string ItemType { get; set; }

        //for solr
        public string SolrUrl { get; set; }
        public string IdString { get; set; }
        public string SolrQueryUrl { get; set; }
        public string SolrQuery { get; set; }
        public string XmlFilePath { get; set; }
        public string SqlQuery { get; set; }
        public string ConnStr { get; set; }
        public string ProviderName { get; set; }

    }
    
    public class Abbreviation
    {
        public string ClassName { get; set; }
        public string FieldName { get; set; }
    }

    internal class ConnectionStr
    {
        // Fields
        private string _ConnectionString;
        private string _Key;

        // Methods
        public ConnectionStr(string name, string connectionString)
        {
            this.Key = name;
            this.ConnectionString = connectionString;
        }

        // Properties
        public string ConnectionString { get; set; }
        public string Key { get; set; }
    }

    public partial class Option
    {
        public enum CountryOfResidence
        {
            HK = 2,
            //Indonesia
            ID = 4,
            TH = 10,
            SG = 8,
        }
        public enum Country
        {
            XX = 1,
            AU = 2,
            HK = 4,
            IN = 5,
            ID = 6,
            KR = 7,
            MY = 8,
            PH = 9,
            SG = 10,
            TW = 11,
            TH = 12,
            US = 13,
        }
        public enum Language
        {
            XX = 1,
            EN = 2,
            TH = 3,
            MS = 4,
            ID = 5,
        }
        public enum WordingGroup
        {
            Warning = 1,
            Label = 2,
            Tip = 3,
            Button = 4,
            Validation = 5,
            MultipleValue = 6,
            Error = 7,
            Reflection = 8,
            Option = 9,
            Code = 10,
            Title = 11,
            Description = 12,
            Data = 13,
        }

        public enum TaskType
        {
            NewRMS = 1,
            Normal = 2,
            Bug = 3,
            Issue = 4,
        }

        public enum ProfilePrivacyLevel
        {
            Open = 1,
            Limited = 2,
            Hidden = 3,
        }

        public enum EnvironmentType
        {
            Dev = 1,
            Test = 2,
            Preview = 3,
            Production = 4
        }

        public enum ItemType
        {
            All = 1,
            DB = 2,
            Auth = 3
        }
    }

    public enum ScriptObj
    {
        All = 1,
        OnlyList = 2,
        IgnoreList = 3
    }

    public class ScriptParams
    {
        public ScriptParams()
        {
            this.NameList = new List<string>();
        }
        public bool IsScriptSchema { get; set; }
        public bool IsScriptDrops { get; set; }
        public bool IsScriptData { get; set; }
        public ScriptObj ScriptObj { get; set; }
        public List<string> NameList { get; set; }

    }
    #endregion
}
