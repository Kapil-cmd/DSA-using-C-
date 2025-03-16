namespace DSA;
class Program
{
    static void Main(string[] args)
    {
        int size = 10;
        Stack stack = new Stack(size);

        for (int i = 0; i < 3; i++)
        {
            stack.Push("Ronaldo");
            stack.Push("Bale");
            stack.Push("Benzema");
        }
        stack.Pop();
        stack.Peek();
        while (!stack.isEmpty())
        {
            var value = stack.Pop();
            Console.WriteLine(value);
        }

    }

}
