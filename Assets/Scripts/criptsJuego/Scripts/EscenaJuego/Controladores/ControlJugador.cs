using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : ControladorBasico {

    Animator animator;
	public GameObject derecha;
	public GameObject izquierda;
	public GameObject medio;
	Vector3 myVector;
	public float speed;

	

	void Start () {
        base.Start();
        animator = GetComponent<Animator>();
		myVector = medio.transform.position;
    }
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.RightArrow) & (gameObject.transform.position.x == 108.45f))
		{
			myVector = new Vector3(derecha.transform.position.x, 14.28f, -64.2f);
			
			Debug.Log ("MaD");
		}

		if (Input.GetKeyDown(KeyCode.LeftArrow) & (gameObject.transform.position.x == 108.45f))
		{
			myVector = new Vector3(izquierda.transform.position.x, 14.28f, -64.2f);
			Debug.Log("MaI");
		}

		if (Input.GetKeyDown(KeyCode.LeftArrow) & (gameObject.transform.position.x == 116.97f))
		{
			myVector = new Vector3(medio.transform.position.x, 14.28f, -64.2f);
			Debug.Log("DaM");
		}

		if (Input.GetKeyDown(KeyCode.RightArrow) & (gameObject.transform.position.x == 98.69f))
		{
			myVector = new Vector3(medio.transform.position.x, 14.28f, -64.2f);
			Debug.Log("IaM");
		}

		transform.position = Vector3.MoveTowards(transform.position, myVector, speed);

		if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool(Utils.ANIMATION_SALTANDO,true);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetBool(Utils.ANIMATION_AGACHADO, true);
        }
		if (Input.GetKeyDown(KeyCode.D))
		{
			animator.SetBool(Utils.ANIMATION_DABADO, true);
		}
	}

    void finalizarAnimacion()
    {
        animator.SetBool(Utils.ANIMATION_SALTANDO, false);
    }

    void finalizarRodado	()
    {
        animator.SetBool(Utils.ANIMATION_AGACHADO, false);
    }
	void finalizarDabado()
	{
		animator.SetBool(Utils.ANIMATION_DABADO, false);
	}


	public override void juegoEnPausa()
    {
        Time.timeScale = 0f;
    }

    public override void juegoRestaurado()
    {
        Time.timeScale = 1f;
    }
}
