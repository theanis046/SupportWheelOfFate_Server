using Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.RuleEngine
{
    public interface IBusinessRuleEngine
    {
        bool validate(Engineer engineer);
    }
}
