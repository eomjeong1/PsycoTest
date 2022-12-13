using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestManager : MonoBehaviour
{
    public bool test1 = false;
    public bool test2 = false;
    public bool test3 = false;
    public bool test4 = false;
    public bool test5 = false;
    public bool test6 = false;
    public TestArray TA;


    public void Test1()
    {
        if (test1 == true)
            TA.QuizArray(1);
    }
    public void Test2()
    {
        if (test2 == true)
            TA.QuizArray(2);
    }
    public void Test3()
    {
        if (test3 == true)
            TA.QuizArray(3);
    }
    public void Test4()
    {
        if (test4 == true)
            TA.QuizArray(4);
    }
    public void Test5()
    {
        if (test5 == true)
            TA.QuizArray(5);
    }
    public void Test6()
    {
        if(test6 == true)
            TA.QuizArray(6);
    }
   


}
