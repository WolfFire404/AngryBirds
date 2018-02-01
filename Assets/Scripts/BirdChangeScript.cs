using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdChangeScript : MonoBehaviour {

    public Sprite fase1;
    public Sprite fase2;
    public Sprite fase3;

    BirdScript birdscript;

    float Health
    {
        get { return BIRDSCRIPT.BirdHealth; }
        set { BIRDSCRIPT.BirdHealth = value; }
    }

    public BirdScript BIRDSCRIPT
    {
        get { return birdscript ?? (birdscript = GetComponent<BirdScript>()); }
    }
    // Use this for initialization
    void Start () {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = fase1;
    }
	
	// Update is called once per frame
	void Update () {
        if (Health == 2f)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = fase2;
        }

        if (Health == 1f)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = fase3;
        }
    }
}
