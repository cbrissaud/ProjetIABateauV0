﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;


namespace projettaquin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CasAButtun_Click(object sender, EventArgs e) //Cas A
        {
            NodeBateau.cas = 'a';
            pictureBox1.Refresh();// Actualise la picturebox
            SearchTree g = new SearchTree();
            NodeBateau N0 = new NodeBateau(100,200); //Entre en entrée les coordonnées (x et y) du noeud initial du bateau pour le Cas A
            NodeBateau._xf = 200; // Entre en entrée les coordonnées en abcscisse du noeud final  que le bateau doit atteindre pour le Cas A
            NodeBateau._yf = 100; //Entre en entrée les coordonnées en ordonnée du noeud final que le bateau doit atteindre pour le Cas A

            //Initialisation du chronomètre
            Stopwatch stopWatch = new Stopwatch(); 
            stopWatch.Start(); 
            Thread.Sleep(10);
            
            List<GenericNode> Lres = g.RechercheSolutionAEtoile(N0);

            if (Lres.Count == 0)
            {
                labelsolution.Text = "Pas de solution";

            }
            else
            {
                labelsolution.Text = "Une solution a été trouvée";

                //Affichage du chronomètre
                 stopWatch.Stop(); 
                TimeSpan ts = stopWatch.Elapsed;            
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                ChronoBox.Text = elapsedTime;
                
                
                int i = 0;
                Pen penwhite = new Pen(Color.White); //Affichage du segment entre deux points
                Graphics g1 = pictureBox1.CreateGraphics();

                PasBox.Text = NodeBateau.pas.ToString();// Affichage du nombre de pas 

                foreach (GenericNode N in Lres)
                {
                    listBox1.Items.Add(N);
                   
                    
                    if (i < Lres.Count - 1)
                    {
                        NodeBateau NT = (NodeBateau)(N);

                        int x1 = NT.Get_x();
                        int y1 = NT.Get_y();

                        NodeBateau NT2 = (NodeBateau)(Lres[i + 1]);

                        int x2 = NT2.Get_x();
                        int y2 = NT2.Get_y();

                        g1.DrawLine(penwhite, new Point((int)x1, pictureBox1.Height - (int)y1),
                        new Point((int)x2, pictureBox1.Height - (int)y2));

                        i++;
                    }
                }
                textTempsParcours.Text = Lres[Lres.Count - 1].GetGCost().ToString(); // Affichage de G : le temps entre le nœud initial et le nœud final 
                labelcountopen.Text = "Nb noeuds des ouverts : " + g.CountInOpenList().ToString();
                labelcountclosed.Text = "Nb noeuds des fermés : " + g.CountInClosedList().ToString();
                g.GetSearchTree(treeView1);
            }

        }

       


        private void CasBButton_Click_1(object sender, EventArgs e) // Cas B
        {
            NodeBateau.cas = 'b';
            pictureBox1.Refresh(); // Actualise la picturebox
            SearchTree g = new SearchTree();
            NodeBateau N0 = new NodeBateau(100, 200); //Entre en entrée les coordonnées(x et y) du noeud initial du bateau pour le Cas B
            NodeBateau._xf = 200; // Entre en entrée les coordonnées en abcscisse du noeud final que le bateau doit atteindre pour le Cas B
            NodeBateau._yf = 100; // Entre en entrée les coordonnées en abcscisse du noeud que le bateau doit atteindre pour le Cas B

            //Intialisation du chronomètre
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start(); 
            Thread.Sleep(10);

            List<GenericNode> Lres = g.RechercheSolutionAEtoile(N0);



            if (Lres.Count == 0)
            {

                labelsolution.Text = "Pas de solution";
            }
            else
            {
                labelsolution.Text = "Une solution a été trouvée";

                // Affichage du chronomètre
                stopWatch.Stop(); 
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", 
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                ChronoBox.Text = elapsedTime;

                int i = 0;
                Pen penwhite = new Pen(Color.White); ////Affichage du segment entre deux points
                Graphics g1 = pictureBox1.CreateGraphics();

                PasBox.Text = NodeBateau.pas.ToString(); // Affichage du nombre de pas 

                foreach (GenericNode N in Lres)
                {
                    listBox1.Items.Add(N);

                  
                    if (i < Lres.Count - 1)
                    {
                        NodeBateau NT = (NodeBateau)(N);

                        int x1 = NT.Get_x();
                        int y1 = NT.Get_y();

                        NodeBateau NT2 = (NodeBateau)(Lres[i + 1]);

                        int x2 = NT2.Get_x();
                        int y2 = NT2.Get_y();

                        g1.DrawLine(penwhite, new Point((int)x1, pictureBox1.Height - (int)y1),
                        new Point((int)x2, pictureBox1.Height - (int)y2));

                        i++;
                    }

                }
                textTempsParcours.Text = Lres[Lres.Count - 1].GetGCost().ToString();// Affichage de G : le temps entre le nœud initial et le nœud final 
                labelcountopen.Text = "Nb noeuds des ouverts : " + g.CountInOpenList().ToString();
                labelcountclosed.Text = "Nb noeuds des fermés : " + g.CountInClosedList().ToString();
                g.GetSearchTree(treeView1);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            NodeBateau.cas = 'c';
            pictureBox1.Refresh();// Actualise la picturebox
            SearchTree g = new SearchTree();
            NodeBateau N0 = new NodeBateau(200, 100);//Entre en entrée les coordonnées(x et y) du noeud initial du bateau pour le Cas C
            NodeBateau._xf = 100; // Entre en entrée les coordonnées en abcscisse du noeud final que le bateau doit atteindre pour le Cas C
            NodeBateau._yf = 200; // Entre en entrée les coordonnées en abcscisse du noeud final que le bateau doit atteindre pour le Cas C


            Stopwatch stopWatch = new Stopwatch(); //Inialiser un chronométre
            stopWatch.Start(); //Chronometre se lance
            Thread.Sleep(10);

            List<GenericNode> Lres = g.RechercheSolutionAEtoile(N0);


            if (Lres.Count == 0)
            {
                labelsolution.Text = "Pas de solution";
            }
            else
            {
                labelsolution.Text = "Une solution a été trouvée";


                //Affichage du chronomètre 
                
                stopWatch.Stop(); 
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", //Affichage du chronomètre 
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                ChronoBox.Text = elapsedTime;

                PasBox.Text = NodeBateau.pas.ToString(); // Affichage du nombre de pas

                int i = 0;
                Pen penwhite = new Pen(Color.White); 
                Graphics g1 = pictureBox1.CreateGraphics();
                foreach (GenericNode N in Lres)
                {
                    listBox1.Items.Add(N);
                   

                    if (i < Lres.Count-1)
                    {
                        NodeBateau NT = (NodeBateau)(N);

                        int x1 = NT.Get_x();
                        int y1 = NT.Get_y();

                        NodeBateau NT2 = (NodeBateau)(Lres[i + 1]);

                        int x2 = NT2.Get_x();
                        int y2 = NT2.Get_y();
                       
                        g1.DrawLine(penwhite, new Point((int)x1, pictureBox1.Height - (int)y1),
                        new Point((int)x2, pictureBox1.Height - (int)y2));

                        i++;
                    }
                }
                textTempsParcours.Text = Lres[Lres.Count - 1].GetGCost().ToString();// Affichage de G : le temps entre le nœud initial et le nœud final 
                labelcountopen.Text = "Nb noeuds des ouverts : " + g.CountInOpenList().ToString();
                labelcountclosed.Text = "Nb noeuds des fermés : " + g.CountInClosedList().ToString();
                g.GetSearchTree(treeView1);
            }
        }

  
    }     
}
