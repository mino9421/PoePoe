using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Transform playerTransform;

    //pubic float offset;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }


    // called after regular update and fixed update 
    void LateUpdate()
    {
        FollwingPlayer();
    }

    void FollwingPlayer()
    {
        // we store current camera's position in variable temp - temporary position
        Vector3 temp = playerTransform.position;

        // we set the camera's position x to be equal to the player's position x
        temp.x = playerTransform.position.x;
        temp.y = playerTransform.position.y;
        temp.z = -10;

        // this will add the offset value to the temporary camera x position
        //temp.x += offset;

        // we set back the camera's temp position to the camera's current position
        transform.position = temp;
    }
}




