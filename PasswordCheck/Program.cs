using System;
public class PasswordCheck
{
    public static void Main()
    {
        //declare 2 string variables
        string username, password;
        //declare 2 int variable 
        int ctr = 0, dd = 0;
        
        Console.Write("\n\nCheck username and password :\n");
        Console.Write("N.B. : Defaule username and password is : username and password\n");
        Console.Write("---------------------------------\n");

        do
        {
            Console.Write("Input a username: ");
            //Read the user name from console and assign it to username varible
            username = Console.ReadLine();

            Console.Write("Input a password: ");
            //Read the Password from console and assign it to password varible
            password = Console.ReadLine();
            //compare password variable values with "username" "password" 
            if (username == "username" && password == "password")
            {
                dd = 1;
                ctr = 3;
            }

            else
            {
                dd = 0;
                ctr++;
            }
        }
        while ((username != "username" || password != "password")
                && (ctr != 3));
        if (dd == 0)
        {
            Console.Write("\nLogin attemp more than three times. Try later!\n\n");
        }
        else
        if (dd == 1)
        {
            Console.Write("\nPassword entered successfull!\n\n");
        }
    }
}
