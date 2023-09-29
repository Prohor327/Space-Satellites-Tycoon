using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class menuscript : MonoBehaviour
{
    [SerializeField] private GameObject _settings;
    [SerializeField] private GameObject _menu;
    [SerializeField] private TMP_Text _volumet;
    private bool _onset;

    public void onStart()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    public void OnPause()
    {
        _onset = !_onset;
        _settings.SetActive(_onset);
        _menu.SetActive(!_onset);
    }

    private void Update()
    {
        _volumet.text = Mathf.Round(PlayerPrefs.GetFloat("Volume") * 100) + " %";
    }
}
