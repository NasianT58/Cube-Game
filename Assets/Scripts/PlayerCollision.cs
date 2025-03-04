using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //Deleted both start and update methods
    //This is for collisions

    public PlayerMovement movement;


    void OnCollisionEnter (Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle") {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
