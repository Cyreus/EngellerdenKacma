using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakterhareketi : MonoBehaviour
{
    public float hareketHizi;


    void Start()
    {
        Debug.Log("oyun baþladý!");

    }

    void Update()
    {
        float hiz = hareketHizi * Input.GetAxis("Horizontal");
        transform.Translate(hiz * Time.deltaTime, 0, 0);

    }
}
