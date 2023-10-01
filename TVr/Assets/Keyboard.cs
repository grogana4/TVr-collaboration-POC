using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI m_Object;
    [SerializeField] TMPro.TextMeshProUGUI m_Button;
    public TMPro.TextMeshProUGUI[] m_Buttons;
    int shiftChecker = 0;

    public void editText()
    {
        m_Object.text += m_Button.text;
    }

    public void editTextSpace()
    {
        m_Object.text += " ";
    }

    public void editTextEnter()
    {
        m_Object.text += "\n";
    }

    public void editTextShift()

    {
        string upperText;
        string lowerText;
        string specialCase;
        if (shiftChecker == 0)
        {
            foreach (TMPro.TextMeshProUGUI button in m_Buttons)
            {

                switch (button.text[0])
                {
                    case '1':
                        specialCase = "!";
                        button.text = specialCase;
                        break;
                    case '2':
                        specialCase = char.ToString('"');
                        button.text = specialCase;
                        break;
                    case '3':
                        specialCase = "£";
                        button.text = specialCase;
                        break;
                    case '4':
                        specialCase = "$";
                        button.text = specialCase;
                        break;
                    case '5':
                        specialCase = "%";
                        button.text = specialCase;
                        break;
                    case '6':
                        specialCase = "^";
                        button.text = specialCase;
                        break;
                    case '7':
                        specialCase = "&";
                        button.text = specialCase;
                        break;
                    case '8':
                        specialCase = "*";
                        button.text = specialCase;
                        break;
                    case '9':
                        specialCase = "(";
                        button.text = specialCase;
                        break;
                    case '0':
                        specialCase = ")";
                        button.text = specialCase;
                        break;
                    case ';':
                        specialCase = ":";
                        button.text = specialCase;
                        break;
                    case '\'':
                        specialCase = "@";
                        button.text = specialCase;
                        break;
                    case '#':
                        specialCase = "~";
                        button.text = specialCase;
                        break;
                    case '/':
                        specialCase = "?";
                        button.text = specialCase;
                        break;
                    case '.':
                        specialCase = ">";
                        button.text = specialCase;
                        break;
                    case ',':
                        specialCase = "<";
                        button.text = specialCase;
                        break;
                    default:
                        upperText = button.text.ToUpper();
                        button.text = upperText;
                        break;
                }
                
            }
            shiftChecker++;
        }
        else
        {
            foreach (TMPro.TextMeshProUGUI button in m_Buttons)
            {


                switch (button.text[0])
                {
                    case '!':
                        specialCase = "1";
                        button.text = specialCase;
                        break;
                    case '"':
                        specialCase = "2";
                        button.text = specialCase;
                        break;
                    case '£':
                        specialCase = "3";
                        button.text = specialCase;
                        break;
                    case '$':
                        specialCase = "4";
                        button.text = specialCase;
                        break;
                    case '%':
                        specialCase = "5";
                        button.text = specialCase;
                        break;
                    case '^':
                        specialCase = "6";
                        button.text = specialCase;
                        break;
                    case '&':
                        specialCase = "7";
                        button.text = specialCase;
                        break;
                    case '*':
                        specialCase = "8";
                        button.text = specialCase;
                        break;
                    case '(':
                        specialCase = "9";
                        button.text = specialCase;
                        break;
                    case ')':
                        specialCase = "0";
                        button.text = specialCase;
                        break;
                    case ':':
                        specialCase = ";";
                        button.text = specialCase;
                        break;
                      case '@':
                          specialCase = "'";
                          button.text = specialCase;
                          break;
                    case '~':
                        specialCase = "#";
                        button.text = specialCase;
                        break;
                    case '?':
                        specialCase = "/";
                        button.text = specialCase;
                        break;
                    case '>':
                        specialCase = ".";
                        button.text = specialCase;
                        break;
                    case '<':
                        specialCase = ",";
                        button.text = specialCase;
                        break;
                    default:
                        lowerText = button.text.ToLower();
                        button.text = lowerText;
                        break;
                }

            }
            shiftChecker--;
        }

    }
    public void editTextBack()
    {
        if (m_Object.text.Length != 0) {
            m_Object.text = m_Object.text.Substring(0, (m_Object.text.Length - 1));
        }
    }
}
