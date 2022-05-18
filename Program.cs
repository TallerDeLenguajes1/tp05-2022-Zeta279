namespace TrabajoPractico5{
    class TrabajoPractico5{
        static void Main(string[] args){
            ejercicio_1();
            // Ejercicio 2, 3 y 4 realizado en otras ramas
        }

        static void ejercicio_1(){
            Console.Write("Ingrese un número: ");
            int numero = ControlIngreso.IngresarInt();

            if(numero > 0){
                var numInvertido = new String("");

                foreach(char c in Convert.ToString(numero)){
                    numInvertido = c + numInvertido;
                }

                Console.WriteLine("Número invertido: " + numInvertido);
            }
            else{
                Console.WriteLine("Número original: " + Convert.ToString(numero));
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
    }
}