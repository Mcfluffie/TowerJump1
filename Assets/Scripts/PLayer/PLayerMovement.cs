using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerMovement : MonoBehaviour
{

    public float jumpSpeed = 3f;
    public float jumpsecond = 5f;
    public float jumpDelay = 2f;
    public Animator anim;

    private bool candoublejump;
    private bool canjump;
    private bool isjumping;
    private Rigidbody rb;
    private float countDown;

    // Start is called before the first frame update
    void Start()
    {
        canjump = true;
        rb = GetComponent<Rigidbody>();
        countDown = jumpDelay;
    }

    // Update is called once per frame
    void Update()
    {
        if (isjumping && countDown > 0)
            countDown -= Time.deltaTime;
        else
        {
            canjump = true;
            isjumping = false;
            countDown = jumpDelay;
        }

    }

    public void StartLetsJump()
    {
        if (canjump)
        {
            anim.Play("Jump");
            canjump = false;
            isjumping = true;
            candoublejump = true;
            rb.AddForce(0, jumpSpeed, 0, ForceMode.Impulse);
            
        }
        else if(candoublejump)
        {
            anim.Play("Jump");
            rb.AddForce(0, jumpsecond, 0, ForceMode.Impulse);
            candoublejump = false;
            
        }

    }

   



}
