
using UnityEngine;

public class MoveCamere : MonoBehaviour
{
    public GameObject player;

    void Start()
    {

    }

    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
    }
}

