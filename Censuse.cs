using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianCenuseStateAnalyzer
{
    internal class Censuse
    {
        public int serialNumber;
        public string stateName;
        public string state;
        public int tin;
        public string stateCode;
        public long population;
        public long density;
        public long area;
        public long housingunit;
        public double totalArea;
        public long waterArea;
        public double landArea;
            public long populationDensity;
        public double housingDensity;

        public Censuse(StateCode statecode)
        {
            this.serialNumber = statecode.serialNumber;
            this.stateName=statecode.stateName;
            this.tin = statecode.tin;
            this.stateCode=statecode.stateCode;
        }
        public Censuse(CensuseData censuseData)
        {
            this.state = censuseData.state;
            this.population = censuseData.population;
            this.area = censuseData.area;
            this.density = censuseData.density;

        }

    }
}
