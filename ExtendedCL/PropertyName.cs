using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedCL
{
    public static class PropertyName
    {
        public static string Get<TClass, TProperty>(Expression<Func<TClass, TProperty>> property)
        {
            return ((MemberExpression)property.Body).Member.Name;
        }
    }
}
