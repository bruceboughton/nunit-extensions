using NUnit.Framework.Constraints;
using NUnit.Framework;

namespace NUnitExtensions
{
    public static class AssertionExtensions
    {
        public static void Should(this object actual, IResolveConstraint constraint)
        {
            Assert.That(actual, constraint);
        }

        public static void Should(this object actual, IResolveConstraint constraint, string message)
        {
            Assert.That(actual, constraint, message);
        }

        public static void Should(this TestDelegate invocation, IResolveConstraint constraint)
        {
            Assert.That(invocation, constraint);
        }

        public static void Should(this TestDelegate invocation, IResolveConstraint constraint, string message)
        {
            Assert.That(invocation, constraint, message);
        }
    }

    public class Be : Is
    {
    }

    public class Have : Has
    {
    }
    
    public class Throw : Throws
    {
    }

    public static class Not
    {
        public static ConstraintExpression Be { get { return Is.Not; } }

        public static ConstraintExpression Have { get { return Has.No; } }

        public static ThrowsNothingConstraint Throw { get { return Throws.Nothing; } }
    }

    public static class The
    {
        public static TestDelegate Invocation(TestDelegate action)
        {
            return action;
        }
    }
}
