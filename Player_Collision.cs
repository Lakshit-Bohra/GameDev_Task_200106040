using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Collision : MonoBehaviour
{
    public Player_Movement movement;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "car")
        {
            movement.enabled = false;
            SceneManager.LoadScene("Car collision menu");
        }

        if (collisionInfo.collider.tag == "barrier")
        {
            movement.enabled = false;
            SceneManager.LoadScene("Barrier collision Menu");
        }

    }
}
