using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{
    [SerializeField] private Text m_GameTimeText;
    public static float m_CurrentTime;

    private void Start()
    {
        m_CurrentTime = 0;
    }
    private void Update()
    {
        m_CurrentTime += Time.deltaTime;
        m_GameTimeText.text = TimeSpan.FromSeconds(m_CurrentTime).ToString(@"mm\:ss\.ff");
    }
}
