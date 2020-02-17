using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBullet : MonoBehaviour
{
    float speed = 0.02f;
    private bool _isFired = false;
    private Rigidbody rb;


    //Will run once even before Start
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
        // Put this in your update function
        if (Input.GetButtonDown("Fire1") || _isFired)
        {
            _isFired = true;
            rb.AddForce(Vector3.forward * speed);

        }

    }
}
