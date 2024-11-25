using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalesPrefab;

    private float rangoXDeTapiz = 25f;
    private float rangoZDeTapiz = 33f;
    private float delay = 2f;
    private float intervalo = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnDeEnemigos",delay,intervalo);
        
    }

    private void SpawnDeEnemigos() {
        int indexAnimales = Random.Range(0, animalesPrefab.Length);
        Vector3 posicionSpawn = new Vector3(Random.Range(-rangoXDeTapiz,rangoXDeTapiz),0, rangoZDeTapiz);
        Instantiate(animalesPrefab[indexAnimales], posicionSpawn, animalesPrefab[indexAnimales].transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        

    }
}
