using UnityEngine;

public class TrampaPeligrosa : MonoBehaviour
{
    // Punto donde Cami volvera cuando toque la trampa
    public Transform puntoInicio;

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Reviso si el objeto que toco la trampa es Cami
        if (collision.gameObject.name == "camila_parada1")
        {
            // Devuelvo a Cami al punto de inicio
            collision.transform.position = puntoInicio.position;

            // Detengo el movimiento para que no siga avanzando al volver
            Rigidbody2D cuerpo = collision.GetComponent<Rigidbody2D>();

            if (cuerpo != null)
            {
                cuerpo.linearVelocity = Vector2.zero;
            }

            Debug.Log("Cami toco la trampa y volvio al inicio");
        }
    }
}