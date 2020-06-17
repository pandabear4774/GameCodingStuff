using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent : MonoBehaviour
{
    public LayerMask clickMask;
    private Vector3 clickPosition = new Vector3(0f, 0f, 0f);
    private Vector3 offSet = new Vector3(0f, 1f, 0f);
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            clickPosition = -Vector3.one;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100f, clickMask))
            {
                clickPosition = hit.point + offSet;
            }
        }
        if (CharacterMovement.selectedCharacter != null)
        {
            Vector3 direction = clickPosition - CharacterMovement.selectedCharacter.transform.position;
            CharacterMovement.selectedCharacter.transform.Translate(direction.normalized * moveSpeed * Time.deltaTime, Space.World);
            
        }

    }
}
