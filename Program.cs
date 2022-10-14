internal class Program
{
    static void Main(string[] args)
    {
        
        int moneda;
        double cant;

        Console.WriteLine("PROGRAMA PARA CONVERTIR A EUROS");
        Console.WriteLine("¿Qué moneda desea cambiar a euros?");
        Console.WriteLine("Ingrese 1 para libra, 2 para yen o 3 para dolar");
        moneda = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad a convertir");
        cant = Convert.ToDouble(Console.ReadLine());

        if (moneda <1 ||moneda >3)
        {
            Console.WriteLine("Moneda inválida");
        }
        else
        {
            double resultado = Conversion (moneda, cant);
            Console.WriteLine("Su resultado es: "+ resultado);
        }

        
    }

    static double Conversion(int moneda, double cant)
    {
        if (moneda == 1)
        {
            return cant*1.22;
        }
        else if (moneda == 2)
        {
            return cant * 0.009;
        }
        else 
        {
            return cant * 0.75;
        }
    }
}