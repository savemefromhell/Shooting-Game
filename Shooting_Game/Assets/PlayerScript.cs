using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerScript : MonoBehaviour
{
    Rigidbody2D rigid2D;

    float Force = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int key = 0;
        int Rkey = 0;
        if (Input.GetKey(KeyCode.UpArrow)) key = 1;
        if (Input.GetKey(KeyCode.DownArrow)) key = -1;
        if (Input.GetKey(KeyCode.RightArrow)) Rkey = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) Rkey = -1;



        this.rigid2D.AddForce(transform.up * key * Force);
        this.rigid2D.AddForce(transform.right * Rkey * Force);

    }
}
