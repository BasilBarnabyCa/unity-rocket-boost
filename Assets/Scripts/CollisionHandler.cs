using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
	private void OnCollisionEnter(Collision collision)
	{
		switch (collision.gameObject.tag)
		{
			case "Friendly":
				Debug.Log("Your mission is a go!");
				break;
			case "Fuel":
				Debug.Log("All fueled up!");
				break;
			case "Finish":
				Debug.Log("You made it!");
				break;
			default:
				Debug.Log("You crashed!");
				break;
		}
	}
}
