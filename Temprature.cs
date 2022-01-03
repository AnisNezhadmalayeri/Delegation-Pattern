using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Delegate
{
    public delegate void InformTemperature(int t);
    class Temprature
    {
        public int min = 0, max = 100, treshold = 80;
        public event InformTemperature Hightemp;
        public event InformTemperature Doentemp;
        Random r = new Random();
        public void generateTemperature()
        {
            for (int i = 0; i < 15; i++)
            {
                int temperature;
                Thread.Sleep(1000);
                temperature = r.Next(min, max);
                if (temperature > treshold)
                {
                    Hightemp(temperature);
                }
                if (temperature < treshold)
                {
                    Doentemp(temperature);
                }
            }
        }
    }
}
