using UnityEngine;

public class CarController : MonoSingleton<CarController>
{
    public float m_CurrentSpeed = 5f;
    public float speedRun = 1;
    public float m_Pos = 0f;
    public Track track;
    private float m_IntNum = 0f;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && track != Track.Left)
        {
            m_Pos = -5f;
        }
        if (Input.GetKeyDown(KeyCode.D) && track != Track.Right)
        {
            m_Pos = 5f;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (speedRun < 2)
            {
                speedRun += Time.deltaTime * 0.5f;
            }
        }
        else
        {
            if (speedRun > 1)
            {
                speedRun -= Time.deltaTime * 0.5f;
            }
        }
        transform.position += transform.forward * m_CurrentSpeed * speedRun * Time.deltaTime;

        Position(m_Pos);
        if (Mathf.Floor(GameTime.m_CurrentTime) % 10 == 0 && Mathf.Floor(GameTime.m_CurrentTime) != m_IntNum)
        {
            m_IntNum = Mathf.Floor(GameTime.m_CurrentTime);
            m_NextSpeed = true;
            m_MaxSpeed = m_CurrentSpeed + 5;
        }
        if (m_NextSpeed == true)
        {
            m_CurrentSpeed += Time.deltaTime;
            if (m_CurrentSpeed >= m_MaxSpeed)
            {
                m_CurrentSpeed = m_MaxSpeed;
                m_NextSpeed = false;
            }
        }
    }

    private bool m_NextSpeed = false;
    private float m_MaxSpeed = 0f;

    public void Position(float _endPos)
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, _endPos * 10 / m_CurrentSpeed * speedRun, 0), Time.deltaTime * 2);
        transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + _endPos, transform.position.y, transform.position.z), Time.deltaTime * (m_CurrentSpeed / 10) * speedRun);
        if (transform.position.x > 0)
        {
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -5)
        {
            transform.position = new Vector3(-5, transform.position.y, transform.position.z);
        }

    }
}
