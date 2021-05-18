using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class amongUsSecret : MonoBehaviour
{
    public GameObject bola, icono;
    float mytime = 0.0f;
    bool activo = false;
    float escala = 1.5f;

    public void Activo()
    {
        Debug.Log("A");
        mytime = 0;
        activo = true;
    }
    public void Reiniciar()
    {
        Debug.Log("R");
        activo = false;
    }

    private void Update()
    {
        mytime += Time.deltaTime;
        if (activo && mytime > 1*escala)
        {
            controlSonido.pausar();
            controlSonido2.continuar();
            bola.gameObject.SetActive(false);
            icono.gameObject.SetActive(true);
        }
    }
}
