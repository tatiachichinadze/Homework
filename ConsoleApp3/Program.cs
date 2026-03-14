using System;

//დაწერეთ კონსოლური აპლიკაცია რომელიც შავი ეკრანიდან მიიღებს ორ input-ს და ეკრანზსე დაბეჭდავს იმას რომელიც უფრო მეტია

//class Program
//{
//    static void Main()
//    {
//        int a = int.Parse(Console.ReadLine());
//        int b = int.Parse(Console.ReadLine());

//        if (a > b)
//            Console.WriteLine(a);
//        else
//            Console.WriteLine(b);
//    }
//}

//დაწერეთ კონსულირი აპლიკაცია რომელიც შავი ეკრანიდან მიიღებს რაიმე input-ს და დაბეჭდავს მასზე მცირე ყველა კენტ რიცხვს. მაგ: 12-> 1, 3, 5, 7, 9, 11

//class Program
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());

//        for (int i = 1; i < n; i += 2)
//        {
//            Console.Write(i + " ");
//        }
//    }
//}

//დაწერეთ კონსულური აპლიკაცია რომელიც გადაწოდებულ რიცხვზე გვეტყვუს მარტივია თუ შდგენილი.

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine("Composite");
                return;
            }
        }

        Console.WriteLine("Prime");
    }
}

