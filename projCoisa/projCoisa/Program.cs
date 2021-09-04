using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projCoisa
{
    class Program
    {
        static void Main(string[] args)
        {
            Coisas asCoisas = new Coisas(5);

            Console.WriteLine(asCoisas.addCoisa(new Coisa(1, "um")) ? "Adicionou" : "Não adicionou");
            Console.WriteLine(asCoisas.addCoisa(new Coisa(2, "dois")) ? "Adicionou" : "Não adicionou");
            Console.WriteLine(asCoisas.addCoisa(new Coisa(3, "três")) ? "Adicionou" : "Não adicionou");
            Console.WriteLine(asCoisas.addCoisa(new Coisa(4, "quatro")) ? "Adicionou" : "Não adicionou");
            Console.WriteLine(asCoisas.addCoisa(new Coisa(5, "cinco")) ? "Adicionou" : "Não adicionou");
            Console.WriteLine(asCoisas.addCoisa(new Coisa(6, "seis")) ? "Adicionou" : "Não adicionou");

            Console.Write(asCoisas.mostraCoisas());

            Console.WriteLine(asCoisas.delCoisa(new Coisa(3, "três"))?"Deletou":"Não encontrou");

            Console.Write(asCoisas.mostraCoisas());

            Coisa coisaProcurada = asCoisas.searchCoisa(new Coisa(88, ""));
            if (coisaProcurada.Id == -1)
                Console.WriteLine("Não encontrou");
            else
                Console.WriteLine(coisaProcurada.dados());

            Console.ReadKey();
        }
    }
}
