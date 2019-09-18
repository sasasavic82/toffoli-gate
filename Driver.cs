using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace toffoli_gate
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var sim = new QuantumSimulator())
            {
                
                var res = ThreeQbitsRun.Run(sim).Result;
                var (p000, p001, p010, p011, p100, p101, p110, p111) = res;
                System.Console.WriteLine("000 -> " + p000 / 10000.0);
                System.Console.WriteLine("001 -> " + p001 / 10000.0);
                System.Console.WriteLine("010 -> " + p010 / 10000.0);
                System.Console.WriteLine("011 -> " + p011 / 10000.0);
                System.Console.WriteLine("100 -> " + p100 / 10000.0);
                System.Console.WriteLine("101 -> " + p101 / 10000.0);
                System.Console.WriteLine("110 -> " + p110 / 10000.0);
                System.Console.WriteLine("111 -> " + p111 / 10000.0);
            }
            
            System.Console.ReadKey();
        }
    }
}