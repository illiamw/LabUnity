using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject[] PanelInformation;

    
    public float velocity = 100.0f;


    void Start()
    {
        
    }

    void Update()
    {
        Movements();

       

    }

    private void OnTriggerEnter(Collider other)
    {
        Information(other);
    }

    void Movements(){
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(x, 0, y) * velocity;

        transform.Translate(dir * Time.deltaTime);
    }


    void Information(Collider other){
        Debug.Log("Entrou");
        PanelInformation[0].SetActive(true);
        velocity = 0;
        
    }
}


