using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class detecthit : MonoBehaviour
{
    // Start is called before the first frame update\
    
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other) 
    {
        

        if (gameObject.CompareTag("obby")) { 
        Destroy(gameObject);
        Destroy(other.gameObject);
        Debug.Log("gud job");
        }
        

    
    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
