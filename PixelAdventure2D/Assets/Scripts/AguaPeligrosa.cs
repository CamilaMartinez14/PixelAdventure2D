using UnityEngine;

public class AguaPeligrosa : MonoBehaviour
{
    // Punto donde Cami volvera si cae al agua
    public Transform inicioPuente;

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Reviso si Cami fue la que toco el agua
        if (collision.gameObject.name == "camila_parada1")
        {
            // La devuelvo al inicio del puente
            collision.transform.position = inicioPuente.position;

            // Detengo su movimiento cuando vuelve
            Rigidbody2D cuerpo = collision.GetComponent<Rigidbody2D>();

            if (cuerpo != null)
            {
                cuerpo.linearVelocity = Vector2.zero;
            }

            Debug.Log("Cami cayo al agua y volvio al inicio del puente");
        }
    }
}