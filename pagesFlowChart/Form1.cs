using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace pagesFlowChart
{
    public partial class cornMazeBackground : Form
    {
        int page =  1;
        Random randGen = new Random();
        int randValue;

        public cornMazeBackground()
        {
            InitializeComponent();
            outputLabel.Text = "You and your Best friend are Stuck in a Corn Maze";
            option1Label.Text = "Work Together";
            option2Label.Text = "Fight for Survival";
            SoundPlayer crowPlayer = new SoundPlayer(Properties.Resources._138344__unclesigmund__crow);
            crowPlayer.Play();


        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {

                page = 2;
            }
            else if (page == 2) { page = 5; }
            else if (page == 3) { page = 100; }
            else if (page == 4) { page = 99; }
            else if (page == 5) { page = 6; }
            else if (page == 6) { page = 7; }
            else if (page == 7) { page = 10; }
            else if (page == 8) { page = 100; }
            else if (page == 9) { page = 100; }
            else if (page == 10) { page = 100; }
            else if (page == 11) { page = 100; }

            switch (page)
            {
                // set up the cases
                case 1:
                    outputLabel.Text = "You and your Best friend are Stuck in a Corn Maze";
                    option1Label.Text = "Work together to survive?";
                    option2Label.Text = "Fight for survival?";
                    


                    break;
                case 2:
                    outputLabel.Text = "you see a poisonous bug,what do you do?";
                    option1Label.Text = "Swat it";
                    option2Label.Text = "Spray it with ur handy bug spray";
                    
                    imageBox.Image = Properties.Resources.harvester_ant;
                    SoundPlayer crowPlayer = new SoundPlayer(Properties.Resources._138344__unclesigmund__crow);
                    crowPlayer.Stop();


                    break;
                case 3:
                    outputLabel.Text = "you faught until you both died from fatiuge.Play again?";
                    option1Label.Text = "no";
                    option2Label.Text = "yes";
                    break;
                case 4:
                    outputLabel.Text = "you sprayed it with bug spray";
                    Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text = "the bug spray was poisonous. You died.Play again?";
                    option1Label.Text = "no";
                    option2Label.Text = "yes";
                   

                    break;
                case 5:
                    outputLabel.Text = "you swated it";
                    Refresh();
                    Thread.Sleep(2000);
                    option1Label.Text = "stay quiet";
                    option2Label.Text = "scream loud";
                    break;
                case 6:
                    outputLabel.Text = "you swated the bug. it hurt! do you scream loud? or try to hide it?";
                    option1Label.Text = "Stay quiet";
                    option2Label.Text = "Scream loud";

                    break;
                case 7:
                    outputLabel.Text = "you stayed quiet and backed up into a fox. He looks mad. Do you pet him? or run away? ";
                    option1Label.Text = "pet him";
                    option2Label.Text = "run away";
                    imageBox.Image = Properties.Resources.red_fox_walking_on_grass_field_wallpaper;
                    

                    break;
                case 8:
                    outputLabel.Text = "you scream loud and someone hears you. You get rescued.Play again?";
                    option1Label.Text = "no";
                    option2Label.Text = "yes";
                    SoundPlayer screamPlayer = new SoundPlayer(Properties.Resources._59164__timtube__scream);
                    screamPlayer.Play();
                    break;
                case 9:
                    outputLabel.Text = "you run away. He catches up to you and is offended you didn't want to be his friend. He eats you. You die. play again?";
                    option1Label.Text = "no";
                    option2Label.Text = "yes";
                    break;
                case 10:
                    outputLabel.Text = "you pet him. He is friendly, he sniffs around and leads you to safety.You win.Play again?";
                    option1Label.Text = "no";
                    option2Label.Text = "yes";
                    break;
                case 11:
                    outputLabel.Text = "your luckily a alot stronger than your friend. you won the fight and got out on your own\n You Win!";
                    option1Label.Text = "no";
                    option2Label.Text = "yes";
                    break;
                case 99:
                    outputLabel.Text = "THANKS FOR PLAYING";
                    Refresh();
                    Thread.Sleep(2500);
                    Application.Exit();
                    break;
                case 100:
                    outputLabel.Text = "sorry did you say you wanted to Play again?";
                    option1Label.Text = "no";
                    option2Label.Text = "yes";
                   

                    break;

                default:
                    break;
            }

        }

        private void Option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                randValue = randGen.Next(1, 101);
                if (randValue < 70)
                {
                    page = 3;
                }
                else
                {
                    page = 11;
                }
            }
            else if (page == 2) { page = 5; }
            else if (page == 3) { page = 100; }
            else if (page == 4) { page = 99; }
            else if (page == 5) { page = 6; }
            else if (page == 6) { page = 7; }
            else if (page == 7) { page = 10; }
            else if (page == 8) { page = 100; }
            else if (page == 9) { page = 100; }
            else if (page == 10) { page = 100; }
            else if (page == 11) { page = 100; }



            switch (page)
            {
                case 1:
                    outputLabel.Text = "You and your Best friend are Stuck in a Corn Maze";
                    option1Label.Text = "Work together to survive?";
                    option2Label.Text = "Fight for survival?";




                    break;
                case 2:
                    outputLabel.Text = "you see a poisonous bug,what do you do?";
                    option1Label.Text = "Swat it";
                    option2Label.Text = "Spray it with ur handy bug spray";



                    break;
                case 3:
                    outputLabel.Text = "you faught until you both died from fatiuge.Play again?";
                    option1Label.Text = "no";
                    option2Label.Text = "yes";
                    break;
                case 4:
                    outputLabel.Text = "you sprayed it with bug spray";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text = "the bug spray was poisonous. You died.Play again?";
                    option1Label.Text = "no";
                    option2Label.Text = "yes";

                    break;
                case 5:
                    outputLabel.Text = "you swated it. Press a button to move on";
                    Refresh();
                    Thread.Sleep(2000);
                    option1Label.Text = "";
                    option2Label.Text = "";

                    break;
                case 6:
                    outputLabel.Text = "you swated the bug. it hurt! do you scream loud? or try to hide it?";
                    option1Label.Text = "Stay quiet";
                    option2Label.Text = "Scream loud";

                    break;
                case 7:
                    outputLabel.Text = "you stayed quiet and backed up into a fox. He looks mad. Do you pet him? or run away? ";
                    option1Label.Text = "pet him";
                    option2Label.Text = "run away";
                    imageBox.Image = Properties.Resources.red_fox_walking_on_grass_field_wallpaper;
                    break;
                case 8:
                    outputLabel.Text = "you scream loud and someone hears you. You get rescued.Play again?";
                    option1Label.Text = "no";
                    option2Label.Text = "yes";
                    SoundPlayer screamPlayer = new SoundPlayer(Properties.Resources._59164__timtube__scream);
                    screamPlayer.Play();
                    break;
                case 9:
                    outputLabel.Text = "you run away. He catches up to you and is offended you didn't want to be his friend. He eats you.You die. Play again?";
                    option1Label.Text = "no";
                    option2Label.Text = "yes";
                    break;
                case 10:
                    outputLabel.Text = "you pet him. He is friendly, he sniffs around and leads you to safety.You win.Play again?";
                    option1Label.Text = "no";
                    option2Label.Text = "yes";
                    break;

                case 99:
                    outputLabel.Text = "THANKS FOR PLAYING";
                    Refresh();
                    Thread.Sleep(2500);
                    Application.Restart();
                    break;
                case 100:
                    outputLabel.Text = "sorry did you say you wanted to Play again?";
                    option1Label.Text = "no";
                    option2Label.Text = "yes";
                    Refresh();
                    Thread.Sleep(2000);
                    Application.Restart();


                    break;
                case 101:
                    Refresh();
                    Thread.Sleep(2000);

                    Application.Exit();
                    break;


                default:
                    break;
            }
        }

        private void cornMazeBackground_Load(object sender, EventArgs e)
        {

        }
    }
}
