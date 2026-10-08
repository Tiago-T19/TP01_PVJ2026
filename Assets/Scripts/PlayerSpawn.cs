using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform spawnPoint;

    public int nivelActual = 1;

    [SerializeField] private GameObject nivel1;
    [SerializeField] private GameObject nivel2;

    private void Update()
    {
        if (transform.position.y < -10f)
        {
            transform.position = spawnPoint.position + Vector3.up;

            if (nivelActual == 1)
            {
                nivel1.SetActive(true);
                nivel2.SetActive(false);
            }
            else if (nivelActual == 2)
            {
                nivel1.SetActive(false);
                nivel2.SetActive(true);
            }
        }
    }
}






