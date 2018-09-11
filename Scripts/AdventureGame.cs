using TMPro;
using UnityEngine;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI karmaText;
    //[SerializeField] KarmaCounter karma;

    //state variables
    [SerializeField] int currentKarma = 0;

    private void Start()
    {
        karmaText.text = currentKarma.ToString();
    }

    //Use this for initialization
    void Update () {                                // Void start will run everything within the curly braces with no return type. 
        KarmaCounter.Karma.ToString();                 // variable state is equal to starting state

    }

    public void AddToKarma()
    {
        currentKarma += currentKarma;                 // adds to counter 
        karmaText.text = currentKarma.ToString();     // turns int into a string

    }

    public void Save()
    {

    }


    //// Update is called once per frame


}