using LaboratoryDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaboratoryDLL;

namespace FinLabAct3_FuentesAngeles
{
    public partial class EquipmentsData : Form
    {
        public EquipmentsData()
        {
            InitializeComponent();
            LoadGraph();
        }

        public void LoadGraph()
        {
            LabHelper labHelper = new LabHelper();  
            // Call the GetEquipmentData method to retrieve equipment data
            DataTable equipmentData = labHelper.GetEquipmentDataGraph();

            // Clear existing series in the chart
            chart1.Series.Clear();

            // Add a new series for the bar graph
            chart1.Series.Add("EquipmentQuantity");
            chart1.Series["EquipmentQuantity"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

            // Add data points to the series
            foreach (DataRow row in equipmentData.Rows)
            {
                string equipmentName = row["EquipmentName"].ToString();
                int equipmentQuantity = Convert.ToInt32(row["EquipmentQuantity"]);

                // Add data point to the series
                chart1.Series["EquipmentQuantity"].Points.AddXY(equipmentName, equipmentQuantity);
            }

            // Set chart title and axis labels
            chart1.Titles.Add("Equipment Quantity Per Product");
            chart1.ChartAreas[0].AxisX.Title = "Equipment Name";
            chart1.ChartAreas[0].AxisY.Title = "Quantity";
        }

    }
}
