using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Temprature tm = new Temprature();
            Light light = new Light();
            Alarm alarm = new Alarm();
            tm.Hightemp += light.redLight;
            tm.Hightemp += alarm.activateAlarm;
            tm.Doentemp += light.yellowLight;
            tm.generateTemperature();
            Console.ReadKey();
        }
    }
}
