namespace leapyear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int leapyear=int.Parse(Console.ReadLine());
            if ((leapyear % 4 == 0 && leapyear % 100 != 0) || (leapyear % 400 == 0))
                Console.WriteLine($"{leapyear}is a leap year");
            else
                Console.WriteLine($"{leapyear} is a not leap year");
            Console.ReadLine();


            
        }
    }
}