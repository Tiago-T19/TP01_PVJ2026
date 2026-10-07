using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponentInParent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        // Si se cae del mapa
        if (transform.position.y < -10f)
        {
            Respawn();
        }
    }

    public void Respawn()
    {
        rb.linearVelocity = Vector3.zero;

        transform.position =
            spawnPoint.position + Vector3.up * 1f;
    }

}

