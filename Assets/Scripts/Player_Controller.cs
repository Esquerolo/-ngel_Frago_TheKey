using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public float Speed = 5;
    public float gravity = -9.81f;
    public float verticalspeed;
    private float horizontalMove;
    private float verticalMove;

    private CharacterController CharacterController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        if (CharacterController.isGrounded == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                verticalspeed = 5f;
            }
        }
        verticalspeed += gravity * Time.deltaTime;

        Vector3 direction = new Vector3(horizontalMove, verticalspeed, verticalMove);
        CharacterController.Move(direction * Speed * Time.deltaTime);
    }
}
