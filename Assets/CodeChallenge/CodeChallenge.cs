using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeChallenge : MonoBehaviour
{
    
    private float horizontal;
    // Create a variable to store the vertical input
    private float vertical;

    // Create a variable to store the speed of the character
    public int speed ;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        horizontal = Input.GetAxis("Horizontal");
        // Create the code to detect the user's up/down arrow keys or the W/S keys
        vertical = Input.GetAxis("Vertical");

        // Update the speed of the horizontal movement to be dynamic instead of the static 10 value
        transform.Translate(new Vector3(horizontal,vertical,0) * speed * Time.deltaTime );
        // Create the code to move the player vertically in the game
        

      

        
    }

   

}
