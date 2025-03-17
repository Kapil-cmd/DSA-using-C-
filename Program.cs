namespace DSA;
class Program
{
    static void Main(string[] args)
    {
        BinarySearchTree tree = new BinarySearchTree();
        tree.Insert(10, "Messi");
        tree.Insert(7, "Ronaldo");
        tree.Insert(11, "Neymar");
        tree.Insert(4, "Ramos");
        Console.WriteLine(tree.Find(7));
    }

}
