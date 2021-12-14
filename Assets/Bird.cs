using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rig;
    public GameObject gameover;
    public GameObject pontuacao;
    public GameObject musica;
    public AudioSource som_impacto;
    public AudioSource som_score;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            rig.velocity = Vector2.up *speed;
        }

        if(Input.GetMouseButtonDown(1)){
            rig.velocity = Vector2.right * speed;
        }
    }
    void OnCollisionEnter2D (Collision2D coll){
        som_impacto.Play();
        musica.SetActive(false);
        pontuacao.SetActive(false);
        gameover.SetActive(true); //torna o GO ativo
        Time.timeScale = 0; //paralisa o jogo
    }
}
