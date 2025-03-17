namespace DSA;
class Program
{
    static void Main(string[] args)
    {
        int size = 10;
        Queue queue = new Queue(size);
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);

        queue.Dequeue();
        queue.Dequeue();

        queue.Peek();
    }

}
