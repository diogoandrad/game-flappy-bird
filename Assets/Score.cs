using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameController controller;
    public Bird passaro;
    // Start is called before the first frame update
    void Start()
    {
       controller = FindObjectOfType<GameController>();
       passaro = FindObjectOfType<Bird>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D coll){
        passaro.som_score.Play();
        controller.Score++;
        controller.scoreText.text = controller.Score.ToString();
    }
}
