// cs0617,cs : 'MyNamedArg' is not a valid named attribute argument. Named attribute arguments must be fields which are not readonly, static or const, or properties with a set accessor which are not static.
// Line : 20

using System;

[AttributeUsage (AttributeTargets.Class, AllowMultiple = true)]
	public class SimpleAttribute : Attribute {

		string name = null;

		public readonly string MyNamedArg;
		
		public SimpleAttribute (string name)
		{
			this.name = name;
		}

	}

[Simple ("Dummy", MyNamedArg = "Dude!")]
	public class Blah {

		public static void Main ()
		{
		}
	}
