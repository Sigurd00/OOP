using System;
using System.Collections.Generic;

namespace FilteringFramework
{
    abstract class PassThroughFilter : PersonFilter
    {
        public override List<Person> Filter(List<Person> plist)
        {
            throw new NotImplementedException();
        }
    }
}