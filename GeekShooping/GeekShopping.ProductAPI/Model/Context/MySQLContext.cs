using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext :DbContext
    {
        
        public MySQLContext() { } //default constructor
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {

        }

    }
}
