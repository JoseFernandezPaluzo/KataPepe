using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinFormsKatas.Katas_UI.Kata_t
{
    public class Deportista
    {
        public double Puntuacion { get; set; }
        public string Nombre { get; set; }
        public string Deporte { get; set; }
        public int Edad { get; set; }

        public Deportista()
        {
            Puntuacion = 12;
            Nombre = "Juan";
            Deporte = "Futbol";
            Edad = 20;
        }
    }
}
