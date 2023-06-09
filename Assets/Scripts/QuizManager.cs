using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
   public List<QuestionAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;
    public Text QuestionTxt;
    public GameObject QuizPanel;
    public GameObject FEEDBACK;

    public Text ScoreTxt;
    int totalQuestions= 0;
    public int score;

    // Start is called before the first frame update
    private void Start()
    {
        totalQuestions=QnA.Count;
        FEEDBACK.SetActive(false);
        generateQuestion();
    }

    public void retry(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        

    }

    public void GameOver(){
        QuizPanel.SetActive(false);
        FEEDBACK.SetActive(true);
        ScoreTxt.text=score +"/"+ totalQuestions;


    }

    public void correct (){
        score +=1;

        QnA.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
    }

    public void wrong(){
        QnA.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
    }

    IEnumerator waitForNext(){
        yield return new WaitForSeconds(1);
        generateQuestion();
    }
    
    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswersScript>().isCorrect=false;
            options[i].transform.GetChild(0).GetComponent<Text>().text= QnA[currentQuestion].Answers[i];
            options[i].GetComponent<Image>().color = options[i].GetComponent<AnswersScript>().startColor;

            if(QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<AnswersScript>().isCorrect=true;
            }
        }
    }

    
    void generateQuestion()
    {
        if(QnA.Count>0)
        {
     currentQuestion = Random.Range(0, QnA.Count);   
    QuestionTxt.text=QnA[currentQuestion].Question;
    SetAnswers();
        }
        else{
            Debug.Log("Out of Quesstions");
            GameOver();
        }
    
    }
}
