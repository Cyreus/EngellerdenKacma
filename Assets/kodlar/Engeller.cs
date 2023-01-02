using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class Engeller : MonoBehaviour
{


    private static int Skor;
    public TextMeshProUGUI SkorYazisi,bitisYazisi;
    void Start()
    {
        Skor = 0; 
    }


    void Update()
    {
        SkorYazisi.text = Skor.ToString();
        bitisYazisi.text = "OYUN BÝTTÝ..\nSkor :" + Skor.ToString();  
    }


    private void OnCollisionEnter2D(Collision2D temas)
    {
       
        float xPozisyonu = Random.Range(-6f, 6f);
        float yPozisyonu = Random.Range(6f, 15f);
        if(temas.gameObject.tag == "Kontrol_Cubugu")
        {
            
            transform.position = new Vector2(xPozisyonu,yPozisyonu);
            Skor += 10;

        }
        else if(temas.gameObject.tag == "karakter")
        {
            transform.position = new Vector2(xPozisyonu, yPozisyonu);
            Can.kalanCan--;

        }

    }


}
