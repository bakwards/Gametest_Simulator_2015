using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour
{
    #region Singleton Pattern 
    private static AudioController _instance = null;
    public static AudioController Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = Instantiate(Resources.Load("Sound/AudioController", typeof(AudioController))) as AudioController;
                _instance.Init();
                return _instance;
            }
            else if (_instance != null)
            {
                return _instance;
            }
            return null;
        }
    }
    
    void Awake()
    {
        Debug.Log("Awake");
        if(_instance != null && _instance != this)
        {
            DestroyImmediate(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    #endregion

    public AudioClip pickUpCoin;
    public AudioSource mainAudioSource;

    void Init()
    {
        Debug.Log("Init");
    }

    public void PlaySound()
    {
        Debug.Log("Play Sound");
        mainAudioSource.clip = pickUpCoin;
        mainAudioSource.Play();        
    }

    void Start()
    {
        Debug.Log("Start");
    }
}
