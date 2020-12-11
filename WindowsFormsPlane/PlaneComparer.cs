using System.Collections.Generic;
namespace WindowsFormsPlane
{
    public class PlaneComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is BomberPlane && y is BomberPlane)
            {
                return ComparerBomberPlane((BomberPlane)x, (BomberPlane)y);
            }
            if(x is Plane && y is BomberPlane)
            {
                return 1;
            }
            if (x is BomberPlane && y is Plane)
            {
                return -1;
            }
            if (x is Plane && y is Plane)
            {
                return ComparerPlane((Plane)x, (Plane)y);
            }
            return 0;
        }
        private int ComparerPlane(Plane x, Plane y)
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
        private int ComparerBomberPlane(BomberPlane x, BomberPlane y)
        {
            var res = ComparerPlane(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Bombs != y.Bombs)
            {
                return x.Bombs.CompareTo(y.Bombs);
            }
            if (x.TurboEngine != y.TurboEngine)
            {
                return x.TurboEngine.CompareTo(y.TurboEngine);
            }
            return 0;
        }
    }
}