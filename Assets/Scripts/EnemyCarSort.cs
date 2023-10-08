using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCarSort : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<EnemyCarSort>())
        {
            if (other.transform.position.z >= gameObject.transform.position.z)
            {
                Destroy(gameObject);
            }
            else
            {
                Destroy(other.gameObject);
            }
        }
    }
    private void Update()
    {
        if (transform.position.z - CarController.Instance.transform.position.z < -20)
        {
            Destroy(gameObject);
        }
    }
    public void Delete(bool del)
    {
        if (del) { Destroy(gameObject); }
    }
}
