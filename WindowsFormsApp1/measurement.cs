using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Measurement
    {
        PolarVector a;
        PolarVector b;
        PolarVector c;
       

        public Measurement(float aLenght, int aAngle, bool al1, float bLenght, int bAngle, bool bl1, float cLenght, int cAngle, bool cl1)
        {
           
            if (!al1)
                aAngle = 360 - aAngle;
            a = new PolarVector(aLenght, aAngle, new System.Drawing.Point(0, 0));
            if (!bl1)
                bAngle = 360 - bAngle;
            b = new PolarVector(bLenght, bAngle, new System.Drawing.Point(0, 0));
            if (!cl1)
                cAngle = 360 - cAngle;
            c = new PolarVector(cLenght, cAngle, new System.Drawing.Point(0, 0));


        }

        internal PolarVector A { get => a; set => a = value; }
        internal PolarVector B { get => b; set => b = value; }
        internal PolarVector C { get => c; set => c = value; }
    }
}
