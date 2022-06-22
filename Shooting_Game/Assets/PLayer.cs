using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float maxSpeed = 0.5f;
    float Force = 1.0f;

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

        Vector2 PlayerVector = new Vector2(this.rigid2D.velocity.x,this.rigid2D.velocity.y);
        float speedx = PlayerVector.magnitude;
        Vector2 AddVector = new Vector2(key, Rkey);
        if (maxSpeed < speedx)
        {
            if(AddVector.x*PlayerVector.x+ AddVector.y * PlayerVector.y<0)
            {
                this.rigid2D.AddForce(AddVector * Force);

            }
            else
                this.rigid2D.AddForce(-PlayerVector * Force / 2);
        }
        else
        {
            if(key==0&&Rkey==0)
            {
                this.rigid2D.AddForce(-PlayerVector * Force/2);
            }
            this.rigid2D.AddForce(AddVector * Force);
 
         }


       
    }
}
