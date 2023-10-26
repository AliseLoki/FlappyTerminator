using UnityEngine;

[RequireComponent(typeof(Bird))]

public class BirdCollisionChecker : MonoBehaviour
{
    private Bird _bird;

    private void Start()
    {
        _bird = GetComponent<Bird>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
            _bird.Die();
    }
}
