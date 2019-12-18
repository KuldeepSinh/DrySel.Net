namespace DrySelJSON.Scripts.Abstractions
{
    public interface IJSONTestScriptExecutor
    {
        void ExecuteInputScript(string uiElementsFilePath, string inputTestDataFilePath);
        void ExecuteVerificationScript(string uiElementsFilePath, string expectedTestDataFilePath);
    }
}