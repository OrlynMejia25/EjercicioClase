

namespace EjercicioClase
{
    public class SuperHeroe
    {
        public string Nombre { get; set; }

        public string IdentidadSecreta { get; set; }

        public string Ciudad {  get; set; }

        public bool PuedeVolar { get; set; }

        public SuperPoder SuperPoder { get; set; }


        // constructor

        public SuperHeroe() { 
        PuedeVolar = true;
        SuperPoder = new SuperPoder();

        }

       public void Imprimir ()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad Secreta: {IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Super Poder: {SuperPoder.nombre}");
            Console.WriteLine($"Descripcioin: {SuperPoder.descripcion}");
            Console.WriteLine($"Nivel: {SuperPoder.nivel}");
            Console.WriteLine();


            if (PuedeVolar)
            {
                Console.WriteLine($"Puede volar:true");
            } else{
                Console.WriteLine($"Puede Volar:false");

            }

        }


    }
}
