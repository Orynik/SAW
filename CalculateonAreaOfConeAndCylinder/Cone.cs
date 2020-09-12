using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateonAreaOfConeAndCylinder
{
    public class Cone
    {
        private int R;
        private int h;

        private SideAreaDependency Dependency = new SideAreaDependency();

        public Cone(int R,int h)
        {
            this.R = R;
            this.h = h;
        }   

        public double CalcSide()
        {
            return Math.PI * R * Dependency.l(R,h);
        }

        public int CalcFullArea()
        {
            return (int)(Dependency.Pi_R_Pow_2(R) + CalcSide());
        }

        public int CalcCapacity()
        {
            return (int)((1 / 3) * (Dependency.Pi_R_Pow_2(R) * h));
        }


    }
}
