using OfficeOpenXml;

namespace ListContact
{
    public partial class Form1 : Form
    {
        private static List<Contact> _listContact = new();  // ������ ����������
        private static Contact? _currentSelectContact;      // ������� �������� �������
        private static bool _editCheck = false;             // �������� �� �������� ��������� � ���������
        public Form1()
        {
            InitializeComponent();
        }
        private void SaveFileBT_Click(object sender, EventArgs e)
        {
            ExcelOperation.SaveFile(_listContact);
            _editCheck = false;
        } // ���������� ��������� ���������
        private void Form1_Load(object sender, EventArgs e) // ������� �������� ����� (������������� ���������)
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
        private void AddUserBT_Click(object sender, EventArgs e) // ���������� ��������
        {
            AddUserBT.Enabled = false;
            if (UserNameTB.Text == "" || UserPhoneTB.Text == "" || UserEmailTB.Text == "" || UserAdressTB.Text == "")
            {
                Other.DisplayErrorMessage("�� ��� ���� ����������!!!");
            }
            else
            {
                _listContact.Add(new Contact(UserNameTB.Text, UserPhoneTB.Text, UserEmailTB.Text, UserAdressTB.Text));
                ClearTB();
                _editCheck = true;
                Other.DisplayNotificationMessage("������� ������� ��������.");
            }
            UpdateContactListData();
            AddUserBT.Enabled = true;
        }
        private void EditUserBT_Click(object sender, EventArgs e) // ��������� ��������
        {
            EditUserBT.Enabled = false;
            _currentSelectContact!.Name = UserNameTB.Text;
            _currentSelectContact.Phone = UserPhoneTB.Text;
            _currentSelectContact.Email = UserEmailTB.Text;
            _currentSelectContact.Address = UserAdressTB.Text;

            ClearTB();
            Other.DisplayNotificationMessage("������� ������� �������.");
            UpdateContactListData();
            _editCheck = true;
            EditUserBT.Enabled = true;
        }
        private void DeleteUserBT_Click(object sender, EventArgs e) // �������� ��������
        {
            DeleteUserBT.Enabled = false;
            _listContact.Remove(_currentSelectContact!);
            ClearTB();
            Other.DisplayNotificationMessage("������� ������� ������.");
            UpdateContactListData();
            _editCheck = true;
            DeleteUserBT.Enabled = true;
        }
        private void UpdateContactListData() // ���������� ������ ���������
        {
            ContactListLTB.Items.Clear();
            for (int i = 0; i < _listContact.Count; i++)
            {
                ContactListLTB.Items.Add(_listContact[i].Name);
            }
        }
        public void ClearTB() // ������� �����
        {
            UserNameTB.Clear();
            UserPhoneTB.Clear();
            UserEmailTB.Clear();
            UserAdressTB.Clear();
        }
        public void ExitApp() // ���������� ������ �� ���������
        {
            if (_editCheck == true)
            {
                var result = MessageBox.Show("��������� �� ���������", "��������� ���������?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcelOperation.SaveFile(_listContact);
                }
            }
            Application.Exit();
        }
        private void ContactListLTB_SelectedIndexChanged(object sender, EventArgs e) // ������� �� ��������� ��������
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
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) // ����� �� ���������
        {
            ExitApp();
        }
    }
}