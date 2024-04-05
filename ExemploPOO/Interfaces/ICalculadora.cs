using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
        // Metodos que não tem corpo são obrigatórios para a implementação
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);

        // Metodos que tem corpo são Opcionais para a implementação
        int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}