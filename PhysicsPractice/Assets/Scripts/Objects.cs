using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objects : MonoBehaviour
{
    public Text UI;
    public int objectsBroken;

    private void Start()
    {
       UI = GameObject.FindGameObjectWithTag("EditorOnly").GetComponent<Text>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("floor"))
        {
            objectsBroken++;
            Debug.Log("hit");
            UI.text = objectsBroken.ToString();
        }
    }
}
