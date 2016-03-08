using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pochela.Infrastructure
{
	public interface IQueryRepository<T> where T : BaseEntity
	{
		T GetById<TKey>(TKey Id);
		IEnumerable<T> Search(Expression<Func<T, bool>> criteria);
	}

	public interface ICommandRepository<T> where T : BaseEntity
	{
		void Save(T model);
		void Delete(T model);
		void Create(T model);
	}
}
