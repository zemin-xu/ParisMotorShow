using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera camera;

    public void TeleportTo(Transform mark)
    {
        camera.transform.position = mark.position;
        camera.transform.rotation = mark.rotation;
    }
}