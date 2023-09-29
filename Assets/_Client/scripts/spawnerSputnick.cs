using UnityEngine;
using System.Collections;

public class spawnerSputnick : MonoBehaviour
{
    [SerializeField] private GameObject _sputnik1;
    [SerializeField] private GameObject _sputnik2;
    [SerializeField] private GameObject _sputnik3;
    [SerializeField] private GameObject _sputnik4;
    [SerializeField] private GameObject _sputnik5;
    private int SP1;
    private int SP2;
    private int SP3;
    private int SP4;
    private int SP5;
    private int spawn1;
    private int spawn2;
    private int spawn3;
    private int spawn4;
    private int spawn5;
    private float _speedSchet;

    public void Spawn(int value)
    {
        PlayerPrefs.SetInt("NumberSP", value);

        switch (value)
        {
            case 1:
                SP1 += 1;
                Instantiate(_sputnik1, Vector3.zero, Quaternion.Euler(0, Random.Range(0f, 360f), 0));
                PlayerPrefs.SetInt("Sp1", SP1);
                _speedSchet = PlayerPrefs.GetFloat("Schet");
                PlayerPrefs.SetFloat("Schet", _speedSchet + 20f);
                PlayerPrefs.SetFloat("Negative", 20f);
                break;
            case 2:
                SP2 += 1;
                Instantiate(_sputnik2, Vector3.zero, Quaternion.Euler(0, Random.Range(0f, 360f), 0));
                PlayerPrefs.SetInt("Sp2", SP2);
                _speedSchet = PlayerPrefs.GetFloat("Schet");
                PlayerPrefs.SetFloat("Schet", _speedSchet + 50f);
                PlayerPrefs.SetFloat("Negative", 50f);
                break;
            case 3:
                SP5 += 1;
                Instantiate(_sputnik5, Vector3.zero, Quaternion.Euler(0, Random.Range(0f, 360f), 0));
                PlayerPrefs.SetInt("Sp5", SP5);
                _speedSchet = PlayerPrefs.GetFloat("Schet");
                PlayerPrefs.SetFloat("Schet", _speedSchet -1024f);
                PlayerPrefs.SetFloat("Negative", -200f);
                break;
            case 4:
                SP3 += 1;
                Instantiate(_sputnik3, Vector3.zero, Quaternion.Euler(0, Random.Range(0f, 360f), 0));
                PlayerPrefs.SetInt("Sp3", SP3);
                _speedSchet = PlayerPrefs.GetFloat("Schet");
                PlayerPrefs.SetFloat("Schet", _speedSchet + 1024f);
                PlayerPrefs.SetFloat("Negative", 100f);
                break;
            case 5:
                SP4 += 1;
                Instantiate(_sputnik4, Vector3.zero, Quaternion.Euler(0, Random.Range(0f, 360f), 0));
                PlayerPrefs.SetInt("Sp4", SP4);
                _speedSchet = PlayerPrefs.GetFloat("Schet");
                PlayerPrefs.SetFloat("Schet", _speedSchet + 10240f);
                PlayerPrefs.SetFloat("Negative", 300f);
                break;
        }
    }

    private void Start()
    {
        spawn1 = PlayerPrefs.GetInt("Sp1");
        spawn2 = PlayerPrefs.GetInt("Sp2");
        spawn3 = PlayerPrefs.GetInt("Sp3");
        spawn4 = PlayerPrefs.GetInt("Sp4");
        spawn5 = PlayerPrefs.GetInt("Sp5");
        do 
        {
            if (spawn1 > 0)
            {
                Instantiate(_sputnik1, Vector3.zero, Quaternion.Euler(0, Random.Range(0f, 360f), 0));
                spawn1 -= 1;
            }
        }
        while (spawn1 > 0);
        do
        {
            if (spawn2 > 0)
            {
                Instantiate(_sputnik2, Vector3.zero, Quaternion.Euler(0, Random.Range(0f, 360f), 0));
                spawn2 -= 1;
            }
        }
        while (spawn2 > 0);
        do
        {
            if (spawn3 > 0)
            {
                Instantiate(_sputnik3, Vector3.zero, Quaternion.Euler(0, Random.Range(0f, 360f), 0));
                spawn3 -= 1;
            }
        }
        while (spawn3 > 0);
        do 
        {
            if (spawn4 > 0)
            {
                Instantiate(_sputnik4, Vector3.zero, Quaternion.Euler(0, Random.Range(0f, 360f), 0));
                spawn4 -= 1;
            }
        }
        while (spawn4 > 0);
        do 
        {
            if (spawn5 > 0)
            {
                Instantiate(_sputnik5, Vector3.zero, Quaternion.Euler(0, Random.Range(0f, 360f), 0));
                spawn5 -= 1;
            }
        }
        while (spawn5 > 0);
    }

    private void Update()
    {
        if (SP1 < 0)
        {
            SP1 = 0;
            PlayerPrefs.SetInt("Sp1", 0);
        }
        if (SP2 < 0)
        {
            SP2 = 0;
            PlayerPrefs.SetInt("Sp2", 0);
        }
        if (SP3 < 0)
        {
            SP3 = 0;
            PlayerPrefs.SetInt("Sp3", 0);
        }
        if (SP4 < 0)
        {
            SP4 = 0;
            PlayerPrefs.SetInt("Sp4", 0);
        }
        if (SP5 < 0)
        {
            SP5 = 0;
            PlayerPrefs.SetInt("Sp5", 0);
        }
    }
}
