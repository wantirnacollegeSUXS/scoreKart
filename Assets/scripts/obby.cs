using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;
public class obby : MonoBehaviour
{
    // Start is called before the first frame update
    public bool game_active = true;
    private scoreUpdate scoreupdate;
    public int Score_board = 1;
    public int point = 5;
    

    

    public ParticleSystem explosion;


    void Start()
    {        
        scoreupdate = GameObject.Find("scoreUpdate").GetComponent<scoreUpdate>();
        explosion.Play();
    }
    
    public void OnTriggerEnter(Collider other)
    {

        
        if (other.gameObject.CompareTag("Player"))
        {
            
            Debug.Log("nvm this just gaem over");
            Destroy(gameObject);
            Destroy(other.gameObject);
            scoreupdate.GameOver();
            scoreupdate.ifcarhit();

        }
        else if (other.gameObject.CompareTag("sigma")) 
        {
            explosion.Play();
            scoreupdate.UpdateScore(point);
            Destroy(gameObject);
            Destroy(other.gameObject);
            Debug.Log("gud job");
            

        }
        

    }
    

    void Update()
    {
        
    }
}
