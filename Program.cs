using System;
using System.Data.Common;

class Program


{           //Method for creating a list with all the operations and results
    static List<string> resList = new();
    //Method for not repeating the code
    private const string Instructions = "Press ENTER to go back to the main menu!";
    public static void Main(string[] args)

    {       //Welcome message for the user 
            //Introduction to project
        Console.WriteLine("Welcome to my minicalculator!");
        Console.WriteLine("Press ENTER and choose the right operation from the menu below: \n");
        Console.ReadLine();

        /* Meddelande för lärare:
        * Försökte att skriva menyn på första sidan men gick inte därför det behövs att
        * trycka på ENTER för att komma till menyn*/

        //Presentation of the menu
        string[] menuOptions = new string[] { "Addition +\t\t", "Substraction -\t\t", "Multiplication *\t\t", "Division /\t\t",
            "Previous operations\t\t" ,"Stop the program\t\t" }; // Variables with users choice

        int menuSelect = 0;




        while (true) //loop

        {    //Method for cleaning the screen
            Console.Clear();
            Console.CursorVisible = false; // Hide the cursor

            if (menuSelect == 0)
            {
                Console.WriteLine("**** " + menuOptions[0] + "<<---");
                Console.WriteLine(menuOptions[1]);
                Console.WriteLine(menuOptions[2]);
                Console.WriteLine(menuOptions[3]);
                Console.WriteLine(menuOptions[4]);
                Console.WriteLine(menuOptions[5]);


            }
            else if (menuSelect == 1)
            {
                Console.WriteLine(menuOptions[0]);
                Console.WriteLine("****" + menuOptions[1] + "<<---");
                Console.WriteLine(menuOptions[2]);
                Console.WriteLine(menuOptions[3]);
                Console.WriteLine(menuOptions[4]);
                Console.WriteLine(menuOptions[5]);


            }

            else if (menuSelect == 2)
            {
                Console.WriteLine(menuOptions[0]);
                Console.WriteLine(menuOptions[1]);
                Console.WriteLine("**** " + menuOptions[2] + "<<---");
                Console.WriteLine(menuOptions[3]);
                Console.WriteLine(menuOptions[4]);
                Console.WriteLine(menuOptions[5]);


            }

            else if (menuSelect == 3)
            {
                Console.WriteLine(menuOptions[0]);
                Console.WriteLine(menuOptions[1]);
                Console.WriteLine(menuOptions[2]);
                Console.WriteLine("**** " + menuOptions[3] + "<<---");
                Console.WriteLine(menuOptions[4]);
                Console.WriteLine(menuOptions[5]);


            }

            else if (menuSelect == 4)
            {
                Console.WriteLine(menuOptions[0]);
                Console.WriteLine(menuOptions[1]);
                Console.WriteLine(menuOptions[2]);
                Console.WriteLine(menuOptions[3]);
                Console.WriteLine("****" + menuOptions[4] + "<<---");
                Console.WriteLine(menuOptions[5]);


            }

            else if (menuSelect == 5)
            {
                Console.WriteLine(menuOptions[0]);
                Console.WriteLine(menuOptions[1]);
                Console.WriteLine(menuOptions[2]);
                Console.WriteLine(menuOptions[3]);
                Console.WriteLine(menuOptions[4]);
                Console.WriteLine("****" + menuOptions[5] + "<<---");

            }
            var keyPressed = Console.ReadKey();
            //Method that allows the arrow to move around the menu
            if (keyPressed.Key == ConsoleKey.DownArrow && menuSelect != menuOptions.Length - 1)
            {
                menuSelect++;
            }
            //Same menu 
            else if (keyPressed.Key == ConsoleKey.UpArrow && menuSelect >= 1)
            {
                menuSelect--;
            }
            else if (keyPressed.Key == ConsoleKey.Enter)
            {
                switch (menuSelect)
                {
                    case 0:
                        Addition();
                        break;
                    case 1:
                        Substraction();
                        break;
                    case 2:
                        Multiplication();
                        break;
                    case 3:
                        Division();
                        break;
                    case 4:
                        Previous();
                        break;
                    case 5:
                        Exit();
                        break;
                }

            }
            else
            {    // If the users selects invalid choice
                Console.Clear();
                Console.WriteLine("You have not make a valid choice!\nGo back to the main menu and make a new choice!");
                Console.WriteLine("Press Enter to go back to the main menu!");
                Console.ReadKey();
            }
        }
    }
    //Presenting the first choice of the menu
    //With the math formula for addition
    public static void Addition()

