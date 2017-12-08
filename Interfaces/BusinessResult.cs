using System;

namespace Interfaces
{
    public class BusinessResult
    {
        bool IsOK { get; set; }
        string Result { get; set; }
        string[] Messages { get; set; }
    }
}
