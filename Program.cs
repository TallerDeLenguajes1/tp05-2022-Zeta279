namespace TrabajoPractico5{
    class TrabajoPractico5{
        static void Main(string[] args){
            ejercicio_2();
        }

        static void ejercicio_2(){
            bool repetir = true;
            int opcion;
            double num1, num2;

            while(repetir){
                Console.WriteLine("Seleccionar una operación:");
                Console.WriteLine("1) Sumar");
                Console.WriteLine("2) Restar");
                Console.WriteLine("3) Multiplicar");
                Console.WriteLine("4) Dividir");

                Console.Write("Operación: ");
                opcion = ControlIngreso.IngresarInt();

                while(opcion < 1 || opcion > 4){
                    Console.Write("Opción incorrecta. Ingresar una opción correcta: ");
                    opcion = ControlIngreso.IngresarInt();
                }

                Console.WriteLine("Ingrese dos números: ");
                Console.Write("Primer número: ");
                num1 = ControlIngreso.IngresarDouble();
                Console.Write("Segundo número: ");
                num2 = ControlIngreso.IngresarDouble();

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