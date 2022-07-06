using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce;
    public float sidewaysForce;
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);//making player move forward

        if(Input.GetKey("d")){
            rb.AddForce(sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
    }
}
