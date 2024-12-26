using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using Tyuiu.MironenkoSE.Sprint7.Project.V11.Lib;
using System.Windows.Forms.DataVisualization.Charting;
namespace Tyuiu.MironenkoSE.Sprint7.Project.V11
    
{
    public partial class FormMain : Form
    {
        public FormMain()

        {
            InitializeComponent();

        }

        DataService ds = new DataService();
        static string openFilePath;
        static int rows;
        static int columns;
        int index;

        private void toolStripHelp_MSE_Click(object sender, EventArgs e)
        {
            FormManual formHelp = new FormManual();
            formHelp.ShowDialog();
        }

        private void toolStripButton_Info_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void toolStripExit_MSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItemSave_MSE_Click(object sender, EventArgs e) //
        {
            saveFileDialog_MSE.FileName = openFilePath;
            saveFileDialog_MSE.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_MSE.ShowDialog();

            string path = saveFileDialog_MSE.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridView_MSE.RowCount;
            int columns = dataGridView_MSE.ColumnCount;

            string str = "";



            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridView_MSE.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridView_MSE.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void ToolStripMenuItemFile_MSE_Click_1(object sender, EventArgs e)//
        {
            try
            {
                openFileDialog_MSE.ShowDialog();
                openFilePath = openFileDialog_MSE.FileName;
                string[,] matrix = ds.LoadFromDataFile(openFilePath);
                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridView_MSE.RowCount = rows + 1;
                dataGridView_MSE.ColumnCount = columns;

                //
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridView_MSE.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                dataGridView_MSE.AutoResizeColumns();
                //
                for (int i = 0; i < dataGridView_MSE.RowCount - 1; i++)
                {

                    if (dataGridView_MSE.Rows[i].Cells[3].Value.ToString() == "")
                    {
                        dataGridView_MSE.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            catch
            {
                MessageBox.Show(".", ".", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripTextBoxSearch_MSE_Click(object sender, EventArgs e)
        {
            //

        }

        private void buttonGrafClock_MSE_Click(object sender, EventArgs e)
        {

            // 
            chart_MSE.Series.Clear();

            //
            Series splineSeries = new Series
            {
                Name = "Заработок",
                Color = System.Drawing.Color.Blue,
                ChartType = SeriesChartType.Spline // 
            };

            // 
            foreach (DataGridViewRow row in dataGridView_MSE.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    string lastName = row.Cells[0].Value.ToString();
                    if (double.TryParse(row.Cells[10].Value.ToString(), out double hours))
                    {
                        // 
                        int index = row.Index;
                        splineSeries.Points.AddXY(index, hours);

                        // 
                        DataPoint point = splineSeries.Points[splineSeries.Points.Count - 1];
                        point.Label = lastName; // 
                    }
                }
            }

            // 
            chart_MSE.Series.Add(splineSeries);

            // 
            chart_MSE.ChartAreas[0].AxisX.Title = "";
            chart_MSE.ChartAreas[0].AxisY.Title = "";

            splineSeries.IsValueShownAsLabel = true; // 
        }

        private void buttonGtafMoney_MSE_Click(object sender, EventArgs e)
        {
            // 
            chart_MSE.Series.Clear();

            // 
            Series splineSeries = new Series
            {
                Name = "Series 1",
                Color = System.Drawing.Color.Blue,
                ChartType = SeriesChartType.Spline // 
            };

            // 
            foreach (DataGridViewRow row in dataGridView_MSE.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[11].Value != null)
                {
                    string lastName = row.Cells[0].Value.ToString();
                    if (double.TryParse(row.Cells[11].Value.ToString(), out double hours))
                    {
                        //
                        int index = row.Index;
                        splineSeries.Points.AddXY(index, hours);

                        //
                        DataPoint point = splineSeries.Points[splineSeries.Points.Count - 1];
                        point.Label = lastName; // 
                    }
                }
            }

            // 
            chart_MSE.Series.Add(splineSeries);

            // 
            chart_MSE.ChartAreas[0].AxisX.Title = "Series 1";
            chart_MSE.ChartAreas[0].AxisY.Title = "Series 2";

            // 
            splineSeries.IsValueShownAsLabel = true; // 
        }



        private void buttonDone_MSE_Click_1(object sender, EventArgs e)
        {
            string surname = textBoxSurname_MSE.Text;
            string name = textBoxName_MSE.Text;
            string middle = textBoxMiddle_MSE.Text; // 
            string telephone = textBoxTel_MSE.Text;
            string data = textBoxData_MSE.Text;
            string mesto = textBoxMesto_MSE.Text;
            string post = textBoxPost_MSE.Text;
            string work = textBoxWork_MSE.Text;
            string birtday = textBoxBirtday_MSE.Text;
            string education = textBoxEducation_MSE.Text;
            string clock = textBoxClock_MSE.Text;
            string money = textBoxMoney_MSE.Text;

            // 
            dataGridView_MSE.Rows.Add(surname, name, middle, telephone, data, mesto, post, work, birtday, education, clock, money);
            textBoxSurname_MSE.Text = "";
            textBoxName_MSE.Text = "";
            textBoxMiddle_MSE.Text = "";
            textBoxTel_MSE.Text = "";
            textBoxData_MSE.Text = "";
            textBoxMesto_MSE.Text = "";
            textBoxPost_MSE.Text = "";
            textBoxWork_MSE.Text = "";
            textBoxBirtday_MSE.Text = "";
            textBoxEducation_MSE.Text = "";
            textBoxClock_MSE.Text = "";
            textBoxMoney_MSE.Text = "";
            dataGridView_MSE.CurrentCell = dataGridView_MSE.Rows[dataGridView_MSE.Rows.Count - 1].Cells[0];

        }

        private void buttonDel_MSE_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Удаление прошло успешно\n", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                index = dataGridView_MSE.CurrentCell.RowIndex;
                dataGridView_MSE.Rows.RemoveAt(index);
            }
        }



        private void buttonStaff_MSE_Click(object sender, EventArgs e)
        {
            int min = 0;
            int max = 0;
            //
            int rows = dataGridView_MSE.RowCount;
            int columns = dataGridView_MSE.ColumnCount;
            string str;
            string[,] matrix = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    str = "";
                    str += dataGridView_MSE.Rows[i].Cells[j].Value;
                    matrix[i, j] = str;
                }

            }

            double summalet = 0;
            int k = 0;
            double srzn = 0;
            // 
            for (int i = 0; i < rows - 1; i++)
            {
                k++;
                textBoxStaff_MSE.Text = k.ToString();

            }
        }

        private void labelMoney_MSE_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSearch_MSE_ButtonClick(object sender, EventArgs e)
        {

        }

        private void dataGridView_MSE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelPost_MSE_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxInPut_MSE_Enter(object sender, EventArgs e)
        {

        }

        private void labelData_MSE_Click(object sender, EventArgs e)
        {

        }

        private void labelSurName_MSE_Click(object sender, EventArgs e)
        {

        }

        private void chart_MSE_Click(object sender, EventArgs e)
        {

        }
    }

}