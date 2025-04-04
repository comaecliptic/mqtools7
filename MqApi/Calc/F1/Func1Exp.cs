﻿using MqApi.Calc.Except;
using MqApi.Calc.Func;
using MqApi.Calc.Util;
using MqApi.Util;
namespace MqApi.Calc.F1{
	internal class Func1Exp : Func1{
		internal override double NumEvaluateDouble(double x){
			return Math.Exp(x);
		}
		internal override Tuple<double, double> NumEvaluateComplexDouble(double re, double im){
			throw new CannotEvaluateComplexDoubleException();
		}
		internal override bool HasComplexArgument => true;
		internal override ReturnType GetValueType(ReturnType returnType){
			return returnType == ReturnType.Integer ? ReturnType.Real : returnType;
		}
		internal override TreeNode RealPart(TreeNode re, TreeNode im){
			throw new CannotCalculateRealPartException();
		}
		internal override TreeNode ImaginaryPart(TreeNode re, TreeNode im){
			throw new CannotCalculateImaginaryPartException();
		}
		internal override TreeNode OuterDerivative(TreeNode x){
			return Exp(x);
		}
		internal override TreeNode IndefiniteIntegral(TreeNode x){
			return Exp(x);
		}
		internal override TreeNode OuterNthDerivative(TreeNode x, TreeNode n){
			return Exp(x);
		}
		internal override TreeNode DomainMin => negInfinity;
		internal override TreeNode DomainMax => posInfinity;
		internal override string ShortName => "exp";
		internal override string Name => "";
		internal override string Description => "";
		internal override DocumentType DescriptionType => DocumentType.PlainText;
		internal override Topic Topic => Topic.Unknown;
	}
}