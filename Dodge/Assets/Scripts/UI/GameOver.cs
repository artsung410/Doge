using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI _bestTimeUI;

    public void Activate(int bestTime)
    {
        gameObject.SetActive(true);
        //_bestTimeUI.text.Replace("~", bestTime.ToString());
        _bestTimeUI.text = $"Ω√∞£ : {bestTime}√ ";
    }
}
