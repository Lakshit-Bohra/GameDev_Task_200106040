using UnityEngine;
using UnityEngine.UI;

public class Distance_Left : MonoBehaviour
{

    public Transform player;
    public Text dist;

 
    void Update()
    {
        dist.text = (280 - player.position.z).ToString("0");
    }
}
