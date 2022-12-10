namespace Yash_meselesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int birth_day, birth_month, birth_year;
            int current_day, current_month, current_year;
            int age;
            Console.WriteLine("Enter birth day, month and year");
            birth_day = int.Parse(Console.ReadLine());
            birth_month = int.Parse(Console.ReadLine());
            birth_year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter current day, month and year");
            current_day = int.Parse(Console.ReadLine());
            current_month = int.Parse(Console.ReadLine());
            current_year = int.Parse(Console.ReadLine());
            age = current_year - birth_year;
            if (birth_month > current_month) age -= 1;
            if (birth_month == current_month)
            {
                if (birth_day > current_day) age -= 1;
            }
                if (age > 1) Console.WriteLine(age);
                if (age <= 0) Console.WriteLine("yashi tamam olmayib");
            


         }
    }
}