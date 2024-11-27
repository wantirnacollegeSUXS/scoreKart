using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outofbounds : MonoBehaviour
{
    // Start is called before the first frame update
    public float topbound = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topbound) 
        { 
        Destroy(gameObject);
        } 
    }
}
