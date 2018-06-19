using Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.RuleEngine
{
    public class BusinessRuleEngine : IBusinessRuleEngine
    {
        public bool validate(Engineer engineer)
        {
            return true;
        }
    }
}
