// See https://aka.ms/new-console-template for more information
using System;
using ItemsCategory;
using DataManagement;
namespace Project
{
    class Program
    {

        static void Main()
        {
            string fileName = "Cars.txt";
            int nbCars = 0;
            AdminData_TextToFile adminCars = new AdminData_TextToFile(fileName);
            Car newCar = new Car();
            adminCars.GetCars(out nbCars);
            string option;
            do
            {
                Console.Clear();
                Console.WriteLine("C. Citire informatii masina de la tastatura");
                Console.WriteLine("A. Afisarea ultimei masini introdus");
                Console.WriteLine("F. Afisare masini din fisier");
                Console.WriteLine("S. Salvare masina in fisier");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                option = Console.ReadLine();
                switch (option.ToUpper())
                {
                    case "C":
                        Console.WriteLine("Ati ales optiunea C!");
                        newCar = ConsoleRead();
                        break;
                    case "A":
                        Console.WriteLine("Ati ales optiunea A!");
                        break;
                    case "F":
                        Console.WriteLine("Ati ales optiunea F!");
                        break;
                    case "S":
                        Console.WriteLine("Ati ales optiunea S!");
                        break;
                    case "X":
                        Console.WriteLine("Ati ales optiunea X!");
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            } while (option.ToUpper() != "X");
            
        }

        public static Car ConsoleRead()
        {
            Console.WriteLine("Marca: ");
            string marca = Console.ReadLine();

            Console.WriteLine("Model: ");
            string model = Console.ReadLine();
            
            Car car = new Car(0, marca, model);

           // Console.WriteLine("Doriti sa introduceti ?:");
            Console.WriteLine("Tip Caroserie: ");
            string tipC = Console.ReadLine();
            car.TipC = tipC;

            Console.WriteLine("Culoare: ");
            string culoare = Console.ReadLine();
            car.Culoare = culoare;

            Console.WriteLine("Combustibil: ");
            string comb = Console.ReadLine();
            car.Combustibil = comb;

            Console.WriteLine("An: ");
            string an = Console.ReadLine();
            car.An = Convert.ToInt32(an);

            Console.WriteLine("Putere: ");
            int put = Convert.ToInt32(Console.ReadLine());
            car.Putere = put;

            return car;
        }
    }
}

