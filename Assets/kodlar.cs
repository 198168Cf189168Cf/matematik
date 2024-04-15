using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class kodlar : MonoBehaviour
{
    public TMP_Text ilksayi,ikincisayi,islem,cevap,sonuc;
    public TMP_InputField sonucbtn;
    int s1,s2,islemisareti,islemsonucu;
    void Start()
    {
        soru();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.Ge)
        {
            if(sonucbtn.text == islemsonucu) Debug.Log("İŞLEM DOĞRU!");
        }

        
        
    }

    public void soru()
    {
        sonuc.text="";
        sonucbtn.text="";
        s1 = Random.Range(1,10);
        s2 = Random.Range(1,10);
        islemisareti = Random.Range(1,5);

        switch(islemisareti)
       {
        case 1:
        islem.text = "+";
        islemsonucu = s1+s2; 
        break;
        case 2 :
        islem.text = "-";
        islemsonucu = s1-s2; 
        break;
        case 3:
        islem.text = "/";
        islemsonucu = s1/s2; 
        break;
        case 4:
        islem.text = "*";
        islemsonucu = s1*s2; 
        break;
       }
       ilksayi.text= s1+"";
       ikincisayi.text=s2+"";


    }
}
