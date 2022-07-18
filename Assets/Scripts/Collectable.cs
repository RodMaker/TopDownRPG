using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inherits from Collidable (4 Pillars of Object Oriented Programming)
public class Collectable : Collidable
{
    // Logic
    protected bool collected;

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player")
            OnCollect();
    }

    protected virtual void OnCollect()
    {
        collected = true;
    }
}
