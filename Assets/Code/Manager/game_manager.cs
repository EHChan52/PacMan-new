using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class game_manager : MonoBehaviour{
    public readonly int UP=0,DOWN=3,LEFT=1,RIGHT=2;
    public int row,column;
    public int frameRate;


    private int lives=3,scores=0;
    private int energizer_number,energizer_number_least;
    private int pellet_number,pellet_eaten,pellet_score=5,ghost_score=100;
    
    void Awake(){
        frameRate=25;
        Application.targetFrameRate=frameRate;
    }
    void Start(){
    pellet_eaten=scores=0;
    }
    void Update(){
    
    }

}
