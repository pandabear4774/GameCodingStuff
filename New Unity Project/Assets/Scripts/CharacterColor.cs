using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterColor : MonoBehaviour
{
    public Material newColor;
    private Material oldColor;

    private void Start()
    {
        oldColor = this.gameObject.GetComponent<MeshRenderer>().material;
    }


    // Update is called once per frame
    void Update()
    {
        if (CharacterMovement.selectedCharacter == this)
        {
            this.gameObject.GetComponent<MeshRenderer>().material = newColor;
        } else
        {
            this.gameObject.GetComponent<MeshRenderer>().material = oldColor;
        }
    }
}
