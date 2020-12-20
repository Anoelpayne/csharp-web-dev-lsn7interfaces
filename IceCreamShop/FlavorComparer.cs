using System.Collections.Generic;
namespace IceCreamShop
{
    class FlavorComparer : IComparer<Flavor>
    {
        public int Compare(Flavor x, Flavor y)
        {
            if (x.Allergens.Count - y.Allergens.Count < 0)
            {
                return -1;
            }
                else if (x.Allergens.Count - y.Allergens.Count > 0)
            {
                return 1;
            }
            return 0;
        }
    }
}
