using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBBAlgoritmasiOrnek211
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int EnBuyuk = -1500, EnKucuk = 1500; 
                string[] A = { "Emin", "Emir", "İclal", "Bekir", "Cem", "Arda", "Kaan", "Metin", "Can", "Ramiz" };
                int[] B = { 56, 78, 95, 23, 95, 87, 61, 77, 45, 33 };

                
                for (int c = 0; c < B.Length; c++)
                {
                    if (B[c] >= EnBuyuk)
                    {
                        EnBuyuk = B[c];
                    }
                    if (B[c] <= EnKucuk)
                    {
                        EnKucuk = B[c];
                    }
                }
             
                Console.WriteLine("En Yüksek Notu Alan Kişiler:");
                for (int i = 0; i < B.Length; i++)
                {
                    if (B[i] == EnBuyuk)
                    {
                        Console.WriteLine(A[i]);
                    }
                }

                Console.WriteLine("En Düşük Notu Alan Kişiler:");
                for (int j = 0; j < B.Length; j++)
                {
                    if (B[j] == EnKucuk)
                    {
                        Console.WriteLine(A[j]);
                    }
                }

                Console.Write("Press any key to continue . . . ");
                Console.ReadKey(true);
            }
        }
    }
        }
 