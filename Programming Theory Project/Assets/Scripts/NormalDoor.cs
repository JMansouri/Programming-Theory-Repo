using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalDoor : Door // INHERITANCE  - child of Door class
{   
    // POLYMORPHISM:
    public override void Open()
    {
        base.Open();
        doorAnimator.SetTrigger("DoorOpen");        
    }    
}