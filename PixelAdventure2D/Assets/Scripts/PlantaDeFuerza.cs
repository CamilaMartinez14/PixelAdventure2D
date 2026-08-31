using UnityEngine;
using TMPro;

public class PlantaDeFuerza : MonoBehaviour
{
    // Me indica si Cami esta cerca de la planta
    private bool camiCerca = false;

    // Guarda si Cami ya obtuvo la fuerza
    public static bool tieneFuerza = false;

    // Texto que aparecera cuando Cami obtenga la fuerza
    public TextMeshProUGUI mensajeFuerza;

    void Start()
    {
        // El mensaje comienza escondido
        mensajeFuerza.gameObject.SetActive(false);
    }

    void Update()
    {
        // Cami consume la planta presionando E
        if (camiCerca && Input.GetKeyDown(KeyCode.E))
        {
            tieneFuerza = true;

            Debug.Log("Cami comio la planta y ahora tiene mas fuerza");

            // Muestro el mensaje
            mensajeFuerza.gameObject.SetActive(true);

            // Lo escondo despues de 3 segundos
            Invoke("OcultarMensaje", 3f);

            // La planta desaparece porque Cami ya la recogio
            gameObject.SetActive(false);
        }
    }

    void OcultarMensaje()
    {
        mensajeFuerza.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Detecta cuando Cami se acerca a la planta
        if (collision.gameObject.name == "camila_parada1")
        {
            camiCerca = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        // Detecta cuando Cami se aleja de la planta
        if (collision.gameObject.name == "camila_parada1")
        {
            camiCerca = false;
        }
    }
}