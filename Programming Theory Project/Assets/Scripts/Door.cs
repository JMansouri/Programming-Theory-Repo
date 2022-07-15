using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Door : MonoBehaviour
{
    // ENCAPSULATION :

    Color _doorColor;
    public Color DoorColor {
        get {
            return _doorColor; 
        }
        set
        {
            if(value == Color.red || value == Color.blue || value == Color.green)
            _doorColor = value;
        }
    }

    //  auto-implemented property
    public string DoorName { get; set; }
    
    public Animator doorAnimator;

    public virtual void Open()
    {
        Debug.Log("Opening this door ...");
    }
}
