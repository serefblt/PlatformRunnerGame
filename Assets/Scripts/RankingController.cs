using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingController : MonoBehaviour
{
    public static int _rank;
    [SerializeField] Transform _pTransform;
    [SerializeField] Transform[] rival;
    [SerializeField] Text _rankingText;
  

    private void FixedUpdate()
    {
        if (_pTransform.transform.position.z < 82.2f)
        {
            foreach (Transform item in rival)
            {
                if (item.position.z >= _pTransform.position.z)
                {
                    _rank++;
                }
            }
            //_lastRankText.text = "Rank:" + (_rank + 1).ToString();
            _rankingText.text = (_rank + 1).ToString() + "/11";
            _rank = 0;
        }
    }
}
