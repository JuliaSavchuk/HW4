namespace HW4
{
    internal class ForeignPassport
    {
        public string PassportNumber { get; set; }
        public string OwnerName { get; set; }
        public DateTime DateOfIssue { get; set; }

        public ForeignPassport(string passportNumber, string ownerName, DateTime dateOfIssue)
        {
            PassportNumber = passportNumber;
            OwnerName = ownerName;
            DateOfIssue = dateOfIssue;
            if (string.IsNullOrWhiteSpace(passportNumber))
            {
                throw new ArgumentException("The passport number cannot be empty or contain only spaces.", nameof(passportNumber));
            }

            if (string.IsNullOrWhiteSpace(ownerName))
            {
                throw new ArgumentException("The owner's name cannot be empty or contain only spaces.", nameof(ownerName));
            }

            if (dateOfIssue == default(DateTime))
            {
                throw new ArgumentException("Incorrect passport issue date.", nameof(dateOfIssue));
            }

        }

    }
}
