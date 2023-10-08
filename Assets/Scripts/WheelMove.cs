using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class WheelMove : MonoBehaviour
{
    [SerializeField] private GameObject m_FrontWheelLeft;
    [SerializeField] private GameObject m_FrontWheelRight;
    [SerializeField] private GameObject m_RearWheelLeft;
    [SerializeField] private GameObject m_RearWheelRight;
    private float rot = 0;
    void Update()
    {
        rot = CarController.Instance.m_CurrentSpeed * CarController.Instance.speedRun;
        m_FrontWheelLeft.transform.Rotate(rot * Time.deltaTime * 20, 0, 0);
        m_FrontWheelRight.transform.Rotate(rot * Time.deltaTime * 20, 0, 0);
        m_RearWheelLeft.transform.Rotate(rot * Time.deltaTime * 20, 0, 0);
        m_RearWheelRight.transform.Rotate(rot * Time.deltaTime * 20, 0, 0);
    }
}
