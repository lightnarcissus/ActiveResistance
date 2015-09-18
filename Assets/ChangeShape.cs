using UnityEngine;
using System.Collections;

public class ChangeShape : MonoBehaviour {

    public Mesh capsule;
    public Mesh cylinder;
    public Mesh cube;
    public Mesh sphere;
    public Mesh plane;
    public Mesh quad;
    public Mesh wrench;
    private GameObject player;
	// Use this for initialization
	void Start () {

        player = GameObject.Find("FPSController");
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        switch(MusicPlayer.sampleIndex%7)
        {
            case 0:
                gameObject.GetComponent<MeshFilter>().mesh = capsule;
                gameObject.GetComponent<Aggressive>().enabled = true;
                gameObject.GetComponent<Passive>().enabled = false;
                
                break;
            case 1:
                gameObject.GetComponent<MeshFilter>().mesh = cylinder;
                gameObject.GetComponent<Aggressive>().enabled = false;
                gameObject.GetComponent<Passive>().enabled = true;
                break;
            case 2:
                gameObject.GetComponent<MeshFilter>().mesh = cube;
                gameObject.GetComponent<Aggressive>().enabled = true;
                gameObject.GetComponent<Passive>().enabled = false;
                break;
            case 3:
                gameObject.GetComponent<MeshFilter>().mesh = sphere;
                gameObject.GetComponent<Aggressive>().enabled = false;
                gameObject.GetComponent<Passive>().enabled = true;
                break;
            case 4:
                gameObject.GetComponent<MeshFilter>().mesh = plane;
                gameObject.GetComponent<Aggressive>().enabled = true;
                gameObject.GetComponent<Passive>().enabled = false;
                break;
            case 5:
                gameObject.GetComponent<MeshFilter>().mesh = quad;
                gameObject.GetComponent<Aggressive>().enabled = false;
                gameObject.GetComponent<Passive>().enabled = true;
                break;
            case 6:
                gameObject.GetComponent<MeshFilter>().mesh = wrench;
                gameObject.GetComponent<Aggressive>().enabled = true;
                gameObject.GetComponent<Passive>().enabled = false;
                break;
            default:
                break;
        }
	
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Collider")
        {
            if(MusicPlayer.discomfort<=9)
                 MusicPlayer.discomfort++;
            player.GetComponent<MusicPlayer>().Jarring();
            Destroy(this.gameObject);
        }
    }
}
