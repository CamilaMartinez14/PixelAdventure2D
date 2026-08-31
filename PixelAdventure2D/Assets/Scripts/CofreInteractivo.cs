using UnityEngine;

public class CofreInteractivo : MonoBehaviour
{
    // Sprite que mostrara el cofre cuando se abra
    public Sprite cofreAbierto;

    // Planta que aparecera cuando Cami abra el cofre
    public GameObject plantaFuerza;

    // Me sirve para saber si Cami esta cerca del cofre
    private bool camiCerca = false;

    // Evita que el cofre se abra varias veces
    private bool estaAbierto = false;

    // Guardo el SpriteRenderer del cofre
    private SpriteRenderer imagenCofre;

    void Start()
    {
        imagenCofre = GetComponent<SpriteRenderer>();

        // La planta comienza escondida
        plantaFuerza.SetActive(false);
    }

    void Update()
    {
        // Si Cami esta cerca puede abrir el cofre presionando E
        if (camiCerca && Input.GetKeyDown(KeyCode.E) && !estaAbierto)
        {
            imagenCofre.sprite = cofreAbierto;
            estaAbierto = true;

            // Muestro la planta cuando se abre el cofre
            plantaFuerza.SetActive(true);

            Debug.Log("Cami encontro una planta de fuerza en el cofre");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Detecta cuando Cami se acerca al cofre
        if (collision.gameObject.name == "camila_parada1")
        {
            camiCerca = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        // Detecta cuando Cami se aleja del cofre
        if (collision.gameObject.name == "camila_parada1")
        {
            camiCerca = false;
        }
    }
}