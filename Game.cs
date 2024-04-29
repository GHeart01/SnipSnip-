using UnityEngine;
using System.Collections;
 
public class Game : MonoBehaviour {
 
    public enum GameState {Stopped, Playing};
    public static GameState myGameState = GameState.Stopped;
 
    // Use this for initialization
    void Start () {
        myGameState = GameState.Stopped;
   
    }
   
    // Update is called once per frame
    void Update () {
 
        switch (myGameState) {
        case GameState.Stopped:
            Time.timeScale = 0;
            break;
        case GameState.Playing:
            Time.timeScale = 1;
            break;
        }
 
   
    }
}
 