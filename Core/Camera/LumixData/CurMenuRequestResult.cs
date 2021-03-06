﻿namespace GMaster.Core.Camera.LumixData
{
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "camrply")]
    public class CurMenuRequestResult : BaseRequestResult
    {
        [XmlElement("menuinfo")]
        public MenuInfo MenuInfo { get; set; }
    }
}