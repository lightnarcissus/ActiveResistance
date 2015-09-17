using UnityEngine;
using System.Collections;

public class Aggressive : MonoBehaviour {

    private GameObject player;
    public float speed = 0f;
	// Use this for initialization
	void Start () {

        player = GameObject.Find("FPSController");
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = Vector3.Lerp(transform.position, player.transform.position, Time.deltaTime * speed);
        transform.localScale += new Vector3(0.000001f,0.000001f,0.000001f);
	}
}
