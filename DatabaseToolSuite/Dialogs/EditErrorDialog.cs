using static DatabaseToolSuite.Repositoryes.RepositoryDataSet;

namespace DatabaseToolSuite.Dialogs
{
    public class EditErrorDialog : CreateNewVersionDialog
    {
        public EditErrorDialog() : base()
        {
            beginDateLabel.Text = "Дата введения в действие";
            Text = "Исправление ошибки в записи о подразделении";
            DialogCaption = "Исправление ошибки в записи о подразделении";
        }

        public EditErrorDialog(gaspsRow row) : base(row)
        {
            beginDateLabel.Text = "Дата введения в действие";
            beginDateTimePicker.Value = row.date_beg;
            Text = "Исправление ошибки в записи о подразделении";
            DialogCaption = "Исправление ошибки в записи о подразделении";
        }
    }
}