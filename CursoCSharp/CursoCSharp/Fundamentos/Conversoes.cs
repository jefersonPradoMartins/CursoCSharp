using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Conversoes {

        public static void Executar() {
            int inteiro = 10;
            double quebrado;
            quebrado= inteiro;

            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota; // nessa conversão o c# salva apenas
            // o 9 e o 7 não é convertido.
            Console.WriteLine($"Nota trucada {notaTruncada}");

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro= Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado convertido int32: {0}", idadeInteiro);


            Console.WriteLine("Digite um número ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            // tenta converter o texto em número
            Console.WriteLine("Resultado {0}",numero);

            Console.Write("Digite o segundo número ");
       
            int.TryParse(Console.ReadLine(), out int numero2);
            // tenta converter o texto em número
            Console.WriteLine("Resultado 2 :{0}", numero2);


        }
    }
}
