using UnityEngine;
using StarterAssets;

public class PlayerCollision : MonoBehaviour
{
    public FirstPersonController controller;
    void OnCollisionEnter(Collision collisionInfo) {
        if(collisionInfo.collider.tag == "Obstacle") {
            controller.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    void EnableController() {
        controller.enabled = true;
    }
}
