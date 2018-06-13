using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController movement;     // A reference to our PlayerController script
    float tempforce;
    int k=0;

    // This function runs when we hit another object.
    // We get information about the collision and call it "collisionInfo".
    void OnCollisionEnter(Collision collisionInfo)
    {
        // We check if the object we collided with has a tag called "Obstacles".
        if (collisionInfo.collider.tag == "Obstacles")
        {
            movement.enabled = false;   // Disable the players movement.
            FindObjectOfType<GameManager>().EndGame();
        }
        else if (collisionInfo.collider.tag == "BoostUps")
        {
           k++;
           if (k == 1)
           {
              tempforce = movement.forwardForce;
           }
           StartCoroutine(Restart());
            
        }
    }

    IEnumerator Restart()
    {   
        movement.forwardForce = 150f;

        if (k == 1)
        {
            yield return new WaitForSeconds(2f);
        }

        if (k > 1)
        {
            yield return new WaitForSeconds(2f);
        }

        k--;
        movement.forwardForce = tempforce;

    }

}
