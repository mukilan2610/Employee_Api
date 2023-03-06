//using Employee_Api.Models;
//using System.Linq.Expressions;

//namespace Employee_Api.Repositores
//{
//    public class Repositores : IRepositores
//    {

//        private readonly EmployeeDBContext dbcontext;

//        public Repositores(EmployeeDBContext _dbcontext)
//        {
//            this.dbcontext = _dbcontext;
//        }

//        public IQueryable<T> AsQueryable<T>() where T : class
//        {
//            throw new NotImplementedException();
//        }

//        public IQueryable<T> Get<T>(params Expression<Func<T, object>>[] navigationProperties) where T : class
//        {
//            throw new NotImplementedException();
//        }

//        public IQueryable<T> Get<T>(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties) where T : class
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<T> Get<T>() where T : class
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
