using System;
using System.Windows.Forms;

namespace SwiftInventory.CustomControls
{
    internal sealed class CenterFlowLayoutPanel : FlowLayoutPanel
    {
        private int _sidePadding = 20;
        public int SidePadding
        {
            get => _sidePadding;
            set
            {
                _sidePadding = value;
                AdjustChildControls();
            }
        }

        public CenterFlowLayoutPanel()
        {
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FlowDirection = FlowDirection.TopDown;
            WrapContents = false;

            ControlAdded += (sender, e) => AdjustChildControls();
            ControlRemoved += (sender, e) => AdjustChildControls();
        }

        // Override OnResize to ensure adjustments happen when the panel's size changes.
        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            AdjustChildControls();
        }

        // Optionally override OnSizeChanged as well.
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            AdjustChildControls();
        }

        // Override OnLayout for extra safety.
        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
            AdjustChildControls();
        }

        private void AdjustChildControls()
        {
            SuspendLayout();
            int newWidth = Math.Max(ClientSize.Width - SidePadding, 0);
            foreach (Control ctrl in Controls)
            {
                // Update the control's width if it's different.
                if (ctrl.Width != newWidth) ctrl.Width = newWidth;

                // Calculate the left (and right) margin needed to center the control.
                int horizontalMargin = (ClientSize.Width - ctrl.Width) / 2;
                horizontalMargin = Math.Max(horizontalMargin, 0);

                // Update the control's margin. (You can preserve its existing top and bottom margins.)
                if (ctrl.Margin.Left != horizontalMargin || ctrl.Margin.Right != horizontalMargin)
                {
                    ctrl.Margin = new Padding(horizontalMargin, ctrl.Margin.Top, horizontalMargin, ctrl.Margin.Bottom);
                }
            }
            ResumeLayout();
        }
    }
}
