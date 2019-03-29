using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaInimigo : MonoBehaviour
{
    public GameObject Jogador;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        //Vector3 de
        GetComponent<Rigidbody>().MovePosition
            (GetComponent<Rigidbody>().position +
            Jogador.transform.position);
    }
}
