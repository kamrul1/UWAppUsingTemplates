using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWAppUsingDataTemplate.Model;
using Windows.UI;

namespace UWAppUsingDataTemplate.ViewModel
{
    public class ClassroomViewModel
    {
        public string ClassroomName { get; private set; }

        public List<Student> Students { get; private set; }

        public ClassroomViewModel()
        {
            ClassroomName = "Ms Henderson's 5th Grade Class";

            Students = new List<Student>()
            {
                new Student{ Name = "Kamrul Islam", FavoriteColor = Colors.Black, Age = 10 }
                , new Student {Name="Anamul Islam", FavoriteColor = Colors.Green, Age=20 }
            };
        }
    }
}
