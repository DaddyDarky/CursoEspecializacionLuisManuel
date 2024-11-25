using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    
    public float velocidadObjeto = 10f;
    public float maxZ = 35f;
    public float minZ = -15f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Mover el objeto hacia adelante en el eje X a la velocidad definida
        transform.Translate(Vector3.forward * velocidadObjeto * Time.deltaTime);

        // Verificar si la pizza ha alcanzado la distancia máxima
        if (transform.position.z >= maxZ || transform.position.z <= minZ)
        {
            // Destruir la pizza cuando alcance la distancia máxima
            Destroy(gameObject);
        }

    }
}
