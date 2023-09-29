using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class logikShop : MonoBehaviour
{
    private float _prisePeople;
    private float _priseWIFI;
    private float _priseTemp;
    private float _priseDavl;
    private float _priseCash;
    private float _people;
    private float _WIFI;
    private float _temp;
    private float _davl;
    private float _cash;
    private float _time;
    private float _speedSchet;
    private float _negative;
    private int _nety;

    private void Start()
    {
        _people = PlayerPrefs.GetFloat("People");
        _WIFI = PlayerPrefs.GetFloat("WIFI");
        _temp = PlayerPrefs.GetFloat("Temp");
        _davl = PlayerPrefs.GetFloat("Davl");
        _cash = PlayerPrefs.GetFloat("Cash");
    }

    public void ButtonBuy(int _index)
    {
        switch (_index)
        {
            case 1:
                _priseCash = 60;
                _prisePeople = 70;
                break;
            case 2:
                _priseCash = 100;
                _prisePeople = 150;
                break;
            case 3:
                _priseCash = 200;
                _prisePeople = 300;
                break;
            case 4:
                _priseCash = 1500;
                _prisePeople = 1200;
                break;
            case 5:
                _priseCash = 10000;
                _prisePeople = 10000;
                break;
        }
        if (_priseCash <= _cash && _prisePeople <= _people && _priseWIFI <= _WIFI)
        {
            FindObjectOfType<spawnerSputnick>().Spawn(_index);
            _speedSchet = PlayerPrefs.GetFloat("Schet");
            _people -= _prisePeople;
            PlayerPrefs.SetFloat("WIFI", _WIFI + _speedSchet);
            _negative =  PlayerPrefs.GetFloat("Negative");
            _WIFI -= _priseWIFI;
            _cash -= _priseCash;
            _davl += _negative * 2;
            _temp += _negative / 50;
            PlayerPrefs.SetFloat("Negative", 0);
            PlayerPrefs.SetFloat("Schet", 0);
        }
        else
        {
            if (_prisePeople >= _people)
            {
                _nety = 1;
            }
            else
            {
                _nety = 2;
            }
            FindObjectOfType<PlayMenu>().PanelNotEnoght(_nety);
        }
    }

    private void Update()
    {
        _WIFI = PlayerPrefs.GetFloat("WIFI");
        _time += 1 * Time.deltaTime;
        if (_time >= 0.5f)
        {
            _people += _WIFI / 140f;
            _cash += _people / 40f;
            _time = 0;
        }
        if (_WIFI <= 0)
        {
            _WIFI = 0;
        }
        if (_davl <= 0)
        {
            _davl = 0;
        }
        if (_temp <= 0)
        {
            _temp = 0;
        }
        if (_cash <= 0)
        {
            _cash = 0;
        }
        if (_people <= 0)
        {
            _people = 0;
        }
        if (_davl >= 5000f || _temp >= 60f)
        {
            SceneManager.LoadScene(2);
        }
        if (_cash >= 1000000000f)
        {
            SceneManager.LoadScene(3);
        }
        PlayerPrefs.SetFloat("People", _people);
        PlayerPrefs.SetFloat("WIFI", _WIFI);
        PlayerPrefs.SetFloat("Temp", _temp);
        PlayerPrefs.SetFloat("Davl", _davl);
        PlayerPrefs.SetFloat("Cash", _cash);
    }
}
