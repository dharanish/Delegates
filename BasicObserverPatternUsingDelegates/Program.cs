using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicObserverPatternUsingDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainSignal signal = new TrainSignal();
            Car c = new Car(signal);
            Bus b = new Bus(signal);
            signal.HereComesTheTrain();
        }
    }

    public class TrainSignal
    {
        public event Action TrainIsComing;
        public void HereComesTheTrain()
        {
            TrainIsComing();
        }
    }

    public class Car
    {
        public Car(TrainSignal trainSignal)
        {
            trainSignal.TrainIsComing += () => Console.WriteLine("Stop");
        }
    }

    public class Bus
    {
        public Bus(TrainSignal signal)
        {
            signal.TrainIsComing += () => Console.WriteLine("Stop with 10 mts distance");
        }
    }
}
