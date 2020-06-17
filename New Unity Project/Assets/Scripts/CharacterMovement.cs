using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject character;
    public Material changeColor;
    public Material oldColor;
    public static GameObject selectedCharacter;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider.tag == "Character")
                {
                    if(selectedCharacter != null)
                    {
                        selectedCharacter.GetComponent<MeshRenderer>().material = oldColor;
                    }
                    selectedCharacter = hit.collider.gameObject;
                    hit.collider.GetComponent<MeshRenderer>().material = changeColor;
                }
            } 
        }
    }
}
