//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /home/cthfvrl/MSE/code/ide-dev/Spring/src/Spring/src/antlr/PascalParser.g4 by ANTLR 4.9.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="PascalParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.1")]
[System.CLSCompliant(false)]
public interface IPascalParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] PascalParser.ProgramContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.compoundStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompoundStatement([NotNull] PascalParser.CompoundStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] PascalParser.StatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBody([NotNull] PascalParser.BodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.simpleStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleStatement([NotNull] PascalParser.SimpleStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.assigmnentStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssigmnentStatement([NotNull] PascalParser.AssigmnentStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignment([NotNull] PascalParser.AssignmentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.procedureStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProcedureStatement([NotNull] PascalParser.ProcedureStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.gotoStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGotoStatement([NotNull] PascalParser.GotoStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLabel([NotNull] PascalParser.LabelContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.structuredStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructuredStatement([NotNull] PascalParser.StructuredStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.conditionalStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConditionalStatement([NotNull] PascalParser.ConditionalStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.repetitiveStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRepetitiveStatement([NotNull] PascalParser.RepetitiveStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.caseStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCaseStatement([NotNull] PascalParser.CaseStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.case"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCase([NotNull] PascalParser.CaseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.caseRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCaseRange([NotNull] PascalParser.CaseRangeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstant([NotNull] PascalParser.ConstantContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.elsePart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElsePart([NotNull] PascalParser.ElsePartContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStatement([NotNull] PascalParser.IfStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForStatement([NotNull] PascalParser.ForStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.repeatStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRepeatStatement([NotNull] PascalParser.RepeatStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileStatement([NotNull] PascalParser.WhileStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.withStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWithStatement([NotNull] PascalParser.WithStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] PascalParser.ExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.simpleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleExpression([NotNull] PascalParser.SimpleExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTerm([NotNull] PascalParser.TermContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactor([NotNull] PascalParser.FactorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCall([NotNull] PascalParser.FunctionCallContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.actualParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitActualParameterList([NotNull] PascalParser.ActualParameterListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.unsignedConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnsignedConstant([NotNull] PascalParser.UnsignedConstantContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.setConstructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSetConstructor([NotNull] PascalParser.SetConstructorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.setGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSetGroup([NotNull] PascalParser.SetGroupContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.valueTypecast"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValueTypecast([NotNull] PascalParser.ValueTypecastContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PascalParser.addressFactor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddressFactor([NotNull] PascalParser.AddressFactorContext context);
}
