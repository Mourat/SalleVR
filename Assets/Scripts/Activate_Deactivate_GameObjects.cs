using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Events;

public class Activate_Deactivate_GameObjects : MonoBehaviour
{
    public GameObject GameObjectToDeactivate;
    //public UnityEvent unityEvent;
    //public MouseControl _mouseControl;
    bool stateVRS = false;
    bool state = false;
    // Start is called before the first frame update
    void Start()
    {
        //if (_mouseControl._leftMouseClick)
        //{
        //    Debug.Log("Left Mouse Cliked");
        //    GameObjectToDeactivate.SetActive(true);
        //}
        //if (!_mouseControl._leftMouseClick)
        //{
        //    GameObjectToDeactivate.SetActive(false);
        //}
    }

    public void OnClickVRSetting()
    {
        stateVRS = !stateVRS;
        GameObjectToDeactivate.SetActive(stateVRS);
    }
        public void SwitchActivation()
    {
        state = !state;
        GameObjectToDeactivate.SetActive(state);
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
        //if (_mouseControl._leftMouseClick)
        {
            //Debug.Log("(Activate_Deactivate_GameObjects.cs) Left Mouse Cliked");
            //GameObjectToDeactivate.SetActive(true);
        }
        //if (!_mouseControl._leftMouseClick)
        {
            //GameObjectToDeactivate.SetActive(false);
        }

    }
}
