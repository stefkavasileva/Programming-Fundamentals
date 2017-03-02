﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hospital
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        long treatedPatients = 0;
        long untreatedPatients = 0;
        int doctors = 7;

        for (int i = 1; i <= n; i++)
        {
            int patients = int.Parse(Console.ReadLine());

            if (i % 3 == 0 && untreatedPatients > treatedPatients)
            {
                ++doctors;
            }

            if (patients <= doctors)
            {
                treatedPatients += patients;
            }
            else
            {
                treatedPatients += doctors;
                untreatedPatients += patients - doctors;
            }



        }

        Console.WriteLine("Treated patients: {0}.", treatedPatients);
        Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
    }
}

