using TMPro;
using UnityEngine;

public class InputLanguage : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown _dropdown;

    private void Start()
    {
        if (PlayerPrefs.GetInt("language") == null) PlayerPrefs.SetInt("language", 0); 
        _dropdown.value = PlayerPrefs.GetInt("language");
    }

    public void SetLanguage()
    {
        PlayerPrefs.SetInt("language", _dropdown.value);
    }
}
