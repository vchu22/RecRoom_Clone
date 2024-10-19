using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject UI_VRMenuGameobject;

    // Start is called before the first frame update
    void Start()
    {
        UI_VRMenuGameobject.SetActive(false);
    }

    public void OnWorldsButtonClicked(){
        Debug.Log("Worlds button is clicked!");
    }
    public void OnGoHomedButtonClicked(){
        Debug.Log("Go Home button is clicked!");
    }
    public void OnChangeAvatarButtonClicked(){
        Debug.Log("Change Avatar button is clicked!");
    }
}
