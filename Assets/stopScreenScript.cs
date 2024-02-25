using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopScreenScript : MonoBehaviour
{
    [SerializeField] private GameObject stopScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenScreen()
    {
        stopScreen.SetActive(true);
    }
    public void CloseScreen()
    {
        stopScreen.SetActive(false);
    }
}
