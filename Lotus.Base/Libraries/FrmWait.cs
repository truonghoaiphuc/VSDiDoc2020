﻿using System;
using DevExpress.XtraWaitForm;

namespace Lotus.Libraries
{
    public partial class FrmWait : WaitForm
    {
        public enum WaitFormCommand
        {
        }

        public FrmWait()
        {
            InitializeComponent();
            progressPanel1.AutoHeight = true;
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            progressPanel1.Caption = caption;
        }

        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            progressPanel1.Description = description;
        }

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
    }
}