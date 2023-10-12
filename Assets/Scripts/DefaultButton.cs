using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefaultButton : MonoBehaviour
{
    public MusicAndEffectForGame _music;
    private SettingButton[] _buttons;
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.clip = _music.Effect_02;
    }
    private void Update()
    {
        _buttons = GameObject.FindObjectsOfType<SettingButton>();
        if(Input.GetMouseButtonUp(0))
        {
            for (int i = 0; i < _buttons.Length; i++)
            {
                _buttons[i].GetComponent<Image>().color = Color.white;
            }
        }
    }
    public void ClickButton()
    {
        _audioSource.Play();
    }
}
