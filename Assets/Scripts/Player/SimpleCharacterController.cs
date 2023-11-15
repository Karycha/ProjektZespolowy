using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{
    public float speed = 5f;
    

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveForward = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float moveSideways = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        rb.MovePosition(transform.position + new Vector3(moveSideways, 0, moveForward));
    }
    
}
