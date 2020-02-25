using System;

namespace MySystem
{
	namespace DataAccess
	{
		public class SqlDataAccess
		{
			public static string GetData()
			{
			return "data from sql server";
			}
		}
		public class OracleDataAccess
		{
			public static string GetData()
			{
				return "data from oracle db";
			}
		}
	}
	namespace Drawing
	{
		public class Circle
		{
			public static string Draw()
			{
			return "drawing circle";
			}
		}

		public class Triangle
		{
			public static string Draw()
			{
				return "drawing triangle";
			}
		}
	}
	public class MyConsole
	{
		public static void Write(object data)
		{
		}
		public static string Read()
		{
			return "data from console";
		}
	}
}