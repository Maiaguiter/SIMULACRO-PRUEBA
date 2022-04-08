using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ2 : MonoBehaviour
{
    public int preciouno;
    public int preciodos;
    public int preciotres;
    public int precioproductos;
    public int dinerodepersona;
    
  

    // Start is called before the first frame update
    void Start()
    {
        int dinerofaltante;
        int dinerosobrante;
        precioproductos = preciouno + preciodos + preciotres;
        if (precioproductos > dinerodepersona)
        {
            dinerofaltante = precioproductos - dinerodepersona;
            Debug.Log("Falta dinero " + dinerofaltante + " para la compra"); 
        }
        else if (precioproductos < dinerodepersona)
        {
            dinerosobrante = dinerodepersona - precioproductos;
            Debug.Log(" Sobra dinero " + dinerosobrante + " para la compra");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
