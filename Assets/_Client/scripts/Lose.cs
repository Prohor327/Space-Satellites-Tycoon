using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    public void Reset()
    {
        SceneManager.LoadScene(0);
    }

    private void Start()
    {
        PlayerPrefs.SetInt("Sp1", 0);
        PlayerPrefs.SetInt("Sp2", 0);
        PlayerPrefs.SetInt("Sp3", 0);
        PlayerPrefs.SetInt("Sp4", 0);
        PlayerPrefs.SetInt("Sp5", 0);
        PlayerPrefs.SetFloat("People", 0f);
        PlayerPrefs.SetFloat("WIFI", 0f);
        PlayerPrefs.SetFloat("Temp", 24f);
        PlayerPrefs.SetFloat("Davl", 100f);
        PlayerPrefs.SetFloat("Cash", 0f);
        PlayerPrefs.SetFloat("Schet", 0f);
    }
}
