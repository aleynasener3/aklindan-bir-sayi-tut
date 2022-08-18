using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aklindanbirsayitut : MonoBehaviour
{

    int minsayi = 1;
    int maxsayi = 100;
    int tahmin;
    bool oyunbaslama = false;
    bool oyunbitti = true;

    // Start is called before the first frame update
    void Start()
    {
        print("benimle oyun oynamak ister misin? e/h");
    }

    // Update is called once per frame
    void Update()
    {

        if (!oyunbaslama) { 
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("o zaman 1-100 arasý sayý tut ve entera bas");
            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                print("sen bilirsin");
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                tahmin = (minsayi + maxsayi) / 2;
                print("aklýndan tuttuðun sayi bu mudur;" + tahmin +" doðruysa boþluk ,daha büyük ise yukarý daha küçük ise aþaðý");
                oyunbaslama = true;

            }
        }
        else if (oyunbitti==true){ 
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                minsayi = tahmin;
                Kontrol();
            }

            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                maxsayi = tahmin;
                Kontrol();
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                print("yey");
                oyunbitti = false;
            }
        }

    }

    void Kontrol()
    {
        tahmin = (minsayi + maxsayi) / 2;
        print("aklýndan tuttuðun sayi bu mudur;" + tahmin + " doðruysa boþluk ,daha büyük ise yukarý daha küçük ise aþaðý");

    }


}
