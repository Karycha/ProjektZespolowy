using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target; // Okre�la, kt�r� posta� kamera ma �ledzi�
    public Vector3 offset = new Vector3(0, 2, -5); // Okre�la po�o�enie kamery wzgl�dem postaci

    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
            transform.LookAt(target.position);
        }
    }
}