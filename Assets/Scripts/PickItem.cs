using UnityEngine;

public class PickItem : MonoBehaviour
{
    [SerializeField] private Transform hand;
    [SerializeField] private GameObject currentItem = null; // Item actual

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Item"))
        {
          if (Input.GetKeyDown(KeyCode.E))Pick(other.gameObject);
          
        }
    }

    private void Pick(GameObject item)
    {
        currentItem = item;

        item.transform.SetParent(hand);
        item.transform.localPosition = Vector3.zero;
        item.transform.localRotation = Quaternion.identity;

        // Verificaciones para evitar confliccto con el jugador
        Rigidbody rb = item.GetComponent<Rigidbody>();

        Collider collider = item.GetComponent<Collider>();

        if (rb != null) rb.isKinematic = true;
        if (collider != null) collider.enabled = false;
    }
    public GameObject DropItem()
    {
        GameObject temp = currentItem; // Guarda de manera temporal el item actual
        currentItem = null; // Deja de llevar el objeto
        return temp; // Devuelve el item
    }
}
