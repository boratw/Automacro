namespace Automacro
{
    partial class Form_Main
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("2");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("3");
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("노드4");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("노드5");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("노드0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("노드1");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("노드2");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("노드3");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_scripts_new = new System.Windows.Forms.Button();
            this.button_scripts_load = new System.Windows.Forms.Button();
            this.button_scripts_delete = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1197, 658);
            this.splitContainer1.SplitterDistance = 399;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listView1);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            this.splitContainer2.Size = new System.Drawing.Size(399, 658);
            this.splitContainer2.SplitterDistance = 291;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_scripts_new);
            this.panel1.Controls.Add(this.button_scripts_load);
            this.panel1.Controls.Add(this.button_scripts_delete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 32);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "스크립트 목록";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_scripts_new
            // 
            this.button_scripts_new.BackColor = System.Drawing.Color.White;
            this.button_scripts_new.BackgroundImage = global::Automacro.Properties.Resources.file;
            this.button_scripts_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_scripts_new.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_scripts_new.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_scripts_new.FlatAppearance.BorderSize = 2;
            this.button_scripts_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_scripts_new.Location = new System.Drawing.Point(301, 0);
            this.button_scripts_new.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_scripts_new.Name = "button_scripts_new";
            this.button_scripts_new.Size = new System.Drawing.Size(32, 32);
            this.button_scripts_new.TabIndex = 2;
            this.button_scripts_new.UseVisualStyleBackColor = false;
            // 
            // button_scripts_load
            // 
            this.button_scripts_load.BackColor = System.Drawing.Color.White;
            this.button_scripts_load.BackgroundImage = global::Automacro.Properties.Resources.open;
            this.button_scripts_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_scripts_load.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_scripts_load.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_scripts_load.FlatAppearance.BorderSize = 2;
            this.button_scripts_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_scripts_load.Location = new System.Drawing.Point(333, 0);
            this.button_scripts_load.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_scripts_load.Name = "button_scripts_load";
            this.button_scripts_load.Size = new System.Drawing.Size(32, 32);
            this.button_scripts_load.TabIndex = 1;
            this.button_scripts_load.UseVisualStyleBackColor = false;
            // 
            // button_scripts_delete
            // 
            this.button_scripts_delete.BackColor = System.Drawing.Color.White;
            this.button_scripts_delete.BackgroundImage = global::Automacro.Properties.Resources.paper_bin;
            this.button_scripts_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_scripts_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_scripts_delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_scripts_delete.FlatAppearance.BorderSize = 2;
            this.button_scripts_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_scripts_delete.Location = new System.Drawing.Point(365, 0);
            this.button_scripts_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_scripts_delete.Name = "button_scripts_delete";
            this.button_scripts_delete.Size = new System.Drawing.Size(32, 32);
            this.button_scripts_delete.TabIndex = 0;
            this.button_scripts_delete.UseVisualStyleBackColor = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.treeView1);
            this.splitContainer3.Size = new System.Drawing.Size(794, 658);
            this.splitContainer3.SplitterDistance = 530;
            this.splitContainer3.SplitterWidth = 6;
            this.splitContainer3.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(0, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(397, 257);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 40;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(231, 191);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "노드4";
            treeNode1.Text = "노드4";
            treeNode2.Name = "노드5";
            treeNode2.Text = "노드5";
            treeNode3.Name = "노드0";
            treeNode3.Text = "노드0";
            treeNode4.Name = "노드1";
            treeNode4.Text = "노드1";
            treeNode5.Name = "노드2";
            treeNode5.Text = "노드2";
            treeNode6.Name = "노드3";
            treeNode6.Text = "노드3";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(486, 296);
            this.treeView1.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1197, 658);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_scripts_delete;
        private System.Windows.Forms.Button button_scripts_new;
        private System.Windows.Forms.Button button_scripts_load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

