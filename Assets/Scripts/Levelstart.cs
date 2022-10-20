using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelstart : MonoBehaviour
{

    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim.Play("countdown");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
