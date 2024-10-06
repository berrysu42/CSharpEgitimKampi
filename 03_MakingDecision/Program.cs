using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If  Else


            //string password2 = "Atw2415+";

            //Console.Write("Please, enter the password -> ");
            //string password;
            //password =Console.ReadLine();

            //if (password == password2)
            //{
            //    Console.WriteLine("Password is correct =)");

            //}
            //else
            //{
            //    Console.WriteLine("Password is not true!");
            //}

            //string capital,country;

            //Console.Write("Please, enter the capital -> ");
            //capital = Console.ReadLine();

            //Console.Write("Please, enter the country -> ");
            //country = Console.ReadLine();

            //if(capital=="ankara" & country=="Türkiye")
            //    Console.WriteLine("Match is true =)");

            //else
            //    Console.WriteLine("Match is not true =(");

            //int number;

            //Console.Write("Please, enter the number -> ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //    Console.WriteLine("Number is correct");
            //else
            //    Console.WriteLine("Number is not correct!");


            // int exam1, exam2, exam3,average;
            // string result;

            // Console.Write("Plase, enter the exam1-> ");
            // exam1=int.Parse(Console.ReadLine ());

            // Console.Write("Plase, enter the exam2-> ");
            // exam2 = int.Parse(Console.ReadLine());

            // Console.Write("Plase, enter the exam3-> ");
            // exam3 = int.Parse(Console.ReadLine());

            // average =(exam1 + exam2 + exam3) / 3;
            //// Console.Write("The exam average -> "+ average);

            // if (average > 0 & average <= 50)
            // {
            //     Console.WriteLine("Average ->" + " " + average);
            //     result ="Your exam failed: ( ";
            // }                             

            // else if (average>50 & average <=70)
            // {
            //     result = "Your exam average :)";
            //     Console.WriteLine("Average ->" + " " + average);
            // }



            // else
            // {
            //     result = "Your exam result is perfect ;)";
            //     Console.WriteLine("Average ->"+" "+average);
            // }

            // Console.WriteLine(result);

            //string city;
            //Console.Write("Plase, enter city: " );
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "konya" | city == "bursa")
            //{
            //    Console.Write("City registered");
            //}

            //else
            //{
            //    Console.Write("City not registered");
            //}

            //Console.Write("Please, enter user name: ");
            //string username = Console.ReadLine();
            //if(username != "admin") 
            //        Console.Write("Invalid username");
            //else
            //        Console.Write("Welcome in your home:)");



            //Console.Read();
            #endregion

            #region Mode Operations
            //int number = 26;
            //int result = number%5;
            //Console.WriteLine(result);


            //Console.Write("Please, enter the number1-> ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Please, enter the number2-> ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("The remainder of the division of the 1st number by the 2nd number-> "+ result);

            //Console.Write("Please, enter the number-> ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)

            //    Console.Write("The number is even");

            //else
            //    Console.Write("The number is odd");
            #endregion

            #region Decision structures with char variables
            //klavyeden girilen harfe göre takımı azdıran kod
            //ilk çözüm kendi çözümüm, 2. çözüm hocamızın çözümü.
            //Console.Write("Please, enter the letter-> ");
            //char letter = char.Parse(Console.ReadLine().ToLower());

            //Console.Write("Please, enter the team-> ");
            //string team = Console.ReadLine().ToLower();

            //if (team.Contains(letter))
            //    Console.Write("letter is team. Team is a "+ team);
            //else
            //    Console.Write("letter is not team.The team is a "+team);

            //char team;
            //Console.Write("Lütfen, takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //    Console.Write("Galatasaray");

            //if(team == 'f' | team == 'F')
            //    Console.Write("Fenerbahçe");

            //if(team == 'b' | team == 'B')
            //    Console.Write("Beşiktaş");
            #endregion


            #region Example Practice
            //Practice : Bir yemek seçim ekranı olsun. Kullanıcı seçtiği kategoriye göre alt menü gelsin.
            /*
            Console.WriteLine("**********************C# Training Camp Restaurant*********************");        
            string drink,desert,mainCourse,soup;
            Console.Write("Please, make a choice\n");
            string choice;
            while (1==1)
            {

                Console.Write("Please, make a choice (drink, desert, mainCourse, soup): ");
                choice = Console.ReadLine().ToLower();
                if (choice == "drink")
                {
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("\tDrink Category");
                    Console.WriteLine("Water\n" + "Coke\n" + "Ayran\n" + "Fruit Juice");
                    Console.WriteLine("-----------------------------------------------------");
                }
                if (choice == "desert")
                {
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("\tDesert Category");
                    Console.WriteLine("Baklava\n" + "Cake\n" + "Kunefe\n" + "Waffle");
                    Console.WriteLine("-----------------------------------------------------");
                }
                if (choice == "mainCourse")
                {
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("\tMain Course Category");
                    Console.WriteLine("Roast Beef\n" + "Fried Calaman\n" + "Etliekmek\n" + "Tandır Kebap");
                    Console.WriteLine("-----------------------------------------------------");
                }
                if (choice == "soup")
                {
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("\tSoup Category");
                    Console.WriteLine("Chicken Soup\n" + "Fish Soup\n" + "Vegetable Soup\n" + "Ezogelin Soup");
                    Console.WriteLine("-----------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please, make a valid choice");

                }
                Console.Write("\nDo you want to make another choice? (yes/no): ");
                string continueChoice = Console.ReadLine().ToLower();

                if (continueChoice != "yes")
                {
                    break;  // Kullanıcı devam etmek istemiyorsa döngüden çıkıyoruz
                }
            }
            Benim çözümüm
            */

            //hocanın yolu
            //Console.WriteLine("\n**********************C# Training Camp Restaurant*********************");
            //Console.WriteLine("--------------------> MENU <--------------------");
            //Console.WriteLine("1- Main Course");
            //Console.WriteLine("2- Soups");
            //Console.WriteLine("3- Pizzas");
            //Console.WriteLine("4- Drinks");
            //Console.WriteLine("5- Sweets");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Select the menu you want to see details about:");
            //menuItem = Console.ReadLine();
            //if(menuItem == "1" )
            //{
            //    Console.WriteLine("-------------------Main Course-------------------\n");
            //    Console.WriteLine("1-Köri Soslu Tavuk");    
            //    Console.WriteLine("2- Kıazrtma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Sommon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("\n-------------------Main Course-------------------\n");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine("\n-------------------Soups-------------------\n");
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2- Ezogelin Çorbası");

            //    Console.WriteLine("\n-------------------Soups-------------------\n");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine("\n-------------------Pizzas-------------------\n");
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2- Margaritha");
            //    Console.WriteLine("2- Tavuklu Pizza");

            //    Console.WriteLine("\n-------------------Pizzas-------------------\n");
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine("\n-------------------Drinks-------------------\n");
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2- Ayran");
            //    Console.WriteLine("3- Water");

            //    Console.WriteLine("\n-------------------Drinks-------------------\n");
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine("\n-------------------Deserts-------------------\n");
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine("3- Sütlaç");

            //    Console.WriteLine("\n-------------------Deserts-------------------\n");
            //}





            //Console.Read();
            #endregion

            #region Switch-Case

            //klavyeden girilen sayıya göre yılın aylarını veren uygulama
            //Console.Write("Please, enter the month : ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:Console.Write("January\n");   break; 

            //    case 2:
            //    Console.Write("February\n");
            //    break;

            //    case 3:
            //    Console.Write("March\n");
            //    break;

            //    case 4: 
            //    Console.Write("April\n");      
            //    break;

            //    case 5:
            //    Console.Write("May\n");
            //    break;

            //    case 6:
            //    Console.Write("June\n");
            //    break;

            //    case 7:
            //    Console.Write("July\n");
            //    break;

            //    case 8:
            //    Console.Write("August\n");
            //    break;

            //    case 9:
            //    Console.Write("September\n");
            //    break;

            //    case 10:
            //    Console.Write("October\n");
            //    break;

            //    case 11:
            //    Console.Write("November\n");
            //    break;

            //    case 12:
            //        Console.Write("December\n");
            //        break;

            //    default:  Console.Write("incorrect data entry"); break;


            //}

            // Console.Read();
            #endregion

            #region Calculator application

            int number1, number2, result;
            char process;


            Console.Write("Please, enter the number1 : ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Please, enter the number2 : ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Please, enter the process : ");
            process = char.Parse(Console.ReadLine());

            switch (process)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Total result -> " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Subtraction result -> " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Multiplication result ->" + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Division result -> " + result);
                    break;
                case '%':
                    result = number1 % number2;
                    Console.WriteLine("Mode result ->" + result);
                    break;

                default: Console.Write("incorrect data entry"); break;
            }


            Console.Read();
            #endregion


        }
    }
}
