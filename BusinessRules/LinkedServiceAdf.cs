using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFactoryAnalyzer.BusinessRules
{
    public class LinkedServiceAdf
    {
        private string _linkedServiceName;
        private string _linkedServiceTypeConnection;
        private int _linkedServiceUsageCount;

        public string LinkedServiceName
        {
            get { return _linkedServiceName; }
            set { _linkedServiceName = value; }
        }

        public string LinkedServiceTypeConnection
        {
            get { return _linkedServiceTypeConnection; }
            set { _linkedServiceTypeConnection = value; }
        }

        public int LinkedServiceUsageCount
        {
            get { return _linkedServiceUsageCount; }
        }

        // create constructor for LinkedServiceAdf
        public LinkedServiceAdf(string linkedServiceName, string linkedServiceTypeConnection)
        {
            _linkedServiceName = linkedServiceName;
            _linkedServiceTypeConnection = linkedServiceTypeConnection;
            _linkedServiceUsageCount = 0;
        }


        // create method to increment usage count
        public void IncrementUsageCount()
        {
            ++_linkedServiceUsageCount;
        }

    }
}
