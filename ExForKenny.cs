using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExForKenny : MonoBehaviour
{
    void Start()
    {
        // Belirli bir aral�ktaki say�lar�n b�lenlerini bulmak i�in yazd�m
         �devListeleVeBul(12, 30);
        print("Son Olarak Aras�ndaki Say�lar : 13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29  +");

    }

    void �devListeleVeBul(int ilksayi, int sonsayi)
    {
        for (int sayi = ilksayi; sayi <= sonsayi; sayi++)
        {
            print($"{sayi} Bu Say�n�n B�lenleri �unlard�r");

            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    Debug.Log(i);

                    // B�len 5'e kadar olanki say�lar 
                    if (i <= 5)
                    {
                        print($"{i} 5'e kadar olan bir b�len ");
                        
                    }
                }
            }
        }
    }
}
