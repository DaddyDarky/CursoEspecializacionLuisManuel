using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearEscalera : MonoBehaviour
{
    public GameObject cubo;
    public int width, heigth, large;

    public void generalMapa() {

        for (int x =0; x< width; x++) {
            for (int y =0;y<heigth; y++) {
                for (int z= 0;z<large; z++) {
                    Instantiate(cubo,new Vector3(x,y,z),Quaternion.identity);
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        generalMapa();   
    }

    // Update is called once per frame
    void Update()
    {

        

    }

   


}
