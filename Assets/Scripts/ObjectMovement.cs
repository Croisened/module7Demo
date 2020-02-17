using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [Tooltip("This controls the speed of the game object")]
    public float speed = 1f;
    public bool shouldMove = false;

    //Will run once even before Start
    private void Awake()
    {
        //Debug.Log("Awake");
    }

    // Start is called before the first frame update at the start of the game
    void Start()
    {
        //Debug.Log("Start was called");
        //transform.position = new Vector3(1, .5f, 0);



    }

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");
        var fire = Input.GetButtonDown("Fire1");


        if (shouldMove)
        {
            transform.Translate(new Vector3(x, 0, z) * speed * Time.deltaTime);
        }

        if (fire)
        {
            Debug.Log("FIRE!");
        }






    }



}
