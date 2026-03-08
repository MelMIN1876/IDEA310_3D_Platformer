using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PowerCollector : MonoBehaviour
{
    public TMP_Text PowerText;
    public int NumPowersInLvl = 4;
    public string LvlToLoad = "Menu";
    private int PowersCollected = 0;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Power")
        {
            PowersCollected += 1;
            PowerText.text = "Power Collected: " + PowersCollected + " / " + NumPowersInLvl;
            Destroy(other.gameObject);

            if(PowersCollected == NumPowersInLvl)
            {
                SceneManager.LoadScene(LvlToLoad);
            }
        }
        if(other.tag == "DeadZone")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
