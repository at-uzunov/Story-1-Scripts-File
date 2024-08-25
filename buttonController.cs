using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class buttonController : MonoBehaviour
{
    GameObject dialog2;
    GameObject Button_2_Holder;
    TextMeshProUGUI dialog2_text;
    Animator test_animation;
    // Start is called before the first frame update
    private void Awake( ) {

    }
    void Start()
    {
        dialog2 = GameObject.Find("Dialog2").gameObject;
        dialog2.SetActive(false);
        Button_2_Holder = GameObject.Find("Buttons_2_Holder").gameObject;
        Button_2_Holder.SetActive(false);
        dialog2_text = dialog2.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        test_animation = GameObject.Find("Canvas").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Button_1_Selected( ) {
        GameObject gameobject = GameObject.Find("Button").gameObject;
        Destroy( gameobject );
        GameObject gameobject2 = GameObject.Find("Button (1)").gameObject;
        Destroy(gameobject2);
        Debug.Log("Button Clicked");

        Button_2_Holder.SetActive(true);
        dialog2.SetActive(true);

        
    }

    public void Button_2_Holder_Button_1( ) {
        Button_2_Holder.SetActive(false);
        dialog2_text.text = "Great! Follow me!";

        test_animation.SetBool("is_pressed", true);
        
    }
}
