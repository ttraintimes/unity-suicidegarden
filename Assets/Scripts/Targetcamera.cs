using UnityEngine;

    public class Targetcamera : MonoBehaviour {  
	public Transform target;
	public float theta;


	void Update(){
		transform.position = (new Vector3 (target.position.x + (-7) * Mathf.Sin (target.eulerAngles.y*(Mathf.PI/180) ), 3+target.position.y ,target.position.z + (-7) * Mathf.Cos (target.eulerAngles.y*(Mathf.PI/180) )));
        transform.rotation = Quaternion.Euler(18.0f, target.eulerAngles.y, 0.0f);
	}
}
