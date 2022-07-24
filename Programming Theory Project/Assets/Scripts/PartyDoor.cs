using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyDoor : Door // INHERITANCE
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
