using System;
using LibraryTrapezium;
using System.Windows.Forms;

namespace MyCompany
{
    [Info(CompanyName = "ProfessorWeb", CompanyUrl = "professorweb.ru")]
    public class MyCompanyInfo
    {
        void IApplicationFunc.Go()
        {
            MessageBox.Show("Важная информация!");
        }
    }
}