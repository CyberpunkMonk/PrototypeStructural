using System;

namespace PrototypeStructural {
	/// <summary>
	/// MainApp startup class
	/// </summary>
	class MainApp {
		/// <summary>
		/// Defines the entry point of the application.
		/// </summary>
		static void Main() {
			//Create two instances and clone each

			ConcretePrototype1 p1 = new ConcretePrototype1("I");
			ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
			Console.WriteLine("Cloned: {0}",c1.Id);

			ConcretePrototype2 p2 = new ConcretePrototype2("II");
			ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
			Console.WriteLine("Cloned: {0}",c2.Id);

			//Wait for user
			Console.ReadKey();
		}
	}

	/// <summary>
	/// The "Prototype" abstract class
	/// </summary>
	abstract class Prototype {
		private string _id;

		//C'tor
		public Prototype(string id) {
			this._id = id;
		}

		public string Id {
			get { return _id; }
		}

		public abstract Prototype Clone();
	}

	/// <summary>
	/// A "ConcretePrototype" class
	/// </summary>
	/// <seealso cref="PrototypeStructural.Prototype" />
	class ConcretePrototype1:Prototype{
		//C'tor
		public ConcretePrototype1(string id) : base(id) { }
		//Returns a shallow copy
		public override Prototype Clone() {
			return (Prototype)this.MemberwiseClone();
		}
	}

	/// <summary>
	/// A "ConcretePrototype" class
	/// </summary>
	/// <seealso cref="PrototypeStructural.Prototype" />
	class ConcretePrototype2 : Prototype {
		//C'tor
		public ConcretePrototype2(string id) : base(id) { }
		//Returns a shallow copy
		public override Prototype Clone() {
			return (Prototype)this.MemberwiseClone();
		}
	}
}
