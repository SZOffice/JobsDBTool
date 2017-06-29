using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JobsDBTool.Helper
{
    public class TreeViewData
    {
        Object id;
        public Object Id
        {
            get { return id; }
            set { id = value; }
        }

        Object name;
        public Object Name
        {
            get { return name; }
            set { name = value; }
        }

        Object pId;
        public Object PId
        {
            get { return pId; }
            set { pId = value; }
        }
    }

    public class TreeViewTool
    {
        public static int pId = 0;
        //  public static List<TreeViewData> ConvertToTreeViewData(
        /// <summary>
        /// 向TreeView填充数据
        /// </summary>
        /// <param name="treeView"></param>
        /// <param name="treeDatas">要填充的数据</param>
        /// <param name="pId">最高类别的父类别</param>
        /// <returns></returns>
        public static bool InsertDataToTreeView(TreeView treeView, List<TreeViewData> treeDatas, int pId)
        {
            TreeViewTool.pId = pId;
            int len = treeDatas.Count;
            int j = 0;
            for (int i = 0; i < len; i++)
            {
                if ((int)treeDatas[i].PId == pId)
                {
                    treeView.Nodes.Add(treeDatas[i].Name.ToString());
                    treeView.Nodes[j].Tag = treeDatas[i].Id;
                    j++;
                }
            }
            for (int i = 0; i < treeView.Nodes.Count; i++)
            {
                TempTreeView(treeView.Nodes[i], treeDatas);
            }
            return false;
        }

        private static void TempTreeView(TreeNode tn, List<TreeViewData> treeDatas)
        {
            int len = treeDatas.Count;
            int j = 0;
            for (int i = 0; i < len; i++)
            {
                if ((int)treeDatas[i].PId != pId)
                {
                    if ((int)treeDatas[i].PId == (int)tn.Tag)
                    {
                        tn.Nodes.Add(treeDatas[i].Name.ToString());
                        tn.Nodes[j].Tag = treeDatas[i].Id;
                        TempTreeView(tn.Nodes[j], treeDatas);
                        j++;
                    }
                }
            }
        }
    }
}
