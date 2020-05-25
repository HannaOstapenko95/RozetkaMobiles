Imports System.CodeDom.Compiler

<Assembly: Global.Xunit.TestFramework("TechTalk.SpecFlow.xUnit.SpecFlowPlugin.XunitTestFrameworkWithAssemblyFixture", "TechTalk.SpecFlow.xUnit.SpecFlowPlugin")>
<Assembly: Global.TechTalk.SpecFlow.xUnit.SpecFlowPlugin.AssemblyFixture(GetType(PROJECT_ROOT_NAMESPACE_XUnitAssemblyFixture))>

<GeneratedCode("SpecFlow", "3.1.97")>
Public Class PROJECT_ROOT_NAMESPACE_XUnitAssemblyFixture
    Implements Global.System.IDisposable

    Private ReadOnly _currentAssembly As Global.System.Reflection.Assembly

    Public Sub New()
        _currentAssembly = GetType(PROJECT_ROOT_NAMESPACE_XUnitAssemblyFixture).Assembly
        Global.TechTalk.SpecFlow.TestRunnerManager.OnTestRunStart(_currentAssembly)
    End Sub


    Public Sub Dispose() Implements Global.System.IDisposable.Dispose
        Global.TechTalk.SpecFlow.TestRunnerManager.OnTestRunEnd(_currentAssembly)
    End Sub
End Class
