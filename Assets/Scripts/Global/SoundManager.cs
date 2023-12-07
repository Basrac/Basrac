using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    private static SoundManager _instance;

    [SerializeField] private AudioSource _bgmSource;
    public Slider VolumeSlider;

    private bool isMuted = false;
    private float previousVolume = 0.2f;

    private PlayerMovement _controller;

    public AudioClip jump;
    private AudioSource audioSource;

    public static SoundManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<SoundManager>();
                if (_instance == null)
                {
                    // 씬에 SoundManager 인스턴스가 없는 경우 새로 생성
                    GameObject soundManagerObject = new GameObject("SoundManager");
                    _instance = soundManagerObject.AddComponent<SoundManager>();
                }
            }
            return _instance;
        }
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        VolumeSlider.onValueChanged.AddListener(AdjustVolume);

        _controller = FindObjectOfType<PlayerMovement>();

        if (_controller != null)
        {
            _controller.OnJumpEvent += PlayJumpSound;
            // _controller.OnLandEvent += PlayLandingSound;
        }
        else
        {

        }
    }

    public void AdjustVolume(float value)
    {
        if(value == 0f)
        {
            MuteBGM();
        }
        else
        {
            UnmuteBGM();
            _bgmSource.volume = value;
        }
    }

    void MuteBGM()
    {
        if (!isMuted)
        {
            isMuted = true;
            previousVolume = _bgmSource.volume;
            _bgmSource.volume = 0f;
        }
    }

    void UnmuteBGM()
    {
        if(isMuted)
        {
            isMuted = false;
            _bgmSource.volume = previousVolume;
        }
    }

    void PlayBGM()
    {
        _bgmSource.loop = true;
        _bgmSource.Play();
    }

    
    private void PlayJumpSound()
    {
        audioSource.PlayOneShot(jump);
    }
    
    private void PlayLandingSound()
    {
       // audioSource.PlayOneShot(landing);
    }

    private void PlayCollisionSound()
    {
        // audioSourece.PlayOneShot();
    }
}

