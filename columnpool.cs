using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class columnpool : MonoBehaviour
{
	public int columnpoolsize = 5;
	public GameObject columnPrefab;
	public float spawnRate = 4f;
	public float columnMin = -1f;
	public float columnMax = 3.5f;
    // Start is called before the first frame update
    private GameObject[] columns;
    private Vector2 objectPoolPosition = new Vector2(-15f,-25f);
    private float timeSinceLastSpawned;
    private float spawnXPosition = 10f;
    private int currentColumn = 0;
    void Start()
    {
        columns = new GameObject[columnpoolsize];
        for (int i=0;i<columnpoolsize;i++)
        {
        	columns [i] = (GameObject)Instantiate (columnPrefab,objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;
        if(GameControl.intance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
        	timeSinceLastSpawned = 0;
        	float spawnYPositon = Random.Range(columnMin,columnMax);
            columns[currentColumn].transform.position = new Vector2 (spawnXPosition,spawnYPositon);
            currentColumn++;
            if(currentColumn >= columnpoolsize)
            {
            	currentColumn = 0;
            }
        }
    }
}
