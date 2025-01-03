﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.StoletovNA.Sprint6.Task5.V12.Lib {
    public class DataService : ISprint6Task5V12 {

        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line  = reader.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] numsArray = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }

            numsArray = numsArray.Where(x => x % 5 != 0).ToArray();
            return numsArray;
        }
    }
}
