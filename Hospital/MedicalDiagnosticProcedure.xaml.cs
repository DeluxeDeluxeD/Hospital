using System.Windows.Controls;
using Hospital.Model;
using System.Linq;

namespace Hospital
{
    public partial class MedicalDiagnosticProcedure : Page
    {
        public MedicalDiagnosticProcedure()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var context = new HospitalEntities9())
            {
                var treatments = context.MedicalDiagnosticProcedure.ToList();
                var patients = context.Patients.ToList();
                DGridPatients.ItemsSource = treatments.Join(patients, t => t.Id, p => p.Id, (t, p) => new {MedicalDiagnosticProcedure = t, Patients = p }).ToList();
            }
        }
    }
}
