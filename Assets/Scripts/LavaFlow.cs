using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaFlow : MonoBehaviour
{

    public GameObject lava;
    public float lavaMoveSpeed = 5f;
    public GameObject resetMenu;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lava.transform.position += new Vector3(0f, lavaMoveSpeed, 0f) * Time.deltaTime;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            resetMenu.SetActive(true);

        }
        else
        {
            resetMenu.SetActive(false);
            Destroy(player);
        }
    }



}
