using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ColecoesQueue {


        public static void Executar() {

            var fila = new Queue<string>();
            fila.Enqueue("Fulano");
            fila.Enqueue("Siclano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);


            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.15);

            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item"));

        }
    }
}
