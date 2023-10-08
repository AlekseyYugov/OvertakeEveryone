using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsGame : MonoBehaviour
{
    [SerializeField] private Text m_Text;
    public float m_Points = 0;
    private void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            m_Points += Time.deltaTime * 2;
        }
        else
        {
            m_Points += Time.deltaTime;
        }
        m_Text.text = m_Points.ToString("F1");
    }
}
