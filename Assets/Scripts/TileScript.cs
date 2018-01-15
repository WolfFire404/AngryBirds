using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour {


    public float TileHealth = 300;

    // Use this for initialization
    void Start () {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude < 7 && collision.relativeVelocity.magnitude > 4)
        {
            TileHealth -= 50f;
        }

        else if (collision.relativeVelocity.magnitude < 10 && collision.relativeVelocity.magnitude > 7)
        {
           TileHealth -=200f;
        }

        else if (collision.relativeVelocity.magnitude > 10)
        {
           TileHealth -=300f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(TileHealth);
        if(TileHealth < 1f)
        {
            Destroy(gameObject);
        }
    }
}
