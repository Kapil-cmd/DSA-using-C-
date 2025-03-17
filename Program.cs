namespace DSA;
class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
        BinarySearch search = new BinarySearch(array,7);
        search.Search(array, 7);
    }

}
