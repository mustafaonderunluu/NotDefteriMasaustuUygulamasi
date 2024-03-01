using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotDefteriUygulaması
{
    public partial class Form1 : Form
    {
        private int TabCount = 0; //sekme Sayısı(belge sayısı aktif olan) 
        public Form1()
        {
            InitializeComponent();
        }
        #region Metotlar
        #region Sekmeler
        private void AddTab() //sekme ekleme 
        {
        
        
        
        
        } 
        private void RemoveTab() //sekme kapat
        
        {


        }
        private void RemoveAllTabs() //Tüm sekmeleri kapat
        {
        
        
       
        }
        private void RemoveAllTabsButThis() //Açık olan haricinde sekmeleri kaldır
        {
        
        
        
        }
        #endregion
        #endregion
        #region SaveAndOpen(KaydetAç)

        private void Save() //kaydetme
        {
        
        
        }
        private void SaveAs() //Farklı isimle Kaydet
        {
        
        
        
        }

        private void Open() //Belge Açma
        
        {
        
        
        }




        #endregion
        #region Özellikler
        private RichTextBox GetCurrnetDocument 
        {
            get { return (RichTextBox)tabControl1.SelectedTab.Controls["Body"]; }


        }
        #endregion





        private void düzenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
