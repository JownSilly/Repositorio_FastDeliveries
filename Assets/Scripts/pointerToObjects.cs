using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pointerToObjects : MonoBehaviour
{
    
    private Transform target;
    private Transform target2;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        // SE HOUVER ALGUM PACOTE GERADO DENTRO DA CENA, O PONTEIRO IRA APONTAR PARA A SUA POSIÇÃO

        if (GameObject.Find("GeradorPacote").GetComponent<GeneratePackage>().hasPackage)
        {
            target = GameObject.FindGameObjectWithTag("Collectable").GetComponent<Transform>();
            Vector2 direction = target.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
        }
        // SE NÃO SE HOUVER ALGUM PONTO DE ENTREGA GERADO DENTRO DA CENA, O PONTEIRO IRA APONTAR PARA A SUA POSIÇÃO
        else if (GameObject.Find("GeradorPontoEntrega").GetComponent<GenerateDeliveryPoint>().hasPointD)
        {
            target2 = GameObject.FindGameObjectWithTag("deliveryPoint").GetComponent<Transform>();
            Vector2 direction = target2.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);

        }
        // CASO NENHUMA DAS CONDIÇÕES FOR VERDADEIRAS, O JOGO ENCERRA, POIS O PLAYER JA ENTREGOU TODOS OS PACOTES
        else
        {

            SceneManager.LoadScene("gameover");
        }
        
        }
    
}
