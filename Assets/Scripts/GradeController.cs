using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradeController : MonoBehaviour
{
    public GameObject noveno;
    public GameObject decimo;
    public GameObject once;

    public GameObject butonAdelante;
    public GameObject butonAtras;
    // Start is called before the first frame update
    
    public void Visible()
    {
        if (noveno.activeSelf)
        {
            noveno.SetActive(false);
            decimo.SetActive(true);
        }
        else
        {
            if (decimo.activeSelf)
            {
                decimo.SetActive(false);
                once.SetActive(true);
            }
            else
            {
                if (once.activeSelf)
                {
                    once.SetActive(false);
                    noveno.SetActive(true);
                }

            }

        }

    }
    public void InVisible()
    {

        if (once.activeSelf)
        {
            once.SetActive(false);
            decimo.SetActive(true);
        }
        else
        {
            if (decimo.activeSelf)
            {
                noveno.SetActive(true);
                decimo.SetActive(false);

            }
            else
            {
                if (noveno.activeSelf)
                {
                    once.SetActive(true);
                    noveno.SetActive(false);

                }
            }
        }


    }
}
