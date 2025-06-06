using System;

namespace ComunidadEducativa
{
    public class Empleado : MiembroDeLaComunidad
    {
        public string Puesto { get; set; }

        public Empleado(string nombre, int edad, string puesto) : base(nombre, edad)
        {
            Puesto = puesto;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Puesto: {Puesto}");
        }
    }
}