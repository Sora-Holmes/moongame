using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControlDelJuego : MonoBehaviour {

    [Range(0f, 0.20f)]
    public float velocidadMovimiento = 0.02f;
    public RawImage fondo;
    public RawImage plataforma;
    public GameObject UiIdle;

    public enum EstadoDeJuego {Idle, Playing};
    public EstadoDeJuego estadoDeJuego = EstadoDeJuego.Idle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Run game
        if(estadoDeJuego == EstadoDeJuego.Idle && (Input.GetKeyDown("up") || Input.GetMouseButtonDown(0))){
            estadoDeJuego = EstadoDeJuego.Playing;
            UiIdle.SetActive(false);
        }
        else if(estadoDeJuego == EstadoDeJuego.Playing){
            MovimientoEscena();
        }
    }

    void MovimientoEscena(){
        float velocidadFinal = velocidadMovimiento * Time.deltaTime;
        fondo.uvRect = new Rect(fondo.uvRect.x + velocidadFinal, 0f, 1f, 1f);
        plataforma.uvRect = new Rect(plataforma.uvRect.x + velocidadFinal * 4, 0f, 1f, 1f);
    }
}
