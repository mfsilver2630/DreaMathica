using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MathQuestion 
{
    public float firstNumber;
    public float secondNumber;
    public MathsOperation operation;
    public float[] answer;

    [Range(0, 3)]
    public int correctAnswer;

    // Start is called before the first frame update

    public enum MathsOperation
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }
   public void AnswerCorrect()
    {
        inputField.GetComponent<Text>().text = Answer.ToString();
        textDisplay.GetComponent<Text>().text = "Correct Answer " + Answer;
    }
}
