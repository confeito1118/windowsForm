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
                    "ファイルを指定していません",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand
                );
            } else {
                // ディレクトリ名
                var dirName = Path.GetDirectoryName(file_n.Text);
                // ファイル名（拡張子無し）
                var fileName = Path.GetFileNameWithoutExtension(file_n.Text);
                // 拡張子名
                var extensionName = Path.GetExtension(file_n.Text);

                // MessageBox.Show(dirName);
                // MessageBox.Show(fileName);
                // MessageBox.Show(extensionName);

                //Workbookインスタンスを作成する
                Workbook workbook = new Workbook();

                //サンプルExcel文書をロードする
                workbook.LoadFromFile(dirName + "\\" + fileName + extensionName);

                //変換時にページに合うようにワークシートを設定する
                workbook.ConverterSetting.SheetFitToPage = true;

                for (int i = 0; i < 10; i++)
                {
                    //最初のワークシートを取得する
                    Worksheet worksheet = workbook.Worksheets[i];
                    var sheetName = worksheet.Name;

                    if (String.IsNullOrEmpty(sheetName))
                    {

                    } else
                    {
                        //PDFに保存する
                        worksheet.SaveToPdf(dirName + "\\" + fileName + "_" + sheetName + ".pdf");
                    }
                }

                MessageBox.Show(
                    "終了",
                    "無事",
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
                openFileDialog.Title = "ファイル選択ダイアログ";
                openFileDialog.Filter = "エクセルファイル(*.xlsm)|*.xlsm|すべてのファイル(*.*)|*.*";
                openFileDialog.InitialDirectory = @"c:\Study\";

                //ファイル選択ダイアログを開く
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ret = openFileDialog.FileName;
                }
            }
            return ret;
        }
    }
}
