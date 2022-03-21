using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianCenuseStateAnalyzer
{
    public class StateCode
    {
        public int serialNumber;
        public string stateName;
        public string tin;
        public string stateCode;
        public StateCode(string v1,string v2,string v3,string v4)
        {
            serialNumber = Convert.ToInt32(v1);
            stateName = v2;
            tin = Convert.ToString(v3);
            stateCode = v4;
        }

    }
}
