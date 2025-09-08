using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap_1;

public class EasyCode
{
    
}

public class Person
{
    public string Name { get; set; }
    public string Greeting => $"Hello,{Name}!";
    public override string ToString() => Name;
}
