using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DatabaseToolSuite.Controls.Base
{
    [DesignerCategory("code")]
    [ToolboxBitmap(typeof(ComboBox))]
    [ComVisible(false)]
    public abstract class PickerControlBase : Control
    {
        private ToolStripControlHost controlHost;
        private ToolStripDropDown dropDown;
        protected Control control;

        private VisualStyleRenderer borderDisabledRenderer;
        private VisualStyleRenderer borderFocusedRenderer;
        private VisualStyleRenderer borderNormalRenderer;
        private VisualStyleRenderer borderSelectedRenderer;

        private VisualStyleRenderer buttonDisabledRenderer;
        private VisualStyleRenderer buttonHotRenderer;
        private VisualStyleRenderer buttonNormalRenderer;
        private VisualStyleRenderer buttonPressedRenderer;

        private Image backImage;

        private Rectangle buttonRectagle;
        private Region buttonBackRegion;
        private Rectangle displayRectagle;
        private Rectangle clipRectagle;

        private bool ButtonPressed;
        private bool Hovering;

        public PickerControlBase(Control control) : base()
        {
            this.BackColor = SystemColors.Window;
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.UserMouse, true);
            this.UpdateStyles();
            this.InitializeVisualStyles();

            this.SuspendLayout();
            this.control = control;
            controlHost = new ToolStripControlHost(this.control);
            dropDown = new ToolStripDropDown();
            dropDown.AutoClose = true;
            dropDown.DefaultDropDownDirection = ToolStripDropDownDirection.Default;
            dropDown.DropShadowEnabled = true;
            dropDown.Items.Add(controlHost);
            this.ResumeLayout(false);
        }

        bool LastVisualStyles;
        private void InitializeVisualStyles()
        {
            this.LastVisualStyles = Application.RenderWithVisualStyles;
            if (Application.RenderWithVisualStyles)
            {
                borderDisabledRenderer = new VisualStyleRenderer(VisualStyleElement.Window.FrameBottom.Active);
                borderFocusedRenderer = new VisualStyleRenderer(VisualStyleElement.Window.FrameLeft.Active);
                borderNormalRenderer = new VisualStyleRenderer(VisualStyleElement.TextBox.TextEdit.Normal);
                borderSelectedRenderer = new VisualStyleRenderer(VisualStyleElement.TextBox.TextEdit.Selected);

                buttonDisabledRenderer = new VisualStyleRenderer(VisualStyleElement.ComboBox.DropDownButton.Disabled);
                buttonHotRenderer = new VisualStyleRenderer(VisualStyleElement.ComboBox.DropDownButton.Hot);
                buttonNormalRenderer = new VisualStyleRenderer(VisualStyleElement.ComboBox.DropDownButton.Normal);
                buttonPressedRenderer = new VisualStyleRenderer(VisualStyleElement.ComboBox.DropDownButton.Pressed);
            }
            else
            {
                if (borderDisabledRenderer != null) { borderDisabledRenderer = null; }
                if (borderFocusedRenderer != null) { borderFocusedRenderer = null; }
                if (borderNormalRenderer != null) { borderNormalRenderer = null; }
                if (borderSelectedRenderer != null) { borderSelectedRenderer = null; }
                if (buttonDisabledRenderer != null) { buttonDisabledRenderer = null; }
                if (buttonHotRenderer != null) { buttonHotRenderer = null; }
                if (buttonNormalRenderer != null) { buttonNormalRenderer = null; }
                if (buttonPressedRenderer != null) { buttonPressedRenderer = null; }
            }
            this.OnResize(new EventArgs());
        }

        public Control Control { get { return this.controlHost.Control; } }

        protected Rectangle ButtonRectagle { get { return this.buttonRectagle; } }

        protected Rectangle DisplayRectagle { get { return this.displayRectagle; } }

        protected sealed override void OnPaintBackground(PaintEventArgs pevent)
        {
            //base.OnPaintBackground(pevent);
        }

        protected sealed override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = Graphics.FromImage(backImage);
            if (this.LastVisualStyles != Application.RenderWithVisualStyles)
            { this.InitializeVisualStyles(); }

            if (Application.RenderWithVisualStyles)
            {
                this.PaintVisualStylesBorder(new PaintEventArgs(graphics, e.ClipRectangle));
                buttonBackRegion = new Region(new Rectangle(buttonRectagle.X, 1, buttonRectagle.Width - 1, buttonRectagle.Height - 2));
            }
            else
            {
                this.PaintBorder(new PaintEventArgs(graphics, e.ClipRectangle));
                buttonBackRegion = new Region(new Rectangle(buttonRectagle.X - 2, 2, buttonRectagle.Width, buttonRectagle.Height - 4));
            }

            Brush backBrush;
            if (this.Enabled)
            { backBrush = new SolidBrush(this.BackColor); }
            else { backBrush = SystemBrushes.ControlLight; }
            graphics.FillRectangle(backBrush, this.clipRectagle);

            graphics.Clip = this.buttonBackRegion;
            if (Application.RenderWithVisualStyles)
            { this.PaintVisualStylesButton(new PaintEventArgs(graphics, this.buttonRectagle)); }
            else
            { this.PaintButton(new PaintEventArgs(graphics, this.buttonRectagle)); }

            e.Graphics.DrawImage(backImage, 0, 0);
            this.OnPaintDisplay(new PaintEventArgs(e.Graphics, this.displayRectagle));
            base.OnPaint(e);
        }

        private void PaintVisualStylesBorder(PaintEventArgs e)
        {
            Brush backBrush;
            Pen backPen;
            if (!this.Enabled)
            {
                backBrush = SystemBrushes.ControlLight;
                backPen = SystemPens.ControlLightLight;
            }
            else
            {
                if (this.Hovering | this.Focused | this.dropDown.Visible)
                {
                    backBrush = new LinearGradientBrush(e.ClipRectangle, SystemColors.ActiveCaption, SystemColors.GradientActiveCaption, LinearGradientMode.Vertical);
                    backPen = SystemPens.ControlLightLight;
                }
                else
                {
                    backBrush = new LinearGradientBrush(e.ClipRectangle, SystemColors.ControlDark, SystemColors.ControlLight, LinearGradientMode.Vertical);
                    backPen = SystemPens.ControlLightLight;
                }
            }
            e.Graphics.FillRectangle(backBrush, e.ClipRectangle);
            // Top
            e.Graphics.DrawLine(backPen, e.ClipRectangle.X + 2, e.ClipRectangle.Y + 1, e.ClipRectangle.Width - 4, e.ClipRectangle.Y + 1);
            e.Graphics.DrawLine(backPen, e.ClipRectangle.X + 2, e.ClipRectangle.Y + 2, e.ClipRectangle.Width - 4, e.ClipRectangle.Y + 2);
            // Left
            e.Graphics.DrawLine(backPen, e.ClipRectangle.X + 1, e.ClipRectangle.Y + 2, e.ClipRectangle.X + 1, e.ClipRectangle.Height - 4);
            e.Graphics.DrawLine(backPen, e.ClipRectangle.X + 2, e.ClipRectangle.Y + 2, e.ClipRectangle.X + 2, e.ClipRectangle.Height - 4);
            // Right
            e.Graphics.DrawLine(backPen, e.ClipRectangle.Width - 3, e.ClipRectangle.Y + 2, e.ClipRectangle.Width - 3, e.ClipRectangle.Height - 4);
            e.Graphics.DrawLine(backPen, e.ClipRectangle.Width - 2, e.ClipRectangle.Y + 2, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 4);
            // Botton
            e.Graphics.DrawLine(backPen, e.ClipRectangle.X + 2, e.ClipRectangle.Height - 3, e.ClipRectangle.Width - 4, e.ClipRectangle.Height - 3);
            e.Graphics.DrawLine(backPen, e.ClipRectangle.X + 2, e.ClipRectangle.Height - 2, e.ClipRectangle.Width - 4, e.ClipRectangle.Height - 2);
        }

        private void PaintBorder(PaintEventArgs e)
        {
            Pen backPen;
            if (this.Enabled)
            {
                backPen = new Pen(this.BackColor);
            }
            else
            {
                backPen = SystemPens.Control;
            }
            e.Graphics.DrawLines(SystemPens.ControlDark, new Point[] { new Point(e.ClipRectangle.X, e.ClipRectangle.Height - 2), new Point(e.ClipRectangle.X, e.ClipRectangle.Y), new Point(e.ClipRectangle.Width - 2, e.ClipRectangle.Y) });
            e.Graphics.DrawLines(SystemPens.ControlDarkDark, new Point[] { new Point(e.ClipRectangle.X + 1, e.ClipRectangle.Height - 3), new Point(e.ClipRectangle.X + 1, e.ClipRectangle.Y + 1), new Point(e.ClipRectangle.Width - 3, e.ClipRectangle.Y + 1) });

            e.Graphics.DrawLines(SystemPens.ControlLightLight, new Point[] { new Point(e.ClipRectangle.X, e.ClipRectangle.Height - 1), new Point(e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1), new Point(e.ClipRectangle.Width - 1, e.ClipRectangle.Y) });
            e.Graphics.DrawLines(SystemPens.ControlLight, new Point[] { new Point(e.ClipRectangle.X + 1, e.ClipRectangle.Height - 2), new Point(e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2), new Point(e.ClipRectangle.Width - 2, e.ClipRectangle.Y + 1) });

            e.Graphics.DrawRectangle(backPen, e.ClipRectangle.X + 2, e.ClipRectangle.Y + 2, e.ClipRectangle.Width - 5, e.ClipRectangle.Height - 5);
        }

        private void PaintVisualStylesButton(PaintEventArgs e)
        {
            if (!this.Enabled)
            { buttonDisabledRenderer.DrawBackground(e.Graphics, e.ClipRectangle); }
            else if (this.ButtonPressed)
            { buttonPressedRenderer.DrawBackground(e.Graphics, e.ClipRectangle); }
            else if (this.Hovering)
            { buttonHotRenderer.DrawBackground(e.Graphics, e.ClipRectangle); }
            else
            { buttonNormalRenderer.DrawBackground(e.Graphics, e.ClipRectangle); }
        }

        private void PaintButton(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(SystemBrushes.Control, e.ClipRectangle);
            if (this.ButtonPressed | this.dropDown.Visible)
            {
                e.Graphics.DrawRectangle(SystemPens.ControlDark, new Rectangle(this.ButtonRectagle.X, this.ButtonRectagle.Y + 2, this.ButtonRectagle.Width - 3, this.ButtonRectagle.Height - 5));
                PaintSymbol(e, 1);
            }
            else
            {
                e.Graphics.DrawLines(SystemPens.ControlLightLight, new Point[] { new Point(this.ButtonRectagle.X + 1, this.ButtonRectagle.Y + this.ButtonRectagle.Height - 5), new Point(this.ButtonRectagle.X + 1, this.ButtonRectagle.Y + 3), new Point(this.ButtonRectagle.X + this.ButtonRectagle.Width - 5, this.ButtonRectagle.Y + 3) });
                e.Graphics.DrawLines(SystemPens.ControlDarkDark, new Point[] { new Point(this.ButtonRectagle.X, this.ButtonRectagle.Y + this.ButtonRectagle.Height - 3), new Point(this.ButtonRectagle.X + this.ButtonRectagle.Width - 3, this.ButtonRectagle.Y + this.ButtonRectagle.Height - 3), new Point(this.ButtonRectagle.X + this.ButtonRectagle.Width - 3, this.ButtonRectagle.Y + 2) });
                e.Graphics.DrawLines(SystemPens.ControlDark, new Point[] { new Point(this.ButtonRectagle.X + 1, this.ButtonRectagle.Y + this.ButtonRectagle.Height - 4), new Point(this.ButtonRectagle.X + this.ButtonRectagle.Width - 4, this.ButtonRectagle.Y + this.ButtonRectagle.Height - 4), new Point(this.ButtonRectagle.X + this.ButtonRectagle.Width - 4, this.ButtonRectagle.Y + 3) });
                PaintSymbol(e, 0);
            }
        }

        private void PaintSymbol(PaintEventArgs e, int pressed)
        {
            Graphics graphics = e.Graphics;
            Rectangle clip = e.ClipRectangle;
            int x = (clip.Width - 7) / 2 - 1 + pressed;
            int y = (clip.Height - 5) / 2 + pressed;
            Pen pen;
            if (this.Enabled)
            {
                pen = SystemPens.ControlText;
            }
            else
            {
                pen = SystemPens.ControlDark;
                graphics.DrawLines(SystemPens.ControlLightLight, new Point[] {
                new Point(clip.X + x + 7, clip.Y + y + 1), new Point(clip.X + x + 6, clip.Y + y + 1),
                new Point(clip.X + x + 6, clip.Y + y + 2), new Point(clip.X + x + 5, clip.Y + y + 2),
                new Point(clip.X + x + 5, clip.Y + y + 3), new Point(clip.X + x + 4, clip.Y + y + 3),
                new Point(clip.X + x + 4, clip.Y + y + 4)});
            }

            graphics.DrawLines(pen, new Point[] {
                new Point(clip.X + x, clip.Y + y), new Point(clip.X + x + 6, clip.Y + y),
                new Point(clip.X + x + 5, clip.Y + y + 1), new Point(clip.X + x + 1, clip.Y + y + 1),
                new Point(clip.X + x + 2, clip.Y + y + 2), new Point(clip.X + x + 4, clip.Y + y + 2),
                new Point(clip.X + x + 3, clip.Y + y + 3)});
        }

        protected abstract void OnPaintDisplay(PaintEventArgs e);

        #region Mouse Event

        protected sealed override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && buttonRectagle.Contains(e.X, e.Y))
            {
                this.ButtonPressed = true;
                if (!DropDownVisible) { ShowDropDown(); }
                base.OnMouseDown(e);
                this.OnButtonClick(new EventArgs());
                this.Invalidate(this.buttonRectagle);
            }
        }

        protected sealed override void OnMouseMove(MouseEventArgs e)
        {
            bool hovering = this.clipRectagle.Contains(e.X, e.Y);
            if (this.Hovering != hovering)
            {
                this.Hovering = hovering;
                this.Invalidate();
            }
            base.OnMouseMove(e);
        }

        protected sealed override void OnMouseUp(MouseEventArgs e)
        {
            this.ButtonPressed = false;
            base.OnMouseUp(e);
            this.Invalidate();
        }

        protected sealed override void OnMouseLeave(EventArgs e)
        {
            this.Hovering = false;
            this.Invalidate();
            base.OnMouseLeave(e);
        }

        #endregion          

        #region Click

        /// <summary>
        /// Событие, возникающее при нажатии кнопки.
        /// </summary>
        public event EventHandler ButtonClick;

        protected virtual void OnButtonClick(EventArgs e)
        {
            ButtonClick?.Invoke(this, e);
        }

        #endregion
        

        private bool DropDownVisible;
        const int WM_MOUSEACTIVATE = 0x0021;

        protected sealed override void WndProc(ref Message m)
        {
            if (m.Msg == WM_MOUSEACTIVATE)
            {
                DropDownVisible = dropDown.Visible;
                return;
            }
            base.WndProc(ref m);
        }

        public void HideDropDown()
        {
            if (dropDown != null)
            { dropDown.Close(); }
        }

        public void ShowDropDown()
        {
            if (dropDown != null)
            {
                dropDown.Show(this, 0, this.Height);
                dropDown.Focus();
            }
        }

        protected sealed override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (dropDown != null)
                {
                    dropDown.Dispose();
                    dropDown = null;
                }
            }
            base.Dispose(disposing);
        }

        protected override void OnFontChanged(EventArgs e)
        {
            this.OnResize(new EventArgs());
            base.OnFontChanged(e);
        }

        protected override void OnResize(EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            SizeF SymbolSize = graphics.MeasureString("#", this.Font);
            if (Application.RenderWithVisualStyles)
            { buttonRectagle = new Rectangle(this.Width - SystemInformation.VerticalScrollBarWidth, 0, SystemInformation.VerticalScrollBarWidth, (int)SymbolSize.Height + SystemInformation.FrameBorderSize.Height * 2); }
            else { buttonRectagle = new Rectangle(this.Width - SystemInformation.VerticalScrollBarWidth - 2, 0, SystemInformation.VerticalScrollBarWidth + 2, (int)SymbolSize.Height + SystemInformation.FrameBorderSize.Height * 2); }
            this.Height = buttonRectagle.Height;
            if (this.Width < SymbolSize.Width + buttonRectagle.Width + SystemInformation.FrameBorderSize.Width * 2)
            { this.Width = (int)SymbolSize.Width + buttonRectagle.Width + SystemInformation.FrameBorderSize.Width * 2; }
            this.displayRectagle = new Rectangle(SystemInformation.FrameBorderSize.Width, SystemInformation.FrameBorderSize.Height, this.Width - this.buttonRectagle.Width - SystemInformation.FrameBorderSize.Width * 2, (int)SymbolSize.Height);
            this.clipRectagle = new Rectangle(3, 3, this.Width - 6, this.Height - 6);
            base.OnResize(e);
            this.backImage = new Bitmap(width: this.Width, height: this.Height, format: System.Drawing.Imaging.PixelFormat.Format64bppArgb);
            this.Invalidate();
        }
    }
}

