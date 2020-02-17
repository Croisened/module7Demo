using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    private Transform playerTransform;
    private Rigidbody rb;
    public Rigidbody beamRB;


    // Start is called before the first frame update
    void Start()
    {
        playerTransform = player.GetComponent<Transform>();
        rb = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("r"))
        {
            rb.velocity = Vector3.zero;
            playerTransform.position = Vector3.zero + Vector3.up;
            beamRB.position = new Vector3(0, 15, -3);
            beamRB.useGravity = false;

        }

        if (Input.GetKeyDown("space"))
        {
            beamRB.useGravity = true;
        }





    }
}
