using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new CRUD();
            context.Delete("222");
            context.Add();

        }
    }


    public class CRUD
    {
        public EF_Demo db = null;

        public CRUD()
        {
            db = new EF_Demo();
        }

        public void Add()
        {
            db.DEMO_1.Add(new DEMO_1
            {
                text1 = "222",
                text2 = "444",
                text3 = "555",
                //text4 = "666"
            });
            db.SaveChanges();
        }

        public void Update(string key)
        {
            var data = db.DEMO_1.Find(key);
            data.text2 = "222";
            data.text3 = "333";
            db.SaveChanges();
        }

        public void Delete(string key)
        {
            var data = db.DEMO_1.Find(key);
            db.DEMO_1.Remove(data);
            db.SaveChanges();
        }

        public void Query()
        {
            var datas =db.DEMO_1.ToList();

            foreach (var item in datas)
            {
                Console.WriteLine(item);
            }

        }



    }

}
