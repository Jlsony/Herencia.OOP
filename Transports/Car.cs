using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace OOP.WinFormsApp1.Transports
{
    internal class Car: Trasports
    {

        public int Cilinders { get; set; }


        /// <summary>
        /// {Clase Hija} : {Clase Padre}
        /// </summary>

        public Car(int cilinders, int capacity, string name) 
        {
            Cilinders = cilinders;
            LtsCapacity = capacity;
            Lts = 0;
            Name = name;

            switch (cilinders)
            {
                case 4:
                    Perfonmance = 15;
                    break;

                case 6:
                    Perfonmance = 11;
                    break;

                case 8:
                    Perfonmance = 8;
                    break;

                case 12:
                    Perfonmance = 6;
                    break;

                default:
                    Console.WriteLine($"{name}** Cantidad de cilindros Inválidos");
                    break;
            }

            
        } 
             

    }
}
