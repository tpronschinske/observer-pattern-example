using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interfaces
{
    interface ISubject
    {
        void Register(IObserver o);
        void UnRegister(IObserver o);
        void NotifyRegisteredUsers(int i);
    }
}
