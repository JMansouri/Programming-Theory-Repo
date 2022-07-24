using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalDoor : Door // INHERITANCE
{   
    // POLYMORPHISM:
    public override void Open()
    {
        base.Open();
        doorAnimator.SetTrigger("DoorOpen");        
    }    
}