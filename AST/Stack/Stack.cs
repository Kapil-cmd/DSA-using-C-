namespace DSA
{
    public class Stack
    {
        public int MaxSize {  get; set; }
        public string[] StackArray { get; set; }

        public int Top { get; set; }

        public Stack(int size)
        {
            this.MaxSize = size;

            this.StackArray = new string[MaxSize];
            Top = -1;
        }
    }
}
