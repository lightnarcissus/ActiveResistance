using UnityEngine;
using System.Collections;

public class CubeSpawner : MonoBehaviour {

    public GameObject cube;
    public GameObject player;
    private int randInt = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if(Random.value<0.005f)
        {
            randInt = Random.Range(0, 2);
            if (randInt == 0)
                Instantiate(cube, player.transform.position + new Vector3(Random.Range(-80f, 80f), Random.Range(-5f, 5f), Random.Range(-20f, 20f)), Quaternion.identity);
            else
                Instantiate(cube, player.transform.position - new Vector3(Random.Range(-80f, 80f), Random.Range(-5f, 5f), Random.Range(-20f, 20f)), Quaternion.identity);
        }
	
	}
}
