﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantsShop.Tabs
{
    public partial class Expander : UserControl
    {
        public Expander()
        {
            InitializeComponent();
            this.Expanded = true;
        }
        #region Events

        public event EventHandler StateChanged;
        public event CancelEventHandler StateChanging;

        #endregion

        #region Properties

        public bool Expanded { get; private set; }

        public Control Header
        {
            get { return this.header; }

            set
            {
                if (this.header != null)
                    this.Controls.Remove(this.header);

                this.header = value;
                this.header.Dock = DockStyle.Top;
                this.Controls.Add(this.header);
                this.Controls.SetChildIndex(this.header, this.Controls.Count > 1 ? 1 : 0);
            }
        }

        public Control Content
        {
            get { return this.content; }

            set
            {
                if (this.content != null)
                    this.Controls.Remove(this.content);

                this.content = value;
                this.Size = new Size(this.Width, this.header.Height + this.content.Height);
                this.content.Top = this.header.Height;

                this.Controls.Add(this.content);
                this.Controls.SetChildIndex(this.content, 0);
            }
        }

        #endregion

        #region Public methods

        public void Expand()
        {
            if (this.Expanded)
                return;

            if (StateChanging != null)
            {
                CancelEventArgs args = new CancelEventArgs();
                StateChanging(this, args);
                if (args.Cancel)
                    return;
            }

            this.Expanded = true;
            ArrangeLayout();

            if (StateChanged != null)
                StateChanged(this, null);
        }

        public void Collapse()
        {
            if (!this.Expanded)
                return;

            if (StateChanging != null)
            {
                CancelEventArgs args = new CancelEventArgs();
                StateChanging(this, args);
                if (args.Cancel)
                    return;
            }

            if (this.Content != null)
                this.contentHeight = this.Content.Height;
            this.Expanded = false;
            ArrangeLayout();

            if (StateChanged != null)
                StateChanged(this, null);
        }

        public void Toggle()
        {
            if (this.Expanded)
                Collapse();
            else
                Expand();
        }

        #endregion

        #region Private methods

        private void ArrangeLayout()
        {
            int h = 0;
            if (this.header != null)
                h += this.header.Height;
            if (this.Expanded && this.content != null)
                h += this.content.Height;
            this.Size = new Size(this.Width, h);
        }

        #endregion

        #region Priate fields

        private Control header;
        private Control content;
        private int contentHeight = 0;

        #endregion
    }

    public static class ExpanderHelper
    {
        public static Label CreateLabelHeader(Expander expander, string text, Image collapsedImage = null, Image expandedImage = null, int height = 35)
        {
            Label headerLabel = new Label();
            headerLabel.Text = text;
            headerLabel.Font =  new System.Drawing.Font("MS Reference Sans Serif", 12F);
            headerLabel.AutoSize = false;
            headerLabel.Height = height;
            // headerLabel.ForeColor =  System.Drawing.SystemColors.ControlLight;
            headerLabel.TextAlign = ContentAlignment.MiddleLeft;
            if (collapsedImage != null && expandedImage != null)
            {
                headerLabel.Image = collapsedImage;
                headerLabel.ImageAlign = ContentAlignment.MiddleRight;
            }
            headerLabel.BackColor = System.Drawing.SystemColors.ControlLight;

            if (collapsedImage != null && expandedImage != null)
            {
                expander.StateChanged += delegate { headerLabel.Image = expander.Expanded ? collapsedImage : expandedImage; };
            }
   
            headerLabel.Click += delegate { expander.Toggle(); };

            expander.Header = headerLabel;

            return headerLabel;
        }
    }
}
