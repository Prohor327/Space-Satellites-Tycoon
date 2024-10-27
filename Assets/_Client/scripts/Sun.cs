using UnityEngine;

public class Sun : MonoBehaviour
{
    [SerializeField] private GameObject _pointPovorot;
    [SerializeField] private int _speed;
    [SerializeField] private Vector3 povorot = new Vector3(0, 0, 0);


    private void Update()
    {
        gameObject.transform.RotateAround(_pointPovorot.transform.position, povorot, _speed * Time.deltaTime);
    }
}
