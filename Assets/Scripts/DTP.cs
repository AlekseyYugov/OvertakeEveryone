using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DTP : MonoBehaviour
{
    private AudioSource m_AudioSource;
    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<CarController>())
        {
            m_AudioSource.Play();
        }
    }
}
