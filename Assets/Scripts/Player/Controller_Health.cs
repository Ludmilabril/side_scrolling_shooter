using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller_Health : MonoBehaviour
{
    public int vida;
    public Slider barraVida;

    private void Update()
    {
        UpdateHealthBar();
    }
    public void UpdateHealthBar()
    {
        barraVida.value = vida;
    }

}
