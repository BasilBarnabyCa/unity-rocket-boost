using UnityEngine;
using UnityEngine.SceneManagement;

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
				ReloadLevel();
				break;
		}
	}

	private void ReloadLevel()
	{
		int currentScene = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(currentScene);
	}
}
