using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokémonGoManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            switch (Properties.Settings.Default.Language)
            {
                case 2:
                    updateComboboxes();
                    françaisToolStripMenuItem.Checked = true;
                    break;
                default:
                    updateComboboxes();
                    englishToolStripMenuItem.Checked = true;
                    break;
            }
            switch (Properties.Settings.Default.Team)
            {
                case 1:
                    teamMysticToolStripMenuItem.Checked = true;
                    break;
                case 2:
                    teamValorToolStripMenuItem.Checked = true;
                    break;
                case 3:
                    teamIntuitionToolStripMenuItem.Checked = true;
                    break;
                default:
                    break;
            }
            cboPokemon.SelectedIndex = 0;
        }

        private void updateComboboxes()
        {
            cboPokemon.Items.Clear();
            cboOverall.Items.Clear();
            cboStatLevel.Items.Clear();
            chkAppraise.Enabled = true;

            int lang = Properties.Settings.Default.Language == 0 ? 1 : Properties.Settings.Default.Language;
            int team = Properties.Settings.Default.Team;

            switch (lang)
            {
                case 2:
                    cboPokemon.Items.AddRange(Data.Lists.NamesFR.ToArray());
                    break;
                default:
                    cboPokemon.Items.AddRange(Data.Lists.NamesEN.ToArray());
                    break;
            }
            for(int i = 0; i < 4; i++)
            {
                switch (team)
                {
                    case 1: // Team Mystic
                        cboOverall.Items.Add(Data.Lists.TextMystic[8 * (lang - 1) + i]);
                        cboStatLevel.Items.Add(Data.Lists.TextMystic[8 * (lang - 1) + i + 4]);
                        break;
                    case 2: // Team Valor
                        cboOverall.Items.Add(Data.Lists.TextValor[8 * (lang - 1) + i]);
                        cboStatLevel.Items.Add(Data.Lists.TextValor[8 * (lang - 1) + i + 4]);
                        break;
                    case 3: // Team Instinct
                        cboOverall.Items.Add(Data.Lists.TextInstinct[8 * (lang - 1) + i]);
                        cboStatLevel.Items.Add(Data.Lists.TextInstinct[8 * (lang - 1) + i + 4]);
                        break;
                    default:
                        chkAppraise.Enabled = false;
                        chkAppraise.Checked = false;
                        break;

                }
            }
            if (cboOverall.Items.Count > 0) cboOverall.SelectedIndex = 0;
            if (cboStatLevel.Items.Count > 0) cboStatLevel.SelectedIndex = 0;
            cboPokemon.SelectedIndex = 0;

        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            int nbFound = 0;
            int minIVs = chkHatched.Checked ? 10 : 0;
            decimal minPercent = 100, maxPercent = 0;
            dataGridView1.Rows.Clear();
            Data.Pokemon species = Data.Lists.PokemonList[cboPokemon.SelectedIndex];
            for(int atkIV = minIVs; atkIV < 16; atkIV++)
            {
                for (int defIV = minIVs; defIV < 16; defIV++)
                {
                    for (int staIV = minIVs; staIV < 16; staIV++)
                    {
                        bool valid = true;
                        int bestStatValue = 0;
                        if (chkBestAtk.Checked) bestStatValue++;
                        if (chkBestDef.Checked) bestStatValue += 2;
                        if (chkBestHP.Checked) bestStatValue += 4;

                        if (chkAppraise.Checked)
                            valid = appraise(atkIV, defIV, staIV, cboOverall.SelectedIndex, bestStatValue, cboStatLevel.SelectedIndex);
                        
                        if (Math.Floor(nudCP.Value) != species.getCP(nudLevel.Value, atkIV, defIV, staIV))
                            valid = false;

                        if (Math.Floor(nudHP.Value) != species.getHP(nudLevel.Value, staIV))
                            valid = false;



                        if (!valid) continue;
                        nbFound++;
                        minPercent = Math.Min(minPercent, Math.Round((atkIV + defIV+ staIV)/45m *1000m) / 10m);
                        maxPercent = Math.Max(maxPercent, Math.Round((atkIV + defIV + staIV) / 45m * 1000m) / 10m);
                        DataGridViewRow newRow = new DataGridViewRow();
                        DataGridViewTextBoxCell atkCell = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell defCell = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell staCell = new DataGridViewTextBoxCell();
                        atkCell.Value = atkIV;
                        defCell.Value = defIV;
                        staCell.Value = staIV;
                        newRow.Cells.Add(atkCell);
                        newRow.Cells.Add(defCell);
                        newRow.Cells.Add(staCell);
                        dataGridView1.Rows.Add(newRow);
                    }
                }
            }
            // Show results
            if(nbFound==0)
            {
                lblResults.Text = "No result found.";
                return;
            }
            lblResults.Text = nbFound + " IVs combinations found." + Environment.NewLine 
                            + "Min %:" + minPercent + " - Max %:" + maxPercent;

        }

        private bool appraise(int atkIV, int defIV, int staIV, int overall, int bestStats, int statLevel)
        {
            // 1: Overall check
            int sum = atkIV + defIV + staIV;
            int bestStatVal = Math.Max(Math.Max(atkIV, defIV), staIV);
            int overallCalc = 0;
            if (sum >= Data.Lists.overallThreshold[0]) overallCalc++;
            if (sum >= Data.Lists.overallThreshold[1]) overallCalc++;
            if (sum >= Data.Lists.overallThreshold[2]) overallCalc++;

            if (overall != overallCalc) return false;

            // 2: Equal stats check
            if (bestStats == 0) bestStats = 7;
            // 2.1: Attack max check
            if ((bestStats%2 == 1) != (atkIV == bestStatVal)) return false;
            // 2.2: Defense max check
            if (((bestStats/2) % 2 == 1) != (defIV == bestStatVal)) return false;
            // 2.3:Stamina max check
            if ((bestStats >=4) != (staIV == bestStatVal)) return false;

            // 3. Best stat value check
            int bestCalc = 0;
            if (bestStatVal >= Data.Lists.statThreshold[0]) bestCalc++;
            if (bestStatVal >= Data.Lists.statThreshold[1]) bestCalc++;
            if (bestStatVal >= Data.Lists.statThreshold[2]) bestCalc++;
            if (statLevel != bestCalc) return false;

            return true;
        }

        private void teamMysticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Team = 1;
            teamMysticToolStripMenuItem.Checked = true;
            teamValorToolStripMenuItem.Checked = false;
            teamIntuitionToolStripMenuItem.Checked = false;
            updateComboboxes();
        }

        private void teamValorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Team = 2;
            teamMysticToolStripMenuItem.Checked = false;
            teamValorToolStripMenuItem.Checked = true;
            teamIntuitionToolStripMenuItem.Checked = false;
            updateComboboxes();
        }

        private void teamIntuitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Team = 3;
            teamMysticToolStripMenuItem.Checked = false;
            teamValorToolStripMenuItem.Checked = false;
            teamIntuitionToolStripMenuItem.Checked = true;
            updateComboboxes();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = 1;
            englishToolStripMenuItem.Checked = true;
            françaisToolStripMenuItem.Checked = false;
            updateComboboxes();
        }

        private void françaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = 2;
            englishToolStripMenuItem.Checked = false;
            françaisToolStripMenuItem.Checked = true;
            updateComboboxes();
        }

        private void chkAppraise_CheckedChanged(object sender, EventArgs e)
        {
            cboOverall.Enabled = chkAppraise.Checked;
            chkBestAtk.Enabled = chkAppraise.Checked;
            chkBestDef.Enabled = chkAppraise.Checked;
            chkBestHP.Enabled = chkAppraise.Checked;
            cboStatLevel.Enabled = chkAppraise.Checked;
            lblBestStats.Enabled = chkAppraise.Checked;
            lblOverall.Enabled = chkAppraise.Checked;
            lblStatsLevel.Enabled = chkAppraise.Checked;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void nudLevel_Enter(object sender, EventArgs e)
        {
            nudLevel.Select(0, nudLevel.Text.Length);
        }

        private void nudCP_Enter(object sender, EventArgs e)
        {

            nudCP.Select(0, nudCP.Text.Length);
        }

        private void nudHP_Enter(object sender, EventArgs e)
        {

            nudHP.Select(0, nudHP.Text.Length);
        }
    }
}
