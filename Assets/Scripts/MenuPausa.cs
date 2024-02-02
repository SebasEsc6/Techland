using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;
    private bool pausarJuego = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if(pausarJuego){
                Reanudar();
            }else{
                Pausar();
            }
        }
    }
   
    public void Pausar()
    {
        pausarJuego = true;
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }

    // Update is called once per frame
    public void Reanudar()
    {
        pausarJuego = false;
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }
    public void Cerrar()
    {
        Debug.Log("Cerrando juego");
        Application.Quit();
    }
    
}
