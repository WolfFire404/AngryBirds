using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {


    public float BirdHealth = 2f;

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude < 8 && collision.relativeVelocity.magnitude > 3)
        {
            BirdHealth -= 1f;
        }

        else if (collision.relativeVelocity.magnitude > 8)
        {
            BirdHealth -= 2f;
        }
    }

    // Update is called once per frame
    void Update ()
    {
		if (BirdHealth < 0f)
        {
            Destroy(gameObject);
        }
	}
}
