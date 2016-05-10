using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DMT_renameNameNumbering
{
    public partial class ftm_customName : Form
    {
        private string _userPrefix = "EB-1-1-";
        private int _startNumber = 1;
        private string _stringStyle = "000";

        private string _userSuffix = "-001";

        private string selectionType = "mainpart";

        public ftm_customName()
        {
            InitializeComponent();
        }

        private void ftm_customName_Load(object sender, EventArgs e)
        {
            rb_hor.Checked = true;
            lbl_suffix.Text = "String style";
            txt_prefix.Text = _userPrefix;
            txt_startNr.Text = _startNumber.ToString();
            txt_style.Text = _stringStyle;
            lbl_statusMessage.Text = DateTime.Now.ToString("h:mm:ss") + "\nProgram Loaded";

            updatePreview();
        }

        private void txt_prefix_TextChanged(object sender, EventArgs e)
        {
            _userPrefix = txt_prefix.Text;
            
            updatePreview();
        }
        
        private void txt_startNr_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _startNumber = int.Parse(txt_startNr.Text);
            }
            catch
            {
                _startNumber = 1;
                txt_startNr.Text = _startNumber.ToString();
            }

            updatePreview();

        }

        private void txt_style_TextChanged(object sender, EventArgs e)
        {
            if (rb_vert.Checked)
            {
                _userSuffix = txt_style.Text;
            }
            else
            {
                _stringStyle = txt_style.Text;
            }

            updatePreview();
        }

        private void updatePreview()
        {
            if (rb_vert.Checked)
            {
                lbl_preview.Text = _userPrefix + _startNumber.ToString() + _userSuffix;
                lbl_preview2.Text = _userPrefix + (_startNumber + 1).ToString() + _userSuffix;

            }
            else
            {
                lbl_preview.Text = _userPrefix + _startNumber.ToString(_stringStyle);
                lbl_preview2.Text = _userPrefix + (_startNumber + 1).ToString(_stringStyle);
            }

        }

        private void btn_rename_Click(object sender, EventArgs e)
        {
            try
            {
                callRenameProgram();
            }
            catch
            {
                MessageBox.Show("VIGA");
            }
        }

        private void callRenameProgram()
        {
            NameNumbering program = new NameNumbering(rb_vert.Checked, _userPrefix, _startNumber, _stringStyle, _userSuffix);
            int changed = program.main(selectionType);

            if (changed == -1)
            {
                lbl_statusMessage.Text = DateTime.Now.ToString("h:mm:ss") + "\nViga! Mudel ei ole avatud.";
            }
            else if (changed < 0)
            {
                lbl_statusMessage.Text = DateTime.Now.ToString("h:mm:ss") + "\nVIGA!";
            }
            else
            {
                lbl_statusMessage.Text = DateTime.Now.ToString("h:mm:ss") + "\nMuudetud " + changed.ToString() + " elemendi nime";
            }
        }

        private void rb_hor_CheckedChanged(object sender, EventArgs e)
        {
            lbl_suffix.Text = "String style";
            txt_style.Text = _stringStyle;
            btn_min_1.Enabled = true;
            btn_pls_1.Enabled = true;
            btn_min_2.Enabled = false;
            btn_pls_2.Enabled = false;
        }

        private void rb_vert_CheckedChanged(object sender, EventArgs e)
        {
            lbl_suffix.Text = "Suffix";
            txt_style.Text = _userSuffix;
            btn_min_1.Enabled = false;
            btn_pls_1.Enabled = false;
            btn_min_2.Enabled = true;
            btn_pls_2.Enabled = true;
        }

        private void rb_part_CheckedChanged(object sender, EventArgs e)
        {
            selectionType = "mainpart";
        }

        private void rb_assembly_CheckedChanged(object sender, EventArgs e)
        {
            selectionType = "assembly";
        }

        private void btn_min_1_Click(object sender, EventArgs e)
        {
            string result = superStringBuilder(_userPrefix, "minus", false);
            txt_prefix.Text = result;
        }

        private void btn_pls_1_Click(object sender, EventArgs e)
        {
            string result = superStringBuilder(_userPrefix, "plus", false);
            txt_prefix.Text = result;
        }

        private void btn_min_2_Click(object sender, EventArgs e)
        {
            string result = superStringBuilder(_userSuffix, "minus", true);
            txt_style.Text = result;
        }

        private void btn_pls_2_Click(object sender, EventArgs e)
        {
            string result = superStringBuilder(_userSuffix, "plus", true);
            txt_style.Text = result;
        }

        public static string superStringBuilder(string start, string equation, bool zeroes)
        {
            string newSuperString = start;
            string resultString = "";

            bool canStop = false;
            ArrayList rewriteStringAtIndex = new ArrayList();
            for (int i = start.Length - 1; i >= 0; i--)
            {
                if (Char.IsDigit(start[i]))
                {
                    resultString = start[i] + resultString;
                    canStop = true;
                    int coolValue = i;
                    rewriteStringAtIndex.Insert(0, coolValue);
                }
                else
                {
                    if (canStop) break;
                }
            }

            if (resultString.Length > 0)
            {
                int resultNumber = Int32.Parse(resultString);
                if (equation == "plus")
                {
                    resultNumber++;
                }
                else
                {
                    resultNumber--;
                    if (resultNumber < 0) resultNumber = 0;
                }

                string nullz = "";
                if (zeroes)
                {
                    int lenResult = resultString.Length;
                    for (int i = 0; i < lenResult; i++) nullz += "0";
                }
                string newString = resultNumber.ToString(nullz);

                var aStringBuilder = new StringBuilder(newSuperString);
                aStringBuilder.Remove((int)rewriteStringAtIndex[0], rewriteStringAtIndex.Count);
                aStringBuilder.Insert((int)rewriteStringAtIndex[0], newString);
                newSuperString = aStringBuilder.ToString();
            }

            return newSuperString;
        }
    }
}
