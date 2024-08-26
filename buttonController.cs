using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class buttonController : MonoBehaviour
{
    GameObject dialog2;

    // to the git readers. This is set to SeralizeField because I can't use the find gameobject
    // because I have an animation that at the begging it sets the active status to false
    [SerializeField] GameObject Button_1_Holder;
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
        Destroy(Button_1_Holder);
        Debug.Log("Button Clicked");
        GameObject dialog1 = GameObject.Find("Dialog1");
        Destroy(dialog1);
        Button_2_Holder.SetActive(true);
        dialog2.SetActive(true);

        
    }

    public void Button_2_Holder_Button_1( ) {
        //Button_1_Holder.SetActive(false);
        Destroy(Button_2_Holder);
        dialog2_text.text = "Great! Follow me!";

        test_animation.SetBool("is_pressed", true);
        
    }
}
