using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriIliskileriYonetimiCRM.Class.Cart
{
    internal class C_Cart
    {
        public static C_Cart instance = new C_Cart();

        private List<int> CartList = new List<int>();
        
        //private List<int> cartList;
        //public List<int> CartList
        //{
        //    get { return cartList; }

        //    set { cartList = value; }
        //}

        internal void AddCartList(int tag)
        {
            CartList.Add(tag);
        }

        internal List<int> GetCartList()
        {
            return CartList;
        }

        internal void RemoveItem(int itemIndex)
        {
            CartList.Remove(itemIndex);
        }

        internal void ClearCart()
        {
            CartList.Clear();
        }
    }
}
