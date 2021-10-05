using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parallax : MonoBehaviour
{
    [SerializeField] private float _speed;

    private RawImage _image;
    private float _imageXPosition;

    private void Start()
    {
        _image = GetComponent<RawImage>();
    }

    private void Update()
    {
        _imageXPosition += _speed * Time.deltaTime;

        if(_imageXPosition > 1)
        {
            _imageXPosition = 0;
        }

        _image.uvRect = new Rect(_imageXPosition, 0, _image.uvRect.width, _image.uvRect.height);
    }
}
