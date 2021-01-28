using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Menu : MonoBehaviour
{
    private Car nearbyCar;

    public GameObject moreInfoButton;

    public GameObject moreInfoUI;
    public TMP_Text title;
    public TMP_Text info;

    public void DisplayCarInfo()
    {
        if (nearbyCar != null)
        {
            title.text = nearbyCar.carName;
            info.text = nearbyCar.detail;
            moreInfoUI.SetActive(true);
            moreInfoUI.transform.position = transform.position + new Vector3(0, 0, -0.2f);
            moreInfoUI.transform.rotation = transform.rotation;
        }
    }

    public void UpdateNearbyCar(Car car)
    {
        nearbyCar = car;
        moreInfoButton.SetActive(true);
    }

    public void DeactivateInfoButton()
    {
        nearbyCar = null;
        moreInfoButton.SetActive(false);
    }

    public void OnExitButtonClicked()
    {
        Camera camera = Camera.main;
        camera.transform.position = Vector3.zero;
        camera.transform.rotation = Quaternion.identity;
    }
}