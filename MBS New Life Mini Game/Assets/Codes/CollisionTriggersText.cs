using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

//this script detects a collision between the player character and any gameobject tagged as "interactable"
//when the collision is detected, it activates a UI Canvas, which is parented to the player character and shows dialogue
//there are two dialogues which can be shown, dialogue1 and dialogue 2. these can we written within the inspector
public class CollisionTriggersText : MonoBehaviour
{
    public Canvas DialogueBox;
    private Text DialogueManager;
    private int currentText;
  
    // Start is called before the first frame update
    void Start()
    {
        DialogueBox = DialogueBox.GetComponentInChildren<Canvas>();
        DialogueBox.gameObject.SetActive(false);
    }
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print (collision.gameObject.tag);
        if (collision.gameObject.tag == "interactable")
        {
            DialogueBox.gameObject.SetActive(true);

         }
    }
}
