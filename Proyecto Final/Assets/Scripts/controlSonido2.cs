using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlSonido2 : MonoBehaviour
{
    public static controlSonido2 _instancia;
    public int contador = 0;
    public static bool creado = false;
    static AudioSource audio;
    private void Awake()
    {
        if(controlSonido2._instancia == null && !creado)
        {
            audio = GetComponent<AudioSource>();
            controlSonido2._instancia = this;
            DontDestroyOnLoad(gameObject);
            creado = true;
            audio.Stop();
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
