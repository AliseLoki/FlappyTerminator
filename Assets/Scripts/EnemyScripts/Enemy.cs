using UnityEngine;

[RequireComponent (typeof(Animator))]

public class Enemy : MonoBehaviour
{
    private const string Die = nameof(Die);

    [SerializeField] private Transform _throwPoint;
    [SerializeField] private Stone _stone;

    private Animator _animator;

    private void OnEnable()
    {
        _animator = GetComponent<Animator> ();
        Instantiate(_stone, _throwPoint);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Bullet bullet))
        {
            _animator.Play(Die);
        }
    }
}
