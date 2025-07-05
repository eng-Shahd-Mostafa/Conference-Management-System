namespace Conference_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConference_Click(object sender, EventArgs e)
        {
            ConferenceForm conferenceForm = new ConferenceForm();
            this.Hide();
            conferenceForm.Show();
            conferenceForm.FormClosed += (s, args) => this.Show(); // Show the main form when the conference form is closed

        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            SessionForm sessionForm = new SessionForm();
            this.Hide();
            sessionForm.Show();
            sessionForm.FormClosed += (s, args) => this.Show(); // Show the main form when the session form is closed
        }

        private void btnParticipant_Click(object sender, EventArgs e)
        {
            ParticipantForm participantForm = new ParticipantForm();
            this.Hide();
            participantForm.Show();
            participantForm.FormClosed += (s, args) => this.Show(); // Show the main form when the participant form is closed
        }

        private void btnAttendee_Click(object sender, EventArgs e)
        {
            AttendeeForm attendeeForm = new AttendeeForm();
            this.Hide();
            attendeeForm.Show();
            attendeeForm.FormClosed += (s, args) => this.Show(); // Show the main form when the attendee form is closed
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            PaperForm paperForm = new PaperForm();
            this.Hide();
            paperForm.Show();
            paperForm.FormClosed += (s, args) => this.Show(); // Show the main form when the paper form is closed
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ConferenceReportForm conferenceReportForm = new ConferenceReportForm();
            this.Hide();
            conferenceReportForm.Show();
            conferenceReportForm.FormClosed += (s, args) => this.Show(); // Show the main form when the report form is closed
        }
    }
}
