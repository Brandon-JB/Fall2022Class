using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public AudioSource audioSource;
    private float defaultPitch;


    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null)
        {
            Instance = this;
        }

        defaultPitch = audioSource.pitch;
        DontDestroyOnLoad(gameObject);
    }

    public void PauseMusic()
    {
        audioSource.pitch = 0;
    }

    public void UnPauseMusic()
    {
        audioSource.pitch = defaultPitch;
    }

}
