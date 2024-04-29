using MyControlsLibrary;
using CalculationLibrary;
using DemoApp;

namespace DemoApp
{
    public partial class ApplicationsForm : Form
    {
        public List<MyApplication> applications;
        public ApplicationsForm()
        {
            InitializeComponent();
            applications = new List<MyApplication>();
        }

        public void AddApplication()
        {
            ApplicationUC applicationUC = new ApplicationUC();
            panelApplications.Controls.Add(applicationUC);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddEditWIndow window = new AddEditWIndow(null);
            window.ShowDialog();
            if (window.DialogResult == DialogResult.OK)
            {
                MyApplication app = new MyApplication(window.id, window.dateStart, window.textEquipment.Text, window.textDefect.Text,
                    window.textClient.Text, window.textProblemDescription.Text);
                applications.Add(app);

                ApplicationUC applicationUC = new ApplicationUC();
                panelApplications.Controls.Add(applicationUC);
                applicationUC.Click += applicationUC_Click;
                FillUC(ref applicationUC, app);
            }
        }
        private void applicationUC_Click(object sender, EventArgs e)
        {
            ApplicationUC uc = (ApplicationUC)((Control)sender).Parent;
            MyApplication currentApp = null;
            foreach (MyApplication app in applications)
            {
                if (app.Id.ToString() == uc.Id)
                {
                    currentApp = app;
                    break;
                }
            }
            AddEditWIndow window = new AddEditWIndow(currentApp);
            window.ShowDialog();
            if (window.DialogResult == DialogResult.OK)
            {
                foreach (MyApplication app in applications)
                {
                    if (app.Id == currentApp.Id)
                    {
                        app.Status = window.boxState.Text;
                        app.Responsible = window.textResponsible.Text;
                        app.ProblemDescription = window.textProblemDescription.Text;
                        FillUC(ref uc, currentApp);
                        break;
                    }
                }
            }
        }

        public void FillUC(ref ApplicationUC uc, MyApplication app)
        {
            uc.Id = app.Id.ToString();
            uc.Date = app.DateStart.ToString();
            uc.Equipment = app.Equipment;
            uc.Defect = app.Defect;
            uc.Client = app.Client;
            uc.ProblemDescription = app.ProblemDescription;
            uc.Status = app.Status;
            uc.Responsible = app.Responsible;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textSearch.Text == "")
            {
                MessageBox.Show("������� Id ����� ��� ������");
                return;
            }
            if (!int.TryParse(textSearch.Text, out int result))
            {
                MessageBox.Show("������� ����� Id");
                return;
            }
            bool flag = false;
            MyApplication currentApp = null;
            foreach (var app in applications)
            {
                if (app.Id == result)
                {
                    flag = true;
                    currentApp = app;
                }
            }
            if (!flag)
            {
                MessageBox.Show("������ �� �������");
                return;
            }
            string message = "";
            message += $"Id: {currentApp.Id} \n";
            message += $"����: {currentApp.DateStart} \n";
            message += $"������������: {currentApp.Equipment} \n";
            message += $"��� �������������: {currentApp.Defect} \n";
            message += $"������: {currentApp.Client} \n";
            message += $"������ ������: {currentApp.Status} \n";
            message += $"�������������: {currentApp.Responsible} \n";
            message += $"�������� ��������: {currentApp.ProblemDescription} \n";
            MessageBox.Show(message);
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            Calculation myCalc = new Calculation(applications);
            int count = myCalc.GetApplicationsCount();
            int time = myCalc.GetAverageTime();
            string statistic = myCalc.GetDefectsStatistics();
            string message = "";
            message += $"���������� ������: {count} \n";
            message += $"������� ����� ����������: {time} \n";

            if (statistic != null)
            {
                message += $"����� ������ ��������: {statistic}\n";
            }
            MessageBox.Show(message);
        }
    }
}