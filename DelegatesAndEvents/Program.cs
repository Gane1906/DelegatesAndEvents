using System;
using System.Diagnostics;

namespace DelegatesAndEvents
{
    public class Program
    {
        static void Main(String[] args)
        {
            MultiCastDelegate multiCastDelegate = new MultiCastDelegate();
            multiCastDelegate.Run();
        }
    }
}