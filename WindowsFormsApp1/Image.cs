using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Image
    {
        public Bitmap Bmp { get; set; }
        int width;
        int height;
        public Image(int width, int height)
        {
            this.width = width;
            this.height = height;
            Bmp = new Bitmap(width, height);
            Graphics graph = Graphics.FromImage(Bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawLine(pen, width/2, height, width/2, 0);
            graph.DrawLine(pen, 0, height/2, width , height/2);
            graph.DrawEllipse(pen, 0,0, width , height );
            graph.DrawEllipse(pen, width / 4, height / 4,  height/2, width/2);
        }
        public Bitmap DrawMeasurement (Measurement measurement)
        {
            
            Graphics graph = Graphics.FromImage(Bmp);
            Pen pen = new Pen(Color.Yellow, 8.0F) ;
            pen.Color = System.Drawing.Color.Yellow;
            
            graph.DrawLine(pen, PointF.Add(new Point(0, 0), new Size(height / 2, width / 2)), PointF.Add(measurement.A.EndPoint, new Size(height / 2, width / 2)));
            pen.Color = System.Drawing.Color.Green;
            graph.DrawLine(pen, PointF.Add(new Point(0,0),new Size(height / 2, width / 2)), PointF.Add(measurement.B.EndPoint, new Size(height / 2, width / 2)));
            pen.Color = System.Drawing.Color.Red;
            graph.DrawLine(pen, PointF.Add(new Point(0, 0), new Size(height / 2, width / 2)), PointF.Add(measurement.C.EndPoint, new Size(height / 2, width / 2)));
            return Bmp;



        }
    }
}
