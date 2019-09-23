using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad1
{
    public partial class Form1 : Form
    {
        class Gra
        {
            bool czyDwoch, czyZaczynaGracz, czyWygralPC = false;
            char[,] tab = new char[3,3];
            List<string> Gracz1 = new List<string>();
            List<string> Gracz2 = new List<string>();
            char obecnyZnak = 'X';
            int liczbaKrokow = 0;
            char znakWybrany = 'O';

            private void pokazMenu(bool tryb, Form1 form)
            {
                form.label1.Visible = tryb;
                form.label5.Visible = tryb;
                form.button1vs1.Visible = tryb;
                form.button1vsPC.Visible = tryb;
                if (!tryb)
                {
                    form.l00.Text = form.l01.Text = form.l02.Text = form.l10.Text = form.l11.Text = form.l12.Text = form.l20.Text = form.l21.Text = form.l22.Text = "";
                }
                else form.plansza.Visible = false;
            }

            private void RuchPC(Form1 form, int grX, int grY)
            {
                int x = grX, y = grY, i, j, pion = 0, poziom = 0, przekGl = 0, przekDr = 0; //Punkty w pionie, poziomie, na glownej przekatnej i na drugiej przekatnej
                Random random = new Random();

                do //DEFENSYWNO-OFENSYWNY (z atakiem gdy moze wygrac)
                {
                    if (liczbaKrokow == 1)
                    {
                        if (tab[1,1] == ' ')
                        {
                            x = y = 1;
                            break;
                        }
                    }
                    if (liczbaKrokow == 0) //Pierwszy ruch GLOWNY PC
                    {
                        do
                        {
                            y = random.Next(0, 3);
                            x = random.Next(0, 3);
                        } while (!(x == y || x + y == 2));
                    }
                    else //Kolejne wykonywanie: "jesli nie ma zagrozenia, atakuj"
                    {
                        bool czyBreak = false;
                        int pionSr = 0; //SRODKOWY
                        int poziomSr = 0; //SRODKOWY
                        int pionLe = 0; //Lewy
                        int poziomGo = 0; //Gorny
                        int pionPr = 0; //Prawy
                        int poziomDo = 0; //Dolny
                        int poprzX = x;
                        int poprzY = y;
                        przekGl = 0;
                        przekDr = 0;

                        /*Sprawdz czy nie ma szansy na wygrana*/
                        for (i = 0; i < 3; i++) //WIERSZ
                        {
                            for (j = 0; j < 3; j++) //KOLUMNA
                            {
                                if (tab[i,j] == obecnyZnak)
                                {
                                    if (i == j) ++przekGl;
                                    if (i + j == 2) ++przekDr;
                                    if (i == 1) ++pionSr;
                                    if (j == 1) ++poziomSr;
                                    if (i == 0) ++pionLe;
                                    if (j == 0) ++poziomGo;
                                    if (i == 2) ++pionPr;
                                    if (j == 2) ++poziomDo;
                                }
                            }
                        }

                        for (i = 0; i < 3; i++) //WIERSZ
                        {
                            for (j = 0; j < 3; j++) //KOLUMNA
                            {
                                if (tab[i,j] == ' ') //Postaw aby wygrac
                                {
                                    if ((przekGl == 2 && i == j) || (przekDr == 2 && i + j == 2) || (pionSr == 2 && i == 1) || (poziomSr == 2 && j == 1) || (pionLe == 2 && i == 0) || (poziomGo == 2 && j == 0) || (pionPr == 2 && i == 2) || (poziomDo == 2 && j == 2))
                                    {
                                        y = i;
                                        x = j;
                                        czyBreak = true;
                                        break;
                                    }
                                }
                            }
                            if (czyBreak) break;
                        }

                        if (!czyBreak) //Nie ma szansy na wygrana, wiec sprawdz czy nie ma zagrozenia, a jak nie ma to atakuj
                        {
                            pion = 0; //SRODKOWY
                            poziom = 0; //SRODKOWY
                            przekGl = 0;
                            przekDr = 0;

                            /*Sprawdz czy nie ma zagrozenia*/
                            for (i = 0; i < 3; i++) //WIERSZ
                            {
                                for (j = 0; j < 3; j++) //KOLUMNA
                                {
                                    if (tab[i,j] == znakWybrany)
                                    {
                                        if (x == y && i == j) ++przekGl;
                                        if (x + y == 2 && i + j == 2) ++przekDr;
                                        if (i == y) ++poziom;
                                        if (j == x) ++pion;
                                    }
                                }
                            }

                            if (pion == 2 || poziom == 2 || przekGl == 2 || przekDr == 2) //Znaleziono zagrozenie
                            {
                                for (i = 0; i < 3; i++) //WIERSZ
                                {
                                    for (j = 0; j < 3; j++) //KOLUMNA
                                    {
                                        if (tab[i,j] == ' ')
                                        {
                                            if ((przekGl == 2 && i == j) || (przekDr == 2 && i + j == 2) || (poziom == 2 && i == y) || (pion == 2 && j == x))
                                            {
                                                y = i;
                                                x = j;
                                                czyBreak = true;
                                                break;
                                            }
                                        }
                                    }
                                    if (czyBreak) break;
                                }
                            }

                            if (!czyBreak) //Nie ma zagrozenia, mozna dzialac
                            {
                                if (liczbaKrokow == 2 && poprzX == 1 && poprzY == 1) //Ruch specjlany jezeli srodek zostal zajety przez przeciwnika w poprzednim kroku i nie ma zagrozenia
                                {
                                    do
                                    {
                                        y = random.Next(0, 3);
                                        x = random.Next(0, 3);
                                    } while (!(x == y || x + y == 2) || tab[y,x] != ' ' || ((przekGl == 1 && x != y) && (przekDr == 1 && x + y != 2)));
                                    break;
                                }
                                for (i = 0; i < 3; i++) //WIERSZ
                                {
                                    for (j = 0; j < 3; j++) //KOLUMNA
                                    {
                                        if (tab[i,j] == ' ') //Staw tam, gdzie nie ma w ogole zagrozenia
                                        {
                                            if (x != i && y != j)
                                            {
                                                if (x == y && x == 1 && y == 1)
                                                {
                                                    y = i;
                                                    x = j;
                                                    czyBreak = true;
                                                    break;
                                                }
                                                else
                                                {
                                                    if ((x == y && i != j) || (x + y == 2 && i + j != 2))
                                                    {
                                                        y = i;
                                                        x = j;
                                                        czyBreak = true;
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        if (i != j)
                                                        {
                                                            y = i;
                                                            x = j;
                                                            czyBreak = true;
                                                            break;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    if (czyBreak) break;
                                }
                                if (!czyBreak)
                                {
                                    do
                                    {
                                        y = random.Next(0, 3);
                                        x = random.Next(0, 3);
                                    } while (tab[y,x] != ' ');
                                }
                            }
                        }
                    }
                } while (tab[y,x] != ' ');

                if(y == 0)
                {
                    if (x == 0) form.l00.Text = ZwrocZnak();
                    else if (x == 1) form.l01.Text = ZwrocZnak();
                    else form.l02.Text = ZwrocZnak();
                }
                else if (y == 1)
                {
                    if (x == 0) form.l10.Text = ZwrocZnak();
                    else if (x == 1) form.l11.Text = ZwrocZnak();
                    else form.l12.Text = ZwrocZnak();
                }
                else
                {
                    if (x == 0) form.l20.Text = ZwrocZnak();
                    else if (x == 1) form.l21.Text = ZwrocZnak();
                    else form.l22.Text = ZwrocZnak();
                }

                Ustaw(y, x, form);
            }

            public Gra(bool czyDwoch, string tekst, Form1 form)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        tab[i, j] = ' ';
                    }
                }

                pokazMenu(false, form);
                form.trybText.Text = tekst;
                form.plansza.Visible = true;
                this.czyDwoch = czyDwoch;
                obecnyZnak = (liczbaKrokow % 2 == 0 ? 'X' : 'O');
                form.ktoTerazText.Text = "Ruch należy do: " + obecnyZnak;
                if(!czyDwoch)
                {
                    czyZaczynaGracz = form.checkBox1.Checked;
                    if (!czyZaczynaGracz) RuchPC(form, 0, 0); else znakWybrany = 'X';
                }
            }

            public void Ustaw(int y, int x, Form1 form)
            {
                tab[y, x] = obecnyZnak;
                if(liczbaKrokow % 2 == 0) Gracz1.Add("X: " + y + "," + x);
                else Gracz2.Add("O: " + y + "," + x);

                /* SPRAWDZANIE CZY WYGRANO */
                int pion = 0, poziom = 0, przekGl = 0, przekDr = 0; //Punkty w pionie, poziomie, na glownej przekatnej i na drugiej przekatnej

                pion = 0;
                poziom = 0;
                przekGl = 0;
                przekDr = 0;
                for (int i = 0; i < 3; i++) //WIERSZ
                {
                    for (int j = 0; j < 3; j++) //KOLUMNA
                    {
                        if (tab[i,j] == obecnyZnak)
                        {
                            if (x == y && i == j) ++przekGl;
                            if (x + y == 2 && i + j == 2) ++przekDr;
                            if (i == y) ++poziom;
                            if (j == x) ++pion;
                        }
                    }
                }

                if (pion == 3 || poziom == 3 || przekGl == 3 || przekDr == 3 || liczbaKrokow == 8)
                {
                    string ruchyX = "", ruchyO = "";

                    if (!czyDwoch)
                    {
                        if (znakWybrany == obecnyZnak) czyWygralPC = false; else czyWygralPC = true;
                    }

                    foreach(string ruch in Gracz1)
                    {
                        ruchyX += ruch+"\n";
                    }

                    foreach (string ruch in Gracz2)
                    {
                        ruchyO += ruch + "\n";
                    }

                    if (pion != 3 && poziom != 3 & przekGl != 3 && przekDr != 3 && liczbaKrokow == 8) MessageBox.Show("REMIS!!!\nRuchy X:\n" + ruchyX + "Ruchy O:\n" + ruchyO);
                    else MessageBox.Show("WYGRAŁ "+obecnyZnak+(!czyDwoch ? (czyWygralPC ? " (PC)": "") : "")+"!!!\nRuchy X:\n" + ruchyX + "Ruchy O:\n" + ruchyO);

                    pokazMenu(true, form);
                }
                else
                {
                    ++liczbaKrokow;
                    obecnyZnak = (liczbaKrokow % 2 == 0 ? 'X' : 'O');
                    form.ktoTerazText.Text = "Ruch należy do: " + obecnyZnak;
                    if (!czyDwoch)
                        if ((czyZaczynaGracz && liczbaKrokow % 2 != 0) || (!czyZaczynaGracz && liczbaKrokow % 2 == 0)) RuchPC(form, x, y);
                }
            }

            public string ZwrocZnak()
            {
                return obecnyZnak.ToString();
            }
        }

        Gra gra;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            plansza.Visible = false;
        }

        private void button1vs1_Click(object sender, EventArgs e)
        {
            if (gra != null) gra = null;
            gra = new Gra(true, "Gracz vs Gracz", this);
        }

        private void button1vsPC_Click(object sender, EventArgs e)
        {
            if (gra != null) gra = null;
            gra = new Gra(false, "Gracz vs PC", this);
        }

        private void l00_Click(object sender, EventArgs e)
        {
            if(l00.Text == "")
            {
                l00.Text = gra.ZwrocZnak();
                gra.Ustaw(0, 0, this);
            }
        }

        private void l01_Click(object sender, EventArgs e)
        {
            if (l01.Text == "")
            {
                l01.Text = gra.ZwrocZnak();
                gra.Ustaw(0, 1, this);
            }
        }

        private void l02_Click(object sender, EventArgs e)
        {
            if (l02.Text == "")
            {
                l02.Text = gra.ZwrocZnak();
                gra.Ustaw(0, 2, this);
            }
        }

        private void l10_Click(object sender, EventArgs e)
        {
            if (l10.Text == "")
            {
                l10.Text = gra.ZwrocZnak();
                gra.Ustaw(1, 0, this);
            }
        }

        private void l11_Click(object sender, EventArgs e)
        {
            if (l11.Text == "")
            {
                l11.Text = gra.ZwrocZnak();
                gra.Ustaw(1, 1, this);
            }
        }

        private void l12_Click(object sender, EventArgs e)
        {
            if (l12.Text == "")
            {
                l12.Text = gra.ZwrocZnak();
                gra.Ustaw(1, 2, this);
            }
        }

        private void l20_Click(object sender, EventArgs e)
        {
            if (l20.Text == "")
            {
                l20.Text = gra.ZwrocZnak();
                gra.Ustaw(2, 0, this);
            }
        }

        private void l21_Click(object sender, EventArgs e)
        {
            if (l21.Text == "")
            {
                l21.Text = gra.ZwrocZnak();
                gra.Ustaw(2, 1, this);
            }
        }

        private void l22_Click(object sender, EventArgs e)
        {
            if (l22.Text == "")
            {
                l22.Text = gra.ZwrocZnak();
                gra.Ustaw(2, 2, this);
            }
        }
    }
}
