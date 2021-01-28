using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public int textureIndex = 0;
    public List<Color> colors;

    public string carName;

    public bool canChangeColor = true;

    [TextArea]
    public string detail;

    private Renderer renderer;
    private int colorIndex = 0;
    private Menu menu;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        menu = FindObjectOfType<Menu>();
        if (canChangeColor)
            colors[colorIndex] = renderer.materials[textureIndex].color;
    }

    // Start is called before the first frame update
    public void ChangeColor()
    {
        if (colorIndex < colors.Count - 1)
        {
            colorIndex++;
        }
        else
        {
            colorIndex = 0;
        }

        renderer.materials[textureIndex].color = colors[colorIndex];
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            menu.UpdateNearbyCar(this);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            menu.DeactivateInfoButton();
        }
    }
}