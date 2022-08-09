using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosArray : MonoBehaviour
{
    public string palabra;
    public char letra;

    public int[] arrayDeInt;

    // Start is called before the first frame update
    void Start()
    {
        //letra = palabra[palabra.Length -1];
        //Debug.Log(arrayDeInt[0]);
        //Debug.Log(arrayDeInt[arrayDeInt.Length-1]);
        //SumaDeLosElementosDelArray();
        //BuscarLetraEnPalabra(palabra, letra);
        EscribirPalabraInvertidaLetraPorLetra(palabra);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SumaDeLosElementosDelArray()
    {
        // Debug.Log(arrayDeInt[0] + arrayDeInt[1] + arrayDeInt[2]);
        int total = 0;
        for (int i=0;i<arrayDeInt.Length;i++)
        {
            total += arrayDeInt[i];
            Debug.Log("Sumé " + arrayDeInt[i]);
        }
            Debug.Log(total);
    }

    void BuscarLetraEnPalabra(string palabra, char letraBuscada)
    {
        int counter = 0;
        while (counter < palabra.Length && letraBuscada != palabra[counter])
        {     
            counter++;
        }
        if (counter == palabra.Length)
        {
            Debug.Log("Letra no encontrada");
        }
        else
        {
            Debug.Log("Letra encontrada en la posición " + counter);
        }
    }

    void EscribirPalabraInvertidaLetraPorLetra(string palabra)
    {
        for (int i =palabra.Length - 1;i>=0;i--)
        {
            Debug.Log(palabra[i]);
        }
    }
}
