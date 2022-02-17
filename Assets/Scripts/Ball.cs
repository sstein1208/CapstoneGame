using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody _rb;
    private float dragCoeff;


    private void Start() {
        _rb = GetComponent<Rigidbody>();
        _rb.isKinematic = true;
        dragCoeff = 10.0f;
    }

	public void Push(Vector3 force, Vector3 drag) {
		_rb.isKinematic = false;
        _rb.AddForce(_rb.mass * force, ForceMode.Impulse);
		_rb.AddForce(_rb.mass * drag, ForceMode.Force);
	}
}