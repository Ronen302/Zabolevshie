using System;

namespace Zabolevshie
{
    class Program
    {
        static void Main(string[] args)
        {
            float NN = 300, zz = 1, kk = 0.5f, nn = 1, vv = 0, ww = 0;

            int i = 0, D = 50;
            float[] A = new float[6] { 0, 0, 0, 0, 0, 0 };
            float n0 = nn;

            for (i = 0; i < D; i++)
            {
                Console.WriteLine($"i = {i + 1}, z = {zz:f1}, v = {vv:f1}, n = {nn:f1}, NN - nn - ww = {(NN - nn - ww)}");

                if (i > 5)
                {
                    vv = A[(i % 6)];
                }

                A[i % 6] = zz;
                zz = kk * (NN - nn - ww) / (NN - n0) * nn;
                nn = nn + zz - vv;
                ww = ww + vv;
            }
        }
    }
}
