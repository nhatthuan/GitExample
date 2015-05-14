using UnityEngine;
using System.Collections;

public class abc : MonoBehaviour {

    public GameObject a;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        a.transform.position = new Vector3(0, -2, 0);
    }
}
