namespace DSA
{
    public class Stack
    {
        public int MaxSize { get; set; }
        public string[] StackArray { get; set; }

        public int Top { get; set; }

        public Stack(int size)
        {
            this.MaxSize = size;

            this.StackArray = new string[MaxSize];
            Top = -1;
        }
        public void Push(string item)
        {
            Top++;
            StackArray[Top] = item;
        }
        public string Pop()
        {
            //Think placeholder
            int old_top = Top;
            //Decrement for the new top
            Top--;
            return StackArray[old_top];
        }
        public string Peek()
        {
            return StackArray[Top];
        }

        public bool isEmpty()
        {
            return Top == 0;
        }

        public bool isFull()
        {
            return (MaxSize -1 == Top) ;
        }
    }
}
