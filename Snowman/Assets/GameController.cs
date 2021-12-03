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
public UnityEngine.UI.Text Fullword;
    public UnityEngine.UI.Text remaining2;
    public UnityEngine.UI.Text getWordtext;
    public UnityEngine.UI.Text hiddenWord;
    public UnityEngine.UI.Text getGuessedLetterstext;
    public UnityEngine.UI.Text checkGuess;
     


    public void StartGame() 
    {
        this.GuessingGame = new WordGuesser.WordGame("apple", 4);
        Debug.Log(this.GuessingGame.GetWord());
        Debug.Log(this.GuessingGame.GetFullWord());
               hiddenWord.text = this.GuessingGame.CheckGuess(PlayerGuess.text);

        PlayerGuess.text = string.Empty;
        getWordtext.text = this.GuessingGame.GetWord();
        int remaining = this.GuessingGame.GetGuessLimit() - this.GuessingGame.GetIncorrectGuesses();
        remaining2.text = $"Remaining Guesses: {remaining}"; 

        getGuessedLetterstext.text = $"Guessed Letters: {this.GuessingGame.GetGuessedLetters()}";

        this.StartScreen.SetActive(false);
        this.PlayScreen.SetActive(true);
        this.GameOverScreen.SetActive(false);
         this.GameWonScreen.SetActive(false);

    }
    public void IsGameOver1()
    {
       Fullword.text = $"The Word You Tried To Guess Was: {this.GuessingGame.GetFullWord()}";
       this.GameWonScreen.SetActive(false);
        this.GameOverScreen.SetActive(true);
        this.PlayScreen.SetActive(false);
        this.StartScreen.SetActive(false);
    }
    public void IsGameWon1()
    {
      this.GameWonScreen.SetActive(true);
        this.PlayScreen.SetActive(false);
        this.StartScreen.SetActive(false);
        this.GameOverScreen.SetActive(false);
    }
    public void SubmitGuess()
    {
        // Debug.Log(this.GuessingGame.CheckGuess(PlayerGuess.text));
                hiddenWord.text = this.GuessingGame.CheckGuess(PlayerGuess.text);

        PlayerGuess.text = string.Empty;
        getWordtext.text = this.GuessingGame.GetWord();
        int remaining = this.GuessingGame.GetGuessLimit() - this.GuessingGame.GetIncorrectGuesses();
        remaining2.text = $"Remaining Guesses: {remaining}"; 

         getGuessedLetterstext.text = $"Guessed Letters: {this.GuessingGame.GetGuessedLetters()}";
        if (this.GuessingGame.IsGameWon())
        {
            this.IsGameWon1();
        }
        else if(this.GuessingGame.IsGameOver())
        {
            this.IsGameOver1();
        }
       

    }
}
