using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OpponentController : MonoBehaviour {

    public Rigidbody opp;
    private Vector3 movement;

    void Start()
    {
        opp = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {      
        opp.velocity = new Vector3(0, 0, 2600f * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        // We check if the object we collided with has a tag called "Obstacles".
        if (collisionInfo.collider.tag == "Obstacles")
        {
            opp.velocity = new Vector3(2000f * Time.deltaTime, 0, 0);

        }
    }

    }
