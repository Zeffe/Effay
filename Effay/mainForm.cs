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
        Driver averageDriver = new Driver();
        List<KeyValuePair<int, Xenon.ThirteenCheckBox>> checkBoxes = new List<KeyValuePair<int, Xenon.ThirteenCheckBox>>();
        Dictionary<int, Attribute> attributes = new Dictionary<int, Attribute>();
        Dictionary<Xenon.ThirteenCheckBox, NumericUpDown> Weights = new Dictionary<Xenon.ThirteenCheckBox, NumericUpDown>();
        bool started = false;
        Driver selectedDriver = null;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            averageDriver.Name = "Average";

            checkBoxes.Add(new KeyValuePair<int, Xenon.ThirteenCheckBox>(3, checkRackIn));
            checkBoxes.Add(new KeyValuePair<int, Xenon.ThirteenCheckBox>(4, checkRackStore));
            checkBoxes.Add(new KeyValuePair<int, Xenon.ThirteenCheckBox>(5, checkAvgRack));
            checkBoxes.Add(new KeyValuePair<int, Xenon.ThirteenCheckBox>(6, checkAvgLeg));
            checkBoxes.Add(new KeyValuePair<int, Xenon.ThirteenCheckBox>(7, checkAvgWait));
            checkBoxes.Add(new KeyValuePair<int, Xenon.ThirteenCheckBox>(8, checkNegWait));
            checkBoxes.Add(new KeyValuePair<int, Xenon.ThirteenCheckBox>(9, checkOtd15));
            checkBoxes.Add(new KeyValuePair<int, Xenon.ThirteenCheckBox>(10, checkOtd20));
            checkBoxes.Add(new KeyValuePair<int, Xenon.ThirteenCheckBox>(11, checkAvgOtd));
            checkBoxes.Add(new KeyValuePair<int, Xenon.ThirteenCheckBox>(12, checkAvgRun));
            checkBoxes.Add(new KeyValuePair<int, Xenon.ThirteenCheckBox>(13, checkCdt30));
            checkBoxes.Add(new KeyValuePair<int, Xenon.ThirteenCheckBox>(14, checkAvgCdt));
            checkBoxes.Add(new KeyValuePair<int, Xenon.ThirteenCheckBox>(15, checkOneAndTwo));

            foreach (KeyValuePair<int, Xenon.ThirteenCheckBox> checkbox in checkBoxes)
            {
                NumericUpDown tempWeight = new NumericUpDown();
                tempWeight.BackColor = Color.FromArgb(75, 75, 75);
                tempWeight.Location = new Point(nmModel.Location.X, checkbox.Value.Location.Y);
                tempWeight.ForeColor = Color.White;
                tempWeight.Size = nmModel.Size;
                tempWeight.Maximum = 100;
                tempWeight.Minimum = 0.01M;
                tempWeight.DecimalPlaces = 2;
                tempWeight.Increment = 1;
                tempWeight.Value = 7.69M;
                tempWeight.TextAlign = HorizontalAlignment.Right;
                tempWeight.Tag = checkbox.Key;
                tempWeight.ValueChanged += new EventHandler(nmChange);

                checkbox.Value.Parent.Controls.Add(tempWeight);
                checkbox.Value.CheckedChanged += new Xenon.ThirteenCheckBox.CheckedChangedEventHandler(checkChange);
                checkbox.Value.Tag = checkbox.Key;
                attributes.Add(checkbox.Key, new Attribute(checkbox.Key, 1));
                Weights.Add(checkbox.Value, tempWeight);
            }
        }

        private void nmChange(object sender, EventArgs e)
        {
            NumericUpDown tempWeight = sender as NumericUpDown;
            int attrib = Convert.ToInt32(tempWeight.Tag);

            if (attributes.ContainsKey(attrib))
            {
                attributes[attrib] = new Attribute(attrib, Convert.ToSingle(tempWeight.Value));
            } else
            {
                attributes.Add(attrib, new Attribute(attrib, Convert.ToSingle(tempWeight.Value)));
            }

            try { populateList(openFileDialog1.FileName); } catch { }
        }

        private void checkChange(object sender)
        {
            Xenon.ThirteenCheckBox tempCheck = sender as Xenon.ThirteenCheckBox;
            int attrib = Convert.ToInt32(tempCheck.Tag);
            Weights[tempCheck].Enabled = tempCheck.Checked;

            if (tempCheck.Checked && !attributes.ContainsKey(attrib))
            {
                attributes.Add(attrib, new Attribute(attrib, 7.69f));
            } else if (!tempCheck.Checked)
            {
                attributes.Remove(attrib);
            }

            try { populateList(openFileDialog1.FileName); } catch { }
        }

        void populateList(string filePath)
        {
            drivers.Clear();
            listDrivers.Items.Clear();

            int[] emptyColumns = { 18, 16, 6, 4, 1 };

            try {

                using (cXML.XLWorkbook workbook = new cXML.XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheets.First();
                    var range = worksheet.RangeUsed();

                    for (int i = 1; i < range.RowCount() + 1; i++)
                    {
                        drivers.Add(new Driver());
                        int skipped = 0;
                        for (int j = 1; j < range.ColumnCount() + 2; j++)
                        {
                            if (!emptyColumns.Contains(j) && (!String.IsNullOrEmpty(worksheet.Cell(i, 3).Value.ToString())) && worksheet.Cell(i, 3).Value.ToString() != "Driver")
                            {
                                drivers[i - 1].SetAttrib(j - skipped, worksheet.Cell(i, j).Value.ToString());
                                //MessageBox.Show((j - skipped).ToString() + "::" + worksheet.Cell(i, j).Value.ToString());
                            } else if (started && !emptyColumns.Contains(j) && String.IsNullOrEmpty(worksheet.Cell(i, 3).Value.ToString()))
                            {
                                averageDriver.SetAttrib(j - skipped, worksheet.Cell(i, j).Value.ToString());
                            } else
                            {
                                skipped++;
                            }
                        }
                        started = averageDriver.Empty();
                    }
                }

            } catch
            {
                msgbox err = new msgbox("Error, selected Excel file is currently being used by another program.", "Error", 1);
                err.Show();
            }

            for (int i = drivers.Count - 1; i >= 0; i--)
            {
                if (drivers[i].Empty()) drivers.RemoveAt(i);
                else if (drivers[i].RunCount < nmMinimum.Value) drivers.RemoveAt(i);
            }

            foreach (Driver driver in drivers)
            {
                try
                {
                    float skip = 0;
                    float efficiency = 0;
                    float divideBy = 0;

                    if (attributes.ContainsKey(8)) skip += attributes[8].weight;     // Skip NegWait

                    foreach (int attrib in attributes.Keys)
                    {
                        efficiency += CompareAttrib(attrib, driver, averageDriver) * (attributes[attrib].weight);
                        divideBy += attributes[attrib].weight;
                    }

                    efficiency /= divideBy - skip;
                    efficiency *= 100;
                    driver.Efficiency = efficiency;
                } catch
                {
                }
            }

            sortDrivers();

            foreach (Driver driver in drivers)
            {
                listDrivers.Items.Add(driver.Name + "\t" + driver.Efficiency.ToString("0.00") + "%");

            }
        }

        private void sortDrivers()
        {
            for (int j = 0; j < drivers.Count; j++)
            {
                for (int i = 0; i < drivers.Count - 1; i++)
                {
                    if (drivers[i].Efficiency < drivers[i + 1].Efficiency)
                    {
                        Driver temp = drivers[i];
                        drivers[i] = drivers[i + 1];
                        drivers[i + 1] = temp;
                    }
                }
            }
        }

        private float CompareAttrib(int attrib, Driver driver, Driver average)
        {
            switch (attrib)
            {
                case 1: return 1;
                case 2: return 1;
                case 3:
                    if (driver.RackIn != 0) return average.RackIn / driver.RackIn;
                    else return 1;
                case 4:
                    if (driver.RackStore != 0) return average.RackStore / driver.RackStore;
                    else return 1;
                case 5:
                    return average.AvgRack / driver.AvgRack;
                case 6:
                    return average.AvgLeg / driver.AvgLeg;
                case 7:
                    return average.AvgWait / driver.AvgWait;
                case 8:
                    return -driver.NegWait;
                case 9:
                    return driver.Otd15 / average.Otd15;
                case 10:
                    return driver.Otd20 / average.Otd20;
                case 11:
                    return average.AvgOtd / driver.AvgOtd;
                case 12:
                    return average.AvgRun / driver.AvgRun;
                case 13:
                    return driver.Cdt30 / average.Cdt30;
                case 14:
                    return average.AvgCdt / driver.AvgCdt;
                case 15:
                    return driver.OneAndTwo;
                case 16: return 1;
                default: return 0;
            }
        }

        private void btnRefresh_MouseEnter(object sender, EventArgs e)
        {
            btnRefresh.Image = Properties.Resources.refresh_buttonU;
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.Image = Properties.Resources.refresh_button;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                populateList(openFileDialog1.FileName);
            }
            catch { }
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

        private void listDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listDrivers.SelectedIndex;

            if (index != -1)
            {
                thirteenTabControl1.SelectedTab = tabPage3;
                selectedDriver = drivers[index];
                lblSelected.Text = selectedDriver.Name;
                lblStore.Text = selectedDriver.Store.ToString();
            }
        }

        private void checkAll_CheckedChanged(object sender)
        {
            foreach (KeyValuePair<int, Xenon.ThirteenCheckBox> checkbox in checkBoxes)
            {
                checkbox.Value.Checked = checkAll.Checked;
                Weights[checkbox.Value].Enabled = checkAll.Checked;
            }     
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (NumericUpDown tempWeight in Weights.Values)
            {
                tempWeight.Value = 7.69M;
            }
        }

        private void cmbAttribute_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbAttribute.SelectedIndex;
            int attribute = cmbAttribute.SelectedIndex + 3;

            if (index != -1 && selectedDriver != null)
            {
                txtDriver.Text = selectedDriver.GetAttrib(attribute).ToString();
                txtAverage.Text = averageDriver.GetAttrib(attribute).ToString();
                txtEfficiency.Text = (CompareAttrib(attribute, selectedDriver, averageDriver) * 100).ToString() + "%";
            }
        }
    }
}
