using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musica : MonoBehaviour
{
    float mytime = 0.0f;
    bool activo = false;
    float escala = 1.5f;
    bool m_act = true;
    public void Start()
    {
    }

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
        if (activo && mytime > 1 * escala)
        {
            // Activamos/desactivamos música
            m_act = !m_act;
            if (!m_act)
                controlSonido.pausar();
            else
                controlSonido.continuar();

            Debug.Log("Funciona");
            activo = false;
        }
    }
}
