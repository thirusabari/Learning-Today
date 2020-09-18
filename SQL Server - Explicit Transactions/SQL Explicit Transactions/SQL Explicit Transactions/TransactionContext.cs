using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace SQL_Explicit_Transactions
{
	public partial class TransactionContext : DbContext
	{
		public TransactionContext()
			: base("name=TransactionContext")
		{
		}

	}
}
