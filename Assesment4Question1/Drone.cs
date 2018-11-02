using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment4
{
    public abstract class Drone
    {
        private int totalFlyTime;//Minutes
        private int totalDistance;//Feet

        public Drone()
        {
        }
        public Drone(int TotalFlyTime, int TotalDistance)
        {
            totalDistance = TotalDistance;
            totalFlyTime = TotalFlyTime;
        }

        public int TotalFlyTime { get; set; }
        public int TotalDistance { get; set; }
        public virtual int FlightSpeed(int totalFlyTime, int totlDistance)
        {
            int calcualtedSpeed;
            return calcualtedSpeed = totalFlyTime / totalDistance;
        }

    }
}
