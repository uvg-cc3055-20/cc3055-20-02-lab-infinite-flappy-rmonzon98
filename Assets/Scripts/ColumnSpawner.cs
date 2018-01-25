using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour {

    public GameObject column;
    public static float spawnTime = 4f;
    public static float elapsedTime = 3f;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (elapsedTime < spawnTime)
        {
            elapsedTime += Time.deltaTime;
        }
        else
        {
            float random = Random.Range(-2f, 2f);
            Instantiate(column, new Vector3(15, random, 0), Quaternion.identity);
            elapsedTime = 0;
        }
    }

}
