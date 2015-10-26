using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace YongFa365.Controls.ComboBoxTree
{
    public class ComboBoxTree : DropDownPanel
    {
        public ComboBoxTree() : base()
        {
            // The base class's property must be set because
            // this derived implementation hides the setter.
            base.DropDownControl = new DropDownTree();
            this.DropDownControl.BorderStyle = BorderStyle.None;
        }

        private new DropDownTree DropDownControl
        {
            get
            {
                if (base.DropDownControl != null)
                {
                    return base.DropDownControl as DropDownTree;
                }

                return null;
            }
        }

        private DropDownNode DropDownNodeValue
        {
            get
            {
                if (this.DropDownControl != null)
                {
                    return this.DropDownControl.Value as DropDownNode;
                }

                return null;
            }
            set
            {
                base.Value = value;
                DropDownControl.SelectedNode = SearchNode(DropDownControl.Nodes, value);
            }
        }

        private TreeNode SearchNode(TreeNodeCollection Nodes, DropDownNode SearchFor)
        {
            if (SearchFor != null)
            {
                foreach (DropDownNode node in Nodes)
                {
                    if (node.Id == SearchFor.Id)
                    {
                        return node;
                    }
                    else
                    {
                        TreeNode found = SearchNode(node.Nodes, SearchFor);

                        if (found != null)
                        {
                            return found;
                        }
                    }
                }
            }

            return null;
        }

        public new string Value
        {
            get
            {
                try
                {
                    return DropDownNodeValue.Id.ToString();
                }
                catch (Exception ex)
                {

                    return ex.Message;
                }

            }
        }


        public new string Text
        {

            get
            {
                try
                {
                    return DropDownNodeValue.Text;
                }
                catch (Exception ex)
                {

                    return ex.Message;
                }


            }

        }

        /// <summary>
        /// 返回结点全路径
        /// </summary>
        public string FullPath
        {
            get
            {
                try
                {
                    return DropDownControl.FullPath;
                }
                catch (Exception ex)
                {

                    return ex.Message;
                }
            }
        }


        /// <summary>
        /// 根据值来查找
        /// </summary>
        /// <param name="value">值</param>
        /// <param name="text">Text可以随便写,当然，最好是什么就写什么</param>
        public void SelectedByValue(object value, object text)
        {
            DropDownNodeValue = new DropDownNode(Convert.ToInt32(value), text.ToString());
        }




        /// <summary>
        /// 填充Tree
        /// </summary>
        /// <param name="ParentID">父级编号</param>
        /// <param name="dt">格式，三列，Id,Name,ParentId,只要顺序一样就可以了</param>
        public void Fill(DataTable dt, object ParentID)
        {

            DropDownControl.Size = new Size(200, 300);



            DataTable temptbl = dt.Copy();
            DataView viewinfo = new DataView(temptbl);
            viewinfo.RowFilter = temptbl.Columns[2].ColumnName + " = " + ParentID;

            DropDownTree tree = DropDownControl;

            //DropDownNode root = new DropDownNode(-1, "==请选择==");
            //tree.Nodes.Clear();
            //tree.Nodes.Add(root);


            if (viewinfo.Count > 0)
            {
                foreach (DataRowView drv in viewinfo)
                {
                    DropDownNode node = new DropDownNode(Convert.ToInt32(drv[0]), drv[1].ToString());
                    tree.Nodes.Add(node);
                    ComboBoxTreeTree(node, drv[0], drv, dt);
                }
            }
            if (tree.Nodes.Count > 0)
            {
                tree.Nodes[0].Expand();
                SelectedByValue(viewinfo[0][0], viewinfo[0][1]);
            }

            //cbxTree.SelectedByValue(1, "==请选择==");
        }

        private void ComboBoxTreeTree(DropDownNode ParentNode, object ParentID, DataRowView ParentDV, DataTable dt)
        {
            DataTable temptbl = dt.Copy();
            DataView viewinfo = new DataView(temptbl);
            viewinfo.RowFilter = temptbl.Columns[2].ColumnName + " = " + ParentID;
            foreach (DataRowView drv in viewinfo)
            {
                DropDownNode node2 = new DropDownNode(Convert.ToInt32(drv[0]), drv[1].ToString());
                ParentNode.Nodes.Add(node2);
                ComboBoxTreeTree(node2, drv[0], drv, dt);
            }
        }

    }
}
