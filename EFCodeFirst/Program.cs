using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Contexto();

            db.Database.CreateIfNotExists();

            var g1 = new Grupo() { Nome = "Peças" };
            var g2 = new Grupo() { Nome = "Serviços" };

            db.Grupo.Add(g1);
            db.Grupo.Add(g2);

            var p1 = new Produto() { Descricao = "Pneu", Grupo = g1 };
            var p2 = new Produto() { Descricao = "Roda", Grupo = g1 };
            var p3 = new Produto() { Descricao = "Alinhamento", Grupo = g2 };
            var p4 = new Produto() { Descricao = "Balanceamento", Grupo = g2 };

            db.Produto.Add(p1);
            db.Produto.Add(p2);
            db.Produto.Add(p3);
            db.Produto.Add(p4);

            db.SaveChanges();

            var dados = from p in db.Produto
                        select p;

            foreach (var linha in dados)
            {
                Console.WriteLine("{0,-30} - {1}", linha.Grupo.Nome, linha.Descricao);
            }
        }
    }
}
