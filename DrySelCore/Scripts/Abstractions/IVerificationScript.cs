using DrySelCore.Model;
using System.Collections.Generic;

namespace DrySelCore.Scripts.Abstractions
{
    public interface IVerificationScript
    {
        SortedDictionary<int, VerificationStep> Script { get; set; }

        void PrepareScript(IEnumerable<UIElement> uiElementList, IEnumerable<TestData> testDataList);
    }
}