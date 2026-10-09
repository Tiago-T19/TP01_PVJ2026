using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movimiento")]
    [SerializeField] private float walkSpeed;

    private Vector3 dir = Vector3.zero;

    private Vector3 externalMoveSpeed;

    [Header("Salto")]
    [SerializeField] private float JumpForce;
    private Rigidbody rb;
    [SerializeField] private bool isGrounded = false;

    [Header("Power Up Velocidad")]
    [SerializeField] private float speedBoostDuration = 8f;
    private bool speedBoostActive = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // MOVIMIENTO
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        dir = new Vector3(h, 0f, v);

        Vector3 mover = dir.normalized * walkSpeed * Time.deltaTime
                      + externalMoveSpeed * Time.deltaTime;

        transform.Translate(mover, Space.Self);

        // SALTO
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }

        Debug.Log($"H:{h} V:{v}");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    // ==========================
    // POWER UP DE VELOCIDAD
    // ==========================

    public void EnableSpeedBoost(float extraSpeed)
    {
        if (!speedBoostActive)
        {
            StartCoroutine(SpeedBoost(extraSpeed));
        }
    }

    private IEnumerator SpeedBoost(float extraSpeed)
    {
        speedBoostActive = true;

        walkSpeed += extraSpeed;

        Debug.Log("<color=green>VELOCIDAD AUMENTADA</color>");

        yield return new WaitForSeconds(speedBoostDuration);

        walkSpeed -= extraSpeed;

        speedBoostActive = false;

        Debug.Log("<color=red>VELOCIDAD NORMAL RESTAURADA</color>");
    }

    public Vector3 ExternalMoveSpeed
    {
        get => externalMoveSpeed;
        set => externalMoveSpeed = value;
    }
}



