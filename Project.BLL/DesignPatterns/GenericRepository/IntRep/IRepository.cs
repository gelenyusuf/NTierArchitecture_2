using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Project.BLL.DesignPatterns.GenericRepository.IntRep
{
	public interface IRepository<T> where T:BaseEntity
	{

		//Raporlama 
		List<T> GetActives();
		List<T> GetPassives();

		List<T> GetModifies();
		List<T> GetAll();


		//Modifikasyon Komutları
		void Add(T item);
		void AddRange(List<T> list);

		void Update(T item);
		void UpdateRange(List<T> list);

		void Delete(T item);
		void DeleteRange(List<T> list);

		void Destroy(T item);
		void DestroyRange(List<T> list);


		//Linq
        List<T> Where(Expression<Func<T,bool>> exp);
		T FirstOrDefault(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);

		IQueryable<X> Select<X>(Expression<Func<T, X>> exp);


		//Find
		T Find(int id);


		//Get Last Datas
		List<T> GetLastDatas(int count=1);

		//Get First Datas
		List<T> GetFirstDatas(int count=1);

		//Get  Datas
		List<T> GetDatas(int count=1);


	}
}
