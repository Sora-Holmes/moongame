using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstaTocandoSuelo : MonoBehaviour {
    private JugadorController jugador;

	// Use this for initialization
	void Start () {
        jugador = GetComponentInParent<JugadorController>();
	}


    private void OnCollisionStay2D(Collision2D collision)
    {
        jugador.grounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        jugador.grounded = false;
    }
}
