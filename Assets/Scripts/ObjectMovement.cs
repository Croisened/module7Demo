using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [Tooltip("This controls the speed of the game object")]
    public float speed = 1f;
    public bool shouldMove = false;
    public float width = 6f;
    public float length = 6f;
    public float height = 6f;

    private Rigidbody rb;


    //Will run once even before Start
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update at the start of the game
    void Start()
    {
        //Debug.Log("Start was called");

    }

    // Update is called once per frame
    void Update()
    {
        
        var x = Input.GetAxisRaw("Horizontal");
        var z = Input.GetAxisRaw("Vertical");
        var fire = Input.GetButtonDown("Fire1");

       

        var position = new Vector3(-x, 0, -z);

        if (shouldMove && CheckBoundary(transform.position + (position * speed * Time.deltaTime)))
        {

            //transform.Translate(position * speed * Time.deltaTime, Space.World);
            rb.AddForce(position * speed * Time.deltaTime);
        }
        else
        {
            rb.velocity = Vector3.zero;
        }



        if (fire)
        {

    
        }


    }


    private bool CheckBoundary(Vector3 _pos)
    {
        bool result = false;
        float widthMin = (width / 2) * -1;
        float widthMax = (width / 2);
        float lengthMin = (length / 2) * -1;
        float lengthMax = (length / 2);

        Debug.Log($"widthMin: {widthMin.ToString()} widthMax: {widthMax.ToString()} pos: {_pos.x.ToString()}");

        if (_pos.x > widthMin && _pos.x < widthMax)
        {
            if (_pos.z > lengthMin && _pos.z < lengthMax)
            {
                result = true;
            }
        }

        return result;
    }


}
