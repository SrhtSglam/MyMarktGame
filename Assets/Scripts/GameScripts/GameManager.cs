using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] Panels;

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
        PlayerPrefs.Save();
    }
#endregion
}
