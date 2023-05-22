using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PuzzlePiece : MonoBehaviour, IDragHandler, IEndDragHandler
{
    private Vector3 startPosition;
    private Vector3 offset;

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition + offset;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Aquí puedes agregar la lógica para verificar si la pieza se coloca en la posición correcta
        // y, si es así, establecer la posición final de la pieza y desactivar la detección de colisiones.
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        startPosition = transform.position;
        offset = startPosition - Input.mousePosition;
    }
}
