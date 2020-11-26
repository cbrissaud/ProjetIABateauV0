using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projettaquin
{
    class NodeBateau : GenericNode
    {

        int _x ; 
        int _y;
        public static  int _xf;
        public static int _yf;
        public static int pas = 2;
        public static char cas ;
       
        public int Get_x ()
        {
            return _x;
        }
        public int Get_y()
        {
            return _y;
        }
        public NodeBateau(int x, int y) : base()  // Constructeur avec les coordonnées du bateau
        {
            _x = x;
            _y = y;
            
        }

        public override bool IsEqual (GenericNode N2) // Cette fonction renvoie un booleen : permet de verifier si deux noeuds sont égaux
        {
            NodeBateau NT = (NodeBateau)(N2);// Permet la conversion N2 qui est un Genericcode en NodeBateau
            return (NT._x ==_x && NT._y==_y ); // Verifier si les x et y sont égaux, ça retourne true ou false
        }

        public override double GetArcCost(GenericNode N2) // Ajouter timesestimation: Fonction permettant d’estimer un temps élémentaire de déplacement entre deux points
        {
            NodeBateau NT = (NodeBateau)(N2);
            int x2 = NT._x;
            int y2 = NT._y;
 
            double distance = Math.Sqrt((_x - x2) * (_x - x2) + (_y - y2) * (_y - y2));
            if (distance > 10) return 1000000;
            double windspeed = get_wind_speed((_x + x2) / 2.0, (_y + y2) / 2.0);
            double winddirection = get_wind_direction((_x + x2) / 2.0, (_y + y2) / 2.0);
            double boatspeed;
            double boatdirection = Math.Atan2(y2 - _y, x2 - _x) * 180 / Math.PI;
            // On ramène entre 0 et 360
            if (boatdirection < 0) boatdirection = boatdirection + 360;
            // calcul de la différence angulaire
            double alpha = Math.Abs(boatdirection - winddirection);
            // On se ramène à une différence entre 0 et 180 :
            if (alpha > 180) alpha = 360 - alpha;
            if (alpha <= 45)
            {
                /* (0.6 + 0.3α / 45) v_v */
                boatspeed = (0.6 + 0.3 * alpha / 45) * windspeed;
            }
            else if (alpha <= 90)
            {
                /*v_b=(0.9-0.2(α-45)/45) v_v */
                boatspeed = (0.9 - 0.2 * (alpha - 45) / 45) * windspeed;
            }
            else if (alpha < 150)
            {
                /* v_b=0.7(1-(α-90)/60) v_v */
                boatspeed = 0.7 * (1 - (alpha - 90) / 60) * windspeed;
            }
            else
                return 1000000;
            // estimation du temps de navigation entre p1 et p2
            return (distance / boatspeed);
        }
        
        // à modifier en ‘b’ ou ‘c’ selon le choix de l’utilisateur
        public double get_wind_speed(double x, double y)
        {
            if (cas == 'a')
                return 50;
            else if (cas == 'b')
                if (y > 150)
                    return 50;
                else return 20;
            else if (y > 150)
                return 50;
            else return 20;
        }
        public double get_wind_direction(double x, double y)
        {
            if (cas == 'a')
                return 30;
            else if (cas == 'b')
                if (y > 150)
                    return 180;
                else return 90;
            else if (y > 150)
                return 170;
            else return 65;
        }
     

        public override bool EndState() // Fonction boolenne qui permet de vérifier si le nœud en parametre est le noeud final
        {
            return (_x==_xf && _y==_yf) ;
        }

        public override List<GenericNode> GetListSucc() // Fonction qui renvoie dans une liste toutes les positions possibles de déplacement  de tous les noeuds successeurs à partir du noeud courant
        {

            List<GenericNode> lsucc = new List<GenericNode>();
            /*
                // permet de lister tout les positions potentiel dans lequel le bateau peut se déplacer
                for (int i = 1; i < 9; i++)
                {

                      //4 if poour chaque coin 
                     if (_x >= i && _y >= i && _x <= 300 - i && _y <= 300 - i)
                     {
                         lsucc.Add(new NodeBateau(_x - i, _y)); // poour aller à gauche 
                         lsucc.Add(new NodeBateau(_x + i, _y)); // poour aller a droite
                         lsucc.Add(new NodeBateau(_x, _y - i)); // pour aller en bas
                         //lsucc.Add(new NodeBateau(_x, _y + i)); // poour aller en haut 

                         lsucc.Add(new NodeBateau(_x - i, _y - i)); // Diagonale en bas à gauche = Sud Ouest
                         lsucc.Add(new NodeBateau(_x + i, _y - i));//Diagonale en bas à  gauche = Sud Est
                         lsucc.Add(new NodeBateau(_x - i, _y + i)); //Diagonale en haut à gauche = Nord Ouest
                         lsucc.Add(new NodeBateau(_x + i, _y + i)); //Diagonale en haut à droite = Nord est

                     }

                     else if (_x < i && _y < i) // Cas en bas a gauche 
                     {
                         lsucc.Add(new NodeBateau(_x + i, _y)); // poour aller a droite
                         lsucc.Add(new NodeBateau(_x, _y + i)); // pour aller en haut
                         lsucc.Add(new NodeBateau(_x + i, _y + i)); //Diagonale en haut à droite = Nord Est

                     }

                     else if (_x < i && _y > 300 - i) // Case en haut à gauche
                     {
                         lsucc.Add(new NodeBateau(_x + i, _y)); // pour aller a droite
                         lsucc.Add(new NodeBateau(_x, _y - i)); // pour aller en bas
                         lsucc.Add(new NodeBateau(_x + i, _y - i));//Diagonale en bas à  gauche = Sud Est

                     }

                     else if (_x > 300 - i && _y < i) // Case en bas à droite
                     {
                         lsucc.Add(new NodeBateau(_x - i, _y)); // poour aller à gauche 
                         lsucc.Add(new NodeBateau(_x - i, _y + i)); //Diagonale en haut à gauche = Nord Ouest
                         lsucc.Add(new NodeBateau(_x, _y + i)); // pour aller en haut

                     }
                     else if (_x < 300 - i && _y < 300 - i) // Case en haut à droite
                     {
                         lsucc.Add(new NodeBateau(_x - i, _y)); // poour aller à gauche 
                         lsucc.Add(new NodeBateau(_x, _y - i)); // pour aller en bas
                         lsucc.Add(new NodeBateau(_x - i, _y - i)); // Diagonale en bas à gauche = Sud Ouest

                     }

                     //4 if pour les cotés et vérifier pour y différent 0 et 300
                     else if (_x < i && _y >= i && _y <= 300 - i) // A coté gauche
                     {
                         lsucc.Add(new NodeBateau(_x, _y - i)); // pour aller en bas
                         lsucc.Add(new NodeBateau(_x, _y + i)); // pour aller en haut
                         lsucc.Add(new NodeBateau(_x + i, _y)); // poour aller a droite
                         lsucc.Add(new NodeBateau(_x + i, _y - i));//Diagonale en bas à  gauche = Sud Est
                         lsucc.Add(new NodeBateau(_x + i, _y + i)); //Diagonale en haut à droite = Nord Est



                     }
                     else if (_y < i && _x >= i && _x <= 300 - i) //En bas
                     {
                         lsucc.Add(new NodeBateau(_x - i, _y)); // poour aller à gauche 
                         lsucc.Add(new NodeBateau(_x, _y + i)); // pour aller en haut
                         lsucc.Add(new NodeBateau(_x + i, _y)); // poour aller a droite
                         lsucc.Add(new NodeBateau(_x + i, _y + i)); //Diagonale en haut à droite = Nord Est
                         lsucc.Add(new NodeBateau(_x - i, _y + i)); //Diagonale en haut à gauche = Nord Ouest

                     }
                     else if (_x < 300 - i && _y >= i && _y <= 300 - i) //coté droit
                     {
                         lsucc.Add(new NodeBateau(_x, _y - i)); // pour aller en bas
                         lsucc.Add(new NodeBateau(_x, _y + i)); // pour aller en haut
                         lsucc.Add(new NodeBateau(_x - i, _y)); // poour aller à gauche 
                         lsucc.Add(new NodeBateau(_x - i, _y + i)); //Diagonale en haut à gauche = Nord Ouest
                         lsucc.Add(new NodeBateau(_x - i, _y - i)); // Diagonale en bas à gauche = Sud Ouest


                     }
                     else if (_y > 300 - i && _x >= i && _x <= 300 - i) //coté en haut
                     {
                         lsucc.Add(new NodeBateau(_x + i, _y)); // poour aller a droite
                         lsucc.Add(new NodeBateau(_x, _y - i)); // pour aller en bas
                         lsucc.Add(new NodeBateau(_x - i, _y)); // poour aller à gauche 
                         lsucc.Add(new NodeBateau(_x - i, _y - i)); // Diagonale en bas à gauche = Sud Ouest
                         lsucc.Add(new NodeBateau(_x + i, _y - i));//Diagonale en bas à  gauche = Sud Est



                     }


            */
           
                // Déplacement possible pour une position 
                if (_x != 0 && _y != 0 && _x != 300 && _y != 300)
                {
                    lsucc.Add(new NodeBateau(_x - pas, _y)); // Deplacement horizontal à gauche
                    lsucc.Add(new NodeBateau(_x + pas, _y)); // Déplacement horizontal à droite
                    lsucc.Add(new NodeBateau(_x, _y - pas)); // Deplacement vertical en bas
                    lsucc.Add(new NodeBateau(_x, _y + pas)); // Déplacement vertical en haut
                    lsucc.Add(new NodeBateau(_x - pas, _y - 2)); // Déplacement en diagonale en bas à gauche = Sud Ouest
                    lsucc.Add(new NodeBateau(_x + pas, _y - pas));// Déplacement en diagonale en bas à  gauche = Sud Est
                lsucc.Add(new NodeBateau(_x - pas, _y + pas)); //Déplacement diagonale en haut à gauche = Nord Ouest
                lsucc.Add(new NodeBateau(_x + pas, _y + pas)); //Déplacement en diagonale en haut à droite = Nord est

            }
                 // Déplacement possible dans le cas où le bateau se situe dans un coin 

                else if (_x == 0 && _y == 0) // Cas coin en bas a gauche 
                {
                    lsucc.Add(new NodeBateau(_x + pas, _y)); // poour aller a droite
                    lsucc.Add(new NodeBateau(_x, _y + pas)); // pour aller en haut
                    lsucc.Add(new NodeBateau(_x + pas, _y + pas)); //Diagonale en haut à droite = Nord Est

                }

                else if (_x == 0 && _y == 300) // Cas coin en haut à gauche
                {
                    lsucc.Add(new NodeBateau(_x + pas, _y)); // pour aller a droite
                    lsucc.Add(new NodeBateau(_x, _y - pas)); // pour aller en bas
                    lsucc.Add(new NodeBateau(_x + pas, _y - pas));//Diagonale en bas à  gauche = Sud Est

                }

                else if (_x == 300 && _y == 0) // Cas coin en bas à droite
                {
                    lsucc.Add(new NodeBateau(_x - pas, _y)); // poour aller à gauche 
                    lsucc.Add(new NodeBateau(_x - pas, _y + pas)); //Diagonale en haut à gauche = Nord Ouest
                    lsucc.Add(new NodeBateau(_x, _y + pas)); // pour aller en haut

                }
                else if (_x == 300 && _y == 300) // Cas coin en haut à droite
                {
                    lsucc.Add(new NodeBateau(_x - pas, _y)); // poour aller à gauche 
                    lsucc.Add(new NodeBateau(_x, _y - pas)); // pour aller en bas
                    lsucc.Add(new NodeBateau(_x - pas, _y - pas)); // Diagonale en bas à gauche = Sud Ouest

                }

                // Déplacement dans le cas où le bateau se situe sur les cotés 

                else if (_x == 0 && _y != 0 && _y != 300) // Coté gauche
                {
                    lsucc.Add(new NodeBateau(_x, _y - pas)); // Déplacement vertical en bas
                    lsucc.Add(new NodeBateau(_x, _y + pas)); // Déplacement vertical en haut 
                    lsucc.Add(new NodeBateau(_x + pas, _y)); // Deplacement horizontal à droite
                    lsucc.Add(new NodeBateau(_x + pas, _y - pas));// Déplacement en diagonale en bas à gauche = Sud Est
                    lsucc.Add(new NodeBateau(_x + pas, _y + pas)); // Déplacement en diagonale en haut à droite = Nord Est



                }
                else if (_y == 0 && _x != 0 && _x != 300) // Coté situé en bas
                {
                    lsucc.Add(new NodeBateau(_x - pas, _y)); //Deplacement horizontal à gauche 
                lsucc.Add(new NodeBateau(_x, _y + pas)); // Déplacement vertical en haut
                lsucc.Add(new NodeBateau(_x + pas, _y)); // Deplacement horizontal à droite
                lsucc.Add(new NodeBateau(_x + pas, _y + pas)); // Déplacement en diagonale en haut à droite = Nord Est
                    lsucc.Add(new NodeBateau(_x - pas, _y + pas)); // Déplacement en diagonale en haut à gauche = Nord Ouest

                }
                else if (_x == 300 && _y != 0 && _y == 300) //Coté situé a droite
                {
                    lsucc.Add(new NodeBateau(_x, _y - pas)); // Déplacement vertical en bas
                lsucc.Add(new NodeBateau(_x, _y + pas)); //Déplacement vertical en haut 
                lsucc.Add(new NodeBateau(_x - pas, _y)); // Deplacement horizontal à gauche 
                lsucc.Add(new NodeBateau(_x - pas, _y + pas)); // Déplacement en diagonale en haut à gauche = Nord Ouest
                    lsucc.Add(new NodeBateau(_x - pas, _y - pas)); //Déplacement en diagonale en bas à gauche = Sud Ouest


                }
                else if (_y == 300 && _x != 0 && _x != 300) //Coté situe en haut
                {
                    lsucc.Add(new NodeBateau(_x + pas, _y)); // Deplacement horizontal à droite
                    lsucc.Add(new NodeBateau(_x, _y - pas)); //  Déplacement vertical en bas
                    lsucc.Add(new NodeBateau(_x - pas, _y)); // Deplacement horizontal à gauche  
                    lsucc.Add(new NodeBateau(_x - pas, _y - pas)); // Déplacement en diagonale en bas à gauche = Sud Ouest
                    lsucc.Add(new NodeBateau(_x + pas, _y - pas));// Déplacement en diagonale en bas à  gauche = Sud Est
                
            }



            return lsucc;
        }

        public override double CalculeHCost() //Calculer heuristique : distance entre les deux points 
        {
            
            double Hcoste = Math.Sqrt(Math.Pow(_xf - _x, 2) + Math.Pow(_yf - _y, 2))/45; // Distance à vol d'oiseaux divisé par la vitesse maximal du bateau
            return (Hcoste);

            //return (0); 
        }

        public override string ToString()
        {

            return ("x : " + _x +  " y : " + _y + "   Heuristique : " +  CalculeHCost());
        }
    }
}
