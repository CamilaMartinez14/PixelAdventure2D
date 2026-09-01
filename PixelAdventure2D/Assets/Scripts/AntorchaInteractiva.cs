using UnityEngine;

public class AntorchaInteractiva : MonoBehaviour
{
    // Sprite de la antorcha cuando esta prendida
    public Sprite antorchaPrendida;

    private bool camiCerca = false;
    private bool estaPrendida = false;

    private SpriteRenderer imagenAntorcha;

    void Start()
    {
        // Busco la imagen de la antorcha
        imagenAntorcha = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Si Cami esta cerca puede prender la antorcha con E
        if (camiCerca && Input.GetKeyDown(KeyCode.E) && !estaPrendida)
        {
            imagenAntorcha.sprite = antorchaPrendida;
            estaPrendida = true;

            Debug.Log("Cami prendio la antorcha");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Reviso si Cami se acerco
        if (collision.gameObject.name == "camila_parada1")
        {
            camiCerca = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        // Reviso si Cami se alejo
        if (collision.gameObject.name == "camila_parada1")
        {
            camiCerca = false;
        }
    }
}