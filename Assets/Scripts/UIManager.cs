using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI keyText;

    private void OnEnable(){
        InputActions.InteractEvent += UpdateKeyText; 
    }
    private void OnDestroy()
    {
        InputActions.InteractEvent -= UpdateKeyText; 
    }

    private void UpdateKeyText()
    {
        keyText.text = "Picked up key!";
    }
}
