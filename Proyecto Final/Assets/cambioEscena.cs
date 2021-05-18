using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioEscena : MonoBehaviour
{
    float mytime = 0.0f;
    static int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mytime += Time.deltaTime;
        if (mytime > 1 )
        {
            a++;
            Debug.Log(a);
            if(a==1)
                SceneManager.LoadScene("Auxiliar", LoadSceneMode.Single);
            else
            SceneManager.LoadScene("P_inicial", LoadSceneMode.Single);
        }
    }
}
