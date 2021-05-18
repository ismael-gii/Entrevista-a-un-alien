using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntero360 : MonoBehaviour
{
    public Transform imagen;
    float mytime = 0.0f;
    float escala = 1.5f;
    bool activo = false;

    // Start is called before the first frame update
    void Start()
    {
        Reinicio();
    }

    // Update is called once per frame
    void Update()
    {
        if (activo)
        {
            mytime += Time.deltaTime;
            imagen.GetComponent<Image>().fillAmount = mytime/escala;
            if (mytime > 1*escala)
            {
                Reinicio();
            }
        }   
    }

    public void Activo()
    {
        mytime = 0;
        imagen.GetComponent<Image>().fillAmount = mytime/escala;
        activo = true;
    }

    public void Reinicio()
    {
        mytime = 0;
        imagen.GetComponent<Image>().fillAmount = mytime/escala;
        activo = false;
    }
}
