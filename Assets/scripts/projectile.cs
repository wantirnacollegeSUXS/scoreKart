using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR;
using UnityEngine;

public class projectile : MonoBehaviour
{
    // Start is called before the first frame update

    public float projectilespeed = 40;
    public Quaternion Turnto;
    public float turnspeed = 45.0f;
    public GameObject Player;
    private Vector3 TargetCords;
    public bool Game_Over = false;
    void Start()
    {
        TargetCords = Player.transform.position;
    }

    


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * projectilespeed);
        Turnto = Player.transform.rotation;
        transform.rotation = Quaternion.Slerp(transform.rotation, Turnto, Time.deltaTime * turnspeed);
    }
}
