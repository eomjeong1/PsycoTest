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

    private string[] QuizTitleArray = { "����1", "����2", "����3", "����4", "����5", "����6" };
    private string[] QuizTextArray = { "����� ���� �ſ��� ���ϴ�. �׷��� �ſ��� �� ������ ������������ �ʳ׿�. �� ������ �����ϱ��?",
    "�ƹ��� ���� ���� �ʴ� ���ÿ� ���� �� �λ��� ���� ������ �ʻ�ȭ�� �ɷ��ֽ��ϴ�. �� ������ ��ģ ���� ��� ���ϱ��?",
    "��ο� �� �ӿ��� ����� �ٷ� �տ� ���ڰ� �ֽ��ϴ�. ���Ŀ�� ���ڸ� �ٶ󺸰� �ִµ� ���ڱ� �ڿ� ���𰡰� ���� �������ϴ�. ������ ���� �����ϱ��?",
    "����� ���� ���� ���Ǳ⸦ ã�ҽ��ϴ�. �ű��ϰԵ� ���Ǳ� �� ��������� � ��ǥ�� �����ϴ�. ����� ���� �����(��ü)�� ���� �����ϱ��?",
    "��ο� �� �ȿ� ����� Ȧ�� �ְ� �ۿ��� ���θ��� Į�� �� ä ����� ã�� �ֽ��ϴ�. ����� ���� �ƹ� �͵� ���⿡ ����� �Ͽ����ϴ�. ��� ���� �ǰ���?",
    "����� 10�� ���� ������ ����� ��ħ�� ���̱�� ����Ͽ����ϴ�. Į�� �緯 �� ��� �տ��� ��õ��¥���� ������¥���� ���� �־����ϴ�. ����� �����Ӿ��� ��õ��¥�� Į�� ������ϴ�. �� ������?" };
    private string[] QuizBtn1Array = { "�ڽ��� �ܸ� ������ ���� �ʾƼ�", "�Ӹ�", "������", "�Ķ���", "�� ��", "���� ��� ���� ���� �Ⱦ" };
    private string[] QuizBtn2Array = { "�󱼿� ��ó�� �־", "�ٸ�", "����", "�����", "ħ�� ��", "�� ���뽺���� ���� �� �־" };
    private string[] QuizBtn3Array = { "���� �Ǽ�", "��", "�̼�", "������","â�� ��", "��õ��¥���� �� ��ī�ο� ������" };
    private string[] QuizBtn4Array = { "�ſ��� ��������", "����", "��", "�����ϴ�","��� ��", "���߿� ���� ���ڶ�" };
    private string[] QuizBtn5Array = { "�ſ� �� �� �ڿ� �ٸ� ����� ������", "��", "�ͽ�", "�� �� �ٸ� ��", "ȭ���", "Į�� ���� �� �ȶ�� ũ�⿩��" };
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

