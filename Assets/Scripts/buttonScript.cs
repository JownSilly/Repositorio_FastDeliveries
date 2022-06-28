using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void reiniciar()
    {
        SceneManager.LoadScene("Level1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
