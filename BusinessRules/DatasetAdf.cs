using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFactoryAnalyzer.BusinessRules
{
    /// <summary>
    /// 
    /// </summary>
    public class DatasetAdf
    {
        private string _datasetName;
        private string _datasetType;
        private string _datasetRefLinkedServiceName;
        private int _datasetUsageCount;

        public string DatasetName
        {
            get { return _datasetName; }
            set { _datasetName = value; }
        }

        public string DatasetType
        {
            get { return _datasetType; }
            set { _datasetType = value; }
        }

        public string DatasetRefLinkedServiceName
        {
            get { return _datasetRefLinkedServiceName; }
            set { _datasetRefLinkedServiceName = value; }
        }

        public int DatasetUsageCount
        {
            get { return _datasetUsageCount; }
        }

        // Create constructor for DatasetAdf
        public DatasetAdf(string datasetName, string datasetType, string datasetRefLinkedServiceName)
        {
            _datasetName = datasetName;
            _datasetType = datasetType;
            _datasetRefLinkedServiceName = datasetRefLinkedServiceName;
            _datasetUsageCount = 0;
        }

        // create method to increment usage count
        public void IncrementUsageCount()
        {
            ++_datasetUsageCount;
        }

        // Create method to get objects from XML file
        public void GetObjectsFromXML()
        {
            // Get objects from XML file
        }

    }
}
