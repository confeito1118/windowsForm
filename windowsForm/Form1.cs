using System;
using System.IO;
using System.Web;

// NuGet Excel
using Spire.Xls;
// NuGet HTML
using HtmlAgilityPack;

namespace windowsForm
{
    public partial class Form1 : Form
    {
        public const int SOFT_VERSION = 101;
        public bool SOFT_VERSION_FLAG = false;

        public Form1()
        {
            InitializeComponent();
            versionCheck();
        }
        public void versionCheck()
        {
            // ぺーでーえふぺいの最新バージョン情報の確認
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load("https://npo-yudu.jp/pei/pdfpei.html");
            // var node = htmlDoc.DocumentNode.SelectSingleNode("//head/title");
            var node = htmlDoc.DocumentNode.SelectSingleNode("//head/version");
            // HTMLタグ付き <title>Yahoo</title>
            // MessageBox.Show("Node Name: " + node.Name + "\n" + node.OuterHtml);
            // HTMLタグ無し Yahoo
            // MessageBox.Show("Node Name: " + node.Name + "\n" + node.InnerText);
            int test = Int32.Parse(node.InnerText);
            if (test == SOFT_VERSION)
            {
                MessageBox.Show("ご利用のバージョンは最新版です");
            } else
            {
                MessageBox.Show("ご利用のバージョンは最新版ではありません。\n最新版をダウンロードしてください");
                this.Close();
            }
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
            }
            else
            {
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

                // Excelのシート数を取得
                int sheetCnt = workbook.Worksheets.Count;
                // MessageBox.Show(Convert.ToString(sheetCnt)); // シート数の表示

                //変換時にページに合うようにワークシートを設定する
                workbook.ConverterSetting.SheetFitToPage = true;

                for (int i = 0; i < sheetCnt; i++)
                {
                    //最初のワークシートを取得する
                    Worksheet worksheet = workbook.Worksheets[i];
                    var sheetName = worksheet.Name;

                    // MessageBox.Show(sheetName);

                    if (String.IsNullOrEmpty(sheetName))
                    {

                    } else
                    {
                        //PDFに保存する
                        worksheet.SaveToPdf(dirName + "\\" + fileName + "_" + sheetName + ".pdf");
                    }

                }

                MessageBox.Show(
                    Convert.ToString(sheetCnt) + "枚分のシートをPDFに変換しました",
                    "処理終了",
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
