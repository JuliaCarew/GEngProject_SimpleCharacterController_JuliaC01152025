using UnityEngine;
using TMPro;

public class Bucket : MonoBehaviour
{
    public TextMeshProUGUI bucketText;
    public GameObject bucketEmpty;
    public GameObject bucketFull;

    private void OnEnable(){
        InputActions.InteractEvent += UpdateBucketText; 
        InputActions.InteractEvent += FillBucket; 
    }
    private void OnDisable()
    {
        InputActions.InteractEvent -= UpdateBucketText; 
        InputActions.InteractEvent -= FillBucket; 
    }

    private void FillBucket() // swap sprites to give illusion of water filling the bucket
    {
        bucketEmpty.SetActive(false);
        bucketFull.SetActive(true);
    }
    private void UpdateBucketText()
    {
        bucketText.text = "Filled up bucket!";
    }
}
