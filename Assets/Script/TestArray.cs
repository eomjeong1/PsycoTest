using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class TestArray : MonoBehaviour
{
    TestManager TM;

    public Text QuizText;
    public Text QuizTitle;
    public Text QuizBtn1;
    public Text QuizBtn2;
    public Text QuizBtn3;
    public Text QuizBtn4;
    public Text QuizBtn5;

    private string[] QuizTitleArray = { "문제1", "문제2", "문제3", "문제4", "문제5", "문제6" };
    private string[] QuizTextArray = { "당신은 자주 거울을 봅니다. 그러나 거울을 볼 때마다 만족스럽지가 않네요. 그 이유는 무엇일까요?",
    "아무도 없는 살지 않는 저택에 전쟁 중 부상을 입은 군인의 초상화가 걸려있습니다. 이 군인이 다친 곳은 어느 곳일까요?",
    "어두운 숲 속에서 당신의 바로 앞에 정자가 있습니다. 우두커니 정자를 바라보고 있는데 갑자기 뒤에 무언가가 스윽 지나갑니다. 지나간 것은 무엇일까요?",
    "당신은 목이 말라 자판기를 찾았습니다. 신기하게도 자판기 안 음료수에는 어떤 상표도 없습니다. 당신이 뽑은 음료수(액체)의 색은 무엇일까요?",
    "어두운 방 안에 당신은 홀로 있고 밖에서 살인마가 칼을 든 채 당신을 찾고 있습니다. 방어할 것이 아무 것도 없기에 숨기로 하였습니다. 어디에 숨을 건가요?",
    "당신은 10년 동안 증오한 사람을 마침내 죽이기로 결심하였습니다. 칼을 사러 간 당신 앞에는 오천원짜리와 오만원짜리가 놓여 있었습니다. 당신은 망설임없이 오천원짜리 칼을 골랐습니다. 그 이유는?" };
    private string[] QuizBtn1Array = { "자신의 외모가 마음에 들지 않아서", "머리", "들짐승", "파랗다", "문 뒤", "굳이 비싼 돈을 쓰기 싫어서" };
    private string[] QuizBtn2Array = { "얼굴에 상처가 있어서", "다리", "낙엽", "노랗다", "침대 밑", "더 고통스럽게 죽일 수 있어서" };
    private string[] QuizBtn3Array = { "살이 쪄서", "눈", "이성", "빨갛다","창문 밖", "오천원짜리가 더 날카로워 보여서" };
    private string[] QuizBtn4Array = { "거울이 더러워서", "심장", "개", "투명하다","장롱 안", "수중에 돈이 모자라서" };
    private string[] QuizBtn5Array = { "거울 속 내 뒤에 다른 사람이 보여서", "팔", "귀신", "그 외 다른 색", "화장실", "칼이 눈에 잘 안띄는 크기여서" };
    public void Start()
    {
        
        for (int j = 0; j < QuizTitleArray.Length; j++)
        {

            for(int i = 0;  i <j; i++)
            {
                QuizTitle.text = QuizTitleArray[i];
                QuizText.text = QuizTextArray[i];
                QuizBtn1.text = QuizBtn1Array[i];
                QuizBtn2.text = QuizBtn2Array[i];
                QuizBtn3.text = QuizBtn3Array[i];
                QuizBtn4.text = QuizBtn4Array[i];
                QuizBtn5.text = QuizBtn5Array[i];
            }


        }
    }
}

