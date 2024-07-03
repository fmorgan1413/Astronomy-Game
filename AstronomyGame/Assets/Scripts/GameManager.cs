using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private Currency currency;

    public int numStars;
    public int starsFound;
    public bool didFind;

    public GameObject winOverlay;
    public TextMeshProUGUI coinsText;
    
    // Start is called before the first frame update
    void Start()
    {
        didFind = false;
        winOverlay.SetActive(false);
        currency = FindObjectOfType<Currency>();
    }

    // Update is called once per frame
    void Update()
    {
        if (numStars == starsFound)
        {
            didFind = true;
            Debug.Log("constellation found");

            winOverlay.SetActive(true);
            currency.coins += 10;

            starsFound = 0;
        }

        Debug.Log("COINS: " + currency.coins);
        coinsText.text = "COINS: " + currency.coins.ToString();
    }
}
