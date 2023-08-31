namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rootPath = @"C:\Users\Print01\Desktop";
            DirectoryInfo root = new DirectoryInfo(rootPath);
            TreeNode child = new TreeNode(root.Name);

            PrintTree(child, root, 0);
        }

        private void PrintTree(TreeNode parent, DirectoryInfo directory, int level)
        {
            DirectoryInfo[] directories = directory.GetDirectories();
            for (int i = 0; i < directories.Length; i++)
            {
                TreeNode child = new TreeNode(directories[i].Name);
                parent.Nodes.Add(child);
                PrintTree(child, directories[i], level + 1);
            }
            if (level == 0)
                treeView1.Nodes.Add(parent);
        }
    }
}