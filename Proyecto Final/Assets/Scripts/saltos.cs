using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saltos : MonoBehaviour
{
    public int mundo;
    float mytime = 0.0f;
    bool activo = false;
    float escala = 1.5f;
    string[] escenas = { "inicio", "e1", "e2", "e3", "e4", "Gris", 
        "Reptiliano", "Umita", "P_inicial", "S1", "S2", "S3", "Among Us"};

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
            if (mundo != 12)
                controlSonido2.pausar();

            SceneManager.LoadScene(escenas[mundo], LoadSceneMode.Single);
        }
    }
}
