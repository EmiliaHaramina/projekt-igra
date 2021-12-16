using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip addIngredient, alcoholicDrink, beer, click, clock, confirmChoice, correctIngredients, fishSauce, mandragora, mysticBall, paper, peaches, plant, wrongIngredients;
    static AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        addIngredient = Resources.Load<AudioClip>("AddIngredientSound");
        alcoholicDrink = Resources.Load<AudioClip>("AlcoholicDrinkSound");
        beer = Resources.Load<AudioClip>("BeerSound");
        clock = Resources.Load<AudioClip>("ClockSound");
        confirmChoice = Resources.Load<AudioClip>("ConfirmChoiceMainMenu");
        correctIngredients = Resources.Load<AudioClip>("CorrectIngredientsSound");
        fishSauce = Resources.Load<AudioClip>("FishSauceSound");
        mandragora = Resources.Load<AudioClip>("MandragoraSound");
        click = Resources.Load<AudioClip>("MouseClick");
        mysticBall = Resources.Load<AudioClip>("MysticBallSound");
        paper = Resources.Load<AudioClip>("PaperSound");
        peaches = Resources.Load<AudioClip>("PeachesSound");
        plant = Resources.Load<AudioClip>("PlantSound");
        wrongIngredients = Resources.Load<AudioClip>("WrongIngredientsSound");

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch(clip)
        {
            case "addIngredient":
                audioSource.PlayOneShot(addIngredient);
                break;
            case "alcoholicDrink":
                audioSource.PlayOneShot(alcoholicDrink);
                break;
            case "beer":
                audioSource.PlayOneShot(beer);
                break;
            case "clock":
                audioSource.PlayOneShot(clock);
                break;
            case "confirmChoice":
                audioSource.PlayOneShot(confirmChoice);
                break;
            case "correctIngredients":
                audioSource.PlayOneShot(correctIngredients);
                break;
            case "fishSauce":
                audioSource.PlayOneShot(fishSauce);
                break;
            case "mandragora":
                audioSource.PlayOneShot(mandragora);
                break;
            case "click":
                audioSource.PlayOneShot(click);
                break;
            case "mysticBall":
                audioSource.PlayOneShot(mysticBall);
                break;
            case "paper":
                audioSource.PlayOneShot(paper);
                break;
            case "peaches":
                audioSource.PlayOneShot(peaches);
                break;
            case "plant":
                audioSource.PlayOneShot(plant);
                break;
            case "wrongIngredients":
                audioSource.PlayOneShot(wrongIngredients); 
                break;           
                                           
        }
    }
}
