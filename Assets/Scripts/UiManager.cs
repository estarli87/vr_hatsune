using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class UiManager : MonoBehaviour
{
    [SerializeField] private GameObject panelOpciones;
    [SerializeField] private GameObject panelIdiomas;
    [SerializeField] private GameObject panelPrincipal;
    [SerializeField] private AudioSource musica;
    [SerializeField] private GameObject panelUI;
    [SerializeField] private GameObject panelColorUI;
    [SerializeField] private GameObject luz;

    private static extern void SetScreenBrightness(int value);
    void Update()
    {
        if (Input.GetButtonDown("XRI_Left_MenuButton"))
        {
            panelUI.SetActive(!panelUI.active);
            panelColorUI.SetActive(!panelColorUI.active);
        }
    }
    public void showOpciones()
    {
        panelIdiomas.SetActive(false);
        panelPrincipal.SetActive(false);
        panelOpciones.SetActive(true);
    }
    
    public void showLanguages()
    {
        panelIdiomas.SetActive(true);
        panelPrincipal.SetActive(false);
        panelOpciones.SetActive(false);
    }
    
    public void showMainMenu()
    {
        panelIdiomas.SetActive(false);
        panelPrincipal.SetActive(true);
        panelOpciones.SetActive(false);
    }
    public void cambiarBrillo(float _brillo)
    {
        luz.GetComponent<Light>().intensity = _brillo;
    }
    public void ajustarVolumen(float _volumen)
    {
        musica.volume = _volumen;
    }

}
