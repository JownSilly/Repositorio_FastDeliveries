using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Essa classe ira gerar Pontos de Entrega em posições aleatórias dentro das ruas

public class GenerateDeliveryPoint : MonoBehaviour
{
    public GameObject deliveryPointPrefab;
    public bool hasPointD;
    private int randomNumber;
    private GameObject[] ruas;
    void Start()
    {
        ruas = GameObject.FindGameObjectsWithTag("Rua");
        hasPointD = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void generateDeliveryPoint()
    {
        hasPointD = true;
        randomNumber = Random.Range(0, ruas.Length);
        var name = ruas[randomNumber].GetComponent<SpriteRenderer>().sprite.name;
        
        if (name== "rua_horizontal")
        {
            var spawnPosition = new Vector2(ruas[randomNumber].transform.position.x, ruas[randomNumber].transform.position.y + 1.1f);
            Instantiate(deliveryPointPrefab, spawnPosition, Quaternion.identity);
        }
        else
        {
            var spawnPosition = new Vector2(ruas[randomNumber].transform.position.x + 1.1f, ruas[randomNumber].transform.position.y);
            Instantiate(deliveryPointPrefab, spawnPosition, Quaternion.Euler(0,0,90));
        }
    }
}
