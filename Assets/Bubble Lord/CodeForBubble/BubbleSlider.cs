using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BubbleSlider : MonoBehaviour
{
    public Slider scaleSlider;      // Reference to the UI Slider
    public GameObject bubbleObject; // The bubble object to scale

    void Start()
    {
       
    }

    void Update()
    {
        if (bubbleObject != null)
        {
            bubbleObject.transform.localScale = new Vector3(1, 1, 0);
        }
    }
}
