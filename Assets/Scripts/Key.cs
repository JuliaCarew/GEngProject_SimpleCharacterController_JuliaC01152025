using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnEnable(){
        InputActions.InteractEvent += Disappear; 
    }
    private void OnDisable(){
        InputActions.InteractEvent -= Disappear; 
    }

    private void Disappear(){ // effect of picking up key, ui updates as well
        gameObject.SetActive(false);
    }
}
