using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 4f;
    void Start()
    {
        StartCoroutine(enemyDrop());
    }
    
    

    IEnumerator enemyDrop()
    {
        while (true)
        {
            float xPos = Random.Range(39, -39);
            float yPos = 0.68f;
            float zPos = Random.Range(-39, -39);
            Vector3 spawnPos = new Vector3(xPos, yPos, zPos);
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity); 
            yield return new WaitForSeconds(spawnInterval);
        }
    }

}
