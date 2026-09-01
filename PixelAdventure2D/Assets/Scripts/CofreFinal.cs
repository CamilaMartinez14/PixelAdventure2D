using UnityEngine;

public class CofreFinal : MonoBehaviour
{
    public Sprite cofreAbierto;
    public GameObject mensajeTesoro;

    private bool camiCerca = false;
    private bool cofreAbiertoYa = false;

    void Start()
    {
        // Al comenzar el juego escondo el mensaje
        mensajeTesoro.SetActive(false);
    }

    void Update()
    {
        // Si Cami esta cerca puede abrir el cofre con E
        if (camiCerca && Input.GetKeyDown(KeyCode.E) && !cofreAbiertoYa)
        {
            GetComponent<SpriteRenderer>().sprite = cofreAbierto;

            cofreAbiertoYa = true;

            // Muestro el mensaje cuando encuentra el tesoro
            mensajeTesoro.SetActive(true);

            Debug.Log("Cami encontro el tesoro de la selva");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Reviso si Cami se acerco al cofre
        if (collision.gameObject.name == "camila_parada1")
        {
            camiCerca = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        // Reviso si Cami se alejo del cofre
        if (collision.gameObject.name == "camila_parada1")
        {
            camiCerca = false;
        }
    }
}