using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarNiveles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CargarQuiz(){
        SceneManager.LoadScene("MainMenuQuiz");
        Time.timeScale = 1;
    }

    public void CargarCartas(){
        SceneManager.LoadScene("Cartas");
        Time.timeScale = 1;
    }

    public void SaliR(){
        
        Application.Quit();
    }
}
