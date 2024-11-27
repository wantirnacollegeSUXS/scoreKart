using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{

    public GameObject Player;
    private Vector3 offset = new Vector3(0, 5, -7);
    private Vector3 TargetCords;
    public float turnspeed = 45f;
    public Quaternion Turnto;

    // Start is called before the first frame update
    void Start()
    {
        TargetCords = Player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Turnto = Player.transform.rotation;
        transform.position = Player.transform.position + offset;
        transform.rotation = Quaternion.Slerp(transform.rotation, Turnto, Time.deltaTime * turnspeed);
    }
}
