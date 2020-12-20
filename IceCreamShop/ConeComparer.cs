using System.Collections.Generic;
namespace IceCreamShop
{
    class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            if (x.Cost - y.Cost < 0)
            {
                return -1;
            } 
            else if ( x.Cost - y.Cost > 0)
            {
                return 1;
            }
            return 0;

        }
    }
}
