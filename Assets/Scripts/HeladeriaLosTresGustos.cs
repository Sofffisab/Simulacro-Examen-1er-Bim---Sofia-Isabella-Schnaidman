using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeladeriaLosTresGustos : MonoBehaviour
{
    public int cantidadDeHelado;
    public string codigoGusto;
    float precioPorKilo = 1250;
    float precioPorGramo;
    float precioTotal;
    


    // Start is called before the first frame update
    void Start()
    {
        if (cantidadDeHelado > 3000  || cantidadDeHelado < 250)
        {
            Debug.Log("Cantidad de helado no valida");
            return;
        }

        precioPorGramo = precioPorKilo / 1000;
        precioTotal = precioPorGramo * cantidadDeHelado;
        if (codigoGusto == "DDL")
        {
            Debug.Log("Pediste " + cantidadDeHelado + " gramos de helado de dulce de leche, el costo sera $" + precioTotal); 
        } else if (codigoGusto == "CHO")
        {
            Debug.Log("Pediste " + cantidadDeHelado + " gramos de helado de chocolate, el costo sera $" + precioTotal);
        }
        else if (codigoGusto == "FRU")
        {
            precioTotal = precioTotal * 0.9f;
            Debug.Log("Pediste " + cantidadDeHelado + " gramos de helado de frutilla, el costo sera $" + precioTotal);
        } else
        {
            Debug.Log("Codigo no valido");
            return;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
