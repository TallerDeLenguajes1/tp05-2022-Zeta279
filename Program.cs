namespace TrabajoPractico5{
    class TrabajoPractico5{
        static void Main(string[] args){
            ejercicio_4();
        }

        static void ejercicio_4(){
            string cadena1, cadena2;
            char operador = ' ';
            int resultado = 0;

            Console.Write("Ingresar una cadena: ");
            cadena1 = Console.ReadLine();

            Console.WriteLine("Longitud de la cadena: " + cadena1.Length);

            Console.Write("Ingresar otra cadena: ");
            cadena2 = Console.ReadLine();

            Console.WriteLine("Concadenación de ambas cadenas: " + (cadena1 + cadena2));

            /* Ya se realizó anteriormente en la branch CalculadoraV1 
            el ejercicio de mostrar en texto el resultado de las operaciones */

            Console.WriteLine($"Mostrando cada letra de la primera cadena, separada por un espacio");
            foreach(char c in cadena1){
                Console.Write(c + " ");
            }
            Console.Write("\n");

            Console.Write("Ingresar una cadena para comprobar si pertenece en la primera cadena: ");
            if(cadena1.Contains(Console.ReadLine())){
                Console.WriteLine("La cadena ingresada si se encuentra en la primera cadena");
            }
            else{
                Console.WriteLine("La cadena ingresada no se encuentra en la primera cadena");
            }

            Console.WriteLine($"La cadena \"{cadena1}\" en mayuscula es \"{cadena1.ToUpper()}\"");
            Console.WriteLine($"La cadena \"{cadena1}\" en minuscula es \"{cadena1.ToLower()}\"");

            Console.Write("Ingresar una cadena con un caracter separador: ");
            cadena2 = Console.ReadLine();

            Console.Write("Ingresar el caracter separador: ");
            foreach(string s in cadena2.Split(Console.ReadLine())){
                Console.WriteLine(s);
            }

            Console.Write("Ingresa una operación matemática simple (con un solo operador, sin paréntesis y con números enteros): ");
            cadena1 = Console.ReadLine();

            if(cadena1.Contains('+')){
                operador = '+';
                resultado = Int32.Parse(cadena1.Split(operador)[0]) + Int32.Parse(cadena1.Split(operador)[1]);
            }
            else if(cadena1.Contains('-')){
                operador = '-';
                resultado = Int32.Parse(cadena1.Split(operador)[0]) - Int32.Parse(cadena1.Split(operador)[1]);
            }
            else if(cadena1.Contains('*')){
                operador = '*';
                resultado = Int32.Parse(cadena1.Split(operador)[0]) * Int32.Parse(cadena1.Split(operador)[1]);
            }
            else if(cadena1.Contains('/')){
                operador = '/';
                try{
                    resultado = Int32.Parse(cadena1.Split(operador)[0]) / Int32.Parse(cadena1.Split(operador)[1]);
                }
                catch(DivideByZeroException){
                    Console.WriteLine("No es posible dividir en cero");
                }
            }

            if(operador != '/' || cadena1.Split(operador)[1] != "0"){
                Console.WriteLine($"{cadena1.Split(operador)[0]} {operador} {cadena1.Split(operador)[1]} = {resultado}");
            }
            
        }
    }
}