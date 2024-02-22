using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class miniGameSO : ScriptableObject
{
    [SerializeField]
    private int _value;
    [SerializeField]
    private string _question;
    [SerializeField]
    private string _a1;
    [SerializeField]
    private string _a2;
    [SerializeField]
    private string _a3;
    [SerializeField]
    private string _a4;
    [SerializeField]
    private string _ca;
    [SerializeField]
    private string _ageg;
    [SerializeField]
    private string _category;

    public int Value
    {
        get { return _value;}
        set { _value = value; }
    }


    public string Question
    {
        get { return _question; }
        set { _question = value; }
    }

    public string A1
    {
        get { return _a1; }
        set { _a1 = value; }
    }

    public string A2
    {
        get { return _a2; }
        set { _a2 = value; }
    }

    public string A3
    {
        get { return _a3; }
        set { _a3 = value; }
    }

    public string A4
    {
        get { return _a4; }
        set { _a4 = value; }
    }

    public string CA
    {
        get { return _ca; }
        set { _ca = value; }
    }


    public string AgeG
    {
        get { return _ageg; }
        set { _ageg = value; }
    }


    public string Category
    {
        get { return _category; }
        set { _category = value; }
    }

}
