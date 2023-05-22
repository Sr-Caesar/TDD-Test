using EsameTesting.Objects;

namespace EsameTesting
{
    public static class Checker
    {
        public static PVG CheckPath(PVG G1, PVG G2, PVG G3, PVG G4)
            => Compare(Compare(G1, G2), Compare(G3, G4));
        
       

    public static PVG Compare(PVG pvg1, PVG pvg2)
        {
            int g1 = 0;
            int v1 = 0;
            int p1 = 0;
            if (pvg1.GetG.Price <= pvg2.GetG.Price)
            {
                g1 = pvg2.GetG.Price;
            }
            if (pvg1.GetV.Price <= pvg2.GetV.Price)
            {
                v1 = pvg2.GetV.Price;
            }
            if (pvg1.GetP.Price <= pvg2.GetP.Price)
            {
                p1 = pvg2.GetP.Price;
            }
            P my_P = new(p1);
            V my_V = new(v1, my_P);
            G my_G = new(g1, my_V);

            return new PVG(my_P, my_V, my_G);
        }
    }
}
