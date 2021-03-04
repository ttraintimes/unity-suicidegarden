using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story1images: MonoBehaviour {

	public GameObject shot2;
	public GameObject shot3;
	public GameObject shot4;
	public new Camera camera;

	private bool auto_play = false;

	IEnumerator AutoPlay() {
		yield
		return new WaitForSeconds(GlobalVariables.AutoPlayTimeInterval);

		InteractiveCallback(1);

		yield
		return new WaitForSeconds(GlobalVariables.AutoPlayTimeInterval);

		InteractiveCallback(2);

		yield
		return new WaitForSeconds(GlobalVariables.AutoPlayTimeInterval);

		InteractiveCallback(3);
	}

	// IEnumerator ShowShot4()
	// {
	// yield return new WaitForSeconds (2.0f);
	// Display highlighter
	// shot4_highlighter.GetComponent<SpriteRenderer> ().enabled = true;
	// shot4_highlighter.GetComponent<Animator> ().enabled = true;
	// }

	void InteractiveCallback(int shot) {
		switch (shot) {
			case 1:
				// Shot #1
				shot2.GetComponent < Animator > ().Play("gardenshot2");
				break;
			case 2:
				// Shot #2
				shot3.GetComponent < Animator > ().Play("gardenshot3");
				break;
			case 3:
				// Shot #3
				shot4.GetComponent < Animator > ().Play("gardenshot4");
				break;
			default:
				break;
		}

	}

	// @params : void
	// @return : void
	// @brif : Go to next stage when shot #5 display after finished MenuGame
	void GotoNextStage() {
		// Go to next stage
		SceneManager.LoadScene("storyshot4");
	}

	// Update is called once per frame
	void Update() {

		if (!auto_play) {
			auto_play = true;
			StartCoroutine(AutoPlay());
		}

	}
}