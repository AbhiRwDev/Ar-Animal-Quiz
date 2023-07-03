using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreSetter : MonoBehaviour
{
    public TextMeshProUGUI AnimalScore, HumanScore, FruitScore;
    // Start is called before the first frame update
    void Start()
    {
        AnimalScore.text = "Animal Quiz - " + PlayerPrefs.GetString("AnimalScore");
        HumanScore.text = "Human Quiz - " + PlayerPrefs.GetString("HumanScore");
        FruitScore.text = "Fruit Quiz - " + PlayerPrefs.GetString("FruitScore");
    }

    
}
