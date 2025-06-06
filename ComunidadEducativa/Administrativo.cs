using System;

namespace ComunidadEducativa
{
    public class Administrativo : Empleado
    {
        public string AreaAdministrativa { get; set; }

        public Administrativo(string nombre, int edad, string puesto, string areaAdministrativa) : base(nombre, edad, puesto)
        {
            AreaAdministrativa = areaAdministrativa;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Área Administrativa: {AreaAdministrativa}");
        }
    }
}