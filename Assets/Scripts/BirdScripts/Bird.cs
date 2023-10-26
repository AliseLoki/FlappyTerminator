using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BirdMover))]

public class Bird : MonoBehaviour
{
    private BirdMover _mover;

    public event UnityAction GameOver;

    private void Start()
    {
        _mover = GetComponent<BirdMover>();
    }

    public void ResetPlayer()
    {
        _mover.ResetBird();
    }

    public void Die()
    {
        GameOver?.Invoke();
    }
}
