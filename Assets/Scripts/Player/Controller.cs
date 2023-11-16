using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Ruch gracza
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalMovement, 0f, verticalMovement) * speed * Time.deltaTime;
        rb.MovePosition(transform.position + movement);

        // Skakanie gracza
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        // Stabilizacja rotacji
        StabilizeRotation();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Sprawdü, czy gracz jest na ziemi
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void StabilizeRotation()
    {
        // Stabilizacja rotacji w p≥aszczyünie Y (up)
        Vector3 newRotation = transform.rotation.eulerAngles;
        newRotation.x = 0f;
        newRotation.z = 0f;
        transform.rotation = Quaternion.Euler(newRotation);
    }
}