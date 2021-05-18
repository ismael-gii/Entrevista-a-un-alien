using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambioColores : MonoBehaviour
{
    float mytime = 0.0f;
    bool activo = false;
    public void Red()
    {
        Debug.Log("R");
        GetComponent<Renderer>().material.color = Color.red;
        mytime = 0;
        activo = true;
    }
    public void Blue()
    {
        Debug.Log("B");
        GetComponent<Renderer>().material.color = Color.blue;
        activo = false;
    }
    public void Green()
    {
        Debug.Log("G");
        GetComponent<Renderer>().material.color = Color.green;
        activo = false;
    }
    private void Update()
    {
        mytime += Time.deltaTime;
        if (activo && mytime > 1)
        {
            Destroy(gameObject);
        }
    }
}
