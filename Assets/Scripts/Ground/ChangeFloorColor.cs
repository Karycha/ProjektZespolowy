using UnityEngine;

public class ChangeFloorColor : MonoBehaviour
{
    public Color newColor = Color.red;

    void Start()
    {
        ChangeColor();
    }

    void ChangeColor()
    {
        Renderer renderer = GetComponent<Renderer>();
        Material material = renderer.material;

        material.color = newColor;
    }
}