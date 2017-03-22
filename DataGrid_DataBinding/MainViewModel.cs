using Prism.Commands;
using System.Collections.Generic;
using System.Windows.Input;
using System;
using System.Threading.Tasks;

namespace DataGrid_DataBinding
{
    public class MainViewModel
    {
        public MainViewModel(MainWindow mainView)
        {
            _mainView = mainView;
            LoadCommand = new DelegateCommand(LoadAsync);
            SelectionChangedCommand = new DelegateCommand(SelectionChangedAsync);
        }

        private void SelectionChangedAsync()
        {
            object obj = _mainView.datagrid.SelectedItem;
            Console.WriteLine(obj);
        }

        private void LoadAsync()
        {
            Lessons = new List<LessonInfo>();

            Lessons.Add(new LessonInfo()
                {
                    Name = "语文",
                    Teacher = "于丹",
                    StartTime = "2017-03-22 22:12:21",
                    EndTime = "2017-03-22 22:12:29",
                    Master = "122"
                });
                Lessons.Add(new LessonInfo()
                {
                    Name = "数学",
                    Teacher = "史冬鹏",
                    StartTime = "2017-03-22 22:12:21",
                    EndTime = "2017-03-22 22:12:29",
                    Master = "122"
                });
                Lessons.Add(new LessonInfo()
                {
                    Name = "英语",
                    Teacher = "李阳",
                    StartTime = "2017-03-22 22:12:21",
                    EndTime = "2017-03-22 22:12:29",
                    Master = "122"
                });

                _mainView.datagrid.ItemsSource = Lessons;
        }

        public List<LessonInfo> Lessons { get; set; }
        public ICommand LoadCommand { get; set; }
        private MainWindow _mainView;
        public ICommand SelectionChangedCommand { get; set; }
    }
}