using UnityEngine;
using System.Collections.Generic;
using System;

public class mizan : MonoBehaviour
{
    public Vector3 position;
    public DynamicTextData data;
    private string text;

    private GameObject[] inside = new GameObject[30];
    private int i = 0;
    private Int32 somme = 0;
    void FixedUpdate()
    {
            somme = sommeInside();
            text = somme.ToString(); 
            DynamicTextManager.CreateText(position, text, data);
       
    }
    private void OnTriggerEnter(Collider other)
    {
        inside[i] = other.gameObject;
        i++;
    }

    private void OnTriggerExit(Collider other)
    {
        // remove one time the object called other.gameObject.name
        for (int j = 0; j < i; j++)
        {
            if (inside[j].name == other.gameObject.name)
            {
                inside[j] = null;
                break;
            }
        }
        // decalage des elements non nul le plus gauche possible
        for (int j = 0; j < i; j++)
        {
            if (inside[j] == null)
            {
                for (int k = j; k < i; k++)
                {
                    inside[k] = inside[k + 1];
                }
            }
        }
        i--;
        
    }
    private int sommeInside()
    {
        int somme = 0;
        for (int j = 0; j < i; j++)
        {
            somme += Int32.Parse(inside[j].name);
        }
        return somme;
    }
}
