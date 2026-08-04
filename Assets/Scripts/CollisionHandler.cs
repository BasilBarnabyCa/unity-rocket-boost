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
			case "Finish":
				Debug.Log("You made it!");
				LoadNextLevel();
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

	private void LoadNextLevel()
	{
		int currentScene = SceneManager.GetActiveScene().buildIndex;
		int nextScene = currentScene + 1;
		
		if (nextScene == SceneManager.sceneCountInBuildSettings) {
			nextScene = 0;
		} 

		SceneManager.LoadScene(nextScene);
	}
}
