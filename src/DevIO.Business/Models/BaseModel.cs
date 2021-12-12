using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Models
{
    public abstract class BaseModel
    {
        public Guid Id { get; set; }
        public BaseModel()
        {
            Id = Guid.NewGuid();
        }
    }
}
