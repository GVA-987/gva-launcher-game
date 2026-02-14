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
using System.Windows.Shapes;

namespace GVA_Launcher_Private.Views
{
    /// <summary>
    /// Lógica de interacción para TutorialView.xaml
    /// </summary>
    public partial class TutorialView : Window
    {
        private int currentStep = 0;

        // Estructura simple para los pasos
        private readonly (string Title, string Desc, string Image)[] steps = {
            ("Step 1: Find Icon", "Find the shortcut of your game on the desktop.", "step1.png"),
            ("Step 2: Properties", "Right-click the icon and select 'Properties'.", "step2.png"),
            ("Step 3: Copy Path", "Go to the 'Shortcut' tab and copy the 'Target' text.", "step3.png"),
            ("Step 4: Final Step", "Paste the path in our app and click 'Add Game'!", "step4.png")
        };
        public TutorialView()
        {
            InitializeComponent();
            UpdateUI();
        }
        private void UpdateUI()
        {
            StepTitle.Text = steps[currentStep].Title;
            StepDescription.Text = steps[currentStep].Desc;
            // TutorialImage.Source = ... (Aquí cargarás las imágenes después)

            BtnBack.Visibility = currentStep == 0 ? Visibility.Hidden : Visibility.Visible;
            BtnNext.Content = currentStep == steps.Length - 1 ? "Finish" : "Next";
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            if (currentStep < steps.Length - 1)
            {
                currentStep++;
                UpdateUI();
            }
            else
            {
                this.Close(); // Terminar tutorial
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (currentStep > 0)
            {
                currentStep--;
                UpdateUI();
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e) => this.Close();
    }
}
