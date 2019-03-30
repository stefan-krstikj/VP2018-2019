using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    enum PasswordStrenght
    {
        easy,
        normal,
        hard
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Passowrd difficulty to generate? (0) - easy, (1) - normal, (2) - hard");
            int difficultyChoice = Convert.ToInt32(Console.ReadLine());
            String pw = "";
            if (difficultyChoice == 0)
                pw = generatePassword(PasswordStrenght.easy);
            else if (difficultyChoice == 1)
                pw = generatePassword(PasswordStrenght.normal);
            else
                pw = generatePassword(PasswordStrenght.hard);

            System.Diagnostics.Debug.WriteLine("Generated password is: " + pw);
            Console.WriteLine("Enter your password guesses, seperated by a space");

            string passLine = Console.ReadLine();
            char[] delimiter = { ' ' };
            string[] parts = passLine.Split(delimiter);

            bool cracked = false;
            foreach (String s in parts)
            {
                if(s == pw)
                {
                    cracked = true;
                    break;
                }
            }

            if (cracked)
            {
                Console.WriteLine("Password cracked!");
            }
            else
            {
                Console.WriteLine("Password not cracked");
            }
            Console.ReadKey();
        }

        static string generatePassword(PasswordStrenght passwordStrenght)
        {
            Console.WriteLine("Generating random password...");
            string password = "";
            Random random = new Random();
            if (passwordStrenght == PasswordStrenght.easy)
            {
                // generate how many numbers we'll have
                int password_length = random.Next(0, 7);
                for(int i = 0; i < password_length; i++)
                {
                    password += ((char)random.Next('a', 'z'+1));
                }
            }
            else if(passwordStrenght == PasswordStrenght.normal)
            {
                // generate how many numbers we'll have
                int password_length = random.Next(6, 11);
                for (int i = 0; i < password_length; i++)
                {
                    // number (0) or uppercase (1)?
                    int randomChoice = random.Next(0, 2);
                    if (randomChoice == 1)
                        password += ((char)random.Next('A', 'Z'+1));
                    else
                        password += ((char)random.Next('0', '9'+1));
                }  
            }
            else
            {
                // generate how many numbers we'll have
                int password_length = random.Next(10, 30);
                for (int i = 0; i < password_length; i++)
                {
                    // ova ke generira random bukva izmegju '!' i 'z' + 5. Ova gi vklucuva i brojkite, bidejki sepak toa go pravi password'ot potezok
                    // za da se izbegnat brojki vo password'ot, ke treba da napravime nesto nalik prethodnite slucai, kade sto random ke generira broj 0 ili 1,
                    // i ke ni bidat podeleni slucaite na rang od '!' do pred '0', i rang od '9'+1 do 'z'+5
                    password += ((char)random.Next('!', 'z' + 5)); // +5 bidejki posle 'z' na ascii tabelata ima uste 4 karakteri koi se specijalni znaci
                }
            }
            Console.WriteLine("Password successfully generated");
            return password;
        }

        
    }
}
