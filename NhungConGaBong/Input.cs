﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhungConGaBong
{
    public class Input
    {

        public static void SoNguyen(TextBox t, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)8))
            {
                e.Handled = true; 
            }

            if (char.IsDigit(e.KeyChar) && t.Text.Replace(" ", "").Length >= 10)
            {
                e.Handled = true; 
            }
        }
        public static void SoNguyen(KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }
        public static void SoThuc(TextBox t, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9'
                || (t.Text.Length > 0 && t.Text.IndexOf('.') == -1)
                || e.KeyChar == (char)8))
                e.Handled = true;
        }
        public static void ChuCai(TextBox t, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)8)
            {
                return;
            }
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

            return Regex.IsMatch(email, pattern);
        }
        public static void ClearTextBoxes(Control control, TextBox exclusions)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox && c != exclusions)
                {
                    ((TextBox)c).Text = "";
                }
                else if (c.HasChildren)
                {
                    ClearTextBoxes(c, exclusions); // Gọi đệ quy nếu control đó là một container
                }
            }
        }
    }
}


