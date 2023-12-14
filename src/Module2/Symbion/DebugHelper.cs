using System;
using System.Diagnostics;
using System.Reflection;

namespace Symbion {
	public static class DebugHelper {
		public static void ShowProperties(this object obj) {
			PropertyInfo[] props = obj.GetType().GetProperties();
			foreach (PropertyInfo prop in props) Console.WriteLine("{0}={1}",
				prop.Name, prop.GetValue(obj, null));
		}

		[Conditional("DEBUG")]
		public static void ShowLoadedAssemblies() {
			AppDomain domain = AppDomain.CurrentDomain;
			Assembly[] assemblies = domain.GetAssemblies();
			foreach (Assembly assembly in assemblies)
				Console.WriteLine(assembly.FullName);
		}

		[Conditional("DEBUG")]
		public static void ShowTypes(this Assembly assembly) {
			Type[] types = assembly.GetExportedTypes();
			Console.WriteLine("Types in assembly: {0}", assembly.FullName);
			foreach (Type type in types) Console.WriteLine("\t{0}", type.FullName);
		}

		public static void ShowFields(this Type type) {
			FieldInfo[] items = type.GetFields(); Console.WriteLine("\nFields:");
			foreach (FieldInfo item in items)
				Console.WriteLine("\t{0},{1}", item.Name, item.FieldType);
		}
		public static void ShowProperties(this Type type) {
			PropertyInfo[] items = type.GetProperties(); Console.WriteLine("\nProperties:");
			foreach (PropertyInfo item in items)
				Console.WriteLine("\t{0},{1}", item.Name, item.PropertyType);
		}
		public static void ShowEvents(this Type type) {
			EventInfo[] items = type.GetEvents(); Console.WriteLine("\nEvents:");
			foreach (EventInfo item in items)
				Console.WriteLine("\t{0},{1}", item.Name, item.EventHandlerType);
		}
		public static void ShowConstructors(this Type type) {
			ConstructorInfo[] items = type.GetConstructors(); Console.WriteLine("\nConstructors:");
			foreach (ConstructorInfo item in items) {
				Console.WriteLine("\t{0}", item.Name);
				ParameterInfo[] parameters = item.GetParameters();
				foreach (ParameterInfo param in parameters)
					Console.WriteLine("\t\t{0},{1}", param.Name, param.ParameterType);
			}
		}
		public static void ShowMethods(this Type type) {
			MethodInfo[] items = type.GetMethods(); Console.WriteLine("\nMethods:");
			foreach (MethodInfo item in items) {
				Console.WriteLine("\t{0},{1},{2}",
				item.Name, item.ReturnType, item.IsStatic ? "(S)" : "");
				ParameterInfo[] parameters = item.GetParameters();
				foreach (ParameterInfo param in parameters)
					Console.WriteLine("\t\t{0},{1}", param.Name, param.ParameterType);
			}
		}

		public static void ShowTypeInfo(this Type type) {
			Console.WriteLine("Name: {0}", type.Name);
			Console.WriteLine("Namespace: {0}", type.Namespace);
			Console.WriteLine("FullName: {0}", type.FullName);
			Console.WriteLine("BaseType: {0}", type.BaseType);
			Console.WriteLine("Assembly: {0}", type.Assembly.FullName);
			Console.WriteLine("IsEnum: {0}", type.IsEnum);
			Console.WriteLine("IsClass: {0}", type.IsClass);
			Console.WriteLine("IsValueType: {0}", type.IsValueType);
			Console.WriteLine("IsInterface: {0}", type.IsInterface);
			if (type.IsClass || type.IsValueType) {
				type.ShowFields();
				type.ShowProperties();
				type.ShowEvents();
				type.ShowConstructors();
				type.ShowMethods();
			}
		}
	}
}
