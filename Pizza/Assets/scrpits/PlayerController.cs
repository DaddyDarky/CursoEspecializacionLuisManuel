using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject pizza ;
    public float velocidad = 10f;
    public float limiteEjeX = 25f;
    //public float limiteIzquierdo = -25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");

        // Calculamos el movimiento en base a la velocidad y la entrada
        Vector3 movement = Time.deltaTime * velocidad * new Vector3(moveInput, 0f, 0f);

        // Movemos al jugador
        transform.position += movement;

        // Limitamos la posición del jugador entre minX y maxX
        float clampedX = Mathf.Clamp(transform.position.x, -limiteEjeX, limiteEjeX);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);

        // Verificar si se ha pulsado la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instanciar el prefab de la pizza en la posición del jugador y con la rotación del prefab
            Instantiate(pizza, transform.position, pizza.transform.rotation);
        }
    }
}

