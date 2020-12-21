using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTech
{
	class VehicleComparer : IComparer<Vehicle>
	{
        public int Compare(Vehicle x, Vehicle y)
        {
            if(x is ArmoredVehicle && y is ArmoredVehicle)
            {
                return -ComparerArmoredVehicle((ArmoredVehicle)x, (ArmoredVehicle)y);
            }
            if (x is Tank && y is Tank)
            {
                return -ComparerTank((Tank)x, (Tank)y);
            }
            if (x is ArmoredVehicle && y is Tank)
            {
                return -1;
            }
            if (x is Tank && y is ArmoredVehicle)
            {
                return 1;
            }
            return 0;
        }
        private int ComparerArmoredVehicle(ArmoredVehicle x, ArmoredVehicle y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerTank(Tank x, Tank y)
        {
            var res = ComparerArmoredVehicle(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.SecColor != y.SecColor)
            {
                return x.SecColor.Name.CompareTo(y.SecColor.Name);
            }
            if (x.Tower != y.Tower)
            {
                return x.Tower.CompareTo(y.Tower);
            }
            if (x.Camo != y.Camo)
            {
                return x.Camo.CompareTo(y.Camo);
            }
            return 0;
        }
    }
}

