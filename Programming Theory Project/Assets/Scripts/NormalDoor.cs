using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalDoor : Door
{   
    public override void Open()
    {
        base.Open();
        doorAnimator.SetTrigger("DoorOpen");        
    }    
}