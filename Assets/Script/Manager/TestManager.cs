using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Quiz
{
    Psyco = 0,
    Socio = 1
}
public class TestManager : MonoBehaviour
{
    #region SingletoneMake
    public static TestManager instance = null;
    public static TestManager GetInstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("@TestManager");
            instance = go.AddComponent<TestManager>();

            DontDestroyOnLoad(go);
        }
        return instance;
    }
    #endregion

    #region QuizListInitiate
    public Quiz quiztype;
    public Dictionary<Quiz, QuizGen[]> quizList = new Dictionary<Quiz, QuizGen[]>();

    public void InitQuiz()
    {
        quizList.Add(Quiz.Psyco, new QuizGen[]
        {
            new QuizGen(" 문제1 ","당신은 자주 거울을 봅니다. 그러나 거울을 볼 때마다 만족스럽지가 않네요. 그 이유는 무엇일까요?",
            new string[]{"자신의 외모가 마음에 들지 않아서","얼굴에 상처가 있어서", "살이 쪄서", "거울이 더러워서", "거울 속 내 뒤에 다른 사람이 보여서" }, 20, 3),

            new QuizGen(" 문제2 ","아무도 없는 살지 않는 저택에 전쟁 중 부상을 입은 군인의 초상화가 걸려있습니다. 이 군인이 다친 곳은 어느 곳일까요?",
            new string[]{ "머리", "다리", "눈", "허리", "팔"},20,2),

            new QuizGen(" 문제3 ", "어두운 숲 속에서 당신의 바로 앞에 정자가 있습니다. 우두커니 정자를 바라보고 있는데 갑자기 뒤에 무언가가 스윽 지나갑니다. 지나간 것은 무엇일까요?",
            new string[]{ "들짐승", "낙엽","이성", "개", "귀신"},20,3),

            new QuizGen(" 문제4 ","당신은 목이 말라 자판기를 찾았습니다. 신기하게도 자판기 안 음료수에는 어떤 상표도 없습니다. 당신이 뽑은 음료수(액체)의 색은 무엇일까요?",
            new string[]{ "파랗다", "노랗다","빨갛다","투명하다", "보라색" },20,2),

            new QuizGen(" 문제5 ","어두운 방 안에 당신은 홀로 있고 밖에서 살인마가 칼을 든 채 당신을 찾고 있습니다. 방어할 것이 아무 것도 없기에 숨기로 하였습니다. 어디에 숨을 건가요?",
            new string[]{ "문 뒤", "침대 밑", "창문 밖", "장롱 안", "화장실"},20,0),

            new QuizGen(" 문제6 ","당신은 10년 동안 증오한 사람을 마침내 죽이기로 결심하였습니다. 칼을 사러 간 당신 앞에는 오천원짜리와 오만원짜리가 놓여 있었습니다. 당신은 망설임없이 오천원짜리 칼을 골랐습니다. 그 이유는?",
            new string[]{ "굳이 비싼 돈을 쓰기 싫어서", "더 고통스럽게 죽일 수 있어서", "오천원짜리가 더 날카로워 보여서", "수중에 돈이 모자라서", "칼이 눈에 잘 안띄는 크기여서"},20,1),

        });

        quizList.Add(Quiz.Socio, new QuizGen[]
        {
            new QuizGen("문제1","타인에게 자신의 매력을 보여주는 데 관심이 없나요?",
            new string[]{"예", "아니오" },10,0),

            new QuizGen("문제2","당신은 자아가 약한 편인가요?",
             new string[]{"예", "아니오" },10,0),

            new QuizGen("문제3","당신은 비밀이 적나요?",
            new string[]{"예", "아니오" },10,0),

            new QuizGen("문제4","당신은 맞고 그름의 차이를 알고 있습니까?",
             new string[]{"예", "아니오" },10,1),

            new QuizGen("문제5","당신의 인간관계는 길게 지속되는 편인가요?",
            new string[]{"예", "아니오" },10,1),

            new QuizGen("문제6","과거의 실수로부터 배우는 편인가요?",
            new string[]{"예", "아니오" },10,1),

            new QuizGen("문제7","당신의 미래 계획은 비현실적입니까? (솔직하게 응답하세요.)",
            new string[]{"예", "아니오" },10,0),

            new QuizGen("문제8","약속을 자주 어기나요?",
            new string[]{"예", "아니오" },10,0),

            new QuizGen("문제9","개인적 이득을 위해서 타인을 이용하시나요?",
            new string[]{"예", "아니오" },10,0),

            new QuizGen("문제10","타인을 사랑하는 능력이 부족한가요?",
            new string[]{"예", "아니오" },10,0),


        });
    }
    #endregion

    public void Awake()
    {
        InitQuiz();
    }

}
