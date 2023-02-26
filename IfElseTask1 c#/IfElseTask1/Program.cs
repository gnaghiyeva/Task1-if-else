namespace IfElseTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.Write("mebleg:");
            double mebleg = double.Parse(Console.ReadLine());

       
            double result;

            if (mebleg < 100)
            {

                result = mebleg - (mebleg * 0.05);
                Console.WriteLine("5%-li endirim"+" "+ result);
            }

            else if(mebleg >= 100 && mebleg <= 1000)
            {
                result = mebleg - (mebleg * 0.08);
                Console.WriteLine("8%-li endirim" + " " + result);
            }

            else
            {
                result = mebleg - (mebleg * 0.10);
                Console.WriteLine("10%-li endirim" + " " + result);
            }

        }
    }
}