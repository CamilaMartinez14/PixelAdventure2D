using UnityEngine;

public class MovimientoDeCami : MonoBehaviour
{
    // Velocidad que tendra Cami al caminar
    public float velocidad = 5f;

    // Fuerza que tendra el salto
    public float fuerzaSalto = 7f;

    // Guardo el Rigidbody para poder mover al personaje
    private Rigidbody2D cuerpo;

    // Guardo el Animator para cambiar las animaciones
    private Animator animador;

    // Me indica si Cami esta tocando el suelo
    private bool estaEnSuelo = false;

    void Start()
    {
        // Busco el Rigidbody que le agregue a Cami en Unity
        cuerpo = GetComponent<Rigidbody2D>();

        // Busco el Animator que tiene Cami
        animador = GetComponent<Animator>();
    }

    void Update()
    {
        // Detecta cuando uso A, D o las flechas
        float movimiento = Input.GetAxisRaw("Horizontal");

        // Reviso si Cami esta agachada con S o flecha abajo
        bool agachada = Input.GetKey(KeyCode.S) ||
                        Input.GetKey(KeyCode.DownArrow);

        // Reviso si estoy apretando Shift mientras Cami se mueve
        bool corriendo = Input.GetKey(KeyCode.LeftShift) &&
                         movimiento != 0 &&
                         !agachada;

        // Si Cami corre aumenta un poco su velocidad
        float velocidadActual = corriendo ? velocidad * 1.5f : velocidad;

        // Si Cami esta agachada no puede avanzar
        if (agachada)
        {
            movimiento = 0;
        }

        // Muevo a Cami hacia los lados y mantengo la caida por gravedad
        cuerpo.linearVelocity = new Vector2(
            movimiento * velocidadActual,
            cuerpo.linearVelocity.y
        );

        // Activo caminar cuando Cami se mueve sin correr
        animador.SetBool(
            "EstaCaminando",
            movimiento != 0 && !corriendo
        );

        // Activo correr cuando uso Shift mientras Cami se mueve
        animador.SetBool("EstaCorriendo", corriendo);

        // Activo la animacion cuando Cami se agacha
        animador.SetBool("EstaAgachada", agachada);

        // Cami puede saltar solo cuando esta tocando el suelo
        // y no esta agachada
        if (Input.GetKeyDown(KeyCode.Space) &&
            estaEnSuelo &&
            !agachada)
        {
            cuerpo.linearVelocity = new Vector2(
                cuerpo.linearVelocity.x,
                fuerzaSalto
            );

            // Activo la animacion de salto
            animador.SetBool("EstaSaltando", true);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Si Cami toca el objeto que tiene la etiqueta Suelo puede saltar
        if (collision.gameObject.CompareTag("Suelo"))
        {
            estaEnSuelo = true;

            // Cuando vuelve al suelo termina la animacion de salto
            animador.SetBool("EstaSaltando", false);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        // Si Cami deja de tocar el suelo significa que esta en el aire
        if (collision.gameObject.CompareTag("Suelo"))
        {
            estaEnSuelo = false;
        }
    }
}