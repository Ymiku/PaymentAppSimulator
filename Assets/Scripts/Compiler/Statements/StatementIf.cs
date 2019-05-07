﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Compiler
{
	public class StatementIf :  StatementBase{
		protected override void GenerateGrammar ()
		{
			grammar.Push ("if(");
			grammar.Push(Attribute.Bool);
			grammar.Push("){");
			grammar.Push (Attribute.Void);
			grammar.Push("}");
		}
		public override Parameter Execute ()
		{
			if (GetParam (0)) {
				StatementBase statement = GetParam (1);
				statement.Execute ();
			}
			return new Parameter ();
		}
	}
}