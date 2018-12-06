using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using Books.BL;

namespace AssemblyLibr
{
    public class AssemblyInfo
    {
        public Assembly Assembl { get; set; }
        public List<Type> types { get; set; }
        public AssemblyInfo(Assembly assembl)
        {
            Assembl = assembl;
            SaveTypes(assembl);

        }
        private void SaveTypes(Assembly assembl)
        {
            var intypes = assembl.DefinedTypes.Where(x => x.ImplementedInterfaces.Contains(typeof(IEdition)));
            Type[] input = assembl.GetTypes();
            List<Type> filtred = new List<Type>();
            foreach (var item in intypes)
            {
                if (!item.IsAbstract)
                    filtred.Add(item);
            }
            types = filtred;

        }
        public List<string> GetNamesOfAllTypes()
        {
            List<string> names = new List<string>();
            foreach (var item in types)
            {
                StringBuilder sb = new StringBuilder();
                if (item.IsClass)
                {
                    if (item.IsAbstract)
                        sb.Append("abstract ");
                    sb.Append("class ");
                }
                if (item.IsInterface)
                    sb.Append("interface ");
                sb.Append(item.Name);
                names.Add(sb.ToString());
            }
            return names;
        }
        //public List<string> Get
    }
}
