using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction2 : MonoBehaviour
{
    public GameObject HulalaDoor;
    public Button interactionButton;
    public float interactionDistance = 2.0f;

    private void Update()
    {
        float distance = Vector2.Distance(transform.position, HulalaDoor.transform.position);
        if (distance < interactionDistance)
        {
            interactionButton.gameObject.SetActive(true);
        }
        else
        {
            interactionButton.gameObject.SetActive(false);
        }
    }
}
