using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameSO : ScriptableObject
{


    [SerializeField]
    private miniGameSO _value;
   
    public miniGameSO Value
    {
        get { return _value;}
        set { _value = value; }
    }

}
