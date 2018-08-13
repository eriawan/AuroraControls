﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace AuroraControls
{
    public class aTextBox : TextBox
    {
        #region Member Variables
        Color focusColor = Color.White;
        Color unfocusColor = Color.White;
        Color focusTextColor = Color.Black;
        Color unfocusTextColor = Color.Black;
        #endregion

        #region Constructor
        public aTextBox()
        {

            this.BackColor = focusColor;

            this.Leave += Textbox_Leave;
            this.Enter += Textbox_Enter;

        }
        #endregion
        private void Textbox_Enter(object sender, EventArgs e)
        {
            this.BackColor = focusColor;
            this.ForeColor = focusTextColor;
        }

        private void Textbox_Leave(object sender, EventArgs e)
        {
            this.BackColor = unfocusColor;
            this.focusTextColor = unfocusTextColor;
        }

        #region User Defined Properties
        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("Set color when focused")]
        [DisplayName("Focused Color")]
        public Color FocusedColor
        {
            get
            {
                return this.focusColor;
            }
            set
            {
                this.focusColor = value;

            }
        }
        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("Set color when lost focus or leave the control")]
        [DisplayName("unFocused Color")]
        public Color unFocusedColor
        {
            get
            {
                return this.unfocusColor;
            }
            set
            {
                this.unfocusColor = value;

            }
        }
        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("Set text color when focused")]
        [DisplayName("Focused Color")]
        public Color FocusedTextColor
        {
            get
            {
                return this.focusTextColor;
            }
            set
            {
                this.focusTextColor = value;

            }
        }
        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("Set text color when lost focus or leave the control")]
        [DisplayName("unFocused Color")]
        public Color unFocusedTextColor
        {
            get
            {
                return this.unfocusTextColor;
            }
            set
            {
                this.unfocusTextColor = value;

            }
        }
        #endregion
    }
}
