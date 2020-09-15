using System;
using System.Collections.Generic;
using System.Text;

namespace CorporeRMApi.Models
{
    public class DataServerResult<T>
    {
        public List<ErrorMessage> Messages { get; set; }
        public int Length { get; set; }
        public T Data { get; set; }
    }
}
