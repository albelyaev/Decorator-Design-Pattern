using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( "***\r\n Begin program - no logging\r\n" );

			IRepository<Customer> customerRepository = new Repository<Customer>();

			var customer = new Customer
			{
				Id = 1,
				Name = "Customer 1",
				Address = "Address 1"
			};

			customerRepository.Add(customer);
			customerRepository.Update(customer);
			customerRepository.Delete(customer);

			Console.WriteLine( "\r\nEnd program - no logging\r\n***" );
			Console.ReadKey();
		}
	}
}
