using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataBase
{
    public struct Processor
    {
        public string Name;
        public string Socket;
        public string Producer;
        public int MinFrequency;
        public int MaxFrequency;
        public string CoreName;
        public int CountCore;
        public int CacheVolume1;
        public int CacheVolume2;
        public int CacheVolume3;
        public int MaxPower;
        public double MaxTemperature;
        //public Bitmap Image;
        public double Cost;
    }
    class Component
    {
    }
}
