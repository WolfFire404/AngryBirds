using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour {


    public float TileHealth = 3f;

    // Use this for initialization
    void Start () {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude < 5 && collision.relativeVelocity.magnitude > 3)
        {
            TileHealth -=1f;
        }

        else if (collision.relativeVelocity.magnitude < 7 && collision.relativeVelocity.magnitude > 5)
        {
           TileHealth -=2f;
        }

        else if (collision.relativeVelocity.magnitude > 7)
        {
           TileHealth -=3f;
        }
        Debug.Log(collision.relativeVelocity.magnitude);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(TileHealth);
        if(TileHealth < 1f)
        {
            Destroy(gameObject);
        }
    }
}
