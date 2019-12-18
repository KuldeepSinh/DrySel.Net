using DrySelCore.Model;
using System.Collections.Generic;

namespace DrySelCore.Scripts.Abstractions
{
    public interface IInputScript
    {
        SortedDictionary<int, InputStep> Script { get; set; }

        void PrepareScript(IEnumerable<UIElement> uiElementList, IEnumerable<TestData> testDataList);
    }
}