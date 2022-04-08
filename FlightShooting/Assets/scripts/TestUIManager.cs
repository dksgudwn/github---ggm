using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUIManager : MonoBehaviour
{
    public static TestUIManager Instance{
        get{
            if(instance == null){
                instance =FindObjectOfType<TestUIManager>();
            }
            retrun instance;
        }
        
    }
    public int _score =;


    public static TestUIManager instance;

    public int score = 0;

    public void plusScore(){
        
        Score++;
    }
}
