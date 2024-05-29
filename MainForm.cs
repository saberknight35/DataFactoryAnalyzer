using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json; // Add reference to Newtonsoft.Json library
using DataFactoryAnalyzer.BusinessRules;

namespace DataFactoryAnalyzer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

        private List<LinkedServiceAdf> lstLinkedServiceAdf = new List<LinkedServiceAdf>();
        private List<DatasetAdf> lstDatasetAdf = new List<DatasetAdf>();

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFolder = folderBrowserDialog1.SelectedPath;
                txbFolderPath.Text = selectedFolder;
                ParseAdfJsonFiles(selectedFolder);
            }
        }

        private void ParseAdfJsonFiles(string folderPath)
        {
            ParseAdfLinkedServiceJsonFiles(folderPath + "\\linkedService");
            ParseAdfDatasetJsonFiles(folderPath + "\\dataset");
        }

        private void ParseAdfLinkedServiceJsonFiles(string folderPath)
        {
            lsbJsonFileList.Items.Clear();
            var linkedServiceJsonFiles = Directory.EnumerateFiles(folderPath, "*.json");

            foreach (var file in linkedServiceJsonFiles)
            {
                try
                {
                    string jsonString = File.ReadAllText(file);
                    dynamic jsonData = JsonConvert.DeserializeObject(jsonString);

                    string linkedServiceName = jsonData["name"];
                    string linkedServiceTypeConnection = jsonData["properties"]["type"];

                    LinkedServiceAdf linkedService = new LinkedServiceAdf(linkedServiceName, linkedServiceTypeConnection);
                    lstLinkedServiceAdf.Add(linkedService);

                    //lsbJsonFileList.Items.Add(Path.GetFileName(file) + ": " + linkedService.LinkedServiceName + " - " + linkedService.LinkedServiceTypeConnection + " - Usage Count: " + linkedService.LinkedServiceUsageCount);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error parsing file: " + file + ", Exception: " + ex.Message);
                    // You can add a message box to display the error to the user
                }
            }
        }

        private void ParseAdfDatasetJsonFiles(string folderPath)
        {
            lsbJsonFileList.Items.Clear();
            var datasetJsonFiles = Directory.EnumerateFiles(folderPath, "*.json");

            foreach (var file in datasetJsonFiles)
            {
                try
                {
                    string jsonString = File.ReadAllText(file);
                    dynamic jsonData = JsonConvert.DeserializeObject(jsonString);

                    string datasetName = jsonData["name"];
                    string datasetType = jsonData["properties"]["type"];
                    string datasetRefLinkedServiceName = jsonData["properties"]["linkedServiceName"]["referenceName"];

                    DatasetAdf dataset = new DatasetAdf(datasetName, datasetType, datasetRefLinkedServiceName);
                    lstDatasetAdf.Add(dataset);
                    lstLinkedServiceAdf.Find(x => x.LinkedServiceName == datasetRefLinkedServiceName).IncrementUsageCount();

                    //lsbJsonFileList.Items.Add(Path.GetFileName(file) + ": " + dataset.DatasetName + " - " + dataset.DatasetType + " - " + dataset.DatasetRefLinkedServiceName + " - Usage Count: " + dataset.DatasetUsageCount);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error parsing file: " + file + ", Exception: " + ex.Message);
                    // You can add a message box to display the error to the user
                }
            }
        }

        private void btnShowSummary_Click(object sender, EventArgs e)
        {
            txbLinkedServiceSummary.Text = "Linked Service Summary:\r\n";
            txbLinkedServiceSummary.Text += "Linked Service Name - Linked Service Type - Usage Count\r\n";
            foreach (var linkedService in lstLinkedServiceAdf)
            {
                txbLinkedServiceSummary.Text += linkedService.LinkedServiceName + " - " + linkedService.LinkedServiceTypeConnection + " - " + linkedService.LinkedServiceUsageCount + "\r\n";
            }

            txbDatasetSummary.Text = "Dataset Summary:\r\n";
            txbDatasetSummary.Text += "Dataset Name - Dataset Type - Linked Service Name - Usage Count\r\n";
            foreach (var dataset in lstDatasetAdf)
            {
                txbDatasetSummary.Text += dataset.DatasetName + " - " + dataset.DatasetType + " - " + dataset.DatasetRefLinkedServiceName + " - " + dataset.DatasetUsageCount + "\r\n";
            }
        }
    }
}
