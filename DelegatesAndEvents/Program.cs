using System;
using System.Diagnostics;

namespace DelegatesAndEvents
{
    public class Program
    {
        static void Main(String[] args)
        {
            SingleCastDelegate singleCastDelegate=new SingleCastDelegate();
            singleCastDelegate.Run();
        }
    }
}