using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject _parent;
    [SerializeField] private int _size;

    private List<GameObject> _pool = new List<GameObject>();

    protected void Initialize(GameObject prefab)
    {
        for (int i = 0; i < _size; i++)
        {
            GameObject obj = Instantiate(prefab, _parent.transform);
            obj.SetActive(false);

            _pool.Add(obj);
        }
    }

    protected bool TryGetObject(out GameObject result)
    {
        result = _pool.FirstOrDefault(o => o.activeSelf == false);

        return result != null;
    }
}
