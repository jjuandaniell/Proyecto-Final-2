using Microsoft.CognitiveServices.Speech;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace azurespeech
{
    public partial class Form1 : Form
    {
        // Las claves se obtienen de variables de entorno
        private static readonly string SubscriptionKey = Environment.GetEnvironmentVariable("AZURE_SPEECH_KEY");
        private static readonly string Region = Environment.GetEnvironmentVariable("AZURE_SPEECH_REGION");
        private const string ConnectionString = "Server=ZEPHYRUS-DE-DAN\\SQLEXPRESS;Database=dbproyecto2;Trusted_Connection=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnSpeak_Click(object sender, EventArgs e)
        {
            btnSpeak.Enabled = false;
            try
            {
                if (string.IsNullOrWhiteSpace(SubscriptionKey) || string.IsNullOrWhiteSpace(Region))
                {
                    MessageBox.Show("No se encontraron las variables de entorno para la clave o región de Azure Speech.", "Error de configuración", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var config = SpeechConfig.FromSubscription(SubscriptionKey, Region);
                using var synthesizer = new SpeechSynthesizer(config);

                string textoUsuario = txtInputText.Text;
                await synthesizer.SpeakTextAsync(textoUsuario);

                GuardarTextoEnBaseDeDatos(textoUsuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnSpeak.Enabled = true;
        }

        private void GuardarTextoEnBaseDeDatos(string textoUsuario)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO TextToSpeechLogs (TextoUsuario) VALUES (@textoUsuario)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@textoUsuario", textoUsuario);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar en la base de datos: {ex.Message}", "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnStartRecognition_Click(object sender, EventArgs e)
        {
            btnStartRecognition.Enabled = false;
            txtRecognizedText.Text = "Escuchando...";
            try
            {
                if (string.IsNullOrWhiteSpace(SubscriptionKey) || string.IsNullOrWhiteSpace(Region))
                {
                    txtRecognizedText.Text = "No se encontraron las variables de entorno para la clave o región de Azure Speech.";
                    return;
                }

                var config = SpeechConfig.FromSubscription(SubscriptionKey, Region);
                using var recognizer = new SpeechRecognizer(config);

                var result = await recognizer.RecognizeOnceAsync();
                txtRecognizedText.Text = result.Text;
            }
            catch (Exception ex)
            {
                txtRecognizedText.Text = $"Error: {ex.Message}";
            }
            btnStartRecognition.Enabled = true;
        }
    }
}
