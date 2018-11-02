using NLog;
using Newtonsoft.Json.Linq;

namespace Pompa
{
    public interface IConverter
    {
        JObject GetGelfJson(LogEventInfo logEventInfo, string facility);
    }
}