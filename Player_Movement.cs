using UnityEngine;

public class Player_Movement : MonoBehaviour { 
    public Rigidbody player;
    public float forwardforce  = 2000f;
    public float sidewaysforce = 500f;

    // Start is called before the first frame update
 

    // Update is called once per frame
    void FixedUpdate()
    {
        player.AddForce(0, 0, forwardforce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            player.AddForce(sidewaysforce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            player.AddForce(-sidewaysforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (player.position.y < -0.5 || player.position.x <-9 || player.position.x > 9)
        {
            FindObjectOfType<Game_Manager>().GameEnd();
        }
    }
}
