using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionImplementation.Entities
{
    //composition
    //aggregation
    //association

    public class TestClassInfo
    {
        #region Data Members
        int testClassId;
        string testClassName;
        string applicationName;
        //navigation attribute
        List<TestMethodInfo> testMethods;
        #endregion

        #region Constructors
        public TestClassInfo()
        {

        }
        public TestClassInfo(int testClassId, string className, string applicationName, List<TestMethodInfo> testMethods = null)
        {
            this.testClassId = testClassId;
            this.testMethods = testMethods;
            this.testClassName = className;
            this.applicationName = applicationName;
        }
        #endregion

        #region Properties
        public int TestClassId
        {
            get => testClassId; set => testClassId = value;
        }
        public string TestClassName
        {
            get => testClassName; set => testClassName = value;
        }
        public string ApplicationName
        {
            get => applicationName; set => applicationName = value;
        }
        public List<TestMethodInfo> TestMethods
        {
            get => testMethods; set => testMethods = value;
        }
        #endregion

        #region Object Class Methods
        public override string ToString()
        {
            return $"Class Name: {TestClassName} and Application: {ApplicationName}";
        }
        public override int GetHashCode()
        {
            int hash = 0;
            hash = this.testClassId.GetHashCode();
            hash = this.testClassName.GetHashCode() * hash;
            hash = this.applicationName.GetHashCode() * hash;
            return hash;
        }
        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                if (obj is TestClassInfo)
                {
                    TestClassInfo other = obj as TestClassInfo;
                    if (this == other)
                        return true;
                    if (!this.testClassId.Equals(other.testClassId))
                        return false;
                    if (!this.testClassName.Equals(other.testClassName))
                        return false;
                    if (!this.applicationName.Equals(other.applicationName))
                        return false;
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
        #endregion
    }
    //class Test
    //{
    //    void foo()
    //    {
    //        TestClassInfo clsInfo = new TestClassInfo(1, "CalculationTest", "CalLib");
    //        TestMethodInfo addInfo = new TestMethodInfo(1, "AddTest", new DateTime(2020, 3, 9), 20, TestMethodRunStatus.Pass, clsInfo);
    //        Console.WriteLine(addInfo.TestClass.ApplicationName);
    //    }
    //}
}
