using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Rotation : MonoBehaviour
{ public float rotationSpeed = 1.0f; // Factor de escala para controlar la velocidad de rotación

    void Update()
    {
        // Genera un ángulo aleatorio en el rango [-360f, 360f] para cada eje
        float randomAngleX = Random.Range(-360f, 360f) * rotationSpeed;
        float randomAngleY = Random.Range(-360f, 360f) * rotationSpeed;
        float randomAngleZ = Random.Range(-360f, 360f) * rotationSpeed;

        // Aplica la rotación aleatoria al transform
        transform.Rotate(new Vector3(randomAngleX, randomAngleY, randomAngleZ) * Time.deltaTime);
    }
}
