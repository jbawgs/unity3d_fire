using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject pc;
    public float cameraHeight;
	// Use this for initialization
	void Start () {
        pc = GameObject.FindGameObjectsWithTag("Player")[0];
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = new Vector3(pc.transform.position.x, pc.transform.position.y+cameraHeight, pc.transform.position.z);
        transform.position = pos;
	}
}
