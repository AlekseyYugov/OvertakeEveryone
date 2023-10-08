using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float m_Speed = 10;
    void Update()
    {
        transform.position += transform.forward * m_Speed * Time.deltaTime;
        if (transform.position.y < -5) Destroy(gameObject);
    }

    
}
