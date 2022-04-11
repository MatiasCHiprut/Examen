//Realizar el programa que permita ingresar por inspector el código de la categoría del animal y cuántos días va a quedarse.
//El programa debe cumplir los siguientes requerimientos:
//Debe devolver el mensaje “Para ese período se necesitan  ” + [peso en gramos del alimento] + “ gramos de alimento”.
//Sabiendo que el precio del alimento es de $80 por 100g, agregar un mensaje que muestre el costo de la cantidad de alimento calculada.
//Debe mostrar mensajes de error(y no realizar el cálculo) si se ingresa un código no válido o si se ingresa una cantidad de días menor a 3.


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1 : MonoBehaviour
{
    public string codigo;
    public int dias;
    // Start is called before the first frame update
    void Start()
    {
        if (dias < 3)
        {
            Debug.Log("Error");
        }
        else
        {
            if (codigo == "G")
            {
                int total = 300 * dias;
                int precio = total * 80 / 100;
                Debug.Log("Para ese período se necesitan " + total + " gramos de alimento y le costaría " + precio + " pesos.");
            }
            else if (codigo == "PP")
            {
                int total = 400 * dias;
                int precio = total * 80 / 100;
                Debug.Log("Para ese período se necesitan " + total + " gramos de alimento y le costaría " + precio + " pesos.");
            }
            else if (codigo == "PG")
            {
                int total = 700 * dias;
                int precio = total * 80 / 100;
                Debug.Log("Para ese período se necesitan " + total + " gramos de alimento y le costaría " + precio + " pesos.");
            }
            else
            {
                Debug.Log("Error");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
