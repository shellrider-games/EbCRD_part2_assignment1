using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowBezier : MonoBehaviour
{
    [SerializeField] private Transform controlPoint0, controlPoint1, controlPoint2, controlPoint3;
    private Transform[] _controlPoints;
    [SerializeField] private float timeFrame = 1;
    private float _timePassed;
    private bool _goForward = true;
    // Update is called once per frame

    void Awake()
    {
        _controlPoints = new Transform[] { controlPoint0, controlPoint1, controlPoint2, controlPoint3 };
        _timePassed = 0f;
    }
    void Update()
    {
        _timePassed =  _goForward ? (_timePassed + Time.deltaTime) : _timePassed - Time.deltaTime;
        if (_goForward)
        {
            _timePassed = Mathf.Min(_timePassed + Time.deltaTime, timeFrame);
        }
        else
        {
            _timePassed = Mathf.Max(_timePassed - Time.deltaTime, 0);
        }

        if (_timePassed == 0 || _timePassed == timeFrame) _goForward = !_goForward;
        transform.position = DeterminePositionFor(_timePassed / timeFrame);
    }

    private Vector3 DeterminePositionFor(float t)
    {
        Vector3 pos = Mathf.Pow(1 - t, 3) * _controlPoints[0].position +
                      3 * t * Mathf.Pow(1 - t, 2) * _controlPoints[1].position +
                      3 * Mathf.Pow(t, 2) * (1-t) * _controlPoints[2].position +
                      Mathf.Pow(t, 3) * _controlPoints[3].position;
        return pos;
    }
}
