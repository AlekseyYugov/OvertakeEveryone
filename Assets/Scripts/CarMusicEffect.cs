using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CarMusicEffect : MonoBehaviour
{
    [SerializeField] private MusicAndEffectForGame musicAndEffect;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = musicAndEffect.Effect_01;
    }

    private void Update()
    {
        if (audioSource == null) audioSource.clip = musicAndEffect.Effect_01;
        if (Input.GetKey(KeyCode.Space))
        {
            audioSource.clip = musicAndEffect.Effect_02;
        }
        else
        {
            audioSource.clip = musicAndEffect.Effect_01;
        }
        if(audioSource.isActiveAndEnabled)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        

    }
}
