using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDraggingScript : MonoBehaviour
{
    private bool Clicked;
    private bool BeenShot;

    private void Start()
    {
        Clicked = false;
        BeenShot = false;
    }

    void Update()
    {
        if (!BeenShot)
        {
            if (Input.GetMouseButton(0))
            {
                Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = (pos);
                Clicked = true;
            }else if (Clicked)
            {
                GetComponent<SpringJoint2D>().enabled = false;
                Clicked = false;
                BeenShot = true;
            }
        }
        
    }

}
