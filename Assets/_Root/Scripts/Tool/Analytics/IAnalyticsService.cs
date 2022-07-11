using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Services.Analytics
{
    internal interface IAnalyticsService
    {
        void SendEvent(string eventName);
        void SendEvent(string evantName, Dictionary<string, object> eventData);
    }
}
