using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Smartphone
{
    class Program
    {
        static bool vecini(int i, int j)
        {
            if (i == 1)
                if (j == 2 || j == 4 || j == 5)
                    return true;
            if (i == 2)
                if (j == 1 || j == 3 || j == 4 || j == 5 || j == 6)
                    return true;
            if (i == 3)
                if (j == 2 || j == 5 || j == 6)
                    return true;
            if (i == 4)
                if (j == 1 || j == 2 || j == 5 || j == 7 || j == 8)
                    return true;
            if (i == 5)
                if (j == 1 || j == 2 || j == 3 || j == 4 || j == 6 || j == 7 || j == 8 || j == 9)
                    return true;
            if (i == 6)
                if (j == 2 || j == 3 || j == 5 || j == 8 || j == 9)
                    return true;
            if (i == 7)
                if (j == 4 || j == 5 || j == 8)
                    return true;
            if (i == 8)
                if (j == 4 || j == 5 || j == 6 || j == 7 || j == 9)
                    return true;
            if (i == 9)
                if (j == 5 || j == 6 || j == 8)
                    return true;
            return false;

        }
        static void Main(string[] args)
        { 
            int n, x, C;
            n = int.Parse(Console.ReadLine());
            C = n;
            int k = 0;
            if (n >= 1 && n <= 1000)
            {
                while (k<n)
                {
                    x = int.Parse(Console.ReadLine());
                    int numar, cif1, cif2, nrcif_x;
                    numar = x;
                    nrcif_x = 0;
                    while (x > 0)
                    {
                        nrcif_x++;
                        x /= 10;
                    }

                    for (int i = 0; i < nrcif_x - 1; i++)
                    {
                        cif1 = numar % 10;
                        cif2 = numar / 10 % 10;
                        if (vecini(cif1, cif2) == false)
                        {
                            C--;
                            break;
                        }
                        numar /= 10;
                    }
                    k++;
                }

            }
            Console.WriteLine(C);
        }
    }
}
