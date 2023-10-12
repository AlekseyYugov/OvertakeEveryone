using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfRide : MonoBehaviour
{
    [SerializeField] private UIButtonInPlay m_UI;
    private AudioSource m_AudioSource;
    private void Start()
    {
        m_AudioSource= GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<EnemyController>())
        {
            Time.timeScale = 0.0f;
            m_UI.UIEndOfRide.SetActive(true);
            m_UI.UIButtonPause.SetActive(false);
            m_AudioSource.enabled= false;
        }
    }
}
