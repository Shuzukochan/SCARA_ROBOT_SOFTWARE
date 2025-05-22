using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SCARA_ROBOT_SOFTWARE
{
    public partial class Setup : Form
    {
        private List<ProgramCard> allCards = new List<ProgramCard>();
        private ProgramCard selectedCard;

        public Setup()
        {
            InitializeComponent();
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            allCards = flowLayoutPanel1.Controls.OfType<ProgramCard>().ToList();

            foreach (var card in allCards)
            {
                card.Click += ProgramCard_Click;
                foreach (Control ctrl in card.Controls)
                    ctrl.Click += ProgramCard_Click;
            }

            var defaultCard = allCards[0];
            foreach (var card in allCards)
                card.SetSelected(card == defaultCard);

            selectedCard = defaultCard;
            label2.Text = defaultCard.Title;
            setupProgramText.Text = "Setup " + defaultCard.Title;

            rackXTextBox.Text = selectedCard.Columns.ToString();
            rackYTextBox.Text = selectedCard.Rows.ToString();

            if (selectedCard.Columns > 0 && selectedCard.Rows > 0)
                GenerateLocationButtons(selectedCard.Columns, selectedCard.Rows);
        }

        private void ProgramCard_Click(object sender, EventArgs e)
        {
            ProgramCard clickedCard = null;

            if (sender is ProgramCard pc)
                clickedCard = pc;
            else if (sender is Control ctrl && ctrl.Parent is ProgramCard parentCard)
                clickedCard = parentCard;

            if (clickedCard != null)
            {
                foreach (var card in allCards)
                    card.SetSelected(card == clickedCard);

                selectedCard = clickedCard;

                label2.Text = clickedCard.Title;
                setupProgramText.Text = "Setup " + clickedCard.Title;

                rackXTextBox.Text = clickedCard.Columns.ToString();
                rackYTextBox.Text = clickedCard.Rows.ToString();

                if (clickedCard.Columns > 0 && clickedCard.Rows > 0)
                    GenerateLocationButtons(clickedCard.Columns, clickedCard.Rows);
                else
                    showLocationPanel.Controls.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(rackXTextBox.Text, out int cols) || cols <= 0 ||
                !int.TryParse(rackYTextBox.Text, out int rows) || rows <= 0)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương cho cả Rack X và Y.");
                return;
            }

            if (selectedCard == null)
            {
                MessageBox.Show("Vui lòng chọn một Program.");
                return;
            }

            selectedCard.Columns = cols;
            selectedCard.Rows = rows;

            GenerateLocationButtons(cols, rows);
        }

        private void GenerateLocationButtons(int cols, int rows)
        {
            showLocationPanel.Controls.Clear();
            showLocationPanel.Enabled = false;

            int panelWidth = showLocationPanel.Width;
            int panelHeight = showLocationPanel.Height;
            int spacing = 6;

            int buttonWidth = (panelWidth - (cols + 1) * spacing) / cols;
            int buttonHeight = (panelHeight - (rows + 1) * spacing) / rows;

            int startX = spacing;
            int startY = spacing;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int index = row * cols + col;
                    Button btn = new Button();
                    btn.Size = new Size(buttonWidth, buttonHeight);
                    btn.Location = new Point(startX + col * (buttonWidth + spacing), startY + row * (buttonHeight + spacing));
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Text = $"{col + 1},{row + 1}";
                    btn.Tag = new Point(col, row);
                    btn.Name = $"btn_{index}";
                    btn.Click += LocationButton_Click;

                    showLocationPanel.Controls.Add(btn);
                }
            }

            showLocationPanel.Enabled = true;
        }

        private void LocationButton_Click(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Button btn && btn.Tag is Point p)
            {
                MessageBox.Show($"Bạn đã click vị trí: {p.X + 1}, {p.Y + 1}");
            }
        }
    }
}
