
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _target;
    private int _wavepointIndex = 0;

    private void Start()
    {
        _target = Waypoints.waypoints[0];
    }
    private void Update()
    {
        Vector3 direction = _target.position - transform.position;
        transform.Translate(direction.normalized * (_speed * Time.deltaTime),Space.World);

        if(Vector3.Distance(transform.position,_target.position)<= 0.1f)
        {
            GetNextWaypoint();
        }
        
    }
    void GetNextWaypoint()
    {
        if(_wavepointIndex >= Waypoints.waypoints.Length-1)
        {
            Destroy(gameObject);
            return;
        }
        _wavepointIndex++;
        _target = Waypoints.waypoints[_wavepointIndex];
    }
}
