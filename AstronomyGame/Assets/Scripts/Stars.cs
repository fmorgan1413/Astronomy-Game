using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Stars : MonoBehaviour, IPointerClickHandler
{
    // TODO: CREATE TEXT RESPONSES LIKE DEBUG LOG AND WIN CIRCLE FOR PLAYER

    private GameManager GM;
    private bool alreadyClicked;
    private SpriteRenderer SR;
    public GameObject FI;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("TODO: CREATE TEXT RESPONSES LIKE DEBUG LOG AND WIN CIRCLE FOR PLAYER");

        GM = FindObjectOfType<GameManager>();
        alreadyClicked = false;
        SR = this.gameObject.GetComponent<SpriteRenderer>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!alreadyClicked)
        {
            Debug.Log("star clicked");
            GM.starsFound++;
            SR.color = Color.yellow;
            FI.SetActive(true);
            Debug.Log("stars clicked: " + GM.starsFound + " / stars needed: " + GM.numStars);
            alreadyClicked = true;
        }
        else 
        {
            Debug.Log("already found");
        }
        
    }
}
