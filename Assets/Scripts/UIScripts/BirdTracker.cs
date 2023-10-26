using UnityEngine;

public class BirdTracker : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private float _offsetZ;

    private void Update()
    {
        transform.position = new Vector3(_bird.transform.position.x - _offsetZ,
            transform.position.y, transform.position.z);
    }
}
