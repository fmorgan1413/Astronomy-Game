using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNext : MonoBehaviour
{
    private Currency currency;
    public GameObject constellation;

    void Start()
    {
        currency = FindObjectOfType<Currency>();
    }

    public void OnClick() 
    {
        Debug.Log("clicked");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MoveToShop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void MoveToMain()
    {
        SceneManager.LoadScene("Ursa Major");
    }

    public void Unlock()
    {
        constellation.SetActive(true);
        currency.coins -= 5;
    }

    public void Close()
    {
        constellation.SetActive(false);
    }
}
