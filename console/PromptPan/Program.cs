using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromptPan
{
    class Program
    {
        static void Main(string[] args)
        {
            CrudCustomer CS = new CrudCustomer();
            CS.insertcustomer();
            CS.updatecustomer();
            CS.deletecutomer();
            CS.selectcustomer();

            CrudBuy buy = new CrudBuy();
            buy.BuyInsert();
            buy.BuyUpdate();
            buy.BuyDelete();
            buy.BuySelect();

            CrudAdmin CA = new CrudAdmin();
            CA.AdimnInsert();
            CA.AdminUpate();
            CA.AdminDelete();
            CA.AdminSelect();

            CrudTotal CT = new CrudTotal();
            CT.Inserttoal();
            CT.UpdateTotal();
            CT.deleteTotal();
            CT.selectTotal();

            CrudProductName CN = new CrudProductName();
            CN.InsertProductName();
            CN.UpdateProductName();
            CN.deleteProductName();
            CN.selectProductName();

            CrudProductType CPT = new CrudProductType();
            CPT.InsertProductType();
            CPT.UpdateProductType();
            CPT.DeleteProductType();
            CPT.selectProductType();
        }
    }
}
