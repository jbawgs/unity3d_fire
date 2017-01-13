using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pc : MonoBehaviour {
    SphereCollider sc;
    Collider[] co;
    public GameObject prefab;
	// Use this for initialization
	void Start () {
        sc = GameObject.FindGameObjectWithTag("Fire").GetComponent<SphereCollider>();
    }
	
	// Update is called once per frame
	void Update () {
        co = Physics.OverlapSphere(transform.position, sc.radius);
        foreach(Collider c in co)
        {
            if(c.tag == "Prop")
            {
                GameObject a = Instantiate(prefab, c.transform.position, c.transform.rotation);
                a.transform.SetParent(c.transform);
                PropKilla pk = c.GetComponent<PropKilla>();
                pk.activated = true;
            }
            
        }
    }
}
