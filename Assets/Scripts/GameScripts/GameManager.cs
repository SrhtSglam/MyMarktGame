using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] Panels;
    public TextMeshProUGUI[] InputTextArray; //Id0 = Username Text, Id1 = Companyname Text
    private PlayerSO playerSO;

    void Start()
    {
        string IsCreate = PlayerPrefs.GetString("IsPlayerCreated");
        if(string.IsNullOrEmpty(IsCreate)){
            Panels[0].SetActive(true);
        }else{
            Panels[0].SetActive(false);
        }
    }

#region //Main Panel Elements
    public void PlayGameOnClick(){
        PlayerPrefs.SetString("IsPlayerCreated", "True");
        string username = InputTextArray[0].text;
        string companyname = InputTextArray[1].text;
        PlayerPrefs.SetString("Player-Username", username);
        PlayerPrefs.SetString("Player-Companyname", companyname);
        PlayerPrefs.Save();
    }
#endregion
}
