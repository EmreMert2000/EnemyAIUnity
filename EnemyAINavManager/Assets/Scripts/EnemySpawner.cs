using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyprefab;
    [SerializeField] private int enemycount;
    private Vector3 enemypos;
    private void Start()
    {
        for (int i = 0; i < enemycount; i++)
        {
            enemypos = new Vector3(Random.Range(-8, 8), enemypos.y, Random.Range(-10, 10));
            Instantiate(enemyprefab, enemypos, Quaternion.identity);
        }
    }
}
