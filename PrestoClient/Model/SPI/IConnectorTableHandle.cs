﻿using BAMCIS.PrestoClient.Serialization;
using Newtonsoft.Json;

namespace BAMCIS.PrestoClient.Model.SPI
{
    /// <summary>
    /// From com.facebook.presto.spi.ConnectorTableHandle.java
    /// </summary>
    [JsonConverter(typeof(EmptyInterfaceConverter))]
    public interface IConnectorTableHandle
    {
        // Intentionally empty
    }
}
