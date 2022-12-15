using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

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

    public void AddScores(int anyscore)
    {
        
        totalScore += anyscore;
    }


    #region EvaluationSystem;

    public string Grade()
    {
        string grade = "";
        if (TestManager.instance.quiztype == 0)
        {

            if (totalScore >= 100)
            {
                grade = "���.. �˰��� �������н�?";
            }
            else if (totalScore >= 80 && totalScore < 100)
            {
                grade = "����� ���� �ӿ� ������ �༮�� ��� �־��!";
            }
            else if (totalScore >= 60 && totalScore < 80)
            {
                grade = "�������н��� �ǽ��� �ܰ�� �ƴմϴ�.";
            }
            else
            {
                grade = "�������н� ���� ����! ����� û�Ű�� ��������";
            }
            return grade;
        }
       
        return grade;
    }
    public string Answer()
    {

        string answer;

        if (TestManager.instance.quiztype == 0)
        {
            
            if (totalScore >= 100)
            {
                answer = "����� �������н��� ����� �ɸ� ���¸� ������ �ֽ��ϴ�. �̷� ���� �ſ� �年�ϴ�.";

            }
            else if (totalScore >= 80 && totalScore < 100)
            {
                answer = "����� �� ���� ������ �������н� ������ ������ �ֽ��ϴ�.";
            }
            else if (totalScore >= 60 && totalScore < 80)
            {
                answer = "�ణ ��¥�� ���. �ֺ� ģ������ �ڽ��� ��� �����ϳ���?";
            }
            else
            {
                answer = "����� ���������� ���� ������ ����Դϴ�. ����� Ÿ���� ������ ���� ���� �ɷ��� �ſ� �پ��, �ٸ� ����� �����̳� ����� ��Ȳ�� ���� ���� ����ġ�� ���ϴ� ��Ÿ�� ���� �����մϴ�. ����� ������ ������ �ſ� ������ ����̱���.";
            }
            return answer;
        }
        else
        {
            if (totalScore >= 80)
            {
                answer = "���.. �ҽÿ��н�? ���� �������..";
            }
            else if (totalScore >= 60 && totalScore < 80)
            {
                answer = "������� ����� ���������� ���ϳ���?";
            }
            else if (totalScore >= 20 && totalScore < 60)
            {
                answer = "���� ��ġ���� ������� ���̱⵵ �մϴ�.";
            }
            else
            {
                answer = "������ ���Դϴ�.";
            }
            return answer;
        }
      
    }

    #endregion
}
