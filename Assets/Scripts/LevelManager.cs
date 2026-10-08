using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class LevelManager : MonoBehaviour
{
    // Script para manejar los niveles
    [SerializeField] private GameObject level01;
    [SerializeField] private GameObject level02;
    [SerializeField] private GameObject Meta;
    [SerializeField] private int level;


    public void LoadLevel(int levelNumber)
    {
        switch (levelNumber)
        {
            case 1:

                level01.SetActive(true);
                level02.SetActive(false);
                Meta.SetActive(false);

                break;

            case 2:

                level01.SetActive(false);
                level02.SetActive(true);
                Meta.SetActive(false);

                break;

            case 3:

                level01.SetActive(false);
                level02.SetActive(false);
                Meta.SetActive(true);

                break;
        }
    }

   /* private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switch (level)
            {
                case 1:

                    Debug.Log("<color=purple>Nivel 1: </color> Supera las <color=magenta>plataformas</color> y esquiva los <color=magenta>obstaculos</color>");

                    level01.SetActive(true);
                    level02.SetActive(false);
                    Meta.SetActive(false);

                    break;

                case 2:

                    Debug.Log("<color=purple>Nivel 2: </color> Lleva el <color=magenta>objeto</color> a su <color=magenta>lugar</color>");

                    level01.SetActive(false);
                    level02.SetActive(true);
                    Meta.SetActive(false);

                    break;

                case 3:

                    Debug.Log("<color=green>FELICIDADES!!!</color>");

                    level01.SetActive(false);
                    level02.SetActive(false);
                    Meta.SetActive(true);

                    break;
            }
        }
    }*/

}