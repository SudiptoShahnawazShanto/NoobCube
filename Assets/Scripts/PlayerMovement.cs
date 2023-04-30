using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sideWaysForce = 500f;
    public float upWardForce = 50f;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0, upWardForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGameFall();
        }
    } 
}
