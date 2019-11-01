using ObserverPattern.Interfaces;
using ObserverPattern.Models;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer Pattern");

            IObserver obs1 = new ObserverType1("Jessie");
            IObserver obs2 = new ObserverType2("Luke");
            IObserver obs3 = new ObserverType1("Bo");

            Subject sbj = new Subject();
            sbj.Register(obs1);
            sbj.Register(obs2);
            sbj.Register(obs3);

            sbj.Flag = 50;

            sbj.UnRegister(obs1);

            sbj.Flag = 100;

        }
    }
}
