using System; 

    class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        Console.WriteLine("What is your age?");
        string age = Console.ReadLine();
        int number = int.Parse(age);

        Console.WriteLine("What is your eye color?");
        string eyeColor = Console.ReadLine();

        Console.WriteLine("What is your hair color?");
        string hairColor = Console.ReadLine();

        Console.WriteLine("What about your shoe size?");
        string shoeSize = Console.ReadLine();

        Console.WriteLine("Favorite color?");
        string favColor = Console.ReadLine();

        Console.WriteLine("What's your favorite show or movie?");
        string favShow = Console.ReadLine();

        Console.WriteLine("Who is your favorite teacher?");
        string favTeacher = Console.ReadLine();

        Console.WriteLine("Your Favorite class?");
        string favClass = Console.ReadLine();

        Console.WriteLine("Yer favite Oliday?");
        string favHoliday = Console.ReadLine();

        Console.WriteLine("What Season do you prefer?");
        string favSeason = Console.ReadLine();

        Console.WriteLine("Dream Job?");
        string favJob = Console.ReadLine();

        Console.WriteLine("How many siblings you got?");
        string howMany = Console.ReadLine();

        Console.WriteLine("Your name is " + name + " and you are " + age + " years old currently. Your eye color is " + eyeColor + " and hair color is " + hairColor 
        + " unless you are bald. Your shoe size is " + shoeSize + " and your favorite color is " + favColor + " while your favorite show or movie is " + favShow 
        + "? very cool. Your favorite Teacher is " + favTeacher + " but your favorite class is " + favClass + ". Your favorite holiday is " + favHoliday 
        + " but your favorite season is " + favSeason + ". You want your job to be " + favJob + " and you have " + howMany + " siblings. You will be " + (number + 5) 
        + "years old in 5 years by the way.");










    }

}


