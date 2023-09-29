using UnityEngine;
using System.Collections;

public class sputnik : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Transform _pointPovorot;
    [SerializeField] private GameObject _SP;
    private int _sputnick;
    private Vector3 povorot = new Vector3(0, 0, 0);
    private int _sp1;
    private int _sp2;
    private int _sp3;
    private int _sp4;

    private void Start()
    {
        _speed = Random.Range(60f, 120f);

        float x = Random.Range(-1f, 1f);
        float y = Random.Range(-1f, 1f);
        float z = Random.Range(-1f, 1f);

        _rigidbody.rotation = Quaternion.Euler(Random.Range(0f, 360f), Random.Range(-50f, 50f), Random.Range(-40f, 40f));
        povorot = new Vector3(x, y, z);
    }

    private void Update()
    {
        gameObject.transform.RotateAround(_pointPovorot.position, povorot, -_speed * Time.deltaTime);
    }
}
