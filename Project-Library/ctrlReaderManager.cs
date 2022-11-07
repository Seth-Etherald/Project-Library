using Project_Library.Logics;
using Project_Library.Models;

namespace Project_Library
{
    public partial class ctrlReaderManager : UserControl
    {
        private readonly int _minBirthYear = DateTime.Now.Year - 15;
        private readonly int _maxBirthYear = DateTime.Now.Year - 60;
        private List<Reader> _readers = new();
        private Reader? _currentReader;


        public ctrlReaderManager()
        {
            InitializeComponent();

            dgvReader.AutoGenerateColumns = false;

            dgvReader.Columns.Add("CardNumber", "Reader Card Number");
            dgvReader.Columns["CardNumber"].DataPropertyName = "CardNumber";

            dgvReader.Columns.Add("FullName", "Reader Name");
            dgvReader.Columns["FullName"].DataPropertyName = "FullName";

            dgvReader.Columns.Add("Occupation", "Occupation");
            dgvReader.Columns["Occupation"].DataPropertyName = "Occupation";

            LoadDGV();
            InititalizeFields();
        }

        private void DgvReader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                _currentReader = _readers[e.RowIndex];

                switch (_currentReader.Occupation.ToLower())
                {
                    case "học viên":
                        cbOccupation.SelectedValue = 0;
                        break;

                    case "sinh viên":
                        cbOccupation.SelectedValue = 1;
                        break;

                    case "giáo viên":
                        cbOccupation.SelectedValue = 2;
                        break;
                }
                tbReaderCard.Text = _currentReader.CardNumber.ToString();
                tbFullName.Text = _currentReader.FullName;
                dtpDateOfBirth.Value = _currentReader.DateOfBirth;
                dtpCardCreateDate.Value = _currentReader.CardCreationDate;
                tbAddress.Text = _currentReader.Address;
            }
            else
            {
                RefreshElements();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshElements();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string occupation = cbOccupation.SelectedValue switch
            {
                0 => "Học Viên",
                1 => "Sinh Viên",
                2 => "Giáo Viên",
                _ => "Error"
            };

            string fullName = tbFullName.Text.Trim();
            DateTime dateOfBirth = dtpDateOfBirth.Value;
            DateTime cardCreation = DateTime.Now;
            string address = tbAddress.Text;

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Reader name and address must not be empty!");
                return;
            }

            ReaderManager.AddReader(new()
            {
                Occupation = occupation,
                FullName = fullName,
                DateOfBirth = dateOfBirth,
                CardCreationDate = cardCreation,
                Address = address,
            });

            MessageBox.Show("Add new reader successfully!");
            RefreshElements();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string occupation = cbOccupation.SelectedValue switch
            {
                0 => "Học Viên",
                1 => "Sinh Viên",
                2 => "Giáo Viên",
                _ => "Error"
            };

            int readerCard = Convert.ToInt32(tbReaderCard.Text);
            string fullName = tbFullName.Text.Trim();
            DateTime dateOfBirth = dtpDateOfBirth.Value;
            DateTime cardCreation = dtpCardCreateDate.Value;
            string address = tbAddress.Text;

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Reader name and address must not be empty!");
                return;
            }

            ReaderManager.UpdateReader(new()
            {
                CardNumber = readerCard,
                Occupation = occupation,
                FullName = fullName,
                DateOfBirth = dateOfBirth,
                CardCreationDate = cardCreation,
                Address = address,
            });

            MessageBox.Show("Update reader successfully!");
            RefreshElements();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_currentReader != null)
            {
                var result = MessageBox.Show("Do you really want to delete this reader and all of their records?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ReaderManager.DeleteReader(_currentReader);
                    MessageBox.Show("Reader deleted successfully!");
                    RefreshElements();
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            _readers = ReaderManager.GetReaders();
            string filterType = gbSearchInfo.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked == true)!.Text;
            switch (filterType)
            {
                case "Reader Card":
                    bool isInt = int.TryParse(tbSearch.Text, out _);
                    if (isInt)
                    {
                        _readers = _readers
                                           .Where(x => x.CardNumber == Convert.ToInt32(tbSearch.Text))
                                           .ToList();
                        dgvReader.DataSource = _readers;
                    }
                    else
                    {
                        MessageBox.Show("Please enter an integer!");
                        tbSearch.Text = "";
                        tbSearch.Focus();
                    }
                    break;

                case "Reader Name":
                    _readers = _readers
                                       .Where(x => x.FullName.Contains(tbSearch.Text, StringComparison.OrdinalIgnoreCase))
                                       .ToList();
                    dgvReader.DataSource = _readers;
                    break;
            }
        }

        public void InititalizeFields()
        {
            DateTime min = new(_minBirthYear, DateTime.Now.Month, DateTime.Now.Day);
            DateTime max = new(_maxBirthYear, DateTime.Now.Month, DateTime.Now.Day);

            var occupations = new[]
            {
                new {Text = "Học Viên", Value = 0},
                new {Text = "Sinh Viên", Value = 1},
                new {Text = "Giáo Viên", Value = 2}
            };

            cbOccupation.DataSource = occupations;
            cbOccupation.ValueMember = "Value";
            cbOccupation.DisplayMember = "Text";
            cbOccupation.SelectedIndex = 0;

            dtpDateOfBirth.MinDate = max;
            dtpDateOfBirth.MaxDate = min;

            dtpDateOfBirth.Value = min;

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            rbReaderCard.Checked = true;
            tbSearch.Text = "";
        }

        public void LoadDGV()
        {
            _readers = ReaderManager.GetReaders();
            dgvReader.DataSource = _readers;
        }

        public void RefreshElements()
        {
            LoadDGV();
            InititalizeFields();

            tbReaderCard.Text = "";
            tbFullName.Text = "";
            tbAddress.Text = "";
            _currentReader = null;
        }
    }
}