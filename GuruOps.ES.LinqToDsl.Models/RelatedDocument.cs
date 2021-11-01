using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GuruOps.ES.LinqToDsl.Models
{
    public class RelatedDocument
    {
        [JsonPropertyName("documentType")]
        public DocumentType DocumentType { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        public RelatedDocument(DocumentType documentType, string id)
        {
            DocumentType = documentType;
            Id = id;
        }
    }
    
    public enum DocumentType
    {
        [Display(Name = "Appointment", Description = "Appointment")]
        Appointment = 0,

        [Display(Name = "Audit Log", Description = "Audit Log")]
        AuditLog = 2,

        [Display(Name = "Calendar", Description = "Calendar")]
        Calendar = 5,

        [Display(Name = "Case", Description = "Case")]
        Case = 6,

        [Display(Name = "Consultation Status", Description = "Consultation Status")]
        ConsultationStatus = 10,

        [Display(Name = "Consultation Type", Description = "Consultation Type")]
        ConsultationType = 11,
        
        [Display(Name = "Contact", Description = "Contact")]
        Contact = 14,

        [Display(Name = "Contract", Description = "Contract")]
        Contract = 17,

        [Display(Name = "Exclude Date", Description = "Exclude Date")]
        ExcludeDate = 22,

        [Display(Name = "Firm", Description = "Firm")]
        Firm = 25,

        [Display(Name = "Language", Description = "Language")]
        Language = 28,

        [Display(Name = "Consultation Mapping", Description = "Consultation Mapping")]
        ConsultationMapping = 31,

        [Obsolete]
        Locations = 32,

        [Display(Name = "Option List", Description = "Option List")]
        OptionList = 36,

        [Display(Name = "Other", Description = "Other")]
        Other = 37,

        [Display(Name = "Question", Description = "Question")]
        Question = 39,

        [Display(Name = "Questionnaire", Description = "Questionnaire")]
        Questionnaire = 40,

        [Display(Name = "Questionnaire Question", Description = "Questionnaire Question")]
        QuestionnaireQuestion = 41,

        [Display(Name = "Quote", Description = "Quote")]
        Quote = 44,

        [Display(Name = "Reminder", Description = "Reminder")]
        Reminder = 45,

        [Display(Name = "Resource", Description = "Resource")]
        Resource = 46,

        [Display(Name = "Phase and Step", Description = "Phase and Step")]
        PhaseAndStep = 48,

        [Display(Name = "Identity", Description = "Identity")]
        Identity = 53,
        
        [Display(Name = "Persona", Description = "Persona")]
        Persona = 54,

        [Display(Name = "Custom Field", Description = "Custom Field")]
        CustomField = 55,

        [Display(Name = "Custom Option List", Description = "Custom Option List")]
        CustomOptionList = 56,

        [Display(Name = "Template", Description = "Template")]
        Template = 57,

        [Display(Name = "News", Description = "News")]
        News = 58,

        [Display(Name = "Rights", Description = "Rights")]
        Rights = 60,

        [Display(Name = "Alert", Description = "Alert")]
        Alert = 61,

        [Display(Name = "Token", Description = "Token")]
        Token = 62,

        [Display(Name = "Registration Link", Description = "Registration Link")]
        RegistrationLink = 63,

        [Display(Name = "Role", Description = "Role")]
        Role = 64,

        [Display(Name = "Permission", Description = "Permission")]
        Permission = 65,

        [Display(Name = "Auth Request", Description = "Auth Request")]
        AuthRequest = 66,

        [Display(Name = "Azure Token", Description = "Azure Token")]
        AzureToken = 67,

        [Display(Name = "Email Token", Description = "Email Token")]
        EmailToken = 68,

        [Display(Name = "Notification Template", Description = "Notification Template")]
        NotificationTemplate = 300,

        [Display(Name = "Alert History", Description = "Alert History")]
        AlertHistory = 301,

        [Display(Name = "Role Membership", Description = "Role Membership")]
        RoleMembership = 302,

        [Display(Name = "Alert Location", Description = "Alert Location")]
        AlertLocation = 303,

        [Display(Name = "Notication History", Description = "Notification History")]
        NotifHistory = 401,

        [Display(Name = "Device", Description = "Device")]
        Device = 500,

        [Display(Name = "Audio Stream", Description = "Audio Stream")]
        AudioStream = 501,

        [Display(Name = "Rights Category", Description = "Rights Category")]
        RightsCategory = 502,

        [Display(Name = "Alias", Description = "Alias")]
        Alias = 503,

        [Display(Name = "Connector", Description = "Connector")]
        Connector = 504,

        [Display(Name = "Firm Setting", Description = "Firm Setting")]
        FirmSetting = 600,
        
        [Display(Name = "Legal Service", Description = "Legal Service")]
        LegalService = 700,

        [Display(Name = "Form", Description = "Form")]
        Form = 703,

        [Display(Name = "LP Document", Description = "LP Document")]
        LPDocument = 800,

        [Display(Name = "Document Category", Description = "Document Category")]
        DocumentCategory = 801,

        [Display(Name = "Subscription", Description = "Subscription")]
        Subscription = 1000,

        [Display(Name = "Feature", Description = "Feature")]
        Feature = 1100,

        [Display(Name = "Firm Feature", Description = "Firm Feature")]
        FirmFeature = 1200,

        [Display(Name = "Role Feature Permission", Description = "Role Feature Permission")]
        RoleFeaturePermission = 1300,

        [Display(Name = "View", Description = "View")]
        View = 1400,

        [Display(Name = "Firm View", Description = "Firm View")]
        FirmView = 1500,

        [Display(Name = "Role View Permission", Description = "Role View Permission")]
        RoleViewPermission = 1600,

        [Display(Name = "Mailing Office", Description = "Mailing Office")]
        MailingOffice = 1700,

        [Display(Name = "Out of Office", Description = "Out of Office")]
        OutOfOffice = 1800,

        [Display(Name = "Timeslot Setting", Description = "Timeslot Setting")]
        TimeslotSetting = 1900,

        [Display(Name = "Referral Source", Description = "Referral Source")]
        ReferralSource = 2000,

        [Display(Name = "Meeting Type", Description = "Meeting Type")]
        MeetingType = 2100,

        [Display(Name = "Consultation", Description = "Consultation")]
        Consultation = 2200,

        [Display(Name = "Consultation Queue", Description = "Consultation Queue")]
        ConsultationQueue = 2300,

        [Display(Name = "Consultation Queue Step", Description = "Consultation Queue Step")]
        ConsultationQueueStep = 2350,

        [Display(Name = "Quote Template", Description = "Quote Tempate")]
        QuoteTemplate = 2400,

        [Display(Name = "Contract Template", Description = "Contract Template")]
        ContractTemplate = 2500,

        [Display(Name = "Communication History", Description = "Communication History")]
        CommunicationHistory = 2600,

        [Display(Name = "Probability Conversion", Description = "Probability Conversion")]
        ProbabilityConversion = 2700,

        [Display(Name = "Recent Answer", Description = "Recent Answer")]
        RecentAnswer = 2800,

        [Display(Name = "Relationship", Description = "Relationship")]
        Relationship = 2900,

        [Display(Name = "Contract Signing Info", Description = "Contract Signing Info")]
        ContractSigningInfo = 3000,

        [Display(Name = "Office Email", Description = "Office Email")]
        OfficeEmail = 4000,

        [Display(Name = "Question Category", Description = "Question Category")]
        QuestionCategory = 4100,

        [Display(Name = "Invoice", Description = "Invoice")]
        Invoice = 4200,

        [Display(Name = "Customer", Description = "Customer")]
        Customer = 4300,

        [Display(Name = "Notice", Description = "Notice")]
        Notice = 5000,

        [Display(Name = "Notice Type", Description = "Notice Type")]
        NoticeType = 5001,

        [Display(Name = "Todo", Description = "Todo")]
        ToDo = 5002,

        [Display(Name = "Agency", Description = "Agency")]
        Agency = 5003,

        [Display(Name = "Report", Description = "Report")]
        Report = 5004,

        [Display(Name = "Staff Rate", Description = "Staff Rate")]
        StaffRate = 5006,

        [Display(Name = "Identifier", Description = "Identifier")]
        Identifier = 5010,

        [Display(Name = "Message History", Description = "Message History")]
        MessageHistory = 5020,

        [Display(Name = "Time Tracking", Description = "Time Tracking")]
        TimeTracking = 5500,

        [Display(Name = "Email Queue Message", Description = "Email Queue Message")]
        EmailQueueMessage = 5510,

        [Display(Name = "Application", Description = "Application")]
        Application = 5520,

        [Display(Name = "Application API Key", Description = "Application API Key")]
        ApplicationApiKey = 5530,

        [Display(Name = "Key Vault", Description = "Key Vault")]
        KeyVault = 5540,

        [Display(Name = "Immigration Status", Description = "Immigration Status")]
        ImmigrationStatus = 5550,

        [Display(Name = "Persona Immigration Status", Description = "Persona Immigration Status")]
        PersonaImmigrationStatus = 5560,

        [Display(Name = "Recurring Job", Description = "Recurring Job")]
        RecurringJob = 5570,
    }
}