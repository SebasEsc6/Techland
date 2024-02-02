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
        // Aqu� puedes agregar la l�gica para verificar si la pieza se coloca en la posici�n correcta
        // y, si es as�, establecer la posici�n final de la pieza y desactivar la detecci�n de colisiones.
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        startPosition = transform.position;
        offset = startPosition - Input.mousePosition;
    }
}
