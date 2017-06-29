using JobsDBTool.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace JobsDBTool.SubForms
{
    public partial class TaskForm : Form
    {
        public static string sqlitConnKeyName = mainFrm.sqlitConnKeyName;
        public static string sqliteConn = mainFrm.sqliteConn;
        private static PetaPoco.Database db = new PetaPoco.Database(sqlitConnKeyName);

        public TaskForm()
        {
            InitializeComponent();

            foreach (var obj in Enum.GetValues(typeof(TaskStatus)))
            {
                cbStatus.Items.Add(obj.ToString());
            }
            string defaultStatus = TaskStatus.Draft.ToString();
            if (mainFrm.mainFrm_TaskId != default(int))
            {
                var task = db.Query<Task>("SELECT * FROM Task Where Id=" + mainFrm.mainFrm_TaskId).FirstOrDefault();
                if (task != null)
                {
                    this.txtTitle.Text = task.Title;
                    this.txtUrl.Text = task.Url;
                    this.txtSummary.Text = task.Summary;
                    this.txtRemark.Text = task.Remark;
                    defaultStatus = task.Status;
                }
            }

            if (cbStatus.Items.Count > 0)
                cbStatus.SelectedItem = defaultStatus;

        }

        public delegate void ReLoadTask();
        public event ReLoadTask reloadTask;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtTitle.Text.Trim()))
            {
                return;
            }

            string status = this.cbStatus.Text.Trim();
            Task task = new Task();
            if (mainFrm.mainFrm_TaskId != default(int))
            {
                task = db.Query<Task>("SELECT * FROM Task Where Id=" + mainFrm.mainFrm_TaskId).FirstOrDefault();
                if (status != task.Status)
                {
                    TaskLog taskLog = new TaskLog()
                    {
                        TaskId = task.Id,
                        Remark = string.Format("update status from {0} to {1}", task.Status, status),
                        CreatedTime = DateTime.Now
                    };
                    db.Insert("TaskLog", "TaskId", taskLog);
                }
            }

            task.Title = this.txtTitle.Text.Trim();
            task.Url = this.txtUrl.Text.Trim();
            task.Summary = this.txtSummary.Text.Trim();
            task.Remark = this.txtRemark.Text.Trim();
            task.Status = status;
            task.LastModifiedTime = DateTime.Now;
            if (status == TaskStatus.Submitted.ToString())
            {
                task.SubmittedTime = DateTime.Now;
            }

            if (mainFrm.mainFrm_TaskId != default(int))
            {
                //task.Id = Convert.ToInt32(mainFrm.mainFrm_TaskId);
                db.Update("Task", "Id", task);
            }
            else
            {
                task.CreatedTime = DateTime.Now;
                db.Insert("Task", "Id", task);
            }

            reloadTask();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
