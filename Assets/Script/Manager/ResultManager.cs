using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour
{
    #region SingletoneMake
    public static ResultManager instance = null;
    public static ResultManager GetInstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("@ResultManager");
            instance = go.AddComponent<ResultManager>();

            DontDestroyOnLoad(go);
        }
        return instance;
    }
    #endregion
    public int totalScore = 0;
    public int CorrectCount = 0;
    public int quizcount = 0;


    public List<int> scores = new List<int>();


    public void AddScores(int anyscore)
    {
        scores.Add(anyscore);
        totalScore += anyscore;
    }


    #region EvaluationSystem;
    public int GetAverage()
    {
        int totalscore = 0;
        int average;
        for (int i = 0; i < scores.Count; i++)
        {
            totalscore += scores[i];
        }
        average = totalscore / quizcount;
        return average;
    }

    public string Grade()
    {
        int average = GetAverage();
        string grade;
        if (average >= 80)
        {
            grade = "당신.. 알고보니 싸이코패스?";
        }
        else if (average >= 60 && average < 80)
        {
            grade = "싸이코패스 위험군";
        }
        else if (average >= 40 && average < 60)
        {
            grade = "약간 괴짜인 당신. 조심";
        }
        else
        {
            grade = "0%";
        }
        return grade;
    }
    #endregion
}
