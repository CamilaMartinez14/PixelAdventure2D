using UnityEngine;

public class CamaraSigueACami : MonoBehaviour
{
    // Guardo a Cami para que la camara pueda seguirla
    public Transform cami;

    // Distancia que mantendra la camara
    private Vector3 distancia;

    void Start()
    {
        // Guardo la distancia inicial entre la camara y Cami
        distancia = transform.position - cami.position;
    }

    void LateUpdate()
    {
        // La camara sigue a Cami manteniendo la misma distancia
        transform.position = cami.position + distancia;
    }
}