using System;
using System.Linq;
using System.Collections.Generic;

namespace MediaDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> _sequenciaValores = new List<double>();
            double _soma = 0, _media = 0,_maiorNumero = 0,_menorNumero = 0;

            Console.WriteLine("=======\t Média Decimal\t======\n");

            // Solicitar quantidade de números
            Console.Write("Quantos números ? ");
            double.TryParse(Console
            .ReadLine()
            .ToString(), out double _quantidadeNumeros);

            // Solicitar valores
            for (int i = 0; i < _quantidadeNumeros; i++)
            {
                Console.Write($"Número #{i+1}: ");

                _sequenciaValores.Add(Convert
                .ToDouble(Console
                .ReadLine()));
            }

            Console.WriteLine("\n======= Resultado =======");
            
            // Calcular a soma dos números inseridos
            foreach (double _valor in _sequenciaValores)
            {
                _soma = _soma + _valor;
            }
            Console.WriteLine($"\nSoma....: {_soma}");

            // Calcular a média dos números inseridos
            _media = Math.Round(_soma/_quantidadeNumeros);
            Console.WriteLine($"Média...: {_media}");

            // Converter o List em Array para poder visualizar os maiores e menores valores
            double[] _arraySequenciaValores = _sequenciaValores.ToArray();

            // Verificar o maior e menor valor inserido e imprimi-los
            _menorNumero = _arraySequenciaValores.Min();
            _maiorNumero = _arraySequenciaValores.Max();

            Console.WriteLine($"Menor...: {_menorNumero}");
            Console.WriteLine($"Maior...: {_maiorNumero}");
        }
    }
}
