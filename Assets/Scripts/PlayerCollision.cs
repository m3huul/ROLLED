using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement Movement;
    public GameManager gameManager;
    void OnCollisionEnter(Collision collision){
        if(collision.collider.tag == "Obstacle"){
            Movement.forwardForce= 0f;
            Movement.sidewaysForce = 0f;
            gameManager.GameEnded();
        }      
    }
}
