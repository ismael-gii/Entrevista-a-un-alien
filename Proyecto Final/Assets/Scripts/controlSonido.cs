using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlSonido : MonoBehaviour
{
    public static controlSonido _instancia;
    public int contador = 0;
    public static bool creado = false;
    static AudioSource audio;
    private void Awake()
    {
        if(controlSonido._instancia == null && !creado)
        {
            audio = GetComponent<AudioSource>();
            controlSonido._instancia = this;
            DontDestroyOnLoad(gameObject);
            creado = true;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static void addContador()
    {
        _instancia.contador++;
    }

    public static int dameContador()
    {
        return _instancia.contador;
    }
    public static void pausar()
    {
        audio.Stop();
    }
    public static void continuar()
    {
        audio.Play();
    }
}
