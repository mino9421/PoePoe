using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{

    //Player warrior;
    //Player archer;

    private Rigidbody2D myBody;
    private BoxCollider2D myCollider;
    private AudioSource audioSource;
    private Animator anim;

    private Transform myTransform;

    // third function when game is ran
    private void Start()
    {
        anim = GetComponent<Animator>();


    }
    
    private void Update()
    {

    }

}
