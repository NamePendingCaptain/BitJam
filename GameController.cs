using UnityEngine;
using System.Collections;


public class GameController : MonoBehaviour {

    public GUIText scoreText;
    private int score;
	
	void Start () {
        //Resets the score to 0 at beginning of game.
        score = 0;
        UpdateScore();

	}
	
	
	void Update () {
		
	}
    //Updates the score that is displayed onto the screen.
    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
    //This will add the score for shooting enemy.
    public void AddScore(int newScore)
    {
        score += newScore;
        UpdateScore();
    }



}
