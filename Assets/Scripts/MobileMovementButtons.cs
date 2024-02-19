using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MobileMovementButtons : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool IsPressed = false;

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        IsPressed = true;
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        IsPressed = false;
        Debug.Log(name + " stoped being pressed");
    }

    public bool IsTheButtonBeingPressed()
    {
        return IsPressed;
    }


}
