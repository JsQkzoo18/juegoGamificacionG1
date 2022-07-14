using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPaneles : MonoBehaviour
{
    public GameObject panelMainMenu;
    public GameObject panelMundos;
    public GameObject panelCreditos;
    public GameObject panelSalir;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivarPanelMainMenu(){
        panelMainMenu.SetActive(true);
        panelMundos.SetActive(false);
    }

     public void DesactivarPanelMainMenu(){
        panelMainMenu.SetActive(false);
    }

    
    public void ActivarPanelMundos(){
        panelMundos.SetActive(true);
       // panelMainMenu.SetActive(false);
    }

     public void DesactivarPanelMundos(){
        panelMundos.SetActive(false);
        panelMainMenu.SetActive(true);
    }

     public void ActivarPanelCreditos(){
        panelCreditos.SetActive(true);
        //panelMainMenu.SetActive(false);
    }

     public void DesactivarPanelCreditos(){
        panelCreditos.SetActive(false);
        panelMainMenu.SetActive(true);
    }

    public void ActivarPanelSalir(){
        panelSalir.SetActive(true);
        //panelMainMenu.SetActive(false);
    }

     public void DesactivarPanelSalir(){
        panelSalir.SetActive(false);
        panelMainMenu.SetActive(true);
    }

    
}
