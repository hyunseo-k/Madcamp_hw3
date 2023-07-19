using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction4 : MonoBehaviour
{
    public GameObject KaimaruDoor;
    public Button interactionButton;
    public float interactionDistance = 2.0f;

    private void Update()
    {
        float distance = Vector2.Distance(transform.position, KaimaruDoor.transform.position);
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
