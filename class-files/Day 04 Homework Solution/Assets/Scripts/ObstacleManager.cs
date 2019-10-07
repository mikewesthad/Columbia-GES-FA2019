using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField] float numObstacles = 50;
    [SerializeField] GameObject[] obstaclePrefabs;
    [SerializeField] float xMin = -8;
    [SerializeField] float xMax = 8;
    [SerializeField] float zMin = 7;
    [SerializeField] float zMax = 190;

    void SpawnObstacle()
    {
        Vector3 pos = new Vector3(Random.Range(xMin, xMax), 0, Random.Range(zMin, zMax));
        Quaternion rot = Quaternion.Euler(0, Random.Range(0, 360), 0);
        GameObject obstacle = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)];
        Instantiate<GameObject>(obstacle, pos, rot, transform);
    }

    void Start()
    {
        for (int i = 0; i < numObstacles; i++)
        {
            SpawnObstacle();
        }
    }

    void Update()
    {
        
    }
}
