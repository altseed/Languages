using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace cs2ast
{
	enum Operations
	{
		Add,

	}
	class Walker : CSharpSyntaxWalker
	{
		private SemanticModel sema;
		public Walker(SemanticModel s) { sema = s; }
		public override void Visit(SyntaxNode node)
		{
			if (node != null)
			{
				Console.WriteLine("[Node  - Type: {0}, Kind: {1}]\n{2}\n", node.GetType().Name, ((SyntaxKind)node.RawKind).ToString(), node);

				var si = sema.GetSymbolInfo(node);
				var n = si.Symbol;
				if (n != null)
				{
					Console.WriteLine("Definition: {0}\n", n.OriginalDefinition.ToDisplayString());
				}

			}


			base.Visit(node);
		}

		override public void VisitToken(SyntaxToken token)
		{
			base.VisitToken(token);
		}

		public override void VisitTrivia(SyntaxTrivia trivia)
		{
			base.VisitTrivia(trivia);
		}

		public override void VisitBinaryExpression(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax node)
		{
			Console.WriteLine("binexp");
			node.CSharpKind();

			base.VisitBinaryExpression(node);
		}

		public override void VisitAccessorDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax node)
		{
			base.VisitAccessorDeclaration(node);
		}

		public override void VisitAccessorList(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax node)
		{
			base.VisitAccessorList(node);
		}
		public override void VisitAliasQualifiedName(Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax node)
		{
			base.VisitAliasQualifiedName(node);
		}

		public override void VisitAnonymousMethodExpression(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax node)
		{
			base.VisitAnonymousMethodExpression(node);
		}

		public override void VisitAnonymousObjectCreationExpression(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax node)
		{
			base.VisitAnonymousObjectCreationExpression(node);
		}

		public override void VisitAnonymousObjectMemberDeclarator(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax node)
		{
			base.VisitAnonymousObjectMemberDeclarator(node);
		}

		public override void VisitArgument(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax node)
		{
			base.VisitArgument(node);
		}

		public override void VisitArgumentList(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax node)
		{
			base.VisitArgumentList(node);
		}

		public override void VisitArrayCreationExpression(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax node)
		{
			base.VisitArrayCreationExpression(node);
		}

		public override void VisitArrayRankSpecifier(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax node)
		{
			base.VisitArrayRankSpecifier(node);
		}

		public override void VisitArrayType(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax node)
		{
			base.VisitArrayType(node);
		}

		public override void VisitAttribute(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax node)
		{
			base.VisitAttribute(node);
		}

		public override void VisitAttributeArgument(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax node)
		{
			base.VisitAttributeArgument(node);
		}

		public override void VisitAttributeArgumentList(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax node)
		{
			base.VisitAttributeArgumentList(node);
		}

		public override void VisitAttributeList(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax node)
		{
			base.VisitAttributeList(node);
		}

		public override void VisitAttributeTargetSpecifier(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax node)
		{
			base.VisitAttributeTargetSpecifier(node);
		}

		public override void VisitBadDirectiveTrivia(Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax node)
		{
			base.VisitBadDirectiveTrivia(node);
		}

		public override void VisitBaseClassWithArguments(Microsoft.CodeAnalysis.CSharp.Syntax.BaseClassWithArgumentsSyntax node)
		{
			base.VisitBaseClassWithArguments(node);
		}

		public override void VisitBaseExpression(Microsoft.CodeAnalysis.CSharp.Syntax.BaseExpressionSyntax node)
		{
			base.VisitBaseExpression(node);
		}

		public override void VisitBaseList(Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax node)
		{
			base.VisitBaseList(node);
		}

		public override void VisitBlock(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax node)
		{
			base.VisitBlock(node);
		}
		public override void VisitBracketedArgumentList(Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax node)
		{
			base.VisitBracketedArgumentList(node);
		}

		public override void VisitBracketedParameterList(Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax node)
		{
			base.VisitBracketedParameterList(node);
		}
		public override void VisitBreakStatement(Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax node)
		{
			base.VisitBreakStatement(node);
		}

		public override void VisitCastExpression(Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax node)
		{
			base.VisitCastExpression(node);
		}

		public override void VisitCatchClause(Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax node)
		{
			base.VisitCatchClause(node);
		}

		public override void VisitCatchDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax node)
		{
			base.VisitCatchDeclaration(node);
		}

		public override void VisitCatchFilterClause(Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax node)
		{
			base.VisitCatchFilterClause(node);
		}

		public override void VisitCheckedExpression(Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax node)
		{
			base.VisitCheckedExpression(node);
		}

		public override void VisitCheckedStatement(Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax node)
		{
			base.VisitCheckedStatement(node);
		}

		public override void VisitClassDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax node)
		{
			base.VisitClassDeclaration(node);
		}

		public override void VisitClassOrStructConstraint(Microsoft.CodeAnalysis.CSharp.Syntax.ClassOrStructConstraintSyntax node)
		{
			base.VisitClassOrStructConstraint(node);
		}

		public override void VisitCompilationUnit(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax node)
		{
			base.VisitCompilationUnit(node);
		}

		public override void VisitConditionalAccessExpression(Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax node)
		{
			base.VisitConditionalAccessExpression(node);
		}

		public override void VisitConditionalExpression(Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax node)
		{
			base.VisitConditionalExpression(node);
		}

		public override void VisitConstructorConstraint(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorConstraintSyntax node)
		{
			base.VisitConstructorConstraint(node);
		}

		public override void VisitConstructorDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax node)
		{
			base.VisitConstructorDeclaration(node);
		}

		public override void VisitConstructorInitializer(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax node)
		{
			base.VisitConstructorInitializer(node);
		}

		public override void VisitContinueStatement(Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax node)
		{
			base.VisitContinueStatement(node);
		}

		public override void VisitConversionOperatorDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax node)
		{
			base.VisitConversionOperatorDeclaration(node);
		}

		public override void VisitConversionOperatorMemberCref(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax node)
		{
			base.VisitConversionOperatorMemberCref(node);
		}

		public override void VisitCrefBracketedParameterList(Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax node)
		{
			base.VisitCrefBracketedParameterList(node);
		}
		public override void VisitCrefParameter(Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax node)
		{
			base.VisitCrefParameter(node);
		}

		public override void VisitCrefParameterList(Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax node)
		{
			base.VisitCrefParameterList(node);
		}

		public override void VisitDeclarationExpression(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax node)
		{
			base.VisitDeclarationExpression(node);
		}

		public override void VisitDefaultExpression(Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax node)
		{
			base.VisitDefaultExpression(node);
		}

		public override void VisitDefineDirectiveTrivia(Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax node)
		{
			base.VisitDefineDirectiveTrivia(node);
		}

		public override void VisitDelegateDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax node)
		{
			base.VisitDelegateDeclaration(node);
		}

		public override void VisitDestructorDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax node)
		{
			base.VisitDestructorDeclaration(node);
		}

		public override void VisitDocumentationCommentTrivia(Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax node)
		{
			base.VisitDocumentationCommentTrivia(node);
		}

		public override void VisitDoStatement(Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax node)
		{
			base.VisitDoStatement(node);
		}

		public override void VisitElementAccessExpression(Microsoft.CodeAnalysis.CSharp.Syntax.ElementAccessExpressionSyntax node)
		{
			base.VisitElementAccessExpression(node);
		}

		public override void VisitElementBindingExpression(Microsoft.CodeAnalysis.CSharp.Syntax.ElementBindingExpressionSyntax node)
		{
			base.VisitElementBindingExpression(node);
		}

		public override void VisitElifDirectiveTrivia(Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax node)
		{
			base.VisitElifDirectiveTrivia(node);
		}

		public override void VisitElseClause(Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax node)
		{
			base.VisitElseClause(node);
		}

		public override void VisitElseDirectiveTrivia(Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax node)
		{
			base.VisitElseDirectiveTrivia(node);
		}

		public override void VisitEmptyStatement(Microsoft.CodeAnalysis.CSharp.Syntax.EmptyStatementSyntax node)
		{
			base.VisitEmptyStatement(node);
		}

		public override void VisitEndIfDirectiveTrivia(Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax node)
		{
			base.VisitEndIfDirectiveTrivia(node);
		}

		public override void VisitEndRegionDirectiveTrivia(Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax node)
		{
			base.VisitEndRegionDirectiveTrivia(node);
		}

		public override void VisitEnumDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax node)
		{
			base.VisitEnumDeclaration(node);
		}

		public override void VisitEnumMemberDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax node)
		{
			base.VisitEnumMemberDeclaration(node);
		}

		public override void VisitEqualsValueClause(Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax node)
		{
			base.VisitEqualsValueClause(node);
		}

		public override void VisitErrorDirectiveTrivia(Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax node)
		{
			base.VisitErrorDirectiveTrivia(node);
		}

		public override void VisitErrorDirectiveTrivia(Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax node)
		{
			base.VisitErrorDirectiveTrivia(node);
		}

		public override void VisitEventDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax node)
		{
			base.VisitEventDeclaration(node);
		}

		public override void VisitEventFieldDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax node)
		{
			base.VisitEventFieldDeclaration(node);
		}

		public override void VisitExplicitInterfaceSpecifier(Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax node)
		{
			base.VisitExplicitInterfaceSpecifier(node);
		}

		public override void VisitExpressionStatement(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax node)
		{
			base.VisitExpressionStatement(node);
		}

		public override void VisitExpressionStatement(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax node)
		{
			base.VisitExpressionStatement(node);
		}

		public override void VisitExternAliasDirective(Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax node)
		{
			base.VisitExternAliasDirective(node);
		}

		public override void VisitFieldDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax node)
		{
			base.VisitFieldDeclaration(node);
		}

		public override void VisitFinallyClause(Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax node)
		{
			base.VisitFinallyClause(node);
		}

		public override void VisitFixedStatement(Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax node)
		{
			base.VisitFixedStatement(node);
		}

		public override void VisitForEachStatement(Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax node)
		{
			base.VisitForEachStatement(node);
		}

		public override void VisitForStatement(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax node)
		{
			base.VisitForStatement(node);
		}

		public override void VisitFromClause(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax node)
		{
			base.VisitFromClause(node);
		}

		public override void VisitGenericName(Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax node)
		{
			base.VisitGenericName(node);
		}

		public override void VisitGlobalStatement(Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax node)
		{
			base.VisitGlobalStatement(node);
		}

		public override void VisitGotoStatement(Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax node)
		{
			base.VisitGotoStatement(node);
		}

		public override void VisitGroupClause(Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax node)
		{
			base.VisitGroupClause(node);
		}

		public override void VisitIdentifierName(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax node)
		{
			base.VisitIdentifierName(node);
		}

		public override void VisitIfDirectiveTrivia(Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax node)
		{
			base.VisitIfDirectiveTrivia(node);
		}

		public override void VisitIfStatement(Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax node)
		{
			base.VisitIfStatement(node);
		}

		public override void VisitImplicitArrayCreationExpression(Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax node)
		{
			base.VisitImplicitArrayCreationExpression(node);
		}

		public override void VisitIncompleteMember(Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax node)
		{
			base.VisitIncompleteMember(node);
		}

		public override void VisitIndexerDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax node)
		{
			base.VisitIndexerDeclaration(node);
		}

		public override void VisitIndexerMemberCref(Microsoft.CodeAnalysis.CSharp.Syntax.IndexerMemberCrefSyntax node)
		{
			base.VisitIndexerMemberCref(node);
		}

		public override void VisitInitializerExpression(Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax node)
		{
			base.VisitInitializerExpression(node);
		}

		public override void VisitInterfaceDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax node)
		{
			base.VisitInterfaceDeclaration(node);
		}

		public override void VisitInvocationExpression(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax node)
		{
			base.VisitInvocationExpression(node);
		}

		public override void VisitJoinClause(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax node)
		{
			base.VisitJoinClause(node);
		}

		public override void VisitJoinIntoClause(Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax node)
		{
			base.VisitJoinIntoClause(node);
		}

		public override void VisitLabeledStatement(Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax node)
		{
			base.VisitLabeledStatement(node);
		}

		public override void VisitLeadingTrivia(SyntaxToken token)
		{
			base.VisitLeadingTrivia(token);
		}

		public override void VisitLetClause(Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax node)
		{
			base.VisitLetClause(node);
		}

		public override void VisitLineDirectiveTrivia(Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax node)
		{
			base.VisitLineDirectiveTrivia(node);
		}

		public override void VisitLiteralExpression(Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax node)
		{
			base.VisitLiteralExpression(node);
		}

		public override void VisitLocalDeclarationStatement(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax node)
		{
			base.VisitLocalDeclarationStatement(node);
		}

		public override void VisitLockStatement(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax node)
		{
			base.VisitLockStatement(node);
		}

		public override void VisitMakeRefExpression(Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax node)
		{
			base.VisitMakeRefExpression(node);
		}

		public override void VisitMemberAccessExpression(Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax node)
		{
			base.VisitMemberAccessExpression(node);
		}

		public override void VisitMemberBindingExpression(Microsoft.CodeAnalysis.CSharp.Syntax.MemberBindingExpressionSyntax node)
		{
			base.VisitMemberBindingExpression(node);
		}

		public override void VisitMethodDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax node)
		{
			base.VisitMethodDeclaration(node);
		}

		public override void VisitNameColon(Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax node)
		{
			base.VisitNameColon(node);
		}

		public override void VisitNameEquals(Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax node)
		{
			base.VisitNameEquals(node);
		}

		public override void VisitNameMemberCref(Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax node)
		{
			base.VisitNameMemberCref(node);
		}

		public override void VisitNamespaceDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax node)
		{
			base.VisitNamespaceDeclaration(node);
		}

		public override void VisitNullableType(Microsoft.CodeAnalysis.CSharp.Syntax.NullableTypeSyntax node)
		{
			base.VisitNullableType(node);
		}

		public override void VisitObjectCreationExpression(Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax node)
		{
			base.VisitObjectCreationExpression(node);
		}

		public override void VisitOmittedArraySizeExpression(Microsoft.CodeAnalysis.CSharp.Syntax.OmittedArraySizeExpressionSyntax node)
		{
			base.VisitOmittedArraySizeExpression(node);
		}

		public override void VisitOmittedTypeArgument(Microsoft.CodeAnalysis.CSharp.Syntax.OmittedTypeArgumentSyntax node)
		{
			base.VisitOmittedTypeArgument(node);
		}

		public override void VisitOperatorDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax node)
		{
			base.VisitOperatorDeclaration(node);
		}

		public override void VisitOperatorMemberCref(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax node)
		{
			base.VisitOperatorMemberCref(node);
		}

		public override void VisitOrderByClause(Microsoft.CodeAnalysis.CSharp.Syntax.OrderByClauseSyntax node)
		{
			base.VisitOrderByClause(node);
		}

		public override void VisitOrdering(Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax node)
		{
			base.VisitOrdering(node);
		}

		public override void VisitParameter(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax node)
		{
			base.VisitParameter(node);
		}

		public override void VisitParameterList(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax node)
		{
			base.VisitParameterList(node);
		}

		public override void VisitParenthesizedExpression(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax node)
		{
			base.VisitParenthesizedExpression(node);
		}

		public override void VisitParenthesizedLambdaExpression(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax node)
		{
			base.VisitParenthesizedLambdaExpression(node);
		}

		public override void VisitPointerType(Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax node)
		{
			base.VisitPointerType(node);
		}

		public override void VisitPostfixUnaryExpression(Microsoft.CodeAnalysis.CSharp.Syntax.PostfixUnaryExpressionSyntax node)
		{
			base.VisitPostfixUnaryExpression(node);
		}

		public override void VisitPragmaChecksumDirectiveTrivia(Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax node)
		{
			base.VisitPragmaChecksumDirectiveTrivia(node);
		}

		public override void VisitPragmaWarningDirectiveTrivia(Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax node)
		{
			base.VisitPragmaWarningDirectiveTrivia(node);
		}

		public override void VisitPredefinedType(Microsoft.CodeAnalysis.CSharp.Syntax.PredefinedTypeSyntax node)
		{
			base.VisitPredefinedType(node);
		}

		public override void VisitPrefixUnaryExpression(Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax node)
		{
			base.VisitPrefixUnaryExpression(node);
		}

		public override void VisitPropertyDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax node)
		{
			base.VisitPropertyDeclaration(node);
		}

		public override void VisitQualifiedCref(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax node)
		{
			base.VisitQualifiedCref(node);
		}

		public override void VisitQualifiedName(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax node)
		{
			base.VisitQualifiedName(node);
		}

		public override void VisitQueryBody(Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax node)
		{
			base.VisitQueryBody(node);
		}

		public override void VisitQueryContinuation(Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax node)
		{
			base.VisitQueryContinuation(node);
		}

		public override void VisitQueryExpression(Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax node)
		{
			base.VisitQueryExpression(node);
		}

		public override void VisitReferenceDirectiveTrivia(Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax node)
		{
			base.VisitReferenceDirectiveTrivia(node);
		}

		public override void VisitRefTypeExpression(Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax node)
		{
			base.VisitRefTypeExpression(node);
		}

		public override void VisitRefValueExpression(Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax node)
		{
			base.VisitRefValueExpression(node);
		}

		public override void VisitRegionDirectiveTrivia(Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax node)
		{
			base.VisitRegionDirectiveTrivia(node);
		}

		public override void VisitReturnStatement(Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax node)
		{
			base.VisitReturnStatement(node);
		}

		public override void VisitSelectClause(Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax node)
		{
			base.VisitSelectClause(node);
		}

		public override void VisitSimpleLambdaExpression(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax node)
		{
			base.VisitSimpleLambdaExpression(node);
		}

		public override void VisitSizeOfExpression(Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax node)
		{
			base.VisitSizeOfExpression(node);
		}

		public override void VisitSkippedTokensTrivia(Microsoft.CodeAnalysis.CSharp.Syntax.SkippedTokensTriviaSyntax node)
		{
			base.VisitSkippedTokensTrivia(node);
		}

		public override void VisitStackAllocArrayCreationExpression(Microsoft.CodeAnalysis.CSharp.Syntax.StackAllocArrayCreationExpressionSyntax node)
		{
			base.VisitStackAllocArrayCreationExpression(node);
		}

		public override void VisitStructDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax node)
		{
			base.VisitStructDeclaration(node);
		}

		public override void VisitSwitchLabel(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax node)
		{
			base.VisitSwitchLabel(node);
		}

		public override void VisitSwitchSection(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax node)
		{
			base.VisitSwitchSection(node);
		}

		public override void VisitSwitchStatement(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax node)
		{
			base.VisitSwitchStatement(node);
		}

		public override void VisitThisExpression(Microsoft.CodeAnalysis.CSharp.Syntax.ThisExpressionSyntax node)
		{
			base.VisitThisExpression(node);
		}

		public override void VisitThrowStatement(Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax node)
		{
			base.VisitThrowStatement(node);
		}

		public override void VisitTrailingTrivia(SyntaxToken token)
		{
			base.VisitTrailingTrivia(token);
		}

		public override void VisitTryStatement(Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax node)
		{
			base.VisitTryStatement(node);
		}

		public override void VisitTypeArgumentList(Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax node)
		{
			base.VisitTypeArgumentList(node);
		}

		public override void VisitTypeConstraint(Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax node)
		{
			base.VisitTypeConstraint(node);
		}

		public override void VisitTypeCref(Microsoft.CodeAnalysis.CSharp.Syntax.TypeCrefSyntax node)
		{
			base.VisitTypeCref(node);
		}

		public override void VisitTypeOfExpression(Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax node)
		{
			base.VisitTypeOfExpression(node);
		}

		public override void VisitTypeParameter(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax node)
		{
			base.VisitTypeParameter(node);
		}

		public override void VisitTypeParameterConstraintClause(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax node)
		{
			base.VisitTypeParameterConstraintClause(node);
		}

		public override void VisitTypeParameterList(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax node)
		{
			base.VisitTypeParameterList(node);
		}

		public override void VisitUndefDirectiveTrivia(Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax node)
		{
			base.VisitUndefDirectiveTrivia(node);
		}

		public override void VisitUnsafeStatement(Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax node)
		{
			base.VisitUnsafeStatement(node);
		}

		public override void VisitUsingDirective(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax node)
		{
			base.VisitUsingDirective(node);
		}

		public override void VisitUsingStatement(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax node)
		{
			base.VisitUsingStatement(node);
		}

		public override void VisitVariableDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax node)
		{
			base.VisitVariableDeclaration(node);
		}

		public override void VisitVariableDeclarator(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax node)
		{
			base.VisitVariableDeclarator(node);
		}

		public override void VisitWarningDirectiveTrivia(Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax node)
		{
			base.VisitWarningDirectiveTrivia(node);
		}

		public override void VisitWhereClause(Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax node)
		{
			base.VisitWhereClause(node);
		}

		public override void VisitWhileStatement(Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax node)
		{
			base.VisitWhileStatement(node);
		}

		public override void VisitXmlCDataSection(Microsoft.CodeAnalysis.CSharp.Syntax.XmlCDataSectionSyntax node)
		{
			base.VisitXmlCDataSection(node);
		}

		public override void VisitXmlComment(Microsoft.CodeAnalysis.CSharp.Syntax.XmlCommentSyntax node)
		{
			base.VisitXmlComment(node);
		}

		public override void VisitXmlCrefAttribute(Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax node)
		{
			base.VisitXmlCrefAttribute(node);
		}

		public override void VisitXmlElement(Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax node)
		{
			base.VisitXmlElement(node);
		}

		public override void VisitXmlElementEndTag(Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax node)
		{
			base.VisitXmlElementEndTag(node);
		}

		public override void VisitXmlElementStartTag(Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax node)
		{
			base.VisitXmlElementStartTag(node);
		}

		public override void VisitXmlEmptyElement(Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax node)
		{
			base.VisitXmlEmptyElement(node);
		}

		public override void VisitXmlName(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax node)
		{
			base.VisitXmlName(node);
		}

		public override void VisitXmlNameAttribute(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax node)
		{
			base.VisitXmlNameAttribute(node);
		}

		public override void VisitXmlPrefix(Microsoft.CodeAnalysis.CSharp.Syntax.XmlPrefixSyntax node)
		{
			base.VisitXmlPrefix(node);
		}

		public override void VisitXmlProcessingInstruction(Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax node)
		{
			base.VisitXmlProcessingInstruction(node);
		}

		public override void VisitXmlText(Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextSyntax node)
		{
			base.VisitXmlText(node);
		}

		public override void VisitXmlTextAttribute(Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax node)
		{
			base.VisitXmlTextAttribute(node);
		}

		public override void VisitYieldStatement(Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax node)
		{
			base.VisitYieldStatement(node);
		}



	}




	class Parser
	{
		public void Parse()
		{
			var code = System.IO.File.ReadAllText("Program.cs");

			var syntaxTree = CSharpSyntaxTree.ParseText(code);
			var rootNode = syntaxTree.GetRoot();


			var assemblyPath = System.IO.Path.GetDirectoryName(typeof(object).Assembly.Location);
			var mscorelib = new MetadataFileReference(System.IO.Path.Combine(assemblyPath, "mscorlib.dll"));

			var compilation = Microsoft.CodeAnalysis.CSharp.CSharpCompilation.Create(
						"Compilation",
						syntaxTrees: new[] { syntaxTree },
						references: new[] { mscorelib },
						options: new Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions(
												  Microsoft.CodeAnalysis.OutputKind.ConsoleApplication));

			var semanticModel = compilation.GetSemanticModel(syntaxTree);

			var decl = semanticModel.GetDeclarationDiagnostics();
			var methodBodies = semanticModel.GetMethodBodyDiagnostics();

			var type = compilation.GetTypeByMetadataName("cs2ast.Program");

			var walker = new Walker(semanticModel);
			walker.Visit(semanticModel.SyntaxTree.GetRoot());

			System.Console.ReadKey(false);

		}
	}
}
