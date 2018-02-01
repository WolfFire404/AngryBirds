using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour {



    public float TileHealth = 4f;


    // Use this for initialization
    void Start()
        {
            
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.relativeVelocity.magnitude < 8 && collision.relativeVelocity.magnitude > 3)
            {
                TileHealth -= 1f;
            }

            else if (collision.relativeVelocity.magnitude < 15 && collision.relativeVelocity.magnitude > 8)
            {
                TileHealth -= 2f;
            }

            else if (collision.relativeVelocity.magnitude > 15)
            {
                TileHealth -= 3f;
            }
        }

        // Update is called once per frame
        void Update()
        {
            //Debug.Log(TileHealth);
            if (TileHealth < 1f)
            {
                Destroy(gameObject);
            }
        }
}
