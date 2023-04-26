using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demo.Pages
{
    /// <summary>
    /// Логика взаимодействия для AgentListPage.xaml
    /// </summary>
    public partial class AgentListPage : Page
    {
        public AgentListPage()
        {
            InitializeComponent();
            LVProduct.ItemsSource = App.DB.Agent.ToList();
            var agentType = App.DB.AgentType.ToList();
            agentType.Insert(0, new Model.AgentType{ Title = "Все типы" });
            Filtr.ItemsSource = agentType;
        }
    }
}
