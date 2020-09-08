using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WindowsFormsApp1
{

    class Vector
    {
        PointF startPoint;
        PointF endPoint;
        double length;
        public PointF StartPoint { get => startPoint; set => startPoint = value; }
        public PointF EndPoint { get => endPoint; set => endPoint = value; }
        public double Length { get => length; set => length = value; }
    }

    class PolarVector:Vector
    {
        //way derecion;
        float angle;
        public float Angle { get => angle; set => angle = value; }

        public PolarVector(float lenght, float angle, Point StartPoint/*, way way*/)
        {
  //          if (lenght == false) lenght = 0;
 //         if (angle == false) angle = 0;
            this.StartPoint = StartPoint;
            EndPoint = new PointF((float)(lenght * Math.Cos(Math.PI * angle / 180.0)), (float)(lenght * Math.Sin(Math.PI * angle / 180.0)));
            this.Length = lenght;
            this.angle = angle;
            
           // this.derecion = way;
        }

        public PolarVector()
        {
        }
    }
}
