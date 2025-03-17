

namespace DSA
{
    public class BinarySearch
    {
        public int[] Array { get; set; }
        public int Value { get; set; }

        public BinarySearch(int[] array, int value)
        {
            this.Array = array;
            this.Value = value;
        }
        public int Search(int[] array, int value)
        {
            int start = 0;
            int last = array.Length;
            while (start < last)
            {
                int midPoint = (start + last) / 2;

                if (array[midPoint] == Value)
                {
                    return midPoint;
                }
                else if(array[midPoint] > Value) 
                {
                    start = midPoint + 1;
                }
                else
                {
                    last = midPoint;
                }
            }
                return value;
        }
    }
}
