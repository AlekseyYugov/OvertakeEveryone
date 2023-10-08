using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SpawnerCar : MonoBehaviour
{
    [SerializeField] private GameObject car;
    [SerializeField] private float m_MinPosCarEnemy;
    [SerializeField] private float m_MaxPosCarEnemy;
    private Vector3 pos_01;
    private Vector3 pos_02;
    private GameObject[] enemyCars_01 = new GameObject[100];
    private GameObject[] enemyCars_02 = new GameObject[100];
    private void Start()
    {
        m_MinPosCarEnemy = (TriggerSpawn.trig * 10000) + 50f;
        m_MaxPosCarEnemy = m_MinPosCarEnemy + 10000;
        for (int i = 0; i < enemyCars_01.Length; i++)
        {
            pos_01 = new Vector3(-5, 0.5f, Random.Range(m_MinPosCarEnemy, m_MaxPosCarEnemy));
            enemyCars_01[i] = Instantiate(car, pos_01, Quaternion.identity);
        }
        for (int i = 0; i < enemyCars_02.Length; i++)
        {
            pos_02 = new Vector3(0, 0.5f, Random.Range(m_MinPosCarEnemy, m_MaxPosCarEnemy));
            enemyCars_02[i] = Instantiate(car, pos_02, Quaternion.identity);
        }
    }
}
