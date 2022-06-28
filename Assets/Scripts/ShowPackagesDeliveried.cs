using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowPackagesDeliveried : MonoBehaviour
{
    public TMP_Text pacoteEntregues;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pacoteEntregues.text = "Pacotes: " + GameObject.Find("Personagem").GetComponent<Player>().getPackageAmount().ToString();
    }
}
