using System.Linq;
using TMPro;
using UnityEngine;

public class MenuScript : MonoBehaviour
{

#region //Slot Panel Elements 
    void Start(){
        OpenPanel(0); //Main Panel No
    }
#endregion

    // void Update()
    // {
        
    // }

    public GameObject[] SaveSlots;
    public GameObject[] Panels;

#region //Main Panel Elements
    public void PlayOnClick(){
        OpenPanel(1); //Slot Panel No
        string slot = PlayerPrefs.GetString("SaveSlot");
        var slotTMP = SaveSlots[0].GetComponent<Transform>().GetChild(1);
        if(!string.IsNullOrEmpty(slot)){
            slotTMP.GetComponent<TextMeshProUGUI>().text = "Slot Full";
        }
        else{
            slotTMP.GetComponent<TextMeshProUGUI>().text = "New Save";
        }
    }

    public void SettingsOnClick(){
        
    }

    public void ExitOnClick(){
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
#endregion

#region //Slot Panel Elements 
    public void SlotOnClick(){
        string slot = PlayerPrefs.GetString("SaveSlot");
        if(string.IsNullOrEmpty(slot)){
            PlayerPrefs.SetString("SaveSlot", "True");
            PlayerPrefs.Save();
        }
    }
#endregion

#region //Back Button Redirect Mainmenu
    public void BackToMain(){
        AllPanelClose();
        OpenPanel(0);
    }
#endregion

#region //All Panel Close Function 
    public void AllPanelClose(){
        if(Panels.Count() > 0){
            for(int i=0; i < Panels.Count(); i++){
                Panels[i].SetActive(false);
            }
        }
    }
#endregion

#region //Dynamic Panel Open Function 
    public void OpenPanel(int panelNo){
        AllPanelClose();
        Panels[panelNo].SetActive(true);
    }
#endregion
}
