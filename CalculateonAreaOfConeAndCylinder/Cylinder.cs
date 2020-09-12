using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateonAreaOfConeAndCylinder
{
    public class Cylinder
    {
        private int R;
        private int h;
        private SideAreaDependency Dependency = new SideAreaDependency();

        public Cylinder(int R, int h)
        {
            this.R = R;
            this.h = h;
        }

        public int CalcFullArea()
        {
            return (int)(2 * Dependency.Pi_R(R) * (R + h));
        }

        public int CalcCapacity()
        {
            return (int)((1 / 3) * (Dependency.Pi_R_Pow_2(R) * h));
        }
    }
}
