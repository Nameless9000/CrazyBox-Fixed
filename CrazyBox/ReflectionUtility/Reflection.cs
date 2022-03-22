using System;
using System.Reflection;

namespace ReflectionUtility
{
	public static class Reflection
	{
		public static object CallMethod(this object o, string methodName, params object[] args)
		{
			System.Reflection.MethodInfo method = o.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
			bool flag = method != null;
			object result;
			if (flag)
			{
				result = method.Invoke(o, args);
			}
			else
			{
				result = null;
			}
			return result;
		}

		public static object CallStaticMethod(System.Type type, string methodName, params object[] args)
		{
			System.Reflection.MethodInfo method = type.GetMethod(methodName, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
			return method.Invoke(null, args);
		}

		public static object GetField(System.Type type, object instance, string fieldName)
		{
			System.Reflection.BindingFlags bindingAttr = System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic;
			System.Reflection.FieldInfo field = type.GetField(fieldName, bindingAttr);
			return field.GetValue(instance);
		}

		public static void SetField<T>(object originalObject, string fieldName, T newValue)
		{
			System.Reflection.BindingFlags bindingAttr = System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic;
			System.Reflection.FieldInfo field = originalObject.GetType().GetField(fieldName, bindingAttr);
			field.SetValue(originalObject, newValue);
		}
	}
}
