using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ItemsCategory;

namespace DataManagement
{
    internal class AdminData_TextToFile
    {
        private string FileName;
        private const int NB_MAX_CARS = 70;
        public AdminData_TextToFile(string FileName)
        {
            this.FileName = FileName;
            Stream streamTextFile = File.Open(FileName, FileMode.OpenOrCreate);
            streamTextFile.Close();
        }

        public void AddCar(Car car)
        {
            using (StreamWriter sw = new StreamWriter(FileName, true))
            {
                sw.WriteLine(car.StringForTxtFile());
            }
        }

        public Car[] GetCars(out int nbCars)
        {
            Car[] cars = new Car[NB_MAX_CARS];

            using (StreamReader sr = new StreamReader(FileName))
            {
                string fileLine;
                nbCars = 0;
                while ((fileLine = sr.ReadLine()) != null)
                {
                    cars[nbCars++] = new Car(fileLine);
                }
            }
            return cars;
        }
    }
}
