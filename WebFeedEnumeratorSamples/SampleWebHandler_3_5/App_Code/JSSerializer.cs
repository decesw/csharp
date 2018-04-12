using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;

/// <summary>
/// Summary description for JavascriptSerializerDateTimeConverter
/// </summary>
public class JavascriptSerializerDateTimeConverter : JavaScriptConverter
{
    public JavascriptSerializerDateTimeConverter() : base() { }

    public override IEnumerable<Type> SupportedTypes
    {
        get
        {
            yield return typeof(DateTime);
        }
    }

    public override object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer)
    {
        if (typeof(DateTime) == type)
        {
            if (!dictionary.ContainsKey("UTC"))
                return DateTime.MinValue;//hatalı gönderim.
            string valDtStr = dictionary["UTC"] as string;
            if (string.IsNullOrEmpty(valDtStr))
                return DateTime.MinValue;
            return DateTime.Parse(valDtStr, new System.Globalization.CultureInfo("en-US"), System.Globalization.DateTimeStyles.AdjustToUniversal);
        }

        throw new NotSupportedException();
    }

    public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
    {
        if (obj != null && obj.GetType() == typeof(DateTime))
        {
            Dictionary<string, object> rtn2 = new Dictionary<string, object>();
            DateTime dt = (DateTime)obj;
            if (dt != DateTime.MinValue && dt != DateTime.MaxValue)
                rtn2["UTC"] = dt.ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");
            else
                rtn2["UTC"] = "";
            return rtn2;
        }
        throw new NotSupportedException();
    }
}



