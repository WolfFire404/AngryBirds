using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockChangeScript : MonoBehaviour {

    public Sprite fase1;
    public Sprite fase2;
    public Sprite fase3;
    public Sprite fase4;

    TileScript tilescript;

    float Health
    {
        get { return TILESCRIPT.TileHealth; }
        set { TILESCRIPT.TileHealth = value; }
    }

    public TileScript TILESCRIPT
    {
        get { return tilescript ?? (tilescript = GetComponent<TileScript>()); }
    }

    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = fase1;
    }

    // Update is called once per frame
    void Update()
    {

        if (Health == 3f)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = fase2;
        }

        if (Health == 2f)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = fase3;
        }

        if (Health == 1f)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = fase4;
        }
    }
}
