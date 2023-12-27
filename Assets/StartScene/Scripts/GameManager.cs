using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int TotalItemCount;
    public Text stageText;
    public Text PlayerItemText;


    private void Awake()
    {
        stageText.text ="/" +TotalItemCount.ToString();
    }

    public void GetItem(int count)
    {
        PlayerItemText.text = count.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
