namespace BlankCSDotNet8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now;
            DateTime target = new DateTime(2025,4,4,15,15,0);

            TimeSpan difference = current - target;
            Console.WriteLine(difference);

            while (true)
            {
                DateTime current2 = DateTime.Now;
                Console.WriteLine(difference);
                Thread.Sleep(1000);
            }


        }
    }
}
