using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorController : MonoBehaviour {
    public float velocidadMaxima = 5f; // Establecemos velocidad Maxima
    public float Velocidad = 20f;
    public bool grounded;

    private Rigidbody2D rigi;
    private Animator animator;
    // Use this for initialization
    void Start () {
        rigi = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        animator.SetFloat("speed", Mathf.Abs(rigi.velocity.x)); //Valor absoluto sin signo
        animator.SetBool("Grounded", grounded);
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        rigi.AddForce(Vector2.right * Velocidad * h);
        float velocidadLimitada = Mathf.Clamp(rigi.velocity.x, -velocidadMaxima, velocidadMaxima);
        rigi.velocity = new Vector2(velocidadLimitada, rigi.velocity.y); // Se establece nueva velocidad
        Debug.Log(rigi.velocity);
    }
}
