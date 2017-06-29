using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JobsDBTool.SubForms
{
    public partial class GridForm : Form
    {
        public GridForm()
        {
            InitializeComponent();

            this.gv_Result.DataSource = mainFrm.mainFrm_DS.Tables[0];
            if(this.gv_Result.Columns.Count>0)
                this.gv_Result.Columns[0].Width = 150;
            if (this.gv_Result.Columns.Count > 1)
                this.gv_Result.Columns[1].Width = 200;
            if (this.gv_Result.Columns.Count > 2)
                this.gv_Result.Columns[2].Width = 200;
            if (this.gv_Result.Columns.Count > 4)
                this.gv_Result.Columns[4].Width = 160;
        }

        public delegate void BindEmailHandle(string subject, string body);
        public event BindEmailHandle bindEmail;
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string[] str = new string[gv_Result.Rows.Count];
            for (int i=0; i < gv_Result.Rows.Count; i++)
            {
                if (gv_Result.Rows[i].Selected == true)
                {
                    //mainFrm.mainFrm_SendEmail_Subject = gv_Result.Rows[i].Cells[2].Value.ToString();
                    //mainFrm.mainFrm_SendEmail_Body = gv_Result.Rows[i].Cells[3].Value.ToString();
                    bindEmail(gv_Result.Rows[i].Cells[1].Value.ToString(), gv_Result.Rows[i].Cells[2].Value.ToString());
                    this.Close();
                }
            }
        }


    }
}
