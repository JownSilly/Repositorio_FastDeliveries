using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryPointController : MonoBehaviour
{
    private Player _player;
    
    private GeneratePackage _gerarPacote;
    void Start()
    {
        _player = GameObject.Find("Personagem").GetComponent<Player>();
        _gerarPacote = GameObject.Find("GeradorPacote").GetComponent<GeneratePackage>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    // AO ENTRAR EM UM PONTO DE ENTREGA O PACOTE É ENTRE E É CONTABILIZADO +1
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (_player.getIsWithThePackage())
            {
                _player.packageDelivered();
            }
        }
    }
    // QUANDO O CARRO SAIR DE DENTRO DE UM PONTO DE ENTREGA, NOVOS PACOTES SERÃO GERADOS E O PONTO ATUAL É DESTRUIDO 
    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            if (_player.getPackageAmount() <=_player.quantidadePacotes)
            {
                _gerarPacote.generatePackages();
            }
            
            
        }
        Destroy(gameObject);
        GameObject.Find("GeradorPontoEntrega").GetComponent<GenerateDeliveryPoint>().hasPointD = false;
        _player.message.enabled = false;
        
    }
    
}
