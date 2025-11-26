using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Collections;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [Header("Audio Sources")]
    public AudioSource PlayerSFX;
    public AudioSource MusicSource;



    [Header("Music Clips")]
    public AudioClip MainGameMusic;


    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

    }

    void Start()
    {
        float volume = PlayerPrefs.GetFloat("gameVolume", 1f);

        if (MusicSource != null && MainGameMusic != null && !MusicSource.isPlaying)
        {
            MusicSource.clip = MainGameMusic;
            MusicSource.loop = true;
            MusicSource.Play();
        }

    }
}