using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseCalc
{
    public partial class Form1 : Form
    {
        private double result = 0; // 결과 값

        private String buf = "";    // 연산하기 전 입력받고있는 값
        private String buffer = ""; // 입력 받은 값
        private String m_buf = "0";

        private String val = "";    // 계산하기위한 연산값
        private String buf_val = "";// 연산값 임시저장

        private bool dot = false;   // "." 확인


        public Form1()
        {
            InitializeComponent();

            numTextBox.Text = "0";  // 텍스트 박스의 초기 값을 0으로 표시
        }

        private void MakeButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("개발 중 입니다.");   // 이벤트 핸들러 미지정
        }
        private void NumButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;    // 이벤트가 발생한 객체
            buffer = btn.Text;  // 발생한 버튼의 문자열을 저장

            if (buf.Contains(".") && buffer.Equals(".")) // 문자열에 .이 있고 입력받은 값이 . 이면 값 삭제
                buffer = "";

            buf += buffer;  // 연산하기 전까지의 입력 값을 저장
            numTextBox.Text = buf;  // 텍스트 박스에 표시
        }

        private void SignButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;    // 이벤트가 발생한 객체
            String btnText = btn.Text;  // 발생한 버튼의 문자열을 저장
            String sign = numTextBox.Text;

            switch (btnText)
            {
                case "<-":
                    if(sign.Length>0)
                        buf = sign.Remove(sign.Length - 1);

                    break;
                case "±":
                    if (sign.Contains("+"))
                    {
                        buf = sign.Replace("+", "-");
                    }
                    else if (sign.Contains("-"))
                    {
                        buf = sign.Replace("-", "+");
                    }
                    else
                        buf = sign.Insert(0, "+");
                    break;
            }
            numTextBox.Text = buf;
        }
        private void OpButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            val = btn.Text; // 아래의 세 연산의 경우 바로 결과값을 나타내기 위해 val에 저장

            switch (val)
            {
                case "1/x":

                    result = 1 / double.Parse(buf);
                    numTextBox.Text = result.ToString();
                    buf = result.ToString();    //결과를 바로 사용할수 있게 buf에 저장
                    break;

                case "CE":
    //                if (!numTextBox.Text.Equals(""))
   //                     result = double.Parse(numTextBox.Text); // 입력된 값을 저장

                    buf = "";
                    numTextBox.Text = buf.ToString();

                    break;
                case "√":
                    double rootnum = double.Parse(numTextBox.Text);
                    rootnum = Math.Pow(rootnum, 0.5);
                    numTextBox.Text = rootnum.ToString();

                    break;
            }

            val = buf_val;  // 만약 연산자를 입력받았다면 다음 숫자가 입력되면 바로 실행되도록
        }

        private void ValButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            buf_val = btn.Text; // 연산자 임시저장
            opTextBox.Text = buf_val;   // 연산자 텍스트 박스에 표시

            switch (buf_val)
            {
                case "+":
                    CalcFunc();
                    opTextBox.Text = buf_val;

                    break;
                case "-":
                    CalcFunc();
                    opTextBox.Text = buf_val;

                    break;

                case "*":
                    CalcFunc();
                    opTextBox.Text = buf_val;

                    break;

                case "/":
                    CalcFunc();
                    opTextBox.Text = buf_val;

                    break;

                case "%":
                    CalcFunc();
                    opTextBox.Text = buf_val;

                    break;
                case "=":
                    CalcFunc();
                    opTextBox.Text = buf_val;
                    buf = result.ToString();    // 결과표시
                    break;

                case "C":
                    result = 0;
                    numTextBox.Text = result.ToString();
                    buf = "";
                    buf = buf_val = "";
                    opTextBox.Text = buf.ToString();

                    break;

            }
        }

        private void CalcFunc()
        {

            if (buf.Equals("")) // 첫 번째 수가 없고 연산자가 "CE"가 아니면
                val = null; // 저장된 연산자를 지운다

            switch (val)
            {
                case "+":
                    result = result + double.Parse(buf);    // 값 계산
                    numTextBox.Text = result.ToString();    // 숫자 텍스트 박스에 표시

                    buf = "";
                    break;
                case "-":
                    result -= double.Parse(buf);
                    numTextBox.Text = result.ToString();

                    buf = "";
                    break;
                case "/":
                    result = result / double.Parse(buf);
                    numTextBox.Text = result.ToString();

                    buf = "";
                    break;
                case "%":
                    result = result % double.Parse(buf);
                    numTextBox.Text = result.ToString();

                    buf = "";
                    break;

                case "*":
                    result = result * double.Parse(buf);
                    numTextBox.Text = result.ToString();

                    buf = "";
                    break;

                default:
                    result = double.Parse(numTextBox.Text); // 연산자가 입력이 되지 않았으면 계산을 위해 저장

                    break;
            }
            if (val == null)
                result = double.Parse(buf);

            val = buf_val;  // 두 번째 숫자를 누르면 계산할 수있도록 연산자 저장
            buf = "";   // 숫자입력값 초기화
        }

        private void MemoryButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            String btnText = "";
            String nowNum = numTextBox.Text;
            int temp = 0;
            btnText = btn.Text;
            
            switch(btnText)
            {
                case "MC":
                    m_buf = "";
                    ceFunc();

                    break;
                case "MR":
                    numTextBox.Text = m_buf;
                    buf = m_buf;

                    numTextBox.Text = buf;
                    break;
                case "MS":
                    temp = int.Parse(numTextBox.Text);
                    m_buf = temp.ToString();
                    ceFunc();

                    break;
                case "M+":
                    temp = int.Parse(m_buf);
                    temp += int.Parse(numTextBox.Text);
                    m_buf = temp.ToString();
                    ceFunc();

                    break;

                case "M-":
                    temp = int.Parse(m_buf);
                    temp -= int.Parse(numTextBox.Text);
                    m_buf = temp.ToString();
                    ceFunc();


                    break;
            }
        }
        private void ceFunc()
        {
            buf = "";

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}