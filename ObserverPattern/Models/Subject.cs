using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Models
{
    class Subject : ISubject
    {
        List<IObserver> observerList = new List<IObserver>();
        private int flag;
        public int Flag
        {
            get
            {
                return flag;
            }
            set
            {
                flag = value;
                NotifyRegisteredUsers(flag);
            }
        }
        public void NotifyRegisteredUsers(int i)
        {
            foreach(IObserver obs in observerList)
            {
                obs.Update(i);
            }
        }

        public void Register(IObserver o)
        {
            observerList.Add(o);
        }

        public void UnRegister(IObserver o)
        {
            observerList.Remove(o);
        }
    }
}
