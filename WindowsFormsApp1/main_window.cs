using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class main_window: Form
    {
        public main_window()
        {
            InitializeComponent();
            Measurement measurement1 = new Measurement(100F, 0, true, 100F, 120, true, 100F, 120, false);
            Image image = new Image(pictureBox1.Width, pictureBox1.Height);
            image.DrawMeasurement(measurement1);
            pictureBox1.Image = image.Bmp;
            
        }

        private void main_window_Load(object sender, EventArgs e)
        {

        }

        private void Add_Row_Button_Click(object sender, EventArgs e)
        {
            DataRow row;
            row = dataTable1.NewRow();
            dataTable1.Rows.Add(row);


        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PolarVector[] a = new PolarVector[12];
                a[0] = new PolarVector((float)dataGridView1.Rows[0].Cells[1].Value,
                    (float)dataGridView1.Rows[0].Cells[2].Value, new Point(0, 0));
            }

            catch (System.NullReferenceException)
            {


            }
            catch (System.InvalidCastException)
            {


            };

            Measurement measurement2 = new Measurement(100F, 30, true, 100F, 150, true, 100F, 90, false);


        }
        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the row error in case the user presses ESC.   
            dataGridView1.Rows[e.RowIndex].ErrorText = String.Empty;
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Draw_Click(object sender, EventArgs e)
        {
            PolarVector[] vector =  new PolarVector[dataTable1.Rows.Count];
            Image image = new Image(pictureBox1.Width, pictureBox1.Height);
            int i=0;
            foreach (DataRow row in dataTable1.Rows)
            {
                   vector[i] = new PolarVector(row[data_table1_name].ToString(), (double)row[data_table1_scale], (double)row[data_table1_angle], new Point(pictureBox1.Width/2, pictureBox1.Height/2));
                   image.DrawVector(vector[i], i);
                   pictureBox1.Image = image.Bmp;
                   i++;        
            }
            
        }
    }
}
