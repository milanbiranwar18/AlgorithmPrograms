namespace AlgorithmPrograms
{
    public class Program
    {
        public static void Main(string [] args)
        {
            Console.WriteLine(" Wellcome to the Algorithm Problems");

            InsertionSort sort = new InsertionSort();
            sort.CheckSorting();

            BubbleSort bsort = new BubbleSort();
            bsort.Sorting();


        }
    }
}
