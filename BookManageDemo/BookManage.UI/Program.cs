using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Autofac;
using Autofac.Configuration;
using BookManage.IRepository;

namespace BookManage.UI
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            IContainer container;
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterModule(new ConfigurationSettingsReader("autofac"));
            container = builder.Build();
            var repository = container.Resolve<IBookRepository>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BookManageForm form = new BookManageForm();
            form.bookRepository = repository;

            Application.Run(new BookManageForm());
        }
    }
}