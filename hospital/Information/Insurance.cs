using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information
{
    public class Insurance
    {
        public Dictionary<string, string> insuranceInfo { get; private set; }

        public Insurance(string iD, string groupID, string type, string provider)
        {
            SetupInfo();
            insuranceInfo["iD"] = iD;
            insuranceInfo["groupID"] = groupID;
            insuranceInfo["type"] = type;
            insuranceInfo["provider"] = provider;
        }

        private void SetupInfo()
        {
            insuranceInfo = new Dictionary<string,string>
            {
                { "iD", null }
               ,{ "groupID", null }
               ,{ "type", null }
               ,{ "provider", null }
            };
        }

        public string[] XMLOutput()
        {
            var insurance = new string[]
            {
                insuranceInfo["iD"]
               ,insuranceInfo["groupID"]
               ,insuranceInfo["type"]
               ,insuranceInfo["provider"]
            };
            return insurance;
        }
    }
}
