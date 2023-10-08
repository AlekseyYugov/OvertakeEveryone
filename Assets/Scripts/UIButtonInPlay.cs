using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonInPlay : MonoBehaviour
{
    [SerializeField] private GameObject m_UIPause;
    public GameObject UIPause => m_UIPause;
    [SerializeField] private GameObject m_UIEndOfRide;
    public GameObject UIEndOfRide => m_UIEndOfRide;
    private bool m_PauseActivate = false;

    private void Start()
    {
        Time.timeScale = 1.0f;
        m_UIPause.SetActive(false);
        m_UIEndOfRide.SetActive(false);
    }

    public void PauseActivate()
    {
        if (m_PauseActivate == false)
        {
            Time.timeScale = 0.0f;
            m_UIPause.SetActive(true);
            m_PauseActivate = true;
        }

    }
    public void Continue()
    {
        m_PauseActivate = false;
        m_UIPause.SetActive(false);
        Time.timeScale = 1.0f;
    }
    public void NewGame()
    {
        EnemyCarSort[] carsEnemy = FindObjectsOfType<EnemyCarSort>();
        for (int i = 0; i < carsEnemy.Length; i++)
        {
            carsEnemy[i].Delete(true);
        }
        TriggerSpawn.trig = 0;
        SceneManager.LoadScene(0);
    }


}
