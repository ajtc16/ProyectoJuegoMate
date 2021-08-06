using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

	public GameObject[] obstacles;
	public List<GameObject> obstaclesToSpawn = new List<GameObject>();



	void Awake()
	{
		initObstacles ();
	}


	void Start () {
		StartCoroutine (SpawnRandomObstacles());	
	}
	
	 
	void initObstacles () {

		int index = 0;
		for (int i = 0; i < obstacles.Length * 3; i++) {
			GameObject obj = Instantiate (obstacles [index], transform.position, Quaternion.identity);
			obstaclesToSpawn.Add (obj);
			obstaclesToSpawn [i].SetActive (false);
			index++;
			if (index == obstacles.Length) {
				index = 0;
			}
		}
	}

	IEnumerator SpawnRandomObstacles(){

		yield return new WaitForSeconds (Random.Range (5.5f,7.5f));

		int index = Random.Range (0, obstaclesToSpawn.Count - 1);

		while (true) {
			if (!obstaclesToSpawn [index].activeInHierarchy) {
				obstaclesToSpawn [index].SetActive (true);
				obstaclesToSpawn [index].transform.position = transform.position;
				break;
			} else {
				index = Random.Range (0, obstaclesToSpawn.Count - 1);
			}	
		}

		StartCoroutine (SpawnRandomObstacles());
	}
}