    {
        string value;
        do
        {
            int res;
            Console.WriteLine("---------------------");
            Console.Write("\n\nEnter the first value:");
            int num1 = Convert.ToInt32(Console.ReadLine());//method for letting the user to write his choice
            Console.Write("\nEnter the second value:");
            int num2 = Convert.ToInt32(Console.ReadLine());//method for letting the user to write his choice
            Console.WriteLine("Enter symbol + : ");
            string symbol = Console.ReadLine();//method for letting the user to write his choice


            //Method for returning the value
            switch (symbol)
            {
                case "+":
                    res = num1 + num2;//method for calculating the user selection
                    Console.WriteLine("\nTotal:" + res);
                    resList.Add($"{num1} + {num2} = {res}");
                    break;
            }

            Console.ReadLine();

            Console.WriteLine("Do you want to do another operation? Y/N");
            Console.WriteLine(Instructions);
            value = Console.ReadLine();
        }
        while (value == "y" || value == "Y");
        //Console.WriteLine(Instructions);
        //Console.ReadLine();

    }

    //Presenting the second choice of the menu
    //With the math formula for substraction
    public static void Substraction()
    {
        string value;
        do
        {
            int res;
            Console.WriteLine("---------------------");
            Console.Write("\n\nEnter the first value:");
            int num1 = Convert.ToInt32(Console.ReadLine());//method for letting the user to write his choice
            Console.Write("\nEnter the second value:");
            int num2 = Convert.ToInt32(Console.ReadLine());//method for letting the user to write his choice
            Console.WriteLine("Enter symbol - : ");
            string symbol = Console.ReadLine();//method for letting the user to write his choice

            switch (symbol)
            {
                case "-":
                    res = num1 - num2;//method for calculating the user selection
                    Console.WriteLine("\nTotal:" + res);
                    resList.Add($"{num1} - {num2} = {res}");
                    break;
            }
            Console.ReadLine();
            Console.WriteLine("Do you want to do another operation? Y/N");
            Console.WriteLine(Instructions);
            value = Console.ReadLine();
        }
        while (value == "y" || value == "Y");
    }

    //Presenting the thirdschoice of the menu
    //With the math formula for multiplication
    public static void Multiplication()
    {
        string value;
        do
        {
            int res;
            Console.WriteLine("-------------------------");
            Console.Write("\n\nEnter the first value:");
            int num1 = Convert.ToInt32(Console.ReadLine());//method for letting the user to write his choice
            Console.Write("\nEnter the second value:");
            int num2 = Convert.ToInt32(Console.ReadLine());//method for letting the user to write his choice
            Console.WriteLine("Enter symbol * : ");
            string symbol = Console.ReadLine();//method for letting the user to write his choice

            switch (symbol)
            {
                case "*":
                    res = num1 * num2;//method for calculating the user selection
                    Console.WriteLine("\nTotal:" + res);
                    resList.Add($"{num1} * {num2} = {res}");
                    break;
            }
            Console.ReadLine();
            Console.WriteLine("Do you want to do another operation? Y/N");
            Console.WriteLine(Instructions);
            value = Console.ReadLine();//method for letting the user to write his choice
        }
        while (value == "y" || value == "Y");
    }

    //Presenting the fourth choice of the menu
    //With the math formula for division
    public static void Division()
    {
        string value;
        do
        {
            int res;
            Console.WriteLine("---------------------");
            Console.Write("\n\nEnter the first value:");
            int num1 = Convert.ToInt32(Console.ReadLine());//method for letting the user to write his choice
            Console.Write("\nEnter the second value:");
            int num2 = Convert.ToInt32(Console.ReadLine());//method for letting the user to write his choice
            Console.WriteLine("Enter symbol / : ");
            string symbol = Console.ReadLine();//method for letting the user to write his choice

            switch (symbol)
            {
                case "/":
                    if (num2 == 0) // Cannot be divided by zero
                    {
                        Console.WriteLine("\n\nDivision by zero is not allowed!");//message displayed in case of division by 0
                    }
                    else
                    {
                        res = num1 / num2;//method for calculating the user selection
                        Console.WriteLine("\nTotal:" + res);
                        resList.Add($"{num1} / {num2} = {res}");
                    }
                    /*res = num1 / num2;//method for calculating the user selection
                    Console.WriteLine("\nTotal:" + res);
                    resList.Add($"{num1} / {num2} = {res}");*/
                    break;
            }
            Console.ReadLine();
            Console.WriteLine("Do you want to do another operation? Y/N");
            Console.WriteLine(Instructions);
            value = Console.ReadLine();//method for letting the user to write his choice
        }
        while (value == "y" || value == "Y");
    }

    //Presenting the fifth choice of the menu
    //Giving the user a choice to see all the previous operations
    public static void Previous()
    {
        {
            Console.Clear();

            // Iterate through all calculations using for each
            foreach (var result in resList)
            {
                Console.WriteLine(result);
            }

            // Wait for the user
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
    //Presenting the sixth choice of the menu
    //Method for closing the program
    public static void Exit()
    {
        Console.Clear();
        Console.WriteLine("This program is closing down!\n");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Thank you for the visit!\nWe hope to see you again!\nHave a good day!");
        Console.WriteLine("Press ENTER to close the menu!");
        Console.ReadKey();
        Environment.Exit(1);
    }


}