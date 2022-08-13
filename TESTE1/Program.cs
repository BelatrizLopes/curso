using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar },
                {"variaveiseconstantes - Fundamentos", variaveiseconstantes.Executar },
                {"inferencia - Fundamentos", inferencia.Executar },
                {"interpolacao - Fundamentos", interpolacao.Executar },
                {"Notacao ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatanddo Numeros - Fundamentos", formatandonumeros.Executar },
                {"Conversoes - Fundamentos", conversoes.Executar },
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}