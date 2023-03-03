using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
//using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Activate_Deactivate_GameObjects : MonoBehaviour
{
    public GameObject GameObjectToDeactivate;
  //  public GameObject panelToDeactivate;
    public GameObject panelRoomToDeactivate;
    //public UnityEvent unityEvent;
    //public MouseControl _mouseControl;
    bool stateVRS = false;
    bool state = false;
    // Start is called before the first frame update
    void Start()
    {
        GameObjectToDeactivate.SetActive(false);
     
        panelRoomToDeactivate.SetActive(false);
       
    }

    public void OnClickVRSetting()
    {
        stateVRS = !stateVRS;
        GameObjectToDeactivate.SetActive(stateVRS);
    }

    public void OnClickChooseRoom()
    {
        stateVRS = !stateVRS;
        panelRoomToDeactivate.SetActive(true);
        GameObjectToDeactivate.SetActive(stateVRS);
        
    }

    public void OnClickBack()
    {
        
        panelRoomToDeactivate.SetActive(false);
        stateVRS = true;
        GameObjectToDeactivate.SetActive(stateVRS);
        
    }

    public void OnClickRoom1()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("Room1");
    }
    public void OnClickRoom2()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        SceneManager.LoadScene("Room2");
    }
    public void OnClickRoom3()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        SceneManager.LoadScene("Room3");
    }
    public void OnClickRoom4()
    {
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        SceneManager.LoadScene("Room4");
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("(Activate_Deactivate_GameObjects) : Detected GameObject = " + other.gameObject.name);
        if (other.gameObject == GameObjectToDeactivate)
        {
            Debug.Log("(Activate_Deactivate_GameObjects) : GameObjectToDeactivate = " + GameObjectToDeactivate);
            // unityEvent.Invoke();
        }
    }
    // Update is called once per frame
    void Update()
    {
        

    }
}
