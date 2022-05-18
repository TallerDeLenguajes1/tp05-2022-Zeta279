namespace TrabajoPractico5{
    class TrabajoPractico5{
        static void Main(string[] args){
            calculadora(); // Ejercicio 2 y 3
        }

        static void calculadora(){
            bool repetir = true;
            int opcion;
            double num1 = 0, num2 = 0;

            while(repetir){
                Console.WriteLine("Seleccionar una operación:");
                Console.WriteLine("1) Sumar");
                Console.WriteLine("2) Restar");
                Console.WriteLine("3) Multiplicar");
                Console.WriteLine("4) Dividir");
                Console.WriteLine("5) Operaciones varias");

                Console.Write("Operación: ");
                opcion = ControlIngreso.IngresarInt();

                while(opcion < 1 || opcion > 5){
                    Console.Write("Opción incorrecta. Ingresar una opción correcta: ");
                    opcion = ControlIngreso.IngresarInt();
                }

                if(opcion != 5) Console.WriteLine("Ingrese dos números: ");
                else Console.WriteLine("Ingrese un número: ");

                Console.Write("Primer número: ");
                num1 = ControlIngreso.IngresarDouble();

                if(opcion != 5){
                    Console.Write("Segundo número: ");
                    num2 = ControlIngreso.IngresarDouble();
                }
                

                switch(opcion){
                    case 1:
                        Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
                        break;
                    case 4:
                        if(num2 == 0){
                            Console.WriteLine("No se puede dividir en cero");
                        }
                        else{
                            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                        }
                        break;
                    case 5:
                        Console.WriteLine("El valor absoluto de " + num1 + " es " + Math.Abs(num1));
                        Console.WriteLine("El cuadrado de " + num1 + " es " + Math.Pow(num1, 2));
                        Console.WriteLine("La raiz cuadrada de " + num1 + " es " + Math.Sqrt(num1));
                        Console.WriteLine("El seno de " + num1 + " es " + Math.Sin(num1));
                        Console.WriteLine("El coseno de " + num1 + " es " + Math.Cos(num1));
                        Console.WriteLine("La parte entera de " + num1 + " es " + Math.Floor(num1));

                        Console.Write("Ingrese otro número: ");
                        num2 = ControlIngreso.IngresarDouble();

                        Console.WriteLine("El máximo entre " + num1 + " y " + num2 + " es: " + Math.Max(num1, num2));
                        break;
                }

                Console.Write("Ingresar 1 para realizar otro cálculo, otro número para no realizar más cálculos: ");
                if(ControlIngreso.IngresarInt() != 1){
                    repetir = false;
                    Console.WriteLine("Saliendo del programa");
                }
                else{
                    repetir = true;
                }
            }
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