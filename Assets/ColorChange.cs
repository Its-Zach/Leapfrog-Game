using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialColor : MonoBehaviour
{
    // Reference to the Renderer component
    private Renderer _renderer;

    // Awake is called before Start
    void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    // Change the material color to a random color
    public void ChangeToRandomColor()
    {
        // Generate random values for each color channel
        float red = Random.Range(0.0f, 1.0f);
        float green = Random.Range(0.0f, 1.0f);
        float blue = Random.Range(0.0f, 1.0f);

        // Create a new random color
        Color randomColor = new Color(red, green, blue);

        // Set the material color
        _renderer.material.color = randomColor;
    }
}
