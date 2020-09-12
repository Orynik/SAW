using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationCapacityConeAndСylinder
{
    public class CylinderVolume
    {
        private int R;
        private int h;
        private VolumeDependency Dependency = new VolumeDependency();

        public CylinderVolume(int R, int h)
        {
            this.R = R;
            this.h = h;
        }

        public int CalcCapacity()
        {
            return (int)((Dependency.Pi_R_Pow_2(R) * h));
        }
    }
}
