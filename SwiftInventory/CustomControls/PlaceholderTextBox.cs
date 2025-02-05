using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SwiftInventory.CustomControls
{
    public sealed class PlaceholderTextBox : TextBox
    {
        private string _placeholder = "Enter text...";
        private bool _isPlaceholderActive = true;
        private readonly Color _originalForeColor;

        [Category("Appearance")]
        public string PlaceholderText
        {
            get => _placeholder;
            set
            {
                if (_placeholder != value)
                {
                    bool wasPlaceholder = _isPlaceholderActive && Text == _placeholder;
                    _placeholder = value;
                    if (wasPlaceholder)
                    {
                        Text = _placeholder;
                    }
                    else if (string.IsNullOrWhiteSpace(Text))
                    {
                        SetPlaceholder();
                    }
                }
            }
        }

        public PlaceholderTextBox()
        {
            _originalForeColor = ForeColor;
            SetPlaceholder();
            Enter += RemovePlaceholder;
            Leave += SetPlaceholder;
            TextChanged += OnTextChanged;
        }

        private void SetPlaceholder(object sender, EventArgs e) => SetPlaceholder();
        private void RemovePlaceholder(object sender, EventArgs e) => RemovePlaceholder();

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(Text) && !Focused)
            {
                _isPlaceholderActive = true;
                Text = _placeholder;
                ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholder()
        {
            if (_isPlaceholderActive)
            {
                _isPlaceholderActive = false;
                Text = "";
                ForeColor = _originalForeColor;
            }
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (!Focused && string.IsNullOrWhiteSpace(Text) && !_isPlaceholderActive)
            {
                SetPlaceholder();
            }
        }

        public override string Text
        {
            get => _isPlaceholderActive ? string.Empty : base.Text;
            set
            {
                if (!string.IsNullOrEmpty(value) && value != _placeholder)
                {
                    _isPlaceholderActive = false;
                    ForeColor = _originalForeColor;
                }
                base.Text = value;
            }
        }
    }
}