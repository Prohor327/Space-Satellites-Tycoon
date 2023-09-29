using UnityEngine;
using UnityEngine.UI;

public class musikManager : MonoBehaviour
{
    [SerializeField] private Slider _volume;
    private float _vol;

    private void Start()
    {
        _volume.value = PlayerPrefs.GetFloat("Volume");
    }

    public void Volume()
    {
        _vol = _volume.value;
        PlayerPrefs.SetFloat("Volume", _vol);
    }
}
