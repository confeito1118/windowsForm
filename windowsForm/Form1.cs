using Spire.Xls;
using System.IO;

namespace windowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(file_n.Text))
            {
                MessageBox.Show(
                    "�t�@�C�����w�肵�Ă��܂���",
                    "�G���[",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand
                );
            } else {
                // �f�B���N�g����
                var dirName = Path.GetDirectoryName(file_n.Text);
                // �t�@�C�����i�g���q�����j
                var fileName = Path.GetFileNameWithoutExtension(file_n.Text);
                // �g���q��
                var extensionName = Path.GetExtension(file_n.Text);

                // MessageBox.Show(dirName);
                // MessageBox.Show(fileName);
                // MessageBox.Show(extensionName);

                //Workbook�C���X�^���X���쐬����
                Workbook workbook = new Workbook();

                //�T���v��Excel���������[�h����
                workbook.LoadFromFile(dirName + "\\" + fileName + extensionName);

                //�ϊ����Ƀy�[�W�ɍ����悤�Ƀ��[�N�V�[�g��ݒ肷��
                workbook.ConverterSetting.SheetFitToPage = true;

                for (int i = 0; i < 10; i++)
                {
                    //�ŏ��̃��[�N�V�[�g���擾����
                    Worksheet worksheet = workbook.Worksheets[i];
                    var sheetName = worksheet.Name;

                    if (String.IsNullOrEmpty(sheetName))
                    {

                    } else
                    {
                        //PDF�ɕۑ�����
                        worksheet.SaveToPdf(dirName + "\\" + fileName + "_" + sheetName + ".pdf");
                    }
                }

                MessageBox.Show(
                    "�I��",
                    "����",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
            }
        }

        private void file_s_Click(object sender, EventArgs e)
        {
            var path = SelectFile();

            if (path != string.Empty)
            {
                file_n.Text = path;
            }
        }

        private string SelectFile()
        {
            string ret = string.Empty;

            //OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "�t�@�C���I���_�C�A���O";
                openFileDialog.Filter = "�G�N�Z���t�@�C��(*.xlsm)|*.xlsm|���ׂẴt�@�C��(*.*)|*.*";
                openFileDialog.InitialDirectory = @"c:\Study\";

                //�t�@�C���I���_�C�A���O���J��
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ret = openFileDialog.FileName;
                }
            }
            return ret;
        }
    }
}
