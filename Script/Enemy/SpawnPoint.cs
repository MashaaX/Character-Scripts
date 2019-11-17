using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int enemyCount;

    void Start()
    {
        StartCoroutine(enemyDrop());
    }

    IEnumerator enemyDrop()
    {
    	while(enemyCount < 10)
    	{
    		xPos = Random.Range(1, 62);
    		zPos = Random.Range(1, 40);
    		Instantiate(theEnemy, new Vector3(xPos, 6 ,zPos), Quaternion.identity);
    		yield return new WaitForSeconds(2.1f);
    		enemyCount += 1;
    	}
    }

}
