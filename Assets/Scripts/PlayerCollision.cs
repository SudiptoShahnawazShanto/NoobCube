using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Rigidbody rb;
    public PlayerMovement movement;


    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            rb.AddExplosionForce(700f, transform.position, 7f);
            movement.enabled = false;
            //GetComponent<PlayerMovement>.enabled = false;
            FindObjectOfType<GameManager>().EndGameCollision();
            
        }
    }
}
