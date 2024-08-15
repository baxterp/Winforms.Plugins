using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzWare.NBuilder;

namespace Winforms.Plugins.DemoPlugin
{
    public class MockData
    {
        public static DataTable GenerateDataTable<T>(int rows)
        {
            var datatable = new DataTable(typeof(T).Name);

            typeof(T).GetProperties().ToList().ForEach(x => datatable.Columns.Add(x.Name));

            Builder<T>.CreateListOfSize(rows).Build().ToList()
                .ForEach(x => datatable.LoadDataRow(x.GetType().GetProperties()
                    .Select(y => y.GetValue(x, null)).ToArray(), true));

            return datatable;
        }
    }
}
