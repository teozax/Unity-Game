using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float forwardForce;
    public float sidewaysForce;
    public Rigidbody rb;
    public Transform tr;
    Vector3 temp;

    // Update is called once per frame
    void FixedUpdate () {

        float moveHorizontal = Input.GetAxis("Mouse X");
        Vector3 movement = new Vector3(moveHorizontal * sidewaysForce * Time.deltaTime, 0.0f, forwardForce * Time.deltaTime);
        rb.AddForce(movement,ForceMode.VelocityChange);

    }
}
