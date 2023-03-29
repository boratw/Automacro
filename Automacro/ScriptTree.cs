using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automacro
{
    class ScriptTree
    {
        TreeView treeview = null;
        public ScriptTree(TreeView treeview)
        {
            this.treeview = treeview;
        }

        public void NewScript()
        {
            TreeNode node = new TreeNode("스크립트", 0, 0);
            node.Tag = new Script();
            treeview.Nodes.Add(node);
        }
        public void NewFolder()
        {
            TreeNode node = new TreeNode("폴더", 1, 1);
            treeview.Nodes.Add(node);
        }
    }
}
