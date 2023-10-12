using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class SettingButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    private Button _button;
    private DefaultButton _defBut;
    private AudioSource _audioSource;

    private void Start()
    {
        _button= GetComponent<Button>();
        _button.image.color= Color.white;
        _defBut = GameObject.FindObjectOfType<DefaultButton>();
        _audioSource= GetComponent<AudioSource>();
        _audioSource.playOnAwake = false;
    }
    //(255, 175, 59)
    public void OnPointerEnter(PointerEventData eventData)
    {
        _button.image.color = new Color32(255,175,59,255);
        _audioSource.clip = _defBut._music.Effect_01;
        _audioSource.Play();

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _button.image.color = Color.white;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _defBut.ClickButton();
    }
}
