using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBallScript : MonoBehaviour
{
    [SerializeField] private BasketBallMinScript basketBallMini;

    private Vector3 initialPosition;

    private void Awake()
    {
        initialPosition = transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ring")
        {
            //update the score here
            basketBallMini.UpdatePoint();
        }
        
        if (other.gameObject.tag == "Ground")
        {
            // set the basket ball to the initial position once it hits the ground
            
            //transform.position = initialPosition;
            /*gameObject.GetComponent<Rigidbody>().useGravity = false;
            gameObject.GetComponent<Rigidbody>().freezeRotation = true;
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;*/
        }
    }
}
