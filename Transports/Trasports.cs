using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace OOP.WinFormsApp1.Transports
{
    internal class Trasports
    {
        public int LtsCapacity { get; set; }

        public double Lts { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Indica si el vehiculo está en marcha
        /// </summary>
        public bool IsOn { get; set; }

        /// <summary>
        /// Cantidad de KM que recorre por Litros
        /// </summary>
        public int Perfonmance { get; set; }


        /// <summary>
        /// Sonido del claxon/Corneta
        /// </summary>
        public void Sound()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:/Users/jl-19/Downloads/Bus.wav";
            player.Play();
        }
    }
}
