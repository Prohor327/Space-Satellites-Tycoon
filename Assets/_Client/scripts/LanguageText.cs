using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LanguageText : MonoBehaviour
{
    [SerializeField] private string[] _text;

    private TMP_Text _textLine;

    private void Start()
    {
        _textLine = GetComponent<TMP_Text>();
    }
    private void Update()
    {
        _textLine.text = "" + _text[PlayerPrefs.GetInt("language")];
    }
}
