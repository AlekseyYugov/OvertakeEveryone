using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfRide : MonoBehaviour
{
    [SerializeField] private GameObject m_UIEndOfRide;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<EnemyController>())
        {
            Time.timeScale = 0.0f;
            m_UIEndOfRide.SetActive(true);
        }
    }
}
