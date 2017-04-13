using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Abstractions
{
    public interface ICloudService
    {
        ICloudTable<T> GetTable<T>() where T : TableData;
    }
}
