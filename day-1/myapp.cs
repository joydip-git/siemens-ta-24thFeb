using System;
using MySystem;
using MySystem.DataAccess;
using MySystem.Drawing;

namespace Client
{
	class Program
	{
		static void Main()
		{
			//Fully-qualified naming
			MySystem.DataAccess.SqlDataAccess.GetData();
			//OracleDataAccess.GetData();
			Circle.Draw();
			MyConsole.Write("write this");
			MsAccessDataAccess.GetData();
		}
	}
}