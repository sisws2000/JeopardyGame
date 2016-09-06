<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GamePage.aspx.cs" Inherits="Jeopardy.GamePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        * {
            margin: 0;
            padding: 0;
        }

        body {
            background-color: rgb(163, 152, 152);
        }

        .displayAll {
            position: absolute;
            left: -999em;            
        }
        /*#gameQuestionDisplay {
            margin-right:0;
        }*/
        #questionDisplayWindow {
            clear: left;
            position: absolute;
            margin-top: 100px;
            margin-left: 100px;
            padding-top: 100px;
            width: 1750px;
            height: 700px;
            background-color: white;
            opacity: .99;
            box-shadow: 2px 2px 2px rgb(128, 128, 128);
            border-radius: 25px;
        }

        #questionDiv {
            margin-left: 50px;
            margin-right:50px;
        }

        #answerDiv {
            margin-left: 400px;
        }

        #questionbuttons {
            float: left;
            margin-left: 250px;
            margin-top: 30px;
            margin-right: 50px;
        }

        #scoreRecord {
            float: left;
            margin-top: 300px;
            height: 277px;
            width: 358px;
        }

        .radioAnswer {
            zoom: 200%;
        }
        #lblAnswer {
            margin-top:50px;
            margin-left:300px;
        }
        #btnCheckAnswer {
            margin-top: 150px;
            margin-left: 450px;
        }

        .questionType {
            background-color: #45971b;
            border: 2px solid black;
        }

        .gameQuestionDisplay {
            background-color: #f58d00;
        }
        .gameQuestionDisplay:hover {
            background-color:rgb(182, 255, 0);
            border:2px solid green;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="questionbuttons">

            <asp:Panel ID="Panel1" runat="server" Font-Size="X-Large">
                <asp:Button ID="btnHtml" runat="server" Text="HTML" Font-Bold="True" Font-Italic="True" Font-Size="Larger" Height="74px" Width="191px" Enabled="False" EnableTheming="False" ForeColor="#333300" CssClass="questionType" />
                <asp:Button ID="btnCss" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Larger" Height="74px" Text="CSS" Width="191px" CssClass="questionType" Enabled="False" ForeColor="#333300" />
                <asp:Button ID="btnJs" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Larger" Height="74px" Text="JS" Width="191px" CssClass="questionType" Enabled="False" ForeColor="#333300" />
                <asp:Button ID="btnTsql" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Larger" Height="74px" Text="T-SQL" Width="191px" CssClass="questionType" Enabled="False" ForeColor="#333300" />
                <asp:Button ID="btnCSharp" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Larger" Height="74px" Text="C#" Width="191px" CssClass="questionType" Enabled="False" ForeColor="#333300" />
                <asp:Button ID="btnAsp" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Larger" Height="74px" Text="ASP.NET" Width="191px" CssClass="questionType" Enabled="False" ForeColor="#333300" />
                <br />
                <asp:Button ID="btnHtml100" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$100" Width="191px" OnClick="btnHtml100_Click" CssClass="gameQuestionDisplay" />
                <asp:Button ID="btnCss100" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$100" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnCss100_Click" />
                <asp:Button ID="btnJs100" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$100" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnJs100_Click" />
                <asp:Button ID="btnTsql100" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$100" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnTsql100_Click" />
                <asp:Button ID="btnCS100" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$100" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnCS100_Click" />
                <asp:Button ID="btnASP100" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$100" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnASP100_Click" />
                <br />
                <asp:Button ID="btnHtml200" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$200" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnHtml200_Click" />
                <asp:Button ID="btnCss200" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$200" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnCss200_Click" />
                <asp:Button ID="btnJs200" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$200" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnJs200_Click" />
                <asp:Button ID="btnTsql200" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$200" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnTsql200_Click" />
                <asp:Button ID="btnCS200" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$200" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnCS200_Click" />
                <asp:Button ID="btnASP200" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$200" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnASP200_Click" />
                <br />
                <asp:Button ID="btnHtml300" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$300" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnHtml300_Click" />
                <asp:Button ID="btnCss300" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$300" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnCss300_Click" />
                <asp:Button ID="btnJs300" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$300" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnJs300_Click" />
                <asp:Button ID="btnTsql300" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$300" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnTsql300_Click" />
                <asp:Button ID="btnCs300" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$300" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnCs300_Click" />
                <asp:Button ID="btnASP300" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$300" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnASP300_Click" />
                <br />
                <asp:Button ID="btnHtml400" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$400" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnHtml400_Click" />
                <asp:Button ID="btnCss400" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$400" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnCss400_Click" />
                <asp:Button ID="btnJs400" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$400" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnJs400_Click" />
                <asp:Button ID="btnTsql400" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$400" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnTsql400_Click" />
                <asp:Button ID="btnCs400" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$400" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnCs400_Click" />
                <asp:Button ID="btnASP400" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$400" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnASP400_Click" />
                <br />
                <asp:Button ID="btnHtml500" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$500" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnHtml500_Click" />
                <asp:Button ID="btnCss500" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$500" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnCss500_Click" />
                <asp:Button ID="btnJs500" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$500" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnJs500_Click" />
                <asp:Button ID="btnTsql500" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$500" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnTsql500_Click" />
                <asp:Button ID="btnCs500" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$500" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnCs500_Click" />
                <asp:Button ID="btnASP500" runat="server" Font-Bold="True" Font-Size="Larger" Height="165px" Text="$500" Width="191px" CssClass="gameQuestionDisplay" OnClick="btnASP500_Click" />
                <br />
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="displayAll" DataKeyNames="QuestionCatagoryID,DefficultyID,QuestionID,AnswerID" DataSourceID="html100">
                    <Columns>
                        <asp:BoundField DataField="QuestionCatagoryID" HeaderText="QuestionCatagoryID" ReadOnly="True" SortExpression="QuestionCatagoryID" InsertVisible="False" />
                        <asp:BoundField DataField="QuesionCatagoryName" HeaderText="QuesionCatagoryName" SortExpression="QuesionCatagoryName" />
                        <asp:BoundField DataField="DefficultyID" HeaderText="DefficultyID" InsertVisible="False" ReadOnly="True" SortExpression="DefficultyID" />
                        <asp:BoundField DataField="QuestionCatagoryID1" HeaderText="QuestionCatagoryID1" SortExpression="QuestionCatagoryID1" />
                        <asp:BoundField DataField="DifficultyAmount" HeaderText="DifficultyAmount" SortExpression="DifficultyAmount" />
                        <asp:BoundField DataField="QuestionID" HeaderText="QuestionID" ReadOnly="True" SortExpression="QuestionID" InsertVisible="False" />
                        <asp:BoundField DataField="DefficultyID1" HeaderText="DefficultyID1" SortExpression="DefficultyID1" />
                        <asp:BoundField DataField="QuestionText" HeaderText="QuestionText" SortExpression="QuestionText" />
                        <asp:BoundField DataField="AnswerID" HeaderText="AnswerID" InsertVisible="False" ReadOnly="True" SortExpression="AnswerID" />
                        <asp:BoundField DataField="QuestionID1" HeaderText="QuestionID1" SortExpression="QuestionID1" />
                        <asp:BoundField DataField="Answers" HeaderText="Answers" SortExpression="Answers" />
                        <asp:BoundField DataField="CorrectAnswer" HeaderText="CorrectAnswer" SortExpression="CorrectAnswer" />
                    </Columns>
                </asp:GridView>

            </asp:Panel>
        </div>
        <div id="scoreRecord">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Score:" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txtScore" runat="server" Height="32px" Width="114px" BackColor="Lime" Font-Size="X-Large" ReadOnly="True" Style="text-align:center">0</asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Bonus scores:"></asp:Label>
&nbsp;
            <asp:Label ID="lblBonus" runat="server" Font-Size="X-Large" Text="0"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnPlayAgain" runat="server" BackColor="#99CCFF" Enabled="False" Font-Bold="True" Font-Size="Large" Height="37px" OnClick="btnPlayAgain_Click" Text="Play again" Width="144px" />
                <br />
        </div>

        <div id="questionDisplayWindow" runat="server" >
            <div id="questionDiv" runat="server">
                <asp:Label ID="lblDisplayQuestion" runat="server" CssClass="questionDisplayLabel" Font-Size="XX-Large"></asp:Label>
            </div>
            <br />
            <div id="answerDiv" runat="server">
                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Answer choice" CssClass="radioAnswer" Font-Size="Large" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblAnswer1" runat="server" Visible="False"></asp:Label>
                <br />
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Answer choice" CssClass="radioAnswer" Font-Size="Large" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblAnswer2" runat="server" Visible="False"></asp:Label>
                <br />
                <asp:RadioButton ID="RadioButton3" runat="server" GroupName="Answer choice" CssClass="radioAnswer" Font-Size="Large" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblAnswer3" runat="server" Visible="False"></asp:Label>
                <br />
                <asp:RadioButton ID="RadioButton4" runat="server" GroupName="Answer choice" CssClass="radioAnswer" Font-Size="Large" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblAnswer4" runat="server" Visible="False"></asp:Label>
                <br />
                <asp:SqlDataSource ID="html100" runat="server" ConnectionString="<%$ ConnectionStrings:JeopardyConnectionString %>" SelectCommand="GetAllQuestionAndAnswer" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                <br />
            </div>
            <div id="lblAnswer">
                <asp:Label ID="lblButtonAmount" runat="server" Font-Size="Medium" Visible="False" Enabled="False"></asp:Label>
                &nbsp;<asp:Label ID="lblNumQuestionDisplayed" runat="server" Text="0" Visible="False"></asp:Label>
&nbsp;<asp:Label ID="lblCorrectAnswers" runat="server" Text="0" Visible="False"></asp:Label>
                <br />
                <br />
                <br />
                <asp:Label ID="lblCorrectIncorrect" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblAnswerDisplay" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
            </div>

            <asp:Button ID="btnCheckAnswer" runat="server" Text="Check Answer" Font-Bold="True" Font-Size="X-Large" Height="59px" Width="242px" AutoPostBack="False" OnClick="btnCheck_Click1" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnNext" runat="server" Enabled="False" Font-Bold="True" Font-Size="X-Large" Height="59px" OnClick="btnNext_Click" Text="Next" Width="142px" />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
<script>

    
</script>
</html>
