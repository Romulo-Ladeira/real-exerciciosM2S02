using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\ROMULO\Documents\GitHub\exerciciosM2S02\exercicio09\alunos.json";
            var pathCreate = @"C:\Users\ROMULO\Documents\GitHub\exerciciosM2S02\exercicio09\teste.json";


            var jsonString = File.ReadAllText(path);

            var jsonList = JsonConvert.DeserializeObject<List<Aluno>>(jsonString);

            var alunosReprovados = jsonList.Where(aluno => aluno.nota < 5);

            var reprovadosString = JsonConvert.SerializeObject(alunosReprovados);

            using (FileStream fs = File.Create(pathCreate))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(reprovadosString);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
    }
}
