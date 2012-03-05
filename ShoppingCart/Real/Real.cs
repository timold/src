using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;

namespace Real
{
    public class Bar : IBar
    {
        string IBar.PityTheFoo()
        {
            return "Mock";
        }
    }
}
