using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target; // Okreœla, któr¹ postaæ kamera ma œledziæ
    public Vector3 offset = new Vector3(0, 2, -5); // Okreœla po³o¿enie kamery wzglêdem postaci

    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
            transform.LookAt(target.position);
        }
    }
}