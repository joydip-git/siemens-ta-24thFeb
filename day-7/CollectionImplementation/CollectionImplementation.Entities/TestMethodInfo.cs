using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionImplementation.Entities
{
    public class TestMethodInfo
    {
        #region Data Members
        int testMethodId;
        string testMethodName;
        DateTime testMethodRunTime;
        int testMethodRunDuration;
        TestMethodRunStatus testMethodRunStatus;
        //navigation attribute
        TestClassInfo testClass;
        #endregion

        #region constructors
        public TestMethodInfo()
        {

        }
        public TestMethodInfo(int testMethodId, string testMethodName, DateTime testMethodRunTime, int testMethodDuration, TestMethodRunStatus testMethodRunStatus, TestClassInfo testClassInfo)
        {
            this.testMethodName = testMethodName;
            this.testMethodId = testMethodId;
            this.testMethodRunTime = testMethodRunTime;
            this.testMethodRunDuration = testMethodDuration;
            this.testMethodRunStatus = testMethodRunStatus;
            this.testClass = testClassInfo;
        }
        #endregion

        #region Properties
        public int TestMethodId
        {
            get => testMethodId;
            set => testMethodId = value;
        }
        public string TestMethodName
        {
            get => testMethodName;
            set => testMethodName = value;
        }
        public DateTime TestMethodRunTime
        {
            get => testMethodRunTime;
            set => testMethodRunTime = value;
        }
        public int TestMethodRunDuration
        {
            get => testMethodRunDuration;
            set => testMethodRunDuration = value;
        }
        public TestMethodRunStatus TestMethodRunStatus
        {
            get => testMethodRunStatus;
            set => testMethodRunStatus = value;
        }
        //navigation property
        public TestClassInfo TestClass
        {
            get => testClass;
            set => testClass = value;
        }
        #endregion

        #region Object Class Methods
        public override string ToString()
        {
            return $"Method:{testMethodName}, Class:{testClass}, Status:{testMethodRunStatus}";
        }
        public override int GetHashCode()
        {
            int hash = 0;
            hash = this.testMethodName.GetHashCode();
            hash = hash * this.testMethodId.GetHashCode();
            return hash;
        }
        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                if (obj is TestMethodInfo)
                {
                    TestMethodInfo other = obj as TestMethodInfo;
                    if (this == other)
                        return true;
                    if (!this.testMethodId.Equals(other.testMethodId))
                        return false;
                    if (!this.testMethodName.Equals(other.testMethodName))
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
}
