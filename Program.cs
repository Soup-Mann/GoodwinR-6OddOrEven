//Reed Goodwin
//10-19-2022
//Odd or even
//says if a  number is either even or odd



Console.Clear();
bool game = true;
long validnum = 0;
bool number2;
long num;


while (game)
{
    Console.WriteLine("Please Enter a number");
    string nuts = Console.ReadLine();


    number2 = Int64.TryParse(nuts, out validnum);
    if (number2 == true)
    {
        num = Convert.ToInt64(nuts);
        
        if (num % 2 == 0)
        {
            Console.WriteLine("");
            Console.WriteLine("This number is even");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Your Number is Odd");
        }
        Console.WriteLine("");
        Console.WriteLine("Do you want to play again? yes or no?");
        string userinput = Console.ReadLine().ToLower();

        if (userinput == "no")
        {
           Console.WriteLine("");
           Console.WriteLine("Thanks for playing!");
            game = false;
        }
    }
    else
    {
        Console.WriteLine("Invalid entry, please try again");
    }


}