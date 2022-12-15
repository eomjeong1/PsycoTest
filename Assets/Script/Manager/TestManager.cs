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
            new QuizGen(" ����1 ","����� ���� �ſ��� ���ϴ�. �׷��� �ſ��� �� ������ ������������ �ʳ׿�. �� ������ �����ϱ��?",
            new string[]{"�ڽ��� �ܸ� ������ ���� �ʾƼ�","�󱼿� ��ó�� �־", "���� �Ǽ�", "�ſ��� ��������", "�ſ� �� �� �ڿ� �ٸ� ����� ������" }, 20, 3),

            new QuizGen(" ����2 ","�ƹ��� ���� ���� �ʴ� ���ÿ� ���� �� �λ��� ���� ������ �ʻ�ȭ�� �ɷ��ֽ��ϴ�. �� ������ ��ģ ���� ��� ���ϱ��?",
            new string[]{ "�Ӹ�", "�ٸ�", "��", "�㸮", "��"},20,2),

            new QuizGen(" ����3 ", "��ο� �� �ӿ��� ����� �ٷ� �տ� ���ڰ� �ֽ��ϴ�. ���Ŀ�� ���ڸ� �ٶ󺸰� �ִµ� ���ڱ� �ڿ� ���𰡰� ���� �������ϴ�. ������ ���� �����ϱ��?",
            new string[]{ "������", "����","�̼�", "��", "�ͽ�"},20,3),

            new QuizGen(" ����4 ","����� ���� ���� ���Ǳ⸦ ã�ҽ��ϴ�. �ű��ϰԵ� ���Ǳ� �� ��������� � ��ǥ�� �����ϴ�. ����� ���� �����(��ü)�� ���� �����ϱ��?",
            new string[]{ "�Ķ���", "�����","������","�����ϴ�", "�����" },20,2),

            new QuizGen(" ����5 ","��ο� �� �ȿ� ����� Ȧ�� �ְ� �ۿ��� ���θ��� Į�� �� ä ����� ã�� �ֽ��ϴ�. ����� ���� �ƹ� �͵� ���⿡ ����� �Ͽ����ϴ�. ��� ���� �ǰ���?",
            new string[]{ "�� ��", "ħ�� ��", "â�� ��", "��� ��", "ȭ���"},20,0),

            new QuizGen(" ����6 ","����� 10�� ���� ������ ����� ��ħ�� ���̱�� ����Ͽ����ϴ�. Į�� �緯 �� ��� �տ��� ��õ��¥���� ������¥���� ���� �־����ϴ�. ����� �����Ӿ��� ��õ��¥�� Į�� ������ϴ�. �� ������?",
            new string[]{ "���� ��� ���� ���� �Ⱦ", "�� ���뽺���� ���� �� �־", "��õ��¥���� �� ��ī�ο� ������", "���߿� ���� ���ڶ�", "Į�� ���� �� �ȶ�� ũ�⿩��"},20,1),

        });

        quizList.Add(Quiz.Socio, new QuizGen[]
        {
            new QuizGen("����1","Ÿ�ο��� �ڽ��� �ŷ��� �����ִ� �� ������ ������?",
            new string[]{"��", "�ƴϿ�" },10,0),

            new QuizGen("����2","����� �ھư� ���� ���ΰ���?",
             new string[]{"��", "�ƴϿ�" },10,0),

            new QuizGen("����3","����� ����� ������?",
            new string[]{"��", "�ƴϿ�" },10,0),

            new QuizGen("����4","����� �°� �׸��� ���̸� �˰� �ֽ��ϱ�?",
             new string[]{"��", "�ƴϿ�" },10,1),

            new QuizGen("����5","����� �ΰ������ ��� ���ӵǴ� ���ΰ���?",
            new string[]{"��", "�ƴϿ�" },10,1),

            new QuizGen("����6","������ �Ǽ��κ��� ���� ���ΰ���?",
            new string[]{"��", "�ƴϿ�" },10,1),

            new QuizGen("����7","����� �̷� ��ȹ�� ���������Դϱ�? (�����ϰ� �����ϼ���.)",
            new string[]{"��", "�ƴϿ�" },10,0),

            new QuizGen("����8","����� ���� ��⳪��?",
            new string[]{"��", "�ƴϿ�" },10,0),

            new QuizGen("����9","������ �̵��� ���ؼ� Ÿ���� �̿��Ͻó���?",
            new string[]{"��", "�ƴϿ�" },10,0),

            new QuizGen("����10","Ÿ���� ����ϴ� �ɷ��� �����Ѱ���?",
            new string[]{"��", "�ƴϿ�" },10,0),


        });
    }
    #endregion

    public void Awake()
    {
        InitQuiz();
    }

}
