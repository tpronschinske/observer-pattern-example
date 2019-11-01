using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Models
{
    class ObserverType1 : IObserver
    {
        string observerName;

        public ObserverType1(string name)
        {
            this.observerName = name;
        }

        public void Update(int i)
        {
            Console.WriteLine("{0} has received an alert: someone updated myValue in Subject to: {1}", observerName, i);
        }
    }
}
