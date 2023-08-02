using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class MyScript : MonoBehaviour
{
    public string beefSandwich;
    public char K;
    [SerializeField] int john;
    public float stuart;
    public Text scoreText;

    public void MyMethod()
    {
        john++;
        john = john + 1;
        john += 1;
    }

    public void Start()
    {
        MyMethod();
    }

    public void Update()
    {
        scoreText.text = "Score: " + john.ToString();
    }



}
