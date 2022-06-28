using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageController : MonoBehaviour
{
    private Player _player;
    private GenerateDeliveryPoint _deliveryPoint;
    
    private float distancia;
    void Start()
    {
        _player = GameObject.Find("Personagem").GetComponent<Player>();
        _deliveryPoint = GameObject.Find("GeradorPontoEntrega").GetComponent<GenerateDeliveryPoint>();
        
    }

    // Update is called once per frame
    void Update()
    {
        OnProximity();
    }
  // SE A DISTANCIA ENTRE O PERSONAGEM E O PACOTE FOR MENOR QUE ? O PACOTE SERÁ COLETADO E ASSIM UM PONTO DE ENTREGA SERÁ GERADO.
    void OnProximity()
    {
        distancia = Vector2.Distance(_player.transform.position, gameObject.transform.position);
        if (distancia < 3.5f)
        {
            _player.packageCaught();
            
            Destroy(gameObject);
            
            _deliveryPoint.generateDeliveryPoint();
        }
    }
}
