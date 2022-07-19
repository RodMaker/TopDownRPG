using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inherits from Mover, which inherits from Fighter - 4 Pillars of OOP
public class Player : Mover
{
    private void FixedUpdate()
    {
        // Gets the input on the keys defined on the settings, in this case WASD or UPLEFTDOWNRIGHT
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
    
        UpdateMotor(new Vector3(x,y,0));
    }
}
