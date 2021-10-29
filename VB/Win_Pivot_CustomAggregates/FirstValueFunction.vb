Imports DevExpress.Data.Filtering
Imports DevExpress.DataAccess.ExpressionEditor
Imports DevExpress.DataProcessing.Criteria

Namespace FirstValueAggregate
	Friend Class FirstValueAggregateFunction
		Implements ICustomAggregateFunction, ICustomFunctionOperatorBrowsable, ICustomFunctionCategory

		Public ReadOnly Property Name() As String Implements DevExpress.Data.Filtering.ICustomFunctionOperator.Name
			Get
				Return "FirstValue"
			End Get
		End Property

		Public ReadOnly Property MinOperandCount() As Integer Implements ICustomFunctionOperatorBrowsable.MinOperandCount
			Get
				Return 1
			End Get
		End Property

		Public ReadOnly Property MaxOperandCount() As Integer Implements ICustomFunctionOperatorBrowsable.MaxOperandCount
			Get
				Return 1
			End Get
		End Property

		Public ReadOnly Property Description() As String Implements ICustomFunctionOperatorBrowsable.Description
			Get
			Return "Displays the first value of the field"
			End Get
		End Property

		Public ReadOnly Property Category() As FunctionCategory Implements ICustomFunctionOperatorBrowsable.Category
			Get
				Return DevExpress.Data.Filtering.FunctionCategory.Text
			End Get
		End Property

		Public ReadOnly Property FunctionCategory() As String Implements ICustomFunctionCategory.FunctionCategory
			Get
				Return "Aggregate"
			End Get
		End Property

		Public Function Evaluate(ParamArray ByVal operands() As Object) As Object Implements DevExpress.Data.Filtering.ICustomFunctionOperator.Evaluate
			Throw New NotImplementedException()
		End Function

		Public Function GetAggregationContextType(ByVal inputType As Type) As Type Implements ICustomAggregateFunction.GetAggregationContextType
			Return GetType(FirstValueAggregateState(Of )).MakeGenericType(inputType)
		End Function

		Public Function IsValidOperandCount(ByVal count As Integer) As Boolean Implements ICustomFunctionOperatorBrowsable.IsValidOperandCount
			Return count <= MaxOperandCount AndAlso count >= MinOperandCount
		End Function

		Public Function IsValidOperandType(ByVal operandIndex As Integer, ByVal operandCount As Integer, ByVal type As Type) As Boolean Implements ICustomFunctionOperatorBrowsable.IsValidOperandType
			Return IsValidOperandCount(operandCount) AndAlso operandIndex = 0
		End Function

		Public Function ResultType(ParamArray ByVal operands() As Type) As Type Implements DevExpress.Data.Filtering.ICustomFunctionOperator.ResultType
			Return operands(0)
		End Function
	End Class

	Friend Class FirstValueAggregateState(Of TInput)
		Implements ICustomAggregateFunctionContext(Of TInput, TInput)

		Private isSet As Boolean = False
		Private firstValue As TInput
		Public Sub Process(ByVal value As TInput) Implements ICustomAggregateFunctionContext(Of TInput, TInput).Process
			If Not isSet Then
				firstValue = value
				isSet = True
			End If
		End Sub

		Private Function GetResult() As TInput Implements ICustomAggregateFunctionContext(Of TInput, TInput).GetResult
			Return If(isSet, firstValue, Nothing)
		End Function
	End Class
End Namespace
