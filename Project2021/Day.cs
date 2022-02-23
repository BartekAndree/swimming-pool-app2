using System;
using System.Collections.Generic;
using System.Text;

namespace Project2021
{
    class Day
    {
        public Dictionary<int, Pool> olympicSwimmingPool = new Dictionary<int, Pool>();
        
        public Pool hour6 = new Pool();
        public Pool hour7 = new Pool();
        public Pool hour8 = new Pool();
        public Pool hour9 = new Pool();
        public Pool hour10 = new Pool();
        public Pool hour11 = new Pool();
        public Pool hour12 = new Pool();
        public Pool hour13 = new Pool();
        public Pool hour14 = new Pool();
        public Pool hour15 = new Pool();
        public Pool hour16 = new Pool();
        public Pool hour17 = new Pool();
        public Pool hour18 = new Pool();
        public Pool hour19 = new Pool();
        public Pool hour20 = new Pool();
        public Pool hour21 = new Pool();
        public Pool hour22 = new Pool();
        public Day()
        {
            olympicSwimmingPool.Add(6,hour6);
            olympicSwimmingPool.Add(7,hour7);
            olympicSwimmingPool.Add(8,hour8);
            olympicSwimmingPool.Add(9, hour9);
            olympicSwimmingPool.Add(10, hour10);
            olympicSwimmingPool.Add(11, hour11);
            olympicSwimmingPool.Add(12, hour12);
            olympicSwimmingPool.Add(13, hour13);
            olympicSwimmingPool.Add(14, hour14);
            olympicSwimmingPool.Add(15, hour15);
            olympicSwimmingPool.Add(16, hour16);
            olympicSwimmingPool.Add(17, hour17);
            olympicSwimmingPool.Add(18, hour18);
            olympicSwimmingPool.Add(19, hour19);
            olympicSwimmingPool.Add(20, hour20);
            olympicSwimmingPool.Add(21, hour21);
            olympicSwimmingPool.Add(22, hour22);
        }
    }
}
