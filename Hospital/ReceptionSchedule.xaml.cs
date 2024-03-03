using System.Windows.Controls;
using Hospital.Model;
using System.Linq;

namespace Hospital
{
    public partial class ReceptionSchedule : Page
    {
        private Frame myFrame;

        private void LoadData()
        {
            using (var context = new HospitalEntities9())
            {
                var schedule = context.ReceptionSchedule.ToList(); // Получаем все записи из таблицы Расписания
                var doctors = context.Doctors.ToList(); // Получаем все записи из таблицы Врачи
                DGridSchedule.ItemsSource = schedule.Join(doctors, rp => rp.IdDoctor, vr => vr.Id, (rp, vr) => new { ReceptionSchedule = rp, Doctors = vr }); // Устанавливаем источник данных для DataGrid
            }
        }

        public ReceptionSchedule()
        {
            InitializeComponent();
            AppConnect.HospitalModel = new HospitalEntities9();
            AppFrame.frameMain = myFrame;
            LoadData();
        }
    }
}