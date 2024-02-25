using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsSave : MonoBehaviour
{

    [SerializeField]
    private OptionsSO GameO;

    public void SetAgerange(int agerange)
    {
        Debug.Log(agerange);
        GameO.Agerange = agerange;
    }

    public void Setsubject(int subject)
    {
        Debug.Log(subject);

        GameO.Subject = subject;
    }


}
