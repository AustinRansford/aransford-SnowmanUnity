using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WordGuesser;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Button StartButton;
    public GameObject StartScreen;
    public GameObject PlayScreen;
    private WordGuesser.WordGame GuessingGame;
    public UnityEngine.UI.InputField PlayerGuess;
    public GameObject GameOverScreen;
    public GameObject GameWonScreen;
    public void StartGame() 
    {
        this.GuessingGame = new WordGuesser.WordGame("apple", 5);
        Debug.Log(this.GuessingGame.GetWord());
        Debug.Log(this.GuessingGame.GetFullWord());

        this.StartScreen.SetActive(false);
        this.PlayScreen.SetActive(true);
        this.GameOverScreen.SetActive(false);

    }
    public void OpenStartScreen()
    {
        this.StartScreen.SetActive(true);
        this.PlayScreen.SetActive(false);
        this.GameOverScreen.SetActive(false);
    }
    public void SubmitGuess()
    {
        Debug.Log(this.GuessingGame.CheckGuess(PlayerGuess.text));
        PlayerGuess.text = string.Empty;
    }
    public void IsGameOver()
    {
        this.GameOverScreen.SetActive(true);
        this.PlayScreen.SetActive(false);
        this.StartScreen.SetActive(false);
    }
    public void IsGameWon()
    {
      this.GameWonScreen.SetActive(true);
        this.PlayScreen.SetActive(false);
        this.StartScreen.SetActive(false);
        this.GameOverScreen.SetActive(false);
    }
}
