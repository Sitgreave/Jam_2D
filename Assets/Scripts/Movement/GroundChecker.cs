using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] private LayerMask _groundLayerMask;
    [SerializeField] private Transform _footsPosition;
    [SerializeField] private float _radius;

    public bool IsGround;
    private void Update()
    {
        Checking();
    }
    public void Checking()
    {
        IsGround = Physics2D.OverlapCircle(_footsPosition.position, _radius, _groundLayerMask);
    }
}
