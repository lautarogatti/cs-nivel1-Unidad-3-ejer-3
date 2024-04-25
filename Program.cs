using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Una casa de video juegos otorga un descuento dependiendo del importe de la compra 
            realizada según los siguientes valores:

            Si el importe es menor a ARS 1000, no hay descuento.
            Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            Si el importe es ARS 5000 o más, aplica un descuento del 18%. */

            float importe;
            Console.WriteLine("Ingrese el importe total de la compra");
            importe = float.Parse(Console.ReadLine());
            if(importe >= 1000 && importe < 5000){
                Console.WriteLine("Obtiene descuento de 10%");
                Console.WriteLine ("El total es " + (importe * 0.90F));
                Console.WriteLine ("El total es " + (importe - (importe * 10) / 100));
            }else if (importe >= 5000){
                Console.WriteLine("Obtiene un descuento de 18%");
                Console.WriteLine("El total es " + (importe - (importe * 18) / 100));

            }else{
                Console.WriteLine("No posee descuento");
            }

        }
    }
}
