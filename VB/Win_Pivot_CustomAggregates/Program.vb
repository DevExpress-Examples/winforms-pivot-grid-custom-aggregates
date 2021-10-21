Imports Dashboard_FirstValueAggregate
Imports DevExpress.Data.Filtering
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace WinPivot_CustomFunctions
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			CriteriaOperator.RegisterCustomFunction(New FirstValueAggregateFunction())
			Application.Run(New Form1())
		End Sub
	End Module
End Namespace
