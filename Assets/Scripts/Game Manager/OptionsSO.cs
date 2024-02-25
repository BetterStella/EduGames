using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OptionsSO : ScriptableObject
{

    [SerializeField]
    private int _agerange;
    [SerializeField]
    private int _subject;

    public int Agerange
    {
        get { return _agerange; }
        set { _agerange = value; }
    }

    public int Subject
    {
        get { return _subject; }
        set { _subject = value; }
    }
}
