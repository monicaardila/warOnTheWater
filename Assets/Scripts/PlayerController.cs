using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{	 	
	public CharacterController charCon;
	private Vector3 moveInput;
	public  Transform camTrans;

	[Header ("Gravity")]
	public float gravityModifier;

	[Header ("Move Control")]
	public float moveSpeed;
	public float jumpPower;
	private bool  canJump;
	public Transform groundCheckPoint;
	public LayerMask whatIsGround;
	[Header ("Camera Control")]
	public float mouseSensitivity;
	public bool InvertX;
	public bool InvertY;
	public GameObject bullet;
	public Transform  firePoint;
	
	
	public GameObject Canvasl;
    public GameObject Canvasll;
    public GameObject Canvaslll;
    public GameObject Canvaslv;
    public GameObject Canvasv;
    public GameObject Canvasvl;

    // Start is called before the first frame update
    void Start()
    {
    Canvasl.SetActive (true);
    
    	Canvasll.SetActive (false);
    		
    		Canvaslll.SetActive (false);
    		Canvaslv.SetActive (false);
    		Canvasv.SetActive (false);
    
    
    		Canvasvl.SetActive (false);

        
    }

    // Update is called once per frame
    void Update()
    {
      //  moveInput.x= Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime ;
		//moveInput.z= Input.GetAxis("Vertical") * moveSpeed * 

 		// Guardar   y velocity 
		float yStore = moveInput.y;

		Vector3 verMove= transform.forward * Input.GetAxis("Vertical") ;
		Vector3 horiMove= transform.right * Input.GetAxis("Horizontal") ;
		 moveInput = verMove + horiMove;
		moveInput.Normalize();
		moveInput = moveInput * moveSpeed;
		
		moveInput.y = yStore;
 		// Gravedad 
		moveInput.y += Physics.gravity.y * gravityModifier * Time.deltaTime; 

		if (charCon.isGrounded)
			{
				moveInput.y = Physics.gravity.y * gravityModifier * Time.deltaTime;
		
			}
		// Salto del Jugador 
		if (Input.GetButtonDown("Jump"))
			{
				moveInput.y=jumpPower;
			}


		charCon.Move( moveInput *  Time.deltaTime);
    	// control rotacion camara 
		Vector2 mouseInput = new Vector2(Input.GetAxisRaw("Mouse X"),Input.GetAxisRaw("Mouse Y") )*mouseSensitivity;
		if(InvertX)
		{
			mouseInput.x = -mouseInput.x;
			
		}
		if(InvertY)
		{
			mouseInput.y = -mouseInput.y;
			
		}
	
		transform.rotation  = Quaternion.Euler(transform.rotation.eulerAngles.x,transform.rotation.eulerAngles.y + mouseInput.x,transform.rotation.eulerAngles.z );
    	camTrans.rotation=  Quaternion.Euler(camTrans.rotation.eulerAngles + new Vector3(-mouseInput.y, 0f, 0f));
		// Shooting o disparo 
		if(Input.GetMouseButtonDown(0))
		{
				Instantiate(bullet,firePoint.position,firePoint.rotation);
		}
}
}
