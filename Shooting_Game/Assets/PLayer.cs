using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float maxSpeed = 5f;
    float Force = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int key = 0,Rkey = 0;
        if (Input.GetKey(KeyCode.UpArrow)) key = 1;
        if (Input.GetKey(KeyCode.DownArrow)) key = -1;
        if (Input.GetKey(KeyCode.RightArrow)) Rkey = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) Rkey = -1;

        Vector2 PlayerVector = new Vector2(this.rigid2D.velocity.x, this.rigid2D.velocity.y);
        float speedx = PlayerVector.magnitude;
        Vector2 AddVector = new Vector2(Rkey, key);
        if (maxSpeed < speedx)
        {
            this.rigid2D.AddForce(-PlayerVector * Force*Time.deltaTime);
        }
        else
        {
            if (key == 0 && Rkey == 0)
            {
                this.rigid2D.AddForce(-PlayerVector * Force / 2 *Time.deltaTime);
            }
            else
                this.rigid2D.AddForce(AddVector * Force*Time.deltaTime);
        }
    

       
    }
}
