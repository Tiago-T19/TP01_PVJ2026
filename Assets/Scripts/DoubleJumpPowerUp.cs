using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    [SerializeField] private float extraSpeed = 5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMovement player = other.GetComponent<PlayerMovement>();

            if (player != null)
            {
                player.EnableSpeedBoost(extraSpeed);
            }

            Destroy(gameObject);
        }
    }
}