using Unity.VisualScripting;
using UnityEngine;




public class TriggerSpawn : MonoBehaviour
{
    [SerializeField] private GameObject m_Ground;
    public GameObject Ground => m_Ground;
    public static int trig = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<CarController>())
        {
            trig++;
            GroundList.m_Grounds.Add(Instantiate(m_Ground, new Vector3(0, 0, (trig) * 10000), Quaternion.identity));
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
