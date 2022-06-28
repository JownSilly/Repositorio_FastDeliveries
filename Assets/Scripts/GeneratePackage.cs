using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePackage : MonoBehaviour
{
    public bool hasPackage;
    public GameObject packagePrefab;
    private GameObject[] locais;
    private int randomNumber;
    private Vector2 posicaoSpawn;
    // Start is called before the first frame update
    void Start()
    {
        hasPackage = false;
        locais = GameObject.FindGameObjectsWithTag("Local");
        generatePackages();

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void generatePackages()
    {
        hasPackage = true;
        randomNumber = Random.Range(0, locais.Length) ;
        posicaoSpawn =locais[randomNumber].transform.position;
        Instantiate(packagePrefab, posicaoSpawn, Quaternion.identity);
        
    }

}
