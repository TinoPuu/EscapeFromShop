using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Movemint : MonoBehaviour
{
    [SerializeField]
    float playerSpeed;
    [SerializeField]
    float jumpForce;
    [SerializeField]
    //GameManager gm;
    List<GameObject> laatat = new List<GameObject>();
    Vector3 direction;
    Vector3 startPos;
    bool canJump = false;
    bool canMove = false;
    bool running = false;
    bool walking = false;
    float horizontalInput;
    float verticalInput;
    int i;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        i = 0;
        print("alkoi");
        //AddJump();
        startPos = transform.position;
        //HideJump();
        //laatat[i].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove == true) {
            if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
            {
                CalculateMovement();
            }
        }
        else
        {
            if (running == true)
            {
                transform.Translate(direction * playerSpeed * 2 * Time.deltaTime);
            }
            if (walking == true)
            {
                transform.Translate(direction * playerSpeed * Time.deltaTime);
            }
        }
        
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
       

    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && canJump == true)
        {
            if (canJump == true)
            {
                print("Hypp‰‰");
                Jump();
            }
        }
        
            
       
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Lattia")
        {
            print("osuu maahan");
            canJump = true;
            canMove = true;
            walking = false;
            running = false;

            

        }
        if (collision.gameObject.tag == "Trampoliini")
        {
            print("Ja l‰hti");
            canJump = true;
            canMove = true;
            walking = false;
            running = false;
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce * 2);
        }

    }
    void CalculateMovement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        direction = new Vector3(horizontalInput, 0f, verticalInput);
        if(canMove == true)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                walking = false;
                transform.Translate(direction * playerSpeed * 2 * Time.deltaTime);
                running = true;
            }
            else
            {
                running = false;
                transform.Translate(direction * playerSpeed * Time.deltaTime);
                walking = true;
            }
        }
        
        
        
        
        
    }
    void Jump()
    {
        print("Jump()");
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
        canMove = false;
        canJump = false;
    }
   /**void AddJump()
    {
        laatat.Add(GameObject.Find("Hyppylaatta1"));
        laatat.Add(GameObject.Find("Hyppylaatta2"));
        laatat.Add(GameObject.Find("Hyppylaatta3"));
        laatat.Add(GameObject.Find("Hyppylaatta4"));
        laatat.Add(GameObject.Find("Hyppylaatta5"));
        laatat.Add(GameObject.Find("Hyppylaatta6"));
        laatat.Add(GameObject.Find("Hyppylaatta7"));
        laatat.Add(GameObject.Find("Hyppylaatta8"));
       
    }
    void HideJump()
    {
        foreach (GameObject laatta in laatat)
        {
           laatta.SetActive(false);
        }
        
    }**/
}

