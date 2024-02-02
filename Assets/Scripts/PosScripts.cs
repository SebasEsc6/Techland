using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosScripts : MonoBehaviour
{
    public Image myPanel;
    public Color green;
    public Color red;
    public GameObject[] puzzlePieces;
    private int placedPieces = 0;

    // Start is called before the first frame update
    void Start()
    {
        green.a = 1;
        red.a = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CPU"))
        {
            
            if (placedPieces == 1)
            {
                Debug.Log("¡Puzzle completado!");
            }
        }
        if (collision.gameObject.CompareTag("CPU"))
        {
            Debug.Log("GREEN");
            myPanel.color = green;
            placedPieces++;
        }
        else
        {
            if (collision.gameObject.CompareTag("RAM"))
            {
                Debug.Log("RED");
                myPanel.color = red;
               
            }
        }

    }
}
