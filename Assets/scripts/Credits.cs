using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    [SerializeField]private Button exitButton; 
    public void Quit()
    {
        Application.Quit();
    }

    private void OnEnable()
    {
        exitButton.onClick.AddListener(OnQuitButtonClick);
    }

    private void OnQuitButtonClick()
    {
     
    }

    private void OnDisable()
    {
        exitButton.onClick.RemoveListener(OnQuitButtonClick);
    }

}
