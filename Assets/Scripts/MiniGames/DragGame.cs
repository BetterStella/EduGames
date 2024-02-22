using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragGame : MonoBehaviour,IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerDownHandler
{

    private Vector2 lastMousePosition;
    private float x, y, z;
    private CanvasGroup canvasGroup;

    public void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();

    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        lastMousePosition = eventData.position;
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;


    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 currentMousePosition = eventData.position;
        Vector2 diff =  currentMousePosition - lastMousePosition;

        RectTransform rectTransform = GetComponent < RectTransform>();
        x = diff.x;
        y = diff.y;
        z = transform.localPosition.z;

        rectTransform.position = rectTransform.position + new Vector3(x, y, z);

        lastMousePosition = currentMousePosition;
     }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Ended Drag");
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;


    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Mouse clicked");
    }
}
