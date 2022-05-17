namespace TrabajoPractico5{
    class TrabajoPractico5{
        static void Main(string[] args){
            ejercicio_3();
        }

        static void ejercicio_3(){
            double numero, numMax1, numMax2;

            Console.Write("Ingrese un número: ");
            numero = ControlIngreso.IngresarDouble();

            Console.WriteLine("El valor absoluto de " + numero + " es " + Math.Abs(numero));
            Console.WriteLine("El cuadrado de " + numero + " es " + Math.Pow(numero, 2));
            Console.WriteLine("La raiz cuadrada de " + numero + " es " + Math.Sqrt(numero));
            Console.WriteLine("El seno de " + numero + " es " + Math.Sin(numero));
            Console.WriteLine("El coseno de " + numero + " es " + Math.Cos(numero));
            Console.WriteLine("La parte entera de " + numero + " es " + Math.Floor(numero));

            Console.Write("Ingrese dos números: ");
            numMax1 = ControlIngreso.IngresarDouble();
            numMax2 = ControlIngreso.IngresarDouble();

            Console.WriteLine("El máximo entre " + numMax1 + " y " + numMax2 + " es: " + Math.Max(numMax1, numMax2));
        }
    }

    class ControlIngreso{
        public static int IngresarInt(){
            int entero = 0;
            bool error = true;

            while(error){
                try{
                    entero = Convert.ToInt32(Console.ReadLine());
                    error = false;
                }
                catch{
                    Console.WriteLine("Solo se permite ingresar números");
                }
            }

            return entero;
        }

        public static double IngresarDouble(){
            double numero = 0;
            bool error = true;

            while(error){
                try{
                    numero = Convert.ToDouble(Console.ReadLine());
                    error = false;
                }
                catch{
                    Console.WriteLine("Solo se permite ingresar números");
                }
            }

            return numero;
        }
    }
}