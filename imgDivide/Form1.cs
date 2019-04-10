using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imgDivide
{
    public partial class frm_divide : Form
    {
        public frm_divide()
        {
            InitializeComponent();
        }

        private void btn_doit_Click(object sender, EventArgs e)
        {
            //spisak file-ova u folderu - super bi bilo ako moze da se sortira po datumu

            String path_ = @"c:\";
            DirectoryInfo di = new DirectoryInfo(txt_source.Text);
            FileInfo[] fiArray = di.GetFiles();

            Array.Sort(fiArray, (x, y) => StringComparer.OrdinalIgnoreCase.Compare(x.CreationTime, y.CreationTime));

            DateTime lastDT_=fiArray[0].CreationTime;

            foreach (FileInfo fi in fiArray)
            {
                //sada mozes dalje da ispitujes
                TimeSpan ts_ = fi.CreationTime - lastDT_;
                if (ts_.Minutes<Int32.Parse(txt_interval.Text))
                {
                    //sada ga kopira u nesto a ako ne 

                } else
                {
                    //znaci da je potrebno resetovati sve na pocetak
                    //prvo idemo na lastDT_
                    lastDT_ = fi.CreationTime;
                    //pravimo novi folder

                    //kopiramo file u njega
                    String destination = txt_destination.Text;
                    fi.CopyTo(destination + "\\" + fi.Name);
                }
            }



        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            fBD.ShowNewFolderButton = false;
            fBD.SelectedPath = "";
            fBD.ShowDialog();
            if (fBD.SelectedPath != null)
            {
                txt_source.Text = fBD.SelectedPath;
            }
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            fBD.ShowNewFolderButton = true;
            fBD.SelectedPath = "";
            fBD.ShowDialog();
            if (fBD.SelectedPath != null)
            {
                txt_destination.Text = fBD.SelectedPath;
            }
        }
    }
}
