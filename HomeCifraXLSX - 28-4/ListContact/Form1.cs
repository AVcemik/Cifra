using OfficeOpenXml;

namespace ListContact
{
    public partial class Form1 : Form
    {
        private static List<Contact> _listContact = new();  // Список контакатов
        private static Contact? _currentSelectContact;      // Текущий выбраный контакт
        private static bool _editCheck = false;             // Проверка на внесение изменений в программу
        public Form1()
        {
            InitializeComponent();
        }
        private void SaveFileBT_Click(object sender, EventArgs e)
        {
            ExcelOperation.SaveFile(_listContact);
            _editCheck = false;
        } // Сохранение внесенных изменений
        private void Form1_Load(object sender, EventArgs e) // Событие загрузки формы (Предустановки программы)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            if (!File.Exists(Other.GetFilePath()))
                ExcelOperation.CreateFile();
            else
                ExcelOperation.CheckFile();
            ExcelOperation.SetupStyleExcel();
            _listContact.Clear();
            _listContact = ExcelOperation.LoadDataList();
            UpdateContactListData();
        }
        private void AddUserBT_Click(object sender, EventArgs e) // Добавление контакта
        {
            AddUserBT.Enabled = false;
            if (UserNameTB.Text == "" || UserPhoneTB.Text == "" || UserEmailTB.Text == "" || UserAdressTB.Text == "")
            {
                Other.DisplayErrorMessage("Не все поля заполненны!!!");
            }
            else
            {
                _listContact.Add(new Contact(UserNameTB.Text, UserPhoneTB.Text, UserEmailTB.Text, UserAdressTB.Text));
                ClearTB();
                _editCheck = true;
                Other.DisplayNotificationMessage("Контакт успешно добавлен.");
            }
            UpdateContactListData();
            AddUserBT.Enabled = true;
        }
        private void EditUserBT_Click(object sender, EventArgs e) // Изменения контакта
        {
            EditUserBT.Enabled = false;
            _currentSelectContact!.Name = UserNameTB.Text;
            _currentSelectContact.Phone = UserPhoneTB.Text;
            _currentSelectContact.Email = UserEmailTB.Text;
            _currentSelectContact.Address = UserAdressTB.Text;

            ClearTB();
            Other.DisplayNotificationMessage("Контакт успешно изменен.");
            UpdateContactListData();
            _editCheck = true;
            EditUserBT.Enabled = true;
        }
        private void DeleteUserBT_Click(object sender, EventArgs e) // Удаления контакта
        {
            DeleteUserBT.Enabled = false;
            _listContact.Remove(_currentSelectContact!);
            ClearTB();
            Other.DisplayNotificationMessage("Контакт успешно удален.");
            UpdateContactListData();
            _editCheck = true;
            DeleteUserBT.Enabled = true;
        }
        private void UpdateContactListData() // Обновление списка контактов
        {
            ContactListLTB.Items.Clear();
            for (int i = 0; i < _listContact.Count; i++)
            {
                ContactListLTB.Items.Add(_listContact[i].Name);
            }
        }
        public void ClearTB() // Очистка полей
        {
            UserNameTB.Clear();
            UserPhoneTB.Clear();
            UserEmailTB.Clear();
            UserAdressTB.Clear();
        }
        public void ExitApp() // Реализация выхода из программы
        {
            if (_editCheck == true)
            {
                var result = MessageBox.Show("Изменения не сохранены", "Сохранить изменения?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcelOperation.SaveFile(_listContact);
                }
            }
            Application.Exit();
        }
        private void ContactListLTB_SelectedIndexChanged(object sender, EventArgs e) // Событие на выделение контакта
        {
            if (ContactListLTB.SelectedIndex != -1)
            {
                _currentSelectContact = _listContact[ContactListLTB.SelectedIndex];
                //_currentSelectContact = ContactListLTB.SelectedItem;
                UserNameTB.Text = _currentSelectContact.Name;
                UserPhoneTB.Text = _currentSelectContact.Phone;
                UserEmailTB.Text = _currentSelectContact.Email;
                UserAdressTB.Text = _currentSelectContact.Address;
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) // Выход из программы
        {
            ExitApp();
        }
    }
}