using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public LayerMask layer;

    float xInput;
    float zInput;

    [SerializeField]
    float speed = 5f;

    [SerializeField]
    float rayLenght = 1f;

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        Vector3 move = transform.right * xInput + transform.forward * zInput;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.E))
        {
            OpenNearbyDoor();
        }       
    }

    private void OpenNearbyDoor()
    {
        Debug.Log("E pressed");

        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        
        RaycastHit hit;
        if (Physics.Raycast(transform.position,fwd, out hit, rayLenght,layer))
        {
            Debug.Log("hit something");
            Door nearbyDoor = hit.collider.gameObject.GetComponentInParent<Door>();
            if (nearbyDoor != null)
            {
                Debug.Log("Door distance : "+hit.distance);
                nearbyDoor.Open();
            }
        }
    }
}
