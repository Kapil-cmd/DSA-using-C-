namespace DSA
{
    public class Node
    {
        public int Data {  get; set; }
        public Node? next {  get; set; }

        public void DisplayNode()
        {
            Console.WriteLine(Data);
        }
    }
}
