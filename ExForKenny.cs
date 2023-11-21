using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExForKenny : MonoBehaviour
{
    void Start()
    {
        // Belirli bir aralýktaki sayýlarýn bölenlerini bulmak için yazdým
         ÖdevListeleVeBul(12, 30);
        print("Son Olarak Arasýndaki Sayýlar : 13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29  +");

    }

    void ÖdevListeleVeBul(int ilksayi, int sonsayi)
    {
        for (int sayi = ilksayi; sayi <= sonsayi; sayi++)
        {
            print($"{sayi} Bu Sayýnýn Bölenleri Þunlardýr");

            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    Debug.Log(i);

                    // Bölen 5'e kadar olanki sayýlar 
                    if (i <= 5)
                    {
                        print($"{i} 5'e kadar olan bir bölen ");
                        
                    }
                }
            }
        }
    }
}
