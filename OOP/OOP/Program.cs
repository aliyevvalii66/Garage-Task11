using System;
using System.Threading;

namespace OOP
{
    internal class Program
    {
        static void Main()
        {
            Db db = new Db();

            Console.Write("Daxil elemek istediyiniz user sayi : ");
            int count = int.Parse(Console.ReadLine());

            string username = "";
            string password = "";

            for (int i = 1; i <= count; i++)
            {
                Inputs(ref username, ref password, db, i);

            }
            Console.WriteLine("---------------------------------------------------------------");
        choice:

            try
            {
                Console.WriteLine("1)Show users-----2)Exit");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    foreach (var item in db.Users)
                    {
                        item.ShowInfo();
                    }
                }
                else if (choice == 0)
                    return;
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("1 ve 0 dan istifade edin");
                goto choice;
            }



            Console.ReadKey();

        }


        static void Inputs(ref string username, ref string password, Db db, int i)
        {
        username:
            Console.Write($"{i})User ucun username : ");
            username = Console.ReadLine();

        password:
            Console.Write($"{i})User ucun password : ");
            password = Console.ReadLine();

            bool usernameControl = username.UsernameChecker(db);
            bool passwordControl = password.PasswordChecker();


            if (usernameControl && passwordControl)
            {
                User user = new User(username, password);
                db.Users.Add(user);
                Console.WriteLine($"User {i} ugurla elave edildi :)");
            }
            else if (!usernameControl)
            {
                Console.WriteLine("Bu username artiq istifade olunub");
                goto username;
            }
            else if (!passwordControl)
            {
                Console.WriteLine("Shifreniz boyuk herf , kicik herf ve reqemden ibaret olmalidir!");
                goto password;
            }




        }
    }
}
