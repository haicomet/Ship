using UnityEngine;

public class Ship : MonoBehaviour
{
private Rigidbody2D rb2d;
private Vector2 thrustDirection = new Vector2(1,0);
private float thrustForce = 10f;
// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
{
rb2d = GetComponent<Rigidbody2D>();
}

// Update is called once per frame
void Update()
{
}

void FixedUpdate()
{
// Check if the "Thrust" input axis (space key) is pressed
if (Input.GetAxis("Thrust") > 0)
{
// Apply a continuous force in the thrustDirection, scaled by ThrustForce
rb2d.AddForce(thrustDirection * thrustForce, ForceMode2D.Force);
}
}
}