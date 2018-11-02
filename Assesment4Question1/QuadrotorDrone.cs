using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment4
{
    class QuadrotorDrone : Drone
    {
        public int totalFlyTime1 = 1;
        public int totalDistance1 = 1;
        public QuadrotorDrone()
        {
        }

        public QuadrotorDrone(int TotalFlyTime, int TotalDistance) : base(TotalFlyTime, TotalDistance)
        {
        }
        public override int FlightSpeed(int totalFlyTime, int totalDistance)
        {
            int calcualtedSpeed;
            totalFlyTime = totalFlyTime + totalFlyTime1;
            totalDistance = totalDistance + totalDistance1;
            return calcualtedSpeed = totalFlyTime / totalDistance;
        }

    }
}

