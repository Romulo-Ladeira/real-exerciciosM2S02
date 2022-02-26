using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\ROMULO\Documents\GitHub\exerciciosM2S02\exercicio08\alunos.json";

            var jsonString = File.ReadAllText(path);

            var jsonList = JsonConvert.DeserializeObject<List<Aluno>>(jsonString);

            var alunosReprovados = jsonList.Where(aluno => aluno.nota < 5);

            foreach (var aluno in alunosReprovados)
            {
                Console.WriteLine(aluno.nome);
            }
        }
    }
}
