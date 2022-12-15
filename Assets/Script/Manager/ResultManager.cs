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
                grade = "당신.. 알고보니 싸이코패스?";
            }
            else if (totalScore >= 80 && totalScore < 100)
            {
                grade = "당신의 마음 속에 무서운 녀석이 살고 있어요!";
            }
            else if (totalScore >= 60 && totalScore < 80)
            {
                grade = "싸이코패스를 의심할 단계는 아닙니다.";
            }
            else
            {
                grade = "싸이코패스 지수 제로! 당신은 청렴결백 순진무구";
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
                answer = "당신은 싸이코패스에 가까운 심리 상태를 가지고 있습니다. 이런 경우는 매우 드뭅니다.";

            }
            else if (totalScore >= 80 && totalScore < 100)
            {
                answer = "당신은 꽤 높은 수준의 싸이코패스 성향을 가지고 있습니다.";
            }
            else if (totalScore >= 60 && totalScore < 80)
            {
                answer = "약간 괴짜인 당신. 주변 친구들이 자신을 어떻게 생각하나요?";
            }
            else
            {
                answer = "당신은 완전무결한 마음 따뜻한 사람입니다. 당신은 타인의 감정에 대한 공감 능력이 매우 뛰어나고, 다른 사람의 고통이나 곤란한 상황을 보고 절대 지나치지 못하는 이타심 또한 가득합니다. 당신은 오히려 마음이 매우 따뜻한 사람이군요.";
            }
            return answer;
        }
        else
        {
            if (totalScore >= 80)
            {
                answer = "당신.. 소시오패스? 조금 무서운데요..";
            }
            else if (totalScore >= 60 && totalScore < 80)
            {
                answer = "사람들이 당신을 이해해주지 못하나요?";
            }
            else if (totalScore >= 20 && totalScore < 60)
            {
                answer = "종종 눈치없는 사람으로 보이기도 합니다.";
            }
            else
            {
                answer = "순수한 편입니다.";
            }
            return answer;
        }
      
    }

    #endregion
}
