using System;
using System.Collections.Generic;
using System.Reflection;

namespace Symbion {
	public static class ServiceRepository {
		private static Dictionary<Type, IService> _services;

		static ServiceRepository() {
			_services = new Dictionary<Type, IService>();
		}

		public static void AddServices(this IModule module) {
			Assembly assembly = module.GetType().Assembly;
			Type[] types = assembly.GetExportedTypes();
			foreach (Type type in types) {
				if (!type.IsClass) continue;
				var attributes = (ServiceAttribute[])type.GetCustomAttributes(
					typeof(ServiceAttribute), false);
				//	var attributes = type.GetCustomAttributes<ServiceAttribute>();
				if (attributes.Length == 0) continue;
				var serviceObject = (IService)Activator.CreateInstance(type);
				foreach (ServiceAttribute attribute in attributes) {
					Type serviceType = attribute.ServiceType;
					if (!_services.ContainsKey(serviceType))
						_services.Add(serviceType, serviceObject);
				}
			}
		}

		public static bool Add(Type serviceType, IService serviceObject) {
			if (!_services.ContainsKey(serviceType)) {
				_services.Add(serviceType, serviceObject);
				return true;
			}
			return false;
		}

		public static bool Add<TService>(this TService serviceObject) where TService : IService {
			Type serviceType = typeof(TService);
			if (!_services.ContainsKey(serviceType)) {
				_services.Add(serviceType, serviceObject);
				return true;
			}
			return false;
		}

		public static IService Get(Type serviceType) {
			IService serviceObject = null;
			_services.TryGetValue(serviceType, out serviceObject);
			return serviceObject;
		}

		public static TService Get<TService>() where TService : IService {
			Type serviceType = typeof(TService);
			IService serviceObject = null;
			_services.TryGetValue(serviceType, out serviceObject);
			return (TService)serviceObject;
		}

	}
}
