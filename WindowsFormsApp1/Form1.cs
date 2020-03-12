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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Measurement measurement1 = new Measurement(100F, 0, true, 100F, 120, true, 100F, 120, false);
            Image image=new Image(diagramm.Width, diagramm.Height);
            image.DrawMeasurement(measurement1);
            diagramm.Image = image.Bmp;
            
            
        }

        

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Diagramm_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellEndEdit (object sender, DataGridViewCellEventArgs e)
        {
            try { 
            PolarVector [] a =  new PolarVector [12];
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


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
