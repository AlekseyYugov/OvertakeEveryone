using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonInPlay : MonoBehaviour
{
    [SerializeField] private AudioSource m_CarAudioSourse;
    [SerializeField] private GameObject m_UIButtonPause;
    public GameObject UIButtonPause => m_UIButtonPause;
    [SerializeField] private GameObject m_UIPause;
    public GameObject UIPause => m_UIPause;
    [SerializeField] private GameObject m_UIEndOfRide;
    public GameObject UIEndOfRide => m_UIEndOfRide;
    private bool m_PauseActivate = false;

    private void Start()
    {
        Time.timeScale = 1.0f;
        if (m_UIPause != null && m_UIEndOfRide != null && m_UIButtonPause != null)
        {
            m_UIPause.SetActive(false);
            m_UIEndOfRide.SetActive(false);
            m_UIButtonPause.SetActive(true);
        }

    }

    public void PauseActivate()
    {
        if (m_PauseActivate == false)
        {
            Time.timeScale = 0.0f;
            m_UIPause.SetActive(true);
            m_UIButtonPause.SetActive(false);
            m_PauseActivate = true;
            m_CarAudioSourse.enabled= false;
        }

    }
    public void Continue()
    {
        m_PauseActivate = false;
        m_UIPause.SetActive(false);
        m_UIButtonPause.SetActive(true);
        m_CarAudioSourse.enabled = true;
        Time.timeScale = 1.0f;
    }
    public void LoadScene(string _sceneName)
    {
        EnemyCarSort[] carsEnemy = FindObjectsOfType<EnemyCarSort>();
        if (carsEnemy != null)
        {
            for (int i = 0; i < carsEnemy.Length; i++)
            {
                carsEnemy[i].Delete(true);
            }
        }
        TriggerSpawn.trig = 0;
        SceneManager.LoadScene(_sceneName);
    }
    public void Quit()
    {
        Application.Quit();
    }

}
