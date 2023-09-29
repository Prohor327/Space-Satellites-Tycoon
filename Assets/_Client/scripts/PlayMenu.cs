using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayMenu : MonoBehaviour
{
    [SerializeField] private GameObject _panelNotEnoght;
    [SerializeField] private GameObject _imgPeople;
    [SerializeField] private GameObject _imgCash;
    [SerializeField] private GameObject _imgOpasno1;
    [SerializeField] private GameObject _imgOpasno2;
    [SerializeField] private GameObject _pause;
    [SerializeField] private GameObject _settings;
    [SerializeField] private GameObject _pauseBt;
    [SerializeField] private GameObject _allBt;
    [SerializeField] private GameObject _Quest;

    [SerializeField] private TMP_Text _peoplesT;
    [SerializeField] private TMP_Text _WIFIT;
    [SerializeField] private TMP_Text _TempT;
    [SerializeField] private TMP_Text _DavlT;
    [SerializeField] private TMP_Text _CashT;
    [SerializeField] private TMP_Text _volumeT;

    private float _people;
    private float _WIFI;
    private float _temp;
    private float _davl;
    private float _cash;

    private float _WIFIclick;

    public void onButton(int _numberSP)
    {
        FindObjectOfType<logikShop>().ButtonBuy(_numberSP);
    }

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void OnPause()
    {
        _pause.SetActive(true);
        _pauseBt.SetActive(false);
        _allBt.SetActive(true);
        Time.timeScale = 0;
    }

    public void settings()
    {
        _settings.SetActive(true);
        _pause.SetActive(false);
    }

    public void toMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PanelNotEnoght(int _net)
    {
        _panelNotEnoght.SetActive(true);
        _allBt.SetActive(true);
        switch (_net)
        {
            case 1:
                _imgCash.SetActive(false);
                _imgPeople.SetActive(true);
                break;
            case 2:
                _imgCash.SetActive(true);
                _imgPeople.SetActive(false);
                break;
        }
    }

    public void Quest()
    {
        _Quest.SetActive(true);
        _pause.SetActive(false);
    }

    public void Back()
    {
        _panelNotEnoght.SetActive(false);
        _settings.SetActive(false);
        _allBt.SetActive(false);
        _pause.SetActive(false);
        _Quest.SetActive(false);
        _pauseBt.SetActive(true);
        Time.timeScale = 1;
    }

    public void Click(int _click)
    {
        PlayerPrefs.SetFloat("WIFI", _WIFI + _click);
    }

    private void Update()
    {
        _WIFIclick = _WIFI;
        _people = PlayerPrefs.GetFloat("People");
        _WIFI = PlayerPrefs.GetFloat("WIFI");
        _temp = PlayerPrefs.GetFloat("Temp");
        _davl = PlayerPrefs.GetFloat("Davl");
        _cash = PlayerPrefs.GetFloat("Cash");
        _volumeT.text = Mathf.Round(PlayerPrefs.GetFloat("Volume") * 100) + " %";
        if (_davl >= 3000f)
        {
            _imgOpasno2.SetActive(true);
        }
        else
        {
            _imgOpasno2.SetActive(false);
        }
        if (_temp >= 50f)
        {
            _imgOpasno1.SetActive(true);
        }
        else
        {
            _imgOpasno1.SetActive(false);
        }
        if (_people >= 1000000f)
        {
            _people /= 1000000f;
            _people = Mathf.Round(_people * 10f) / 10f;
            _peoplesT.text = _people. ToString() + " M";
        }
        else if (_people >= 1000f)
        {
            _people /= 1000f;
            _people = Mathf.Round(_people * 10f) / 10f;
            _peoplesT.text = _people. ToString() + " k";
        }
        else
        {
            _people = Mathf.Round(_people );
            _peoplesT.text = _people. ToString() + " ";
        }
        if (_WIFIclick >= 1048576f)
        {
            _WIFIclick /= 1048576f;
            _WIFIclick = Mathf.Round(_WIFIclick * 10f) / 10f;
            _WIFIT.text = _WIFIclick. ToString() + " Gbit/s";
        }
        else if (_WIFIclick >= 1024f)
        {
            _WIFIclick /= 1024f;
            _WIFIclick = Mathf.Round(_WIFIclick * 10f) / 10f;
            _WIFIT.text = _WIFIclick. ToString() + " Kbit/s";
        }
        else
        {
            _WIFIclick = Mathf.Round(_WIFI * 10f) / 10f;
            _WIFIT.text = _WIFIclick. ToString() + " bit/s";
        }
        if (_davl >= 1000f)
        {
            _davl /= 1000f;
            _davl = Mathf.Round(_davl * 10f) / 10f;
            _DavlT.text = _davl. ToString() + " MPa";
        }
        else
        {
            _davl = Mathf.Round(_davl * 10f) / 10f;
            _DavlT.text = _davl. ToString() + " KPa";
        }
        if (_cash >= 1000000f)
        {
            _cash /= 1000000f;
            _cash = Mathf.Round(_cash * 10f) / 10f;
            _CashT.text = _cash. ToString() + " B";
        }
        else if (_cash >= 1000f)
        {
            _cash /= 1000f;
            _cash = Mathf.Round(_cash * 10f) / 10f;
            _CashT.text = _cash. ToString() + " M";
        }
        else 
        {
            _cash = Mathf.Round(_cash * 10f) / 10f;
            _CashT.text = _cash. ToString() + " k";
        }
        _temp = Mathf.Round(_temp * 10f) / 10f;
        _TempT.text = _temp. ToString() + " C";   
    }

}
