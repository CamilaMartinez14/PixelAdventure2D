using UnityEngine;

public class PiedraMovible : MonoBehaviour
{
    private bool camiCerca = false;
    private bool piedraMovida = false;

    public float distanciaMovimiento = 5f;

    void Update()
    {
        // Si Cami esta cerca puede intentar mover la piedra con E
        if (camiCerca && Input.GetKeyDown(KeyCode.E) && !piedraMovida)
        {
            // Reviso si Cami ya obtuvo la fuerza de la planta
            if (PlantaDeFuerza.tieneFuerza)
            {
                // La piedra se mueve hacia la izquierda
                transform.position = transform.position + Vector3.left * distanciaMovimiento;

                piedraMovida = true;

                Debug.Log("Cami movio la piedra y libero el camino");
            }
            else
            {
                Debug.Log("Cami necesita la fuerza de la planta");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Detecto cuando Cami se acerca
        if (collision.gameObject.name == "camila_parada1")
        {
            camiCerca = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        // Detecto cuando Cami se aleja
        if (collision.gameObject.name == "camila_parada1")
        {
            camiCerca = false;
        }
    }
}