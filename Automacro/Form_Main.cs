using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Automacro
{
    public partial class Form_Main : Form
    {
        ScriptTree scriptTree = null;
        public Form_Main()
        {
            InitializeComponent();
        }


        private void Form_Main_Load(object sender, EventArgs e)
        {
            scriptTree = new ScriptTree(treeView_scripts);
        }


        private void treeView_scripts_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);

        }

        private void treeView_scripts_DragDrop(object sender, DragEventArgs e)
        {
            Point targetPoint = treeView_scripts.PointToClient(new Point(e.X, e.Y));
            TreeNode targetNode = treeView_scripts.GetNodeAt(targetPoint);
            if (targetNode.ImageIndex == 1)
            {
                TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

                if (!draggedNode.Equals(targetNode) && !ContainsNode(draggedNode, targetNode))
                {
                    draggedNode.Remove();
                    targetNode.Nodes.Add(draggedNode);
                    targetNode.Expand();
                }
            }
        }

        private void treeView_scripts_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;


        }

        private void treeView_scripts_DragOver(object sender, DragEventArgs e)
        {
            Point targetPoint = treeView_scripts.PointToClient(new Point(e.X, e.Y));
            TreeNode node = treeView_scripts.GetNodeAt(targetPoint);
            if (node.ImageIndex == 1)
                treeView_scripts.SelectedNode = node;
            else
                treeView_scripts.SelectedNode = null;
        }

        private bool ContainsNode(TreeNode node1, TreeNode node2)
        {
            if (node2.Parent == null) return false;
            if (node2.Parent.Equals(node1)) return true;
            return ContainsNode(node1, node2.Parent);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            scriptTree.NewScript();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            scriptTree.NewFolder();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
