using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestController : MonoBehaviour
{
    // List of available sprite states. Set in inspector.
    public Sprite[] SpriteStates;

    // Toggleable object to handle state toggling for treasure chest.
    private Toggleable ToggleObject;

    // SpriteRenderer reference. Used to change sprite when the chest is toggled.
    private SpriteRenderer RendererObject;

    public TimerController TimeController;

    // Start is called before the first frame update
    void Start()
    {

        this.ToggleObject = ScriptableObject.CreateInstance("Toggleable") as Toggleable;
        this.RendererObject = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setTimer(TimerController timeController){
        TimeController = timeController;
    }

    // Called by the Unity engine whenever the current enemy object's Collider2D makes contact with another object's Collider2D
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided");
        // See if the enemy has collided with the player
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collided with Player");
            // Get a reference to the colliding player object
            Player player = collision.gameObject.GetComponent<Player>();
            Debug.Log("Toggle");
            ToggleObject.Toggle();

            if (ToggleObject.GetState() == Toggleable.STATE_CLOSED)
            {

                RendererObject.sprite = SpriteStates[1];
                TimeController.Pause();

            }
        }
    }

    /* InOpeningDistance() returns true if the distance between the player
    // and this treasure chest is less than or equal to one. And, false otherwise.
    private bool InOpeningDistance()
    {

        return Vector2.Distance(PlayerController.transform.position, this.transform.position) <= 1.0f;

    }*/

}
