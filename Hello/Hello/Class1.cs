using System;

namespace Hello2 { 

	public class Class1
	{
		int age;

		public int setAge(int _age)
		{
			this.age = _age;
		}

		public void getAge()
		{
			return this.age;
		}

	}

	public class Salil
	{
		static void Main()
		{
			Class1 class1 = new Class1();
			class1.setAge(10);
			int gotAge = class1.getAge();
			Console.WriteLine(gotAge);
		}

	}

}

