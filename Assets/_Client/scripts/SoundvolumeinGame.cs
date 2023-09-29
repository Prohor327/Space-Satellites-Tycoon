using UnityEngine;

public class SoundvolumeinGame : MonoBehaviour
{
    private void Update()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("Volume");
    }
}
