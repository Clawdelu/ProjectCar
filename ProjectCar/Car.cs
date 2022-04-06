using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsCategory
{
    internal class Car
    {
        protected int an, putere;
        protected string marca, culoare, tipC, model, combustibil;
        // static int TotalNbCars;
        private int idCar;

        private const char COMMA = ',';
        private const char CH = '-';

        private const int ID = 0;
        private const int MARCA = 1;
        private const int MODEL = 2;
        private const int AN = 3;
        private const int CULOARE = 4;
        private const int CAROSERIE = 5;
        private const int COMBUSTIBIL = 6;
        private const int PUTERE = 7;

        public Car()
        {
            marca = model = culoare = tipC = combustibil = string.Empty;
            an = 0; putere = 0;

        }

        public Car(string FileLine)
        {
            var FileData = FileLine.Split(COMMA, CH);

            idCar = Convert.ToInt32(FileData[ID]);
            marca = FileData[MARCA];
            model = FileData[MODEL];
            an = Convert.ToInt32(FileData[AN]);
            culoare = FileData[CULOARE];
            tipC = FileData[CAROSERIE];
            combustibil = FileData[COMBUSTIBIL];
            putere = Convert.ToInt32(FileData[PUTERE]);

        }

        public Car(int idCar, string marca, string model)
        {
            this.idCar = idCar;
            this.marca = marca;
            this.model = model;

        }
        public string StringForTxtFile()
        {
            string CarAfis = string.Format("{2}{1}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}",
                COMMA, CH,
                idCar.ToString(),
                (marca ?? "--"), (model ?? "--"), (an.ToString() ?? "--"), (culoare ?? "--"), (tipC ?? "--"),
                (combustibil ?? "--"), (putere.ToString() ?? "--"));

            return CarAfis;
        }

        public int IdCar { get; set; }
        public string Marca { get; set; }
        public int Model { get; set; }
        public string Culoare { get; set; }
        public int An { get; set; }
        public string TipC { get; set; }
        public string Combustibil { get; set; }
        public int Putere { get; set; }
    }
}
