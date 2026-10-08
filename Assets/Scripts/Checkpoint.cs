using UnityEngine;

public class CheckpointNivel : MonoBehaviour
{
    [SerializeField] private GameObject level01;
    [SerializeField] private GameObject level02;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerRespawn respawn = other.GetComponent<PlayerRespawn>();

            // Guardar punto de respawn
            respawn.spawnPoint = transform;

            // Guardar que estamos en nivel 2
            respawn.nivelActual = 2;

            // Activar nivel 2
            level01.SetActive(false);
            level02.SetActive(true);

            Debug.Log("Nivel 2 activado");
        }
    }
}