namespace Symbion {
	public interface IShell : IService {
		object Status { set; }
		void Success(string message);
		void Failure(string message);
	}
}
