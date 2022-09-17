using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class TouchController : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{

    private Vector2 TouchPosition;
    public Vector2 Direction;
    public Vector2 Rotation;


    public void OnDrag(PointerEventData eventData)
    {
        var delta = eventData.position - TouchPosition;
        Direction = delta.normalized;
        Rotation = delta.normalized;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        TouchPosition = eventData.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Direction = Vector2.zero;
    }
}
