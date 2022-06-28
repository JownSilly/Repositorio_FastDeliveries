using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Player : MonoBehaviour
{
    public int quantidadePacotes;
    public Sprite car_withpackage;
    public Sprite car;
    private int packageAmount;
    private bool IsWithThePackage;
    public TMP_Text message;
    SpriteRenderer carro;
    // Start is called before the first frame update
    void Start()
    {
        carro = GetComponent<SpriteRenderer>();
        IsWithThePackage = false;
        packageAmount = 0;
        message.text = "PACOTE ENTREGUE!";
        message.enabled = false;
        
    }
    private void Update()
    {
        
    }
    // Update is called once per frame
    public void packageCaught()
    {
        IsWithThePackage = true;
         
        carro.sprite = car_withpackage;
        GameObject.Find("GeradorPacote").GetComponent<GeneratePackage>().hasPackage = false;
    }
    public bool getIsWithThePackage()
    {
        return IsWithThePackage;
    }
    public void packageDelivered()
    {

        IsWithThePackage = false;
        carro.sprite = car;
        packageAmount += 1;
        message.enabled = true;
    }
    public int getPackageAmount()
    {
        return packageAmount;
    }
}
