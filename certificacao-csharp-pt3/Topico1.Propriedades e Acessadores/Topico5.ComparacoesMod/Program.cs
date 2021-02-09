﻿using System;

namespace Topico5.ComparacoesMod
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno
            {
                Nome = "José da Silva",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            Aluno aluno2 = new Aluno
            {
                Nome = "José da Silva",
                DataNascimento = new DateTime(1995, 1, 1)
            };

            Aluno aluno3 = new Aluno
            {
                Nome = "josé da silva",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            Console.WriteLine(aluno1.Equals(aluno2));
            Console.WriteLine(aluno1.Equals(aluno3)) ;
        }
    }

    class Aluno
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Data nascimento: {DataNascimento:dd/MM/yyyy}";
        }

        public override bool Equals(object obj)
        {
            Aluno outroAluno = obj as Aluno;

            if (obj == null) return false;

            return 
                Nome.Equals(outroAluno.Nome, StringComparison.CurrentCultureIgnoreCase) &&
                DataNascimento.Equals(outroAluno.DataNascimento);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, DataNascimento);
        }
    }
}
