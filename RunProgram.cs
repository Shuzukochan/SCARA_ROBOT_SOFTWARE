using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCARA_ROBOT_SOFTWARE
{
    public partial class RunProgram : Form
    {
        private List<ProgramCard> allCards = new List<ProgramCard>();
        private ProgramCard selectedCard;
        private int selectedIndex = 0;

        private List<Button> runButtons = new List<Button>();
        private int currentRunIndex = 0;
        private bool isRunning = false;
        private bool isPaused = false;

        public RunProgram()
        {
            InitializeComponent();
        }

        private void RunProgram_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.Programs.Count < 9)
            {
                GlobalVariables.Programs.Clear();
                for (int i = 0; i < 9; i++)
                {
                    GlobalVariables.Programs.Add(new GlobalVariables.ProgramData
                    {
                        Title = $"Program {i + 1}",
                        Columns = 0,
                        Rows = 0
                    });
                }
            }

            allCards = flowLayoutPanel1.Controls.OfType<ProgramCard>().ToList();

            foreach (var card in allCards)
            {
                card.Click += ProgramCard_Click;
                foreach (Control ctrl in card.Controls)
                    ctrl.Click += ProgramCard_Click;
            }

            selectedIndex = 0;
            selectedCard = allCards[selectedIndex];

            foreach (var card in allCards)
                card.SetSelected(card == selectedCard);

            LoadProgramData(selectedIndex);
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
                selectedIndex = allCards.IndexOf(clickedCard);
                selectedCard = clickedCard;

                foreach (var card in allCards)
                    card.SetSelected(card == selectedCard);

                LoadProgramData(selectedIndex);
            }
        }

        private void LoadProgramData(int index)
        {
            var program = GlobalVariables.Programs[index];

            label2.Text = program.Title;
            setupProgramText.Text = "Run " + program.Title;
            columnLabel.Text = program.Columns.ToString();
            rowsLabel.Text = program.Rows.ToString();

            if (program.Columns > 0 && program.Rows > 0)
                GenerateLocationButtons(program.Columns, program.Rows);
            else
                showLocationPanel.Controls.Clear();
        }

        private void GenerateLocationButtons(int cols, int rows)
        {
            showLocationPanel.Controls.Clear();
            showLocationPanel.Enabled = false;

            showLocationPanelEnd.Controls.Clear();
            showLocationPanelEnd.Enabled = false;

            int spacing = 6;
            int gridWidth = 750;
            int gridHeight = 300;
            int buttonWidth = (gridWidth - (cols - 1) * spacing) / cols;
            int buttonHeight = (gridHeight - (rows - 1) * spacing) / rows;
            int startX = (showLocationPanel.Width - gridWidth) / 2;
            int startY = (showLocationPanel.Height - gridHeight) / 2;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int index = row * cols + col;
                    Point location = new Point(
                        startX + col * (buttonWidth + spacing),
                        startY + row * (buttonHeight + spacing));

                    Button btn1 = new Button
                    {
                        Size = new Size(buttonWidth, buttonHeight),
                        Location = location,
                        BackColor = Color.Gray,
                        FlatStyle = FlatStyle.Flat,
                        Name = $"btn1_{index}",
                        Tag = new Point(col, row),
                        Text = ""
                    };
                    btn1.FlatAppearance.BorderSize = 0;
                    showLocationPanel.Controls.Add(btn1);

                    Button btn2 = new Button
                    {
                        Size = new Size(buttonWidth, buttonHeight),
                        Location = location,
                        BackColor = Color.Gray,
                        FlatStyle = FlatStyle.Flat,
                        Name = $"btn2_{index}",
                        Tag = new Point(col, row),
                        Text = ""
                    };
                    btn2.FlatAppearance.BorderSize = 0;
                    showLocationPanelEnd.Controls.Add(btn2);
                }
            }
        }

        private async void runButton_Click(object sender, EventArgs e)
        {
            if (isRunning && isPaused)
            {
                isPaused = false;
                await ContinueRunning();
                return;
            }

            runButtons = showLocationPanel.Controls.OfType<Button>()
                .OrderBy(btn => ((Point)btn.Tag).Y)
                .ThenBy(btn => ((Point)btn.Tag).X)
                .ToList();

            isRunning = true;
            isPaused = false;

            await ContinueRunning();
        }

        private async Task ContinueRunning()
        {
            var startButtons = showLocationPanel.Controls.OfType<Button>()
                .OrderBy(btn => ((Point)btn.Tag).Y)
                .ThenBy(btn => ((Point)btn.Tag).X)
                .ToList();

            var endButtons = showLocationPanelEnd.Controls.OfType<Button>()
                .OrderBy(btn => ((Point)btn.Tag).Y)
                .ThenBy(btn => ((Point)btn.Tag).X)
                .ToList();

            while (isRunning && !isPaused && currentRunIndex < startButtons.Count)
            {
                var btnStart = startButtons[currentRunIndex];
                var btnEnd = endButtons[currentRunIndex];

                btnStart.BackColor = Color.Red;

                await Task.Delay(2500);
                btnEnd.BackColor = Color.Lime;

                await Task.Delay(2500);

                currentRunIndex++;
            }
        }



        private void stopButton_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                isPaused = true;
            }
        }
    }
}
