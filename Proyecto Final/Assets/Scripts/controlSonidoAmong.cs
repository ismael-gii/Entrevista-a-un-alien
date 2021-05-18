using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlSonidoAmong : MonoBehaviour
{
    public static controlSonidoAmong _instancia;
    public int contador = 0;
    public static bool creado = false;
    static AudioSource audio;
    private void Awake()
    {
        if(controlSonidoAmong._instancia == null && !creado)
        {
            audio = GetComponent<AudioSource>();
            controlSonidoAmong._instancia = this;
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
