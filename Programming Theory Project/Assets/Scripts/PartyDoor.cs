using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyDoor : Door // INHERITANCE  - child of Door class
{
    public ParticleSystem confettiSystem;

    // POLYMORPHISM:
    public override void Open()
    {
        base.Open();
        doorAnimator.SetTrigger("DoorOpen");
        StartCoroutine("PartyDoorCoroutine");
    }

    IEnumerator PartyDoorCoroutine()
    {
        yield return new WaitForSeconds(1f);
        confettiSystem.Play();
    }
}
