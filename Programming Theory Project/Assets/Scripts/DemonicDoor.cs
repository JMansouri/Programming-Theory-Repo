using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonicDoor : Door // INHERITANCE  - child of Door class
{
    // POLYMORPHISM:
    public override void Open()
    {
        base.Open();

        // ABSTRACTION:
        OpenDemonicDoor();
        
    }

    private void OpenDemonicDoor()
    {
        Debug.Log("-> Initializing the opening process:");
        doorAnimator.SetTrigger("DoorOpen");
        StartCoroutine("DemonicDoorCoroutine");
    }

    IEnumerator DemonicDoorCoroutine()
    {
        yield return new WaitForSeconds(1f);
        while (!(RenderSettings.ambientSkyColor == Color.black))
        {
            Color color = RenderSettings.ambientSkyColor;
            Color newColor = new Color(color.r-0.1f, color.g-0.1f, color.b-0.1f);
            RenderSettings.ambientSkyColor = newColor;            
            yield return new WaitForSeconds(0.1f);
        }
    }

}
