using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Can : MonoBehaviour
{
    public static int kalanCan = 3;
    public TextMeshProUGUI canYazisi;
    public GameObject bitisPaneli;

   

    void Update()
    {
        canYazisi.text = "Can :" + kalanCan.ToString();
        if(kalanCan == 0)
        {
            bitisPaneli.SetActive(true);
            Time.timeScale = 0;
        }
        
    }
}
