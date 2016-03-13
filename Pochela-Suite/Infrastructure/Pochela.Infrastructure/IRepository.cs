using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pochela.Infrastructure
{
	public interface IQueryRepository<T> where T : class, new()
	{
		T GetById<TKey>(TKey Id);
		IEnumerable<T> Search(string filter);
		//IEnumerable<T> Search(Predicate<T>)
	}

	public interface ICommandRepository<T> where T : class, new()
	{
		void Save(T model);
		void Delete(T model);
		void Create(T model);
	}
}
