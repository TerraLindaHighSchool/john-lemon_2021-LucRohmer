using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;
    private Vector3 moveDirection;
    private Quaternion rotation;
    private bool isWalking;

    [SerializeField] private float turnSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        rotation = Quaternion.identity;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    //Animator event
    private void OnAnimatorMove()
    {
      
      
    }
}
