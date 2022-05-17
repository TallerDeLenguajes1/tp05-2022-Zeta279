namespace TrabajoPractico5{
    class TrabajoPractico5{
        static void Main(string[] args){
            ejercicio_1();
        }

        static void ejercicio_1(){
            Console.Write("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

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
}