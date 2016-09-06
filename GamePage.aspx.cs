using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jeopardy
{
    public partial class GamePage : System.Web.UI.Page
    {
        public void checkBoxUncheck()
        {
            for (int i = 1; i <= 4; i++)
            {
                RadioButton rad = (RadioButton)Page.FindControl("RadioButton" + i);
                rad.Checked = false;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
            btnCheckAnswer.Enabled = true;
            RadioButton1.Enabled = true;
            RadioButton2.Enabled = true;
            RadioButton3.Enabled = true;
            RadioButton4.Enabled = true;

            if (!IsPostBack)
            {
                questionDisplayWindow.Visible = false;
            }
        }

        protected void btnHtml100_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(btnHtml100.Text) != true)
            //{
            checkBoxUncheck();

            lblDisplayQuestion.Text = GridView1.Rows[0].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[0].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[1].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[2].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[3].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[0].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[1].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[2].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[3].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnHtml100.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnHtml100.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";            
            btnHtml100.Enabled = false;
            Panel1.Enabled = false;
            //}

        }

        protected void btnHtml200_Click(object sender, EventArgs e)
        {

            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[4].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[4].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[5].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[6].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[7].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[4].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[5].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[6].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[7].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnHtml200.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnHtml200.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 4.ToString();
            btnHtml200.Enabled = false;
            Panel1.Enabled = false;

        }

        protected void btnHtml300_Click(object sender, EventArgs e)
        {

            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[8].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[8].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[9].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[10].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[11].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[8].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[9].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[10].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[11].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnHtml300.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnHtml300.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 8.ToString();
            btnHtml300.Enabled = false;
            Panel1.Enabled = false;

        }

        protected void btnHtml400_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[12].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[12].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[13].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[14].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[15].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[12].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[13].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[14].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[15].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnHtml400.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnHtml400.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 12.ToString();
            btnHtml400.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnHtml500_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[16].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[16].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[17].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[18].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[19].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[16].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[17].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[18].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[19].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnHtml500.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnHtml500.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 16.ToString();
            btnHtml500.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnCss100_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[20].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[20].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[21].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[22].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[23].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[20].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[21].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[22].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[23].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnCss100.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnCss100.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 20.ToString();
            btnCss100.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnCss200_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[24].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[24].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[25].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[26].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[27].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[24].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[25].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[26].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[27].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnCss200.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnCss200.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 24.ToString();
            btnCss200.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnCss300_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[28].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[28].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[29].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[30].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[31].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[28].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[29].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[30].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[31].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnCss300.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnCss300.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 28.ToString();
            btnCss300.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnCss400_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[32].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[32].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[33].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[34].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[35].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[32].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[33].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[34].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[35].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnCss400.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnCss400.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 32.ToString();
            btnCss400.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnCss500_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[36].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[36].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[37].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[38].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[39].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[36].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[37].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[38].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[39].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnCss500.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnCss500.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 36.ToString();
            btnCss500.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnJs100_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[40].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[40].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[41].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[42].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[43].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[40].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[41].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[42].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[43].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnJs100.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnJs100.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 40.ToString();
            btnJs100.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnJs200_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[44].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[44].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[45].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[46].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[47].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[44].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[45].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[46].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[47].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnJs200.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnJs200.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 44.ToString();
            btnJs200.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnJs300_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[48].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[48].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[49].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[50].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[51].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[48].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[49].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[50].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[51].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnJs300.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnJs300.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 48.ToString();
            btnJs300.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnJs400_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[52].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[52].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[53].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[54].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[55].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[52].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[53].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[54].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[55].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnJs400.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnJs400.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 52.ToString();
            btnJs400.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnJs500_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[56].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[56].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[57].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[58].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[59].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[56].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[57].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[58].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[59].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnJs500.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnJs500.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 56.ToString();
            btnJs500.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnTsql100_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[60].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[60].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[61].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[62].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[63].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[60].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[61].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[62].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[63].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnTsql100.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnTsql100.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 60.ToString();
            btnTsql100.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnTsql200_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[64].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[64].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[65].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[66].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[67].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[64].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[65].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[66].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[67].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnTsql200.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnTsql200.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 64.ToString();
            btnTsql200.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnTsql300_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[68].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[68].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[69].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[70].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[71].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[68].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[69].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[70].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[71].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnTsql300.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnTsql300.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 68.ToString();
            btnTsql300.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnTsql400_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[72].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[72].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[73].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[74].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[75].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[72].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[73].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[74].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[75].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnTsql400.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnTsql400.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 72.ToString();
            btnTsql400.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnTsql500_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[76].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[76].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[77].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[78].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[79].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[76].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[77].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[78].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[79].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnTsql500.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnTsql500.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 76.ToString();
            btnTsql500.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnCS100_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[80].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[80].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[81].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[82].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[83].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[80].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[81].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[82].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[83].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnCS100.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnCS100.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 80.ToString();
            btnCS100.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnCS200_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[84].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[84].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[85].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[86].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[87].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[84].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[85].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[86].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[87].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnCS200.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnCS200.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 84.ToString();
            btnCS200.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnCs300_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[88].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[88].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[89].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[90].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[91].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[88].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[89].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[90].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[91].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnCs300.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnCs300.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 88.ToString();
            btnCs300.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnCs400_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[92].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[92].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[93].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[94].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[95].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[92].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[93].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[94].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[95].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnCs400.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnCs400.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 92.ToString();
            btnCs400.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnCs500_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[96].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[96].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[97].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[98].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[99].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[96].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[97].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[98].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[99].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnCs500.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnCs500.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 96.ToString();
            btnCs500.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnASP100_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[100].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[100].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[101].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[102].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[103].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[100].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[101].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[102].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[103].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnASP100.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnASP100.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 100.ToString();
            btnASP100.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnASP200_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[104].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[104].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[105].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[106].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[107].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[104].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[105].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[106].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[107].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnASP200.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnASP200.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 104.ToString();
            btnASP200.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnASP300_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[108].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[108].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[109].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[110].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[111].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[108].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[109].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[110].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[111].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnASP300.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnASP300.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            //lblRowIndex.Text = 108.ToString();
            btnASP300.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnASP400_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[112].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[112].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[113].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[114].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[115].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[112].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[113].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[114].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[115].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnASP400.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnASP400.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            btnASP400.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnASP500_Click(object sender, EventArgs e)
        {
            checkBoxUncheck();
            lblDisplayQuestion.Text = GridView1.Rows[116].Cells[7].Text;
            RadioButton1.Text = " " + GridView1.Rows[116].Cells[10].Text;
            RadioButton2.Text = " " + GridView1.Rows[117].Cells[10].Text;
            RadioButton3.Text = " " + GridView1.Rows[118].Cells[10].Text;
            RadioButton4.Text = " " + GridView1.Rows[119].Cells[10].Text;

            lblAnswer1.Text = GridView1.Rows[116].Cells[11].Text;
            lblAnswer2.Text = GridView1.Rows[117].Cells[11].Text;
            lblAnswer3.Text = GridView1.Rows[118].Cells[11].Text;
            lblAnswer4.Text = GridView1.Rows[119].Cells[11].Text;

            questionDisplayWindow.Visible = true;
            lblButtonAmount.Text = btnASP500.Text.Trim();
            lblNumQuestionDisplayed.Text = (Convert.ToInt16(lblNumQuestionDisplayed.Text) + 1).ToString();
            btnASP500.Text = " ";
            lblCorrectIncorrect.Text = " ";
            lblAnswerDisplay.Text = " ";
            btnASP500.Enabled = false;
            Panel1.Enabled = false;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {


        }

        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            //Keep track of correct answers and display the score 
            if(lblCorrectIncorrect.Text.Trim() == "CORRECT!")
            {
                txtScore.Text = (Convert.ToInt16(txtScore.Text) + Convert.ToInt16(lblButtonAmount.Text.Substring(1, 3))).ToString();

                //check if all the questions are answered and add bonus
                if (lblCorrectAnswers.Text == "30")
                {
                    txtScore.Text = (Convert.ToInt16(txtScore.Text) + 1350).ToString();
                    lblBonus.Text = "1350";
                }

            }

            //Check weather the final question is displayed and enable the play again button
            if (lblNumQuestionDisplayed.Text == "30")
            {
                btnPlayAgain.Enabled = true;
            }               
            
            questionDisplayWindow.Visible = false;
            Panel1.Enabled = true;
        }

        protected void btnCheck_Click1(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
               
                //Check if the final question is displayed and change the text value of the next button to Finish
                if(lblNumQuestionDisplayed.Text == "30")
                {
                    btnNext.Text = "Finish";
                }

                btnNext.Enabled = true;
                btnCheckAnswer.Enabled = false;
                RadioButton1.Enabled = false;
                RadioButton2.Enabled = false;
                RadioButton3.Enabled = false;
                RadioButton4.Enabled = false;

                if (lblAnswer1.Text.Trim() == "yes")
                {
                    lblCorrectIncorrect.Text = "CORRECT!";
                    lblCorrectIncorrect.ForeColor = System.Drawing.Color.Green;

                    lblCorrectAnswers.Text = (Convert.ToInt16(lblCorrectAnswers.Text) + 1).ToString();
                }
                else
                {
                    lblCorrectIncorrect.Text = "INCORRECT!";
                    lblCorrectIncorrect.ForeColor = System.Drawing.Color.Red;

                    if (lblAnswer2.Text.Trim() == "yes")
                    {
                        lblAnswerDisplay.Text = "The Correct answer is---" + RadioButton2.Text;
                    }
                    else if (lblAnswer3.Text.Trim() == "yes")
                    {
                        lblAnswerDisplay.Text = "The Correct answer is---" + RadioButton3.Text;
                    }
                    else
                    {
                        lblAnswerDisplay.Text = "The Correct answer is---" + RadioButton4.Text;
                    }
                }
            }

            else if (RadioButton2.Checked)
            {

                //Check if the final question is displayed and change the text value of the next button to Finish
                if (lblNumQuestionDisplayed.Text == "30")
                {
                    btnNext.Text = "Finish";
                }

                btnNext.Enabled = true;
                btnCheckAnswer.Enabled = false;
                RadioButton1.Enabled = false;
                RadioButton2.Enabled = false;
                RadioButton3.Enabled = false;
                RadioButton4.Enabled = false;

                if (lblAnswer2.Text.Trim() == "yes")
                {
                    lblCorrectIncorrect.Text = "CORRECT!";
                    lblCorrectIncorrect.ForeColor = System.Drawing.Color.Green;

                    lblCorrectAnswers.Text = (Convert.ToInt16(lblCorrectAnswers.Text) + 1).ToString();
                }
                else
                {
                    lblCorrectIncorrect.Text = "INCORRECT!";
                    lblCorrectIncorrect.ForeColor = System.Drawing.Color.Red;

                    if (lblAnswer1.Text.Trim() == "yes")
                    {
                        lblAnswerDisplay.Text = "The Correct answer is---" + RadioButton1.Text;
                    }
                    else if (lblAnswer3.Text.Trim() == "yes")
                    {
                        lblAnswerDisplay.Text = "The Correct answer is---" + RadioButton3.Text;
                    }
                    else
                    {
                        lblAnswerDisplay.Text = "The Correct answer is---" + RadioButton4.Text;
                    }
                }
            }

            else if (RadioButton3.Checked)
            {

                //Check if the final question is displayed and change the text value of the next button to Finish
                if (lblNumQuestionDisplayed.Text == "30")
                {
                    btnNext.Text = "Finish";
                }

                btnNext.Enabled = true;
                btnCheckAnswer.Enabled = false;
                RadioButton1.Enabled = false;
                RadioButton2.Enabled = false;
                RadioButton3.Enabled = false;
                RadioButton4.Enabled = false;

                if (lblAnswer3.Text.Trim() == "yes")
                {
                    lblCorrectIncorrect.Text = "CORRECT!";
                    lblCorrectIncorrect.ForeColor = System.Drawing.Color.Green;

                    lblCorrectAnswers.Text = (Convert.ToInt16(lblCorrectAnswers.Text) + 1).ToString();
                }
                else
                {
                    lblCorrectIncorrect.Text = "INCORRECT!";
                    lblCorrectIncorrect.ForeColor = System.Drawing.Color.Red;

                    if (lblAnswer1.Text.Trim() == "yes")
                    {
                        lblAnswerDisplay.Text = "The Correct answer is---" + RadioButton1.Text;
                    }
                    else if (lblAnswer2.Text.Trim() == "yes")
                    {
                        lblAnswerDisplay.Text = "The Correct answer is---" + RadioButton2.Text;
                    }
                    else
                    {
                        lblAnswerDisplay.Text = "The Correct answer is---" + RadioButton4.Text;
                    }
                }
            }
            
            else if (RadioButton4.Checked)
            {

                //Check if the final question is displayed and change the text value of the next button to Finish
                if (lblNumQuestionDisplayed.Text == "30")
                {
                    btnNext.Text = "Finish";
                }

                btnNext.Enabled = true;
                btnCheckAnswer.Enabled = false;
                RadioButton1.Enabled = false;
                RadioButton2.Enabled = false;
                RadioButton3.Enabled = false;
                RadioButton4.Enabled = false;

                if (lblAnswer4.Text.Trim() == "yes")
                {
                    lblCorrectIncorrect.Text = "CORRECT!";
                    lblCorrectIncorrect.ForeColor = System.Drawing.Color.Green;

                    lblCorrectAnswers.Text = (Convert.ToInt16(lblCorrectAnswers.Text) + 1).ToString();
                }
                else
                {
                    lblCorrectIncorrect.Text = "INCORRECT!";
                    lblCorrectIncorrect.ForeColor = System.Drawing.Color.Red;

                    if (lblAnswer1.Text.Trim() == "yes")
                    {
                        lblAnswerDisplay.Text = "The Correct answer is---" + RadioButton1.Text;
                    }
                    else if (lblAnswer2.Text.Trim() == "yes")
                    {
                        lblAnswerDisplay.Text = "The Correct answer is---" + RadioButton2.Text;
                    }
                    else
                    {
                        lblAnswerDisplay.Text = "The Correct answer is---" + RadioButton3.Text;
                    }
                }
            }
            else
            {
                lblCorrectIncorrect.Text = "Please select an answer";
                lblCorrectIncorrect.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Server.Transfer(Request.Path);
        }
    }
}