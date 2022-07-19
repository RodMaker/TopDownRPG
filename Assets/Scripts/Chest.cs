using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inherits from Collectable which inherits from Collidable (4 Pillars of Object Oriented Programming)
public class Chest : Collectable
{
    public Sprite emptyChest;
    public int escudosAmount = 200;

    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            Debug.Log("Grant " + escudosAmount + " escudos!");
            GameManager.instance.ShowText("+ " + escudosAmount + " escudos!", 25, Color.yellow, transform.position, Vector3.up * 50, 1.5f);
        }
    }
}
