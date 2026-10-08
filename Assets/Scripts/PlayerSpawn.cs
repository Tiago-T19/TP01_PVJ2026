using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform spawnPoint;

    void Update()
    {
        if (transform.position.y < -10f)
        {
            transform.position = spawnPoint.position + Vector3.up * 1f;
        }
    }
}