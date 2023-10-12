using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultAndSettingsPanel : MonoBehaviour
{
    [SerializeField] private GameObject m_Menu;

    [SerializeField] private GameObject m_ResultPanel;
    [SerializeField] private GameObject m_SettingsPanel;

    private void Start()
    {
        m_Menu.SetActive(true);
        m_ResultPanel.SetActive(false);
        m_SettingsPanel.SetActive(false);
    }

    public void OpenPanelResult()
    {
        m_Menu.SetActive(false);

        m_SettingsPanel.SetActive(false);

        m_ResultPanel.SetActive(true);
    }
    public void OpenPanelSettings()
    {
        m_Menu.SetActive(false);

        m_ResultPanel.SetActive(false);

        m_SettingsPanel.SetActive(true);
    }
    public void Closed()
    {
        m_Menu.SetActive(true);

        m_ResultPanel.SetActive(false);

        m_SettingsPanel.SetActive(false);
    }
}
