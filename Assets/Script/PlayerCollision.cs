
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    
    void OnCollisionEnter( Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;

            Debug.Log("You have hit the thing~!");
        }

        if (collisionInfo.collider.name == "Ground")
        {
            Debug.Log("YOu have hit the Ground");

        }

        if (collisionInfo.collider.tag == "Win")
        {
            Debug.Log("YOu won!");
            movement.enabled = false;
        }


    }
}
