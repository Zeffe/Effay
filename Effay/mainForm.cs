using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Citadel;
using cXML = ClosedXML.Excel;

namespace Effay
{
    public partial class mainForm : Form
    {
        List<Driver> drivers = new List<Driver>();

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            listDrivers.Items.Add("Don\t\t90%");
        }

        void populateList(string filePath)
        {
            using (cXML.XLWorkbook workbook = new cXML.XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheets.First();
                var range = worksheet.RangeUsed();

                for (int i = 1; i < range.RowCount() + 1; i++)
                {
                    drivers.Add(new Driver());
                    for (int j = 1; j < range.ColumnCount() + 1; j++)
                    {
                        drivers[i - 1].SetAttrib(j - 1, worksheet.Cell(i, j).Value.ToString());
                        //MessageBox.Show(j.ToString() + "::" + worksheet.Cell(i, j).Value.ToString());
                    }
                }
            }

            foreach (Driver driver in drivers)
            {
                try {
                    listDrivers.Items.Add(driver.Name);
                } catch
                {
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.SafeFileName.Split('.').Last() == "xlsx")
                {
                    txtLoaded.Text = openFileDialog1.FileName;
                    this.Text = "Effay - " + openFileDialog1.SafeFileName;
                    Effay.Text = "Effay - " + openFileDialog1.SafeFileName;
                    populateList(openFileDialog1.FileName);
                } else
                {
                    msgbox err = new msgbox("Please select a valid Excel file.", "Error", 1);
                    err.Show();
                }
            } 
        }
    }
}
