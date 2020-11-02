
using UnityEngine;

public class CameMove : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
    }
}
