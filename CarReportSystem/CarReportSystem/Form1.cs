using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmMain : Form {
        //BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        public fmMain() {
            InitializeComponent();
            //dgvRegistData.DataSource = listCarReport;
        }
        //終了ボタン
        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();//アプリケーション終了
        }
        //画像開くボタン
        private void btPictureOpen_Click(object sender, EventArgs e) {
            if(ofdPictureOpen.ShowDialog()== DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }
        //画像の削除ボタン
        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }
        //選択されているメーカーの名前を返す
        private CarReport.MakerGroup selectedGroup() {
            foreach (RadioButton rb in gbMaker.Controls) {
                if (rb.Checked) {
                    return (CarReport.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag));
                }

            }
            return CarReport.MakerGroup.その他;
        }

        //コンボボックスに記録者をセットする
        private void setCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author)) {

                cbAuthor.Items.Add(author);
            }
        }
        //コンボボックスに車名をセットする
        private void setCbCarName(string carName) {

            if (!cbCarName.Items.Contains(carName)) {

                cbCarName.Items.Add(carName);
            }
        }


        private void btDataAdd_Click(object sender, EventArgs e) {
            if (cbAuthor.Text == "" || cbCarName.Text == "") {
                MessageBox.Show("入力してください");
                return;
            }
            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = selectedGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image
            };
            //リストにデータを追加
            //listCarReport.Insert(0,carReport);

            //コンボボックスに履歴を登録
            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);

            //入力内容のリセット
            cbAuthor.Text = "";
            cbCarName.Text = "";
            tbReport.Clear();

        }
        
        private void setMakerRadioButton(CarReport.MakerGroup mg) {
                switch (mg)
                {
                    case CarReport.MakerGroup.トヨタ:
                        rbToyota.Checked = true;
                        break;
                    case CarReport.MakerGroup.日産:
                        rbNissan.Checked = true;
                        break;
                    case CarReport.MakerGroup.ホンダ:
                        rbHonda.Checked = true;
                        break;
                    case CarReport.MakerGroup.スバル:
                        rbSubaru.Checked = true;
                        break;
                    case CarReport.MakerGroup.外国車:
                        rbInport.Checked = true;
                        break;
                }
        }

        
        //更新ボタンイベント処理
        private void btUpdate_Click(object sender, EventArgs e) {
            if (carReportDataGridView.CurrentRow == null) return;
            carReportDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;    
            carReportDataGridView.CurrentRow.Cells[2].Value = cbAuthor.Text;
            carReportDataGridView.CurrentRow.Cells[3].Value = selectedGroup().ToString();
            carReportDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;
            carReportDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;
            carReportDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray( pbPicture.Image);
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202104DataSet);
#if false
            if (sfdFileSave.ShowDialog() == DialogResult.OK) {
                try { 
                var bf = new BinaryFormatter();
                //バイナリ形式でシリアル化
                using (FileStream fs = File.Open(sfdFileSave.FileName, FileMode.Create)) {
                    bf.Serialize(fs, listCarReport);
                }
            }catch(Exception ex) {
                 MessageBox.Show(ex.Message);
              }
            }
#endif
        }

        private void btConnect_Click(object sender, EventArgs e) {
            this.carReportTableAdapter.Fill(this.infosys202104DataSet.CarReport);
            for (int i = 1; i < carReportDataGridView.RowCount; i++)
            {
                setCbAuthor(carReportDataGridView.Rows[i-1].Cells[2].Value.ToString());
                setCbCarName(carReportDataGridView.Rows[i-1].Cells[4].Value.ToString());
            }
#if false
            if (ofdFileOpen.ShowDialog() == DialogResult.OK) {
                try { 
                var bf = new BinaryFormatter();
                //バイナリ形式で逆シリアル化
                using (FileStream fs = File.Open(ofdFileOpen.FileName, FileMode.Open,FileAccess.Read)) {
                    //逆シリアル化して読み込む
                    listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                    dgvRegistData.DataSource = null;
                    dgvRegistData.DataSource = listCarReport;
                }
            }
                catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                //読み込んだデータを各コンボボックスに登録する
               for(int i=0;i<dgvRegistData.RowCount;i++){ 
                setCbAuthor(dgvRegistData.Rows[i].Cells[1].Value.ToString());
                setCbCarName(dgvRegistData.Rows[i].Cells[3].Value.ToString());
               }
            }
#endif
        }
      

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202104DataSet);

        }

        private void fmMain_Load_1(object sender, EventArgs e)
        {
            carReportDataGridView.Columns[0].Visible    = false;
            carReportDataGridView.Columns[1].HeaderText = "日付";
            carReportDataGridView.Columns[2].HeaderText = "記録者";
            carReportDataGridView.Columns[3].HeaderText = "メーカー";
            carReportDataGridView.Columns[4].HeaderText = "車名";
            carReportDataGridView.Columns[5].HeaderText = "レポート";
            //carReportDataGridView.Columns[6].HeaderText = "画像";
            carReportDataGridView.Columns[6].Visible = false;

        }

        private void carReportDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (carReportDataGridView.CurrentRow == null) return;
            try
            {
                dtpDate.Value   = (DateTime)carReportDataGridView.CurrentRow.Cells[1].Value;
                cbAuthor.Text   = carReportDataGridView.CurrentRow.Cells[2].Value.ToString();
                try
                {
                    setMakerRadioButton((CarReport.MakerGroup)Enum.Parse(typeof(CarReport.MakerGroup),
                      carReportDataGridView.CurrentRow.Cells[3].Value.ToString()));//メーカー文字列→列挙型
                }
                catch(Exception ex)
                {
                    rbOther.Checked = true;
                    ssError.Text = ex.Message;
                }
                cbCarName.Text  = carReportDataGridView.CurrentRow.Cells[4].Value.ToString();
                tbReport.Text   = carReportDataGridView.CurrentRow.Cells[5].Value.ToString();
                pbPicture.Image = ByteArrayToImage((byte[])carReportDataGridView.CurrentRow.Cells[6].Value);
            }
            catch (InvalidCastException)
            {
                pbPicture.Image  = null;
            }
            catch(Exception ex)
            {
                ssError.Text = ex.Message;
            }
        }
        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b)
        {
            Image img = null;
            if (b.Length > 0)
            {
                ImageConverter imgconv = new ImageConverter();
                img=(Image)imgconv.ConvertFrom(b);
            }
            return img;
        }
        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void carReportDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            cbAuthor.Text = "";
            cbCarName.Text = "";
            tbReport.Text = "";
            setMakerRadioButton(CarReport.MakerGroup.その他);
           
        }
    }
}
