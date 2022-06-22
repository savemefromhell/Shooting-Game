using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer : MonoBehaviour
{
    Rigidbody2D rigid2D;
    //float maxSpeed = 2.0f;
    float Force = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int key = 0,Rkey=0;
        if (Input.GetKey(KeyCode.UpArrow)) key = 1;
        if (Input.GetKey(KeyCode.DownArrow)) key = -1;
        if (Input.GetKey(KeyCode.RightArrow)) Rkey = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) Rkey = -1;

        //float speedx = Mathf.Abs(this.rigid2D.velocity.x);


        this.rigid2D.AddForce(transform.up * key * Force);
        this.rigid2D.AddForce(transform.right * Rkey * Force);

       
    }
}
