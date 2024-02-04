using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswersScript : MonoBehaviour
{
    [SerializeField]
    public bool isCorrect = false;

    public QuizManager quizManager;
    public Color startColor;
    public AudioSource audioSourceCorrect;
    public AudioSource audioSourceIncorrect;

    public void Start()
    {
        startColor = GetComponent<Image>().color;
    }

    public void Answer()
    {
        if (isCorrect)
        {
            GetComponent<Image>().color = Color.green;
            Debug.Log("Correct Answer");
            quizManager.correct();
            audioSourceCorrect.Play(); // Reproduce el sonido correcto
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            Debug.Log("Wrong Answer");
            quizManager.wrong();
            audioSourceIncorrect.Play(); // Reproduce el sonido incorrecto
        }
    }
}

