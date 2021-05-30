using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Starter st = new Starter();
            while (true)
            {
                Console.Clear();
                try
                {
                    st.Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Thread.Sleep(2000);
                }
            }
            
        }
    }
}
