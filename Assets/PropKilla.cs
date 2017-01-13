using UnityEngine;
using System.Collections;

public class PropKilla : MonoBehaviour
{
    public float killTime;
    public bool activated = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (activated)
        {
            killTime -= Time.deltaTime;
            if (killTime <= 0)
            {
                killit();
            }
        }
       
    }

    public void killit()
    {
        gameObject.SetActive(false);
    }
}
