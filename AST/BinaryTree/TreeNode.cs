namespace DSA
{
    public class TreeNode
    {
        public int Key { get; set; }
        public string String { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }
        public TreeNode(int key, string value) 
        {
            this.Key = key;
            this.String = value;
        }

    }
}
