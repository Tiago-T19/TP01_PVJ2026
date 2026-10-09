using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;
using static UnityEngine.ParticleSystem;

public class WinBehavior : MonoBehaviour
{
    // Script de victoria
    [SerializeField] private ParticleSystem Particle;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("<color=greenYellow>GANASTE!!! Felicidades, lograste sobrevivir</color>");
            
            GetComponent<Renderer>().material.color = Color.greenYellow; // Cambia el color a verde
            Particle.Play();
        }
    }
}

