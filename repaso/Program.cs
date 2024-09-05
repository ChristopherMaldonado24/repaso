using System;
class Repaso
{
    static void Main(string[] args)
    {
        int Cantidad;
        double Subtotal;
        double Impuesto;
        double Precio;
        int Opcion;
        int Edad;
        string Nombre;
        double PorcentajeImpuesto;
        Console.WriteLine("==== Bienvenido al sistema e ventas");
        Console.Write("Ingrese su nombre: ");
        Nombre = Console.ReadLine();
        Console.Write("Favor ingrese su edad: ");
        Edad= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Seleccione el producto del que desea información: ");
        Console.WriteLine(" 1. Kit de Arduino Base ");
        Console.WriteLine(" 2. Kit de Arduino Intermedio ");
        Console.WriteLine(" 3. Kit de Arduino Avanzdo ");
        Opcion = Convert.ToInt32(Console.ReadLine());

        
        PorcentajeImpuesto = 0;
        Precio = 0;

        switch (Opcion)
        {

            case 1:
                
                 Console.WriteLine("700.Lps kit básico Arduino Uno – bit pack viene con los elementos indispensables para poder realizar las primeras prácticas con Arduino.");
                 Precio = 700;
                 PorcentajeImpuesto = 0.15;
                break;

            case 2:

                Console.WriteLine("1100.Lps kit intermedio Arduino Uno – nibble pack es una actualización incremental a nuestro kit básico Arduino uno.");
                Precio = 1100;
                PorcentajeImpuesto = 0.15;
                break;

            case 3:

                Console.WriteLine("2000.Lps kit avanzado Arduino Uno – byte pack es la máxima expansión de nuestro kit de nivel intermedio para Arduino Uno.");
                Precio = 2000;
                PorcentajeImpuesto = 0;
                 break;

            default:
                Console.WriteLine("Opcion No Valida");
                break;

        }

                Console.WriteLine("ingrese la cantidad deseada");
                Cantidad = Convert.ToInt32(Console.ReadLine());
                Impuesto = Precio * Cantidad * PorcentajeImpuesto;
                Subtotal = Precio * Cantidad + Impuesto;

                Console.WriteLine($"El total es: {Subtotal}");
        


    }
}