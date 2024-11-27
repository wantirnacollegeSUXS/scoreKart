using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.PlayerLoop.EarlyUpdate;


public class playercontrol : MonoBehaviour
{
    //public AudioSource car_drive;
    //public AudioClip car_audio;

    public bool Game_Over=false;

    public TextMeshProUGUI offmap;

    public GameObject player;
    public float speed = 140;
    private Vector3 offset = new Vector3(0, 5, 0);
    public float turnspeed = 45.0f;
    private float horinput;
    private float forward;
    public Transform shootPos;
    public GameObject bullet;
    public float firerate = 3;
    public bool activeSelf = true;
    public scoreUpdate scoreupdate;
    public scoreUpdate minus;
    public int subtract = 3;

    // Start is called before the first frame update
    void Start()
    {
        scoreupdate = GameObject.Find("scoreUpdate").GetComponent<scoreUpdate>();
        
    }

    
    
    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.Space)) 
        
        {
            Instantiate(bullet, shootPos.position, shootPos.rotation);
            
        }


        if (transform.position.y < 10)
        {
            scoreupdate.GameOver();
            offmap.gameObject.SetActive(true);

        }
        

        horinput = Input.GetAxis("Horizontal");
        forward = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * Time.deltaTime * speed * forward);
        transform.Rotate(Vector3.up * turnspeed * horinput* Time.deltaTime );
        

    }
    private void LateUpdate()
    {
        transform.position = player.transform.position;
    }
    public void donthit(Collider other) 
    {
        if (gameObject.CompareTag("barra"))
        {
            scoreupdate.minus(subtract);
        }
    }
}
