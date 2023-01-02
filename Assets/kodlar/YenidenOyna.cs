using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YenidenOyna : MonoBehaviour
{
    public void Yenidenoyna()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Can.kalanCan = 3;
        Time.timeScale = 1;
    }
}
