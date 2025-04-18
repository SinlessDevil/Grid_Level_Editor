using Code.Infrastructure.StaticData;
using UnityEngine;

namespace StaticData
{
    [CreateAssetMenu(menuName = "StaticData/Balance", fileName = "Balance", order = 0)]
    public class BalanceStaticData : ScriptableObject
    {
        public TileBalanceData TileBalanceData;
    }
}