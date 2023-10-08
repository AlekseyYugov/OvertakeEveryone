using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Track
{
    Left,
    Right
}
public class CornerTrigger : MonoBehaviour
{
    public Track track;

    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponentInParent<CarController>())
        {
            if(CarController.Instance.track != track)
            {
                CarController.Instance.track = track;
                CarController.Instance.m_Pos = 0;
            }
            
        }
    }

}
